// Copyright 2009-2014 Blam Games, Inc. All Rights Reserved.

#include "TestApp.h"
#include "Figure.h"
#include <stdlib.h>    
#include <ctime> 
#include <cstdlib>
#include <stdio.h>
#include <conio.h>
#include <cstring>

int score = 0;
int speed = 0;
int speedStep = 2;
int CurrSeed = rand() % 7;
Figure currentFigure;
Figure incomingFigure;
const int fieldSize = 17;
const int fieldRigth = 9;
const int fieldBot = 4;
int Offset = 3;
char buffer[fieldSize+fieldRigth - 2];

char CurrentField[fieldSize - 1][fieldSize - 1];
const int _fieldSize = fieldSize - 1;

bool first_iteration = true;
bool endGame = false;
bool nextdraw = true;



TestApp::TestApp() : Parent(fieldSize+fieldRigth, fieldSize + fieldBot - 1)
{
	
	mObj1XOld = mObj1X = 7;
	mObj1YOld = mObj1Y = 1;
	mObj2X = 7;
	mObj2Y = 3;
}

void fillBoard()
{
	for (int i = 0; i < fieldSize - 1; i++)
		for (int j = 0; j < fieldSize - 1; j++)
			CurrentField[i][j] = '-';
}


int DeleteLines()
{
	int counter;
	int i;
	//считаем по строкам
	for (i = 0; i < _fieldSize; i++)
	{
		counter = 0;

		for (int j = 0; j < _fieldSize; j++)
		{
			if (CurrentField[j][i] == '@')
				counter++;
		}

		if (counter == _fieldSize - 1)
			break;
	}
	if (counter != _fieldSize - 1)
		return 0;

	for (int j = i; j >=0; j--)
	{
		for (int k = 0; k < _fieldSize; k++)
		{
			CurrentField[k][j] = (j == 0) ? '-' : CurrentField[k][j - 1];
		}
	}
	return DeleteLines() + 1;
}

void TestApp::KeyPressed(int btnCode)
{
	
	if (btnCode == 32) // space
		rotation = 1;
	else if (btnCode == 80) //down

		speedUp = 1;
	if (btnCode == 75) //key right

		mObj1X--;
	else 
		if (btnCode == 77) //key left
		mObj1X++;

	if (mObj1X < 0)
		mObj1X = 0;
	else if (mObj1X >= X_SIZE)
		mObj1X = X_SIZE - 1;

	if (mObj1Y < 0)
		mObj1Y = 0;
	else if (mObj1Y >=Y_SIZE)
		mObj1Y = Y_SIZE - 1;
}


void generateSeedFigure(Figure &figure, int s)
{
		Figure figureq(s);
		figure = figureq;
}



void generateFigures()
{
	srand(time(NULL));
	int IncSeed = rand() % 7;
	generateSeedFigure(currentFigure, CurrSeed);

	generateSeedFigure(incomingFigure, IncSeed);
	CurrSeed = IncSeed;
}

void StopGame() {
		endGame = true;
		return;
}



void NextStep(int &CoordX, int &CoordY)
{
	for (int i = 0; i < currentFigure.GetX(); i++)
		for (int j = 0; j < currentFigure.GetY(); j++)
		{
			CurrentField[CoordX + i][CoordY + j] = (currentFigure.GetChar(i, j) == '@' || CurrentField[CoordX + i][CoordY + j] == '@') ? '@' : currentFigure.GetChar(i, j);
		}
	score += DeleteLines();

	if (CoordY<currentFigure.GetY())
		StopGame();
	CoordX = 7;
	CoordY = 1;
	generateFigures();
	speedStep = 2;
	nextdraw = true;
}
void TestApp::UpdateF(float deltaTime)
{
	if (endGame)
	{
		return;
	}
	
	speed += speedStep;
	mObj1Y+=speed/50;
	if (speed >= 50)
		speed = 0;

	if (first_iteration)
	{
		fillBoard();
		generateFigures();
		first_iteration = 0;
	}
	if (rotation)
	{
		currentFigure.Rotate();
		rotation = 0;
	}
	if (speedUp)
	{	
		speedStep = 10;
		speedUp = 0;
	
	}
	//отрисовываем поле при помощи # и -
	
	for (int i = 0; i < fieldSize + fieldRigth; i++)
	{
		for (int j = 0; j < fieldSize + fieldBot; j++)
		{
			
			if (i == 0 || i == fieldSize - 1 && j < fieldSize || j == 0 || j == fieldSize - 1 || i == fieldSize + fieldRigth - 1 || j == fieldSize + fieldBot - 1)
				SetChar(i, j, '#');
			else
				if (i >= fieldSize || j >= fieldSize)
					SetChar(i, j, ' ');
				else SetChar(i, j, CurrentField[i][j]);
		
		}
	}
	sprintf(buffer, "Score = %d", score);
	for (int i = 2; i < fieldSize + fieldRigth; i++)
	{
		if (i<strlen(buffer)+2)
			SetChar(i, fieldSize+1, buffer[i-2]);
	}

	
	//вывод текущей фигуры
	for (int i = 0; i < currentFigure.GetX(); i++)
		for (int j = 0; j < currentFigure.GetY(); j++)
		{
			SetChar(mObj1X + i, mObj1Y + j, currentFigure.GetChar(i, j));
		}
	for (int i = fieldSize; i < fieldSize + 2 * Offset; i++)
		for (int j = 1; j < fieldSize - 1; j++)
			SetChar(i, j, L' ');

	for (int i = 0; i < currentFigure.GetX(); i++) 
	{
		
		for (int j = 0; j < currentFigure.GetY(); j++)
		{
			//движение по нажатию
			SetChar(mObj1XOld-1, mObj1YOld-1, L'-');
			if (mObj1XOld - 1 == 0 || mObj1YOld - 1 == 0)
				SetChar(mObj1XOld - 1, mObj1YOld - 1, L'#');
			SetChar(mObj1X + i, mObj1Y + j, currentFigure.GetChar(i, j));

			mObj1XOld = mObj1X;
			mObj1YOld = mObj1Y;
		}

	}
	for (int i=0; i< incomingFigure.GetX(); i++)
		for (int j =0; j<incomingFigure.GetY(); j++)
			if (incomingFigure.GetChar(i, j) == '@')
				SetChar(fieldSize + Offset + i, Offset + j, incomingFigure.GetChar(i, j));

	//проверки возможности движения налево и направо и столкновения
	for (int i = 0; i < currentFigure.GetX(); i++)
	{

		for (int j = 0; j < currentFigure.GetY(); j++)
		{
			//проверки возможности движения налево и направо
			if (mObj1X < 1) 
				mObj1X++;
			else
				if (mObj1X > fieldSize - 1 - currentFigure.GetX())
					mObj1X--;

			
			
			
			if (mObj1Y + currentFigure.GetY() >= fieldSize -1)
			{
				while (mObj1Y + currentFigure.GetY() >= fieldSize )
					mObj1Y-=2;
				NextStep(mObj1X, mObj1Y);
			}
		
			if (j == currentFigure.GetY() - 1)
			{
				if (currentFigure.GetChar(i, j) == '@' && CurrentField[mObj1X + i][mObj1Y + currentFigure.GetY()] == '@')
					NextStep(mObj1X, mObj1Y);
			}
			else
			{

				if (currentFigure.GetChar(i, j) == '@' && CurrentField[mObj1X + i][mObj1Y + currentFigure.GetY()-1] == '@')
				
					NextStep(mObj1X, mObj1Y);
			}
		}
	}
	
	
		
	
}