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
    class ReposContract
    {
        public Connection connection;
        public ReposContract(Connection con)
        {
            connection = con;
        }

        //вывод всех контрактов
        public List<Contract> GetContracts(string id)
        {
            Contract contract;
            List<Contract> contracts = new List<Contract>();
            try
            {
                string QueryString =
                    "select * from contract where users_id =" + id + ";";
                NpgsqlCommand Command = new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                NpgsqlDataReader dataReader = Command.ExecuteReader();
                foreach (DbDataRecord dbDataRecord in dataReader)
                {
                    contract = new Contract(
                    dbDataRecord["contract_id"].ToString(),
                    dbDataRecord["users_id"].ToString(),
                    dbDataRecord["starting_point"].ToString(),
                    dbDataRecord["destination_point"].ToString(),
                    dbDataRecord["weight"].ToString(),
                    dbDataRecord["is_made"].ToString(),
                    dbDataRecord["date_of_start"].ToString(),
                    dbDataRecord["date_of_finish"].ToString(),
                    dbDataRecord["cost"].ToString(),
                    dbDataRecord["route_id"].ToString(),
                    dbDataRecord["ship_id"].ToString()
                    );
                    contracts.Add(contract);
                }
                dataReader.Close();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show("Ошибка на уровне базы данных" + Convert.ToString(ex));
            }
            return contracts;

           
        }
        //2 и 7 задание 
        public string GetCosts(string s_point, string d_point, string weight)
        {
            string cost = "";
            try
            {
                string QueryString = "select calc_cost(@s_point, @d_point, @weight);";
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                Command.Parameters.AddWithValue("@weight", Convert.ToInt32(weight));
                Command.Parameters.AddWithValue("@d_point", d_point);
                Command.Parameters.AddWithValue("@s_point", s_point);
                NpgsqlDataReader dataReader = Command.ExecuteReader();
                foreach (DbDataRecord dbDataRecord in dataReader)
                {
                    cost = dataReader["calc_cost"].ToString();
                }
                dataReader.Close();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show("Ошибка базы данных \n" + Convert.ToString(ex));
            }
            return cost;
        }

        public string GetDOF(string DOS, string STP, string DSP)
        {
            string DOF = "";
            try
            {
                string QueryString = "select calc_DOF(@DOS, @STP, @DSP);";
                NpgsqlCommand command = new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                command.Parameters.AddWithValue("@DOS", DOS);
                command.Parameters.AddWithValue("@STP", STP);
                command.Parameters.AddWithValue("@DSP", DSP);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                foreach (DbDataRecord dbDataRecord in dataReader)
                {
                    DOF = dataReader["calc_dof"].ToString();
                }
                dataReader.Close();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show("Ошибка базы данных \n" + Convert.ToString(ex));
            }
            return DOF;
        }
        public string GetRouteID(string STP, string DSP)
        {
            string RouteID = "";
            try
            {
                string QueryString = "select get_rid(@stp, @dsp);";
                NpgsqlCommand command = new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                command.Parameters.AddWithValue("@STP", STP);
                command.Parameters.AddWithValue("@DSP", DSP);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                foreach (DbDataRecord dbDataRecord in dataReader)
                {
                    RouteID = dataReader["get_rid"].ToString();
                   
                }
                dataReader.Close();
            }
          
            catch (PostgresException ex)
            {
                MessageBox.Show("Ошибка базы данных \n" + Convert.ToString(ex));
            }
            return RouteID;
           
        }

        public string GetShipID(string we, string stp)
        {
            string ShipID = "";
            try
            {
                string QueryString = "select get_shid(@stp, @we)";
                NpgsqlCommand command = new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                command.Parameters.AddWithValue("@we", Convert.ToInt32(we));
                command.Parameters.AddWithValue("@stp", stp);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                foreach (DbDataRecord dbDataRecord in dataReader)
                {
                    ShipID = dataReader["get_shid"].ToString();
                }
                dataReader.Close();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show("Ошибка базы данных \n" + Convert.ToString(ex));
            }
            return ShipID;
        }
            public void AddContract(
            string uid, string sp, string dp, string w, string im, string dos, string dof, string c, string rid, string shid)
        {
            try
            {
                string QueryString = "insert into contract(users_id, starting_point, destination_point, weight, is_made, date_of_start, date_of_finish, cost, route_id, ship_id)" +
                    "values(@uid,@sp, @dp, @w, @im, '"+dos+"', '"+dof+"', @c, @rid, @shid);" ;
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                npgsqlCommand.Parameters.AddWithValue("@uid", Convert.ToInt32(uid));
                npgsqlCommand.Parameters.AddWithValue("@sp", sp);
                npgsqlCommand.Parameters.AddWithValue("@dp", dp);
                npgsqlCommand.Parameters.AddWithValue("@w", Convert.ToInt32(w));
                npgsqlCommand.Parameters.AddWithValue("@im", Convert.ToInt32(im));
                npgsqlCommand.Parameters.AddWithValue("@dos", dos);
                npgsqlCommand.Parameters.AddWithValue("@dof", dof);
                npgsqlCommand.Parameters.AddWithValue("@c", Convert.ToInt32(c));
                npgsqlCommand.Parameters.AddWithValue("@rid", Convert.ToInt32(rid));
                npgsqlCommand.Parameters.AddWithValue("@shid", Convert.ToInt32(shid));

                try
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            catch(Exception e) { 
                MessageBox.Show("Ошибка выполнения операции." + e.Message); 
            }
        }
    }
}
