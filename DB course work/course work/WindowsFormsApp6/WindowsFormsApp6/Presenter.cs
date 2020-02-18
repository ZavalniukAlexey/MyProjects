using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Kursach
{
    class Presenter
    {
        public string Check_Role(Factory factory, string login)
        {
            return factory.login.Check_Role(login);
        }
        //первое
        public void ShowClientContracts(Factory factory, DataGridView dgv, string user)
        {
            foreach (var i in factory.contract.GetContracts(user))
                dgv.Rows.Add(i.ID, i.StartingPoint, i.DestinationPoint, i.Weight, i.DateOfStart, i.DateOfFinish, i.Cost);
        }
        //Второе, Седьмое
        public void CalculateCosts(Factory factory, TextBox tb, string s_point, string d_point, string weight)
        {
            tb.Text = factory.contract.GetCosts(s_point, d_point, weight).ToString();
        }
        public string CalcDOF(Factory factory, string date_today, string StP, string DsP)
        {
            string DOF = factory.contract.GetDOF(date_today, StP, DsP);
            return DOF;
        }
        public string getRouteID(Factory factory, string StP, string DsP)
        {
            string routeID = factory.contract.GetRouteID(StP, DsP);
            return routeID;
        }
        public string getShipID(Factory factory, string we, string STP)
        {
            string ShipID = factory.contract.GetShipID(we, STP);
            return ShipID;
        }
        // Третье
        public void CreateReport(Factory factory, string con_id, string loc, string arr_date)
        {
            factory.report.AddReport(con_id, loc, arr_date);
        }
        
        // Четвертое
        public void Createuser(Factory factory, string phone, string name, string surname, string pass)
        {
            factory.user.Create_User(phone, name, surname, pass);
        }
        // Пятое
        
        public void AddContract(Factory factory, string uid, string SP, string DP, string W, string IM, string DOS, string DOF, string C, string rid, string shid )
        {

            factory.contract.AddContract(uid, SP, DP, W, IM, DOS, DOF, C, rid, shid);
        }

        // Шестое
        // надо впилить к созданию контракта
       /* public void ClearRequest(Factory factory, string rid)
        {
            factory.request.DeleteRequest(rid);
        }*/
        // Восьмое 
        public void SelectOptimalShip(Factory factory, DataGridView dgv, string weight, string loc)
        {
            foreach (var i in factory.ship.GetShipsByWeight(loc, weight))
                dgv.Rows.Add(i.ID, i.Location, i.CarryingWeight);
        }
        // Девятое
        public void FindShip(Factory factory, DataGridView dgv, string sid)
        {
            foreach (var i in factory.ship.GetShipsByLoc(sid))
                dgv.Rows.Add(i.ID, i.Location, i.CarryingWeight);
        }
        
        public void getReports(Factory factory, DataGridView dgv, string cid)
        {
            foreach (var i in factory.report.SelectReport(cid))
                dgv.Rows.Add(i.ReportID, i.Location, i.DateOfArrival);
        }
        public int getUserID(string str)
        {
            int i = 0;
            return i;
        }
    }
}
