using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;

namespace Kursach
{
    class Login
    {
        
            private Connection sqlConnection;
            public Login(Connection sqlConnection)
            {
                this.sqlConnection = sqlConnection;
            }
            public string Check_Role(string login)
            {
                string _role = "role";
                try
                {
                    string QueryString = "select rolname from pg_user join pg_auth_members on(pg_user.usesysid= pg_auth_members.member) " +
                        "join pg_roles on(pg_roles.oid = pg_auth_members.roleid) " +
                        "where pg_user.usename = '" + login + "';";
                    NpgsqlCommand Command =
                        new NpgsqlCommand(QueryString, sqlConnection.CreateConnection.connection);
                    NpgsqlDataReader dataReader = Command.ExecuteReader();
                    foreach (DbDataRecord dbDataRecord in dataReader)
                    {
                        _role = dbDataRecord["rolname"].ToString();
                    }
                    dataReader.Close();
                    // MessageBox.Show(_role + "is now");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return _role;
            }
        }
    }
