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
    class ReposShip
    {

        public Connection connection;
        public ReposShip(Connection con)
        {
            connection = con;
        }

        // Восьмое задание
        public List<Ship> GetShipsByWeight(string loc, string weight)
        {
            Ship ship;
            List<Ship> ships = new List<Ship>();
            try
            {
                string QueryString =
                    "select * from ship where location = '" + loc + "' and carrying_weight >= '" + weight + "';";
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                NpgsqlDataReader dataReader = Command.ExecuteReader();
                foreach (DbDataRecord dbDataRecord in dataReader)
                {
                    ship = new Ship(
                        dbDataRecord["ship_id"].ToString(),
                        dbDataRecord["name"].ToString(),
                        dbDataRecord["location"].ToString(),
                        dbDataRecord["carrying_weight"].ToString());
                    ships.Add(ship);
                }
                dataReader.Close();
               
            }
            catch (PostgresException ex)
            {
                MessageBox.Show("Ошибка базы данных \n" + Convert.ToString(ex));
            }
            return ships;
        }
        // Девятое задание
        public List<Ship> GetShipsByLoc(string sid)
        {
            Ship ship;
            List<Ship> ships = new List<Ship>();
            try
            {
                string QueryString =
                    "select * from ship where ship_id = " + sid + ";";
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                NpgsqlDataReader dataReader = Command.ExecuteReader();
                foreach (DbDataRecord dbDataRecord in dataReader)
                {
                    ship = new Ship(
                        dbDataRecord["ship_id"].ToString(),
                        dbDataRecord["name"].ToString(),
                        dbDataRecord["location"].ToString(),
                        dbDataRecord["carrying_weight"].ToString());
                    ships.Add(ship);
                }
                dataReader.Close();
            
                    
            }
            
            catch (PostgresException ex)
            {
                MessageBox.Show("Ошибка базы данных \n" + Convert.ToString(ex));
            }
            return ships;
        }
    }
}
