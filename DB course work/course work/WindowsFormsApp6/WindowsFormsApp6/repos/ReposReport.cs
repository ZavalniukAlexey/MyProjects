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
    class ReposReport
    {
        public Connection connection;
        public ReposReport(Connection con)
        {
            connection = con;
        }

        public void AddReport(string con_id, string location, string date_of_arrival)
        {
            try
            {
                string QueryString =
                    "insert into report(_location, date_of_arrival, contract_id) values" +
                    "(@location, '"+date_of_arrival+"', @contract_id);";
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                Command.Parameters.AddWithValue("@location", location);
                Command.Parameters.AddWithValue("@date_of_arrival", date_of_arrival);
                Command.Parameters.AddWithValue("@contract_id", Convert.ToInt32(con_id));


                try
                {
                    Command.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка выполнения операции. \nПроверьте корректность введенных данных");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка выполнения операции." + e.Message);
            }
        }
        public List<Report> SelectReport(string con_id)
        {
            List<Report> reports = new List<Report>();
            Report report;

            try
            {
                string QueryString = "select * from report where report.contract_id = @con_id;";
                NpgsqlCommand command = new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                command.Parameters.AddWithValue("@con_id", Convert.ToInt32(@con_id));

                NpgsqlDataReader dataReader = command.ExecuteReader();
                foreach (DbDataRecord dbDataRecord in dataReader)
                {
                       report = new Report(
                       dbDataRecord["report_id"].ToString(),
                       dbDataRecord["_location"].ToString(),
                       dbDataRecord["date_of_arrival"].ToString(),
                       dbDataRecord["contract_id"].ToString());
                    reports.Add(report);
                }
                dataReader.Close();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return reports;
        }
    }
}
