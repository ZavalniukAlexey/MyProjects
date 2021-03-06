﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
namespace Kursach
{
    class Registration
    {
        private Connection sqlConnection;
        public Registration(Connection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }
        public void Create_User(string login, string pass, string role)
        {
            string QueryString = "create user " + login + " with encrypted password '" + pass + "' in role " + role + ";";
            NpgsqlCommand Command = new NpgsqlCommand(QueryString, sqlConnection.CreateConnection.connection);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения операции. \nПроверьте корректность введенных данных" + ex.Message);
            }
        }
    }
}
