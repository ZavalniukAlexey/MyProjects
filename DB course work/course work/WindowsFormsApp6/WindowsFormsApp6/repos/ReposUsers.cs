using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Kursach.tables;
using System.Data.Common;
using System.Windows.Forms;
namespace Kursach.repos
{
    class ReposUser
    {

        private Connection sqlConnection;
        public ReposUser(Connection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        // Четвертое задание
        public void Create_User(string phone, string name, string surname, string pass)
        {

            string QueryString = "create user " + phone + " with encrypted password '" + pass + "' in role common_users;";
            NpgsqlCommand Command = new NpgsqlCommand(QueryString, sqlConnection.CreateConnection.connection);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения операции. \nПроверьте корректность введенных данных" + ex.Message);
            }

            QueryString = "insert into users (phone_number, name, surname, password)" +
                "values (" + phone + ", '" + name + "', '" + surname + "', '" + pass + "');";
            Command = new NpgsqlCommand(QueryString, sqlConnection.CreateConnection.connection);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения операции. \nПроверьте корректность введенных данных" + ex.Message);
            }

        }

        public Connection connection;
     
        /*public int getUserID(string text)
        {
            try
            {
                string QueryString = "select users_id from users where users.phone_number = @text;";
                NpgsqlCommand command = new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                command.Parameters.AddWithValue("@text", Convert.ToInt32(text));
            }
            catch (Exception ex);
            return 0;*/
        }
    }
