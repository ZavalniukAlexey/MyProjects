using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursach.repos;
using Npgsql;
namespace Kursach
{
    class Factory : IDisposable
    {
        public NpgsqlConnection NpgsqlConnection;
        public Connection connection;
        private bool Disposed = false;
        public Login log { private get; set; }
        public Login login => log;
        public ReposContract con { private get; set; }
        public ReposContract contract => con;
        public ReposReport rep { private get; set; }
        public ReposReport report => rep;
        public ReposRoutes rout { private get; set; }
        public ReposRoutes routes => rout;
        public ReposShip sh { private get; set; }
        public ReposShip ship => sh;
        public ReposUser us { private get; set; }
        public ReposUser user => us;

        public Factory(string server, string port, string user, string pass, string dbname)
        {
            string ConnectionString = "Server=" + server + "; Port=" + port + "; User Id=" + user + "; Password=" + pass + "; Database=" + dbname + ";";
            NpgsqlConnection = new NpgsqlConnection(ConnectionString);
            connection = new Connection(NpgsqlConnection);
            OpenConnection();
            log = new Login(connection);
            con = new ReposContract(connection);
            rep = new ReposReport(connection);
            rout = new ReposRoutes(connection);
            sh = new ReposShip(connection);
            us = new ReposUser(connection);
        }

        public void OpenConnection()
        {
            connection.connection.Open();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    connection.connection.Close();
                }
                Disposed = true;
            }
        }
        ~Factory()
        {
            Dispose(false);
        }
    }
}
