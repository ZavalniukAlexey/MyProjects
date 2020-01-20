#pragma once
#include <iostream>
/*#include "L.h"
#include "Z.h"
#include "T.h"
#include "ReverseL.h"
#include "ReverseZ.h"
#include "Square.h"
#include "Stick.h"*/
using namespace std;

class Figure
{
private:
	int SizeX;
	int SizeY;
	char ** m_figure;
public:
	Figure(){
		SizeX = 4;
		SizeY = 4;
		m_figure = (char **)malloc(SizeX * sizeof(char *));
		for (int i = 0; i < SizeX; ++i) {
			m_figure[i] = (char *)malloc(SizeY * sizeof(char));
		}
		for (int i = 0; i < SizeX; i++)
			for (int j = 0; j < SizeY; j++)
				m_figure[i][j] = '@';

		
	};
	Figure(int selectFigure)
	{
		switch (selectFigure) {
			//l
		case 0:
		{
			SizeX = 2;
			SizeY = 3;
			m_figure = (char **)malloc(SizeX * sizeof(char *));
			for (int i = 0; i < SizeX; ++i) {
				m_figure[i] = (char *)malloc(SizeY * sizeof(char));
			}

			for (int i = 0; i < SizeX; i++)
				for (int j = 0; j < SizeY; j++)
				{
					if (i == 0 || j == 2)
						m_figure[i][j] = '@';
					else
						m_figure[i][j] = '-';
				}
			break;
		}
		//reverseL
		case 1:
		{
			SizeX = 2;
			SizeY = 3;
			m_figure = (char **)malloc(SizeX * sizeof(char *));
			for (int i = 0; i < SizeX; ++i) {
				m_figure[i] = (char *)malloc(SizeY * sizeof(char));
			}

			for (int i = 0; i < SizeX; i++)
				for (int j = 0; j < SizeY; j++)
				{
					if (i == 1 || j == 2)
						m_figure[i][j] = '@';
					else
						m_figure[i][j] = '-';
				}
			break;
		
}
		//z
		case 2:
		{
			SizeX = 2;
			SizeY = 3;
			m_figure = (char **)malloc(SizeX * sizeof(char *));
			for (int i = 0; i < SizeX; ++i) {
				m_figure[i] = (char *)malloc(SizeY * sizeof(char));
			}

			for (int i = 0; i < SizeX; i++)
				for (int j = 0; j < SizeY; j++)
				{
					if (i == 0 && j == 2 || i == 1 && j == 0)
						m_figure[i][j] = '-';
					else
						m_figure[i][j] = '@';
				}
			break;
		}
		//reverseZ
		case 3:
		{
			SizeX = 2;
			SizeY = 3;
			m_figure = (char **)malloc(SizeX * sizeof(char *));
			for (int i = 0; i < SizeX; ++i) {
				m_figure[i] = (char *)malloc(SizeY * sizeof(char));
			}

			for (int i = 0; i < SizeX; i++)
				for (int j = 0; j < SizeY; j++)
				{
					if (i == 0 && j == 0 || i == 1 && j == 2)
						m_figure[i][j] = '-';
					else
						m_figure[i][j] = '@';
				}
		}
		//t
		case 4:
		{
			{
				SizeX = 2;
				SizeY = 3;
				m_figure = (char **)malloc(SizeX * sizeof(char *));
				for (int i = 0; i < SizeX; ++i) {
					m_figure[i] = (char *)malloc(SizeY * sizeof(char));
				}

				for (int i = 0; i < SizeX; i++)
					for (int j = 0; j < SizeY; j++)
					{
						if (i == 1 || j == 1)
							m_figure[i][j] = '@';
						else
							m_figure[i][j] = '-';
					}
			}
			break;

		}
		//stick
		case 5:
		{
			SizeX = 4;
			SizeY = 1;
			m_figure = (char **)malloc(SizeX * sizeof(char *));
			for (int i = 0; i < SizeX; ++i) {
				m_figure[i] = (char *)malloc(SizeY * sizeof(char));
			}
			for (int i = 0; i < SizeX; i++)
				for (int j = 0; j < SizeY; j++)
					m_figure[i][j] = '@';
			break;
		}
		//square
		case 6:
		{
			SizeX = 2;
			SizeY = 2;
			m_figure = (char **)malloc(SizeX * sizeof(char *));
			for (int i = 0; i < SizeX; ++i) {
				m_figure[i] = (char *)malloc(SizeY * sizeof(char));
			}

			for (int i = 0; i < SizeX; i++)
				for (int j = 0; j < SizeY; j++)
				{
					m_figure[i][j] = '@';
				}
			break;
		}
		default:
		{
			cout << "Invalid input while constructing figure" << endl;
			break;
		}
		}
	}

	~Figure()
	{
		for (int i = 0; i < SizeX; ++i) {
			free(m_figure[i]);
		}
		free(m_figure);
	}
	void Rotate()
	{
		//инициализируем массив Y*X
		char ** m_figureloc = (char **)malloc(SizeY * sizeof(char *));
		for (int i = 0; i < SizeY; ++i) {
			m_figureloc[i] = (char *)malloc(SizeX * sizeof(char));
		}
		//перезаписываем значения из исходного массива в новый
		for (int i = 0; i < SizeX; i++)
			for (int j = 0; j < SizeY; j++)
			{
				m_figureloc[j][SizeX-i-1] = m_figure[i][j];
			}
		//очищаем старый массив
		for (int i = 0; i < SizeX; ++i) {
			free(m_figure[i]);
		}
		free(m_figure);


		//инициализируем массив как массив Y*X и заполняем его
		m_figure = (char * *)malloc(SizeY * sizeof(char *));
		for (int i = 0; i < SizeY; ++i) {
			m_figure[i] = (char *)realloc(m_figureloc[i], SizeX * sizeof(char));
		}

		free(m_figureloc);
		int tmp = SizeX;
		SizeX = SizeY;
		SizeY = tmp;
	}
	int GetX()const
	{
		return SizeX;
	}
	int GetY()const
	{
		return SizeY;
	}
	char GetChar(int x, int y) const
	{
		if (x >= SizeX)
			return 0;
		return  m_figure[x][y];
	}
	void SetChar(int x, int y, char c) { m_figure[x][y] = c; }
	void SetSizeX(int x) { this->SizeX = x; }
	void SetSizeY(int y) { this->SizeY = y; }

	Figure& operator=( const Figure &f) 
	{
		if (this == &f)
			return *this;

		for (int i = 0; i < SizeX; ++i) {
			free(m_figure[i]);
		}
		free(m_figure);
		
		SetSizeX(f.GetX());
		SetSizeY(f.GetY());

		m_figure = (char **)malloc(SizeX * sizeof(char *));
		for (int i = 0; i < SizeX; ++i) 
		{
			this->m_figure[i] = (char *)malloc(SizeY * sizeof(char));
		}

		for (int i = 0; i < SizeX; i++)
			for (int j = 0; j < SizeY; j++)
				this->m_figure[i][j] = f.GetChar(i, j);
		return *this;
	}
};

