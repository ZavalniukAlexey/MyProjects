using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form1 : Form
    {
        private string S = "";
        private void fillDGV_contracts()
        {
            DGV_contracts.Columns.Clear();
            DGV_contracts.Columns.Add("contract_id", "Contract ID");
            DGV_contracts.Columns.Add("starting_point", "Starting Point");
            DGV_contracts.Columns.Add("Destination_point", "Destination Point");
            DGV_contracts.Columns.Add("weight", "Weight");
            DGV_contracts.Columns.Add("date_of_start", "Date of start");
            DGV_contracts.Columns.Add("date_of_finish", "Date of finish");
            DGV_contracts.Columns.Add("cost", "Cost");

        }

        private void fillDGV_Reports()
        {
            DGV_contracts.Columns.Clear();
            DGV_contracts.Columns.Add("report_id", "Report ID");
            DGV_contracts.Columns.Add("location", "Location");
            DGV_contracts.Columns.Add("date_of_arrival", "Date of Arrival");
        }
        public Form1()
        {
            InitializeComponent();
            fillDGV_contracts();
            presenter.ShowClientContracts(factory, DGV_contracts, userid.ToString());
            AddCtr.Enabled = false;

        }
        Presenter presenter = new Presenter();
        Factory factory = new Factory("127.0.0.1", "5432", "connector", "11", "kurs_backup"); 
        int userid = 3;

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

  
        private void calcCost_Click(object sender, EventArgs e)
        {
            presenter.CalculateCosts(factory, cost_, SP_.Text, DP_.Text, weight_.Text);
            S = SP_.Text;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string conid_ = CID.Text;
            string loc_ = L.Text;
            string arr_date_ = DOA.Text;
            presenter.CreateReport(factory, conid_, loc_, arr_date_);
        }

        private void L_TextChanged(object sender, EventArgs e)
        {

        }


      
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            string StP = SP_.Text;
            string DsP = DP_.Text;
            string We = weight_.Text;
            string IM;
           
            if (IM_.Checked == true)
            {
                IM = "1";
                AddCtr.Enabled = true;
            }
            else
            {
                IM = "0";
                AddCtr.Enabled = false;
            }
            string date_today = "2019-12-20";

            string DOF = presenter.CalcDOF(factory, date_today, StP, DsP);
            DOF = DOF.Substring(0, DOF.Length-8);
          
            string RID = presenter.getRouteID(factory, StP, DsP);
     
            string SHID = presenter.getShipID(factory, We, StP);

            //профессиональный дебаг через сиауты. 
            //посмотреть в отладке - не вариант.

            /*
            MessageBox.Show(Convert.ToString(userid));
            MessageBox.Show(StP);
            MessageBox.Show(DsP);
            MessageBox.Show(We);
            MessageBox.Show(IM);
            MessageBox.Show(date_today);
            MessageBox.Show(DOF);
            MessageBox.Show(cost_.Text);
            MessageBox.Show(RID);
            MessageBox.Show(SHID);
            */
    
            //вот тут он вылетает при добавлении контракта
            presenter.AddContract(factory, Convert.ToString(userid), StP, DsP, We, IM, date_today, DOF, cost_.Text, RID, SHID);
            fillDGV_contracts();
            presenter.ShowClientContracts(factory, DGV_contracts, userid.ToString());
        }

        private void IM__CheckedChanged(object sender, EventArgs e)
        {
            if (!AddCtr.Enabled)
                AddCtr.Enabled = true;
            else
                AddCtr.Enabled = false;
            if (cost_.Text == "")
                AddCtr.Enabled = false;
        }

        private void SP__SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reg_Click(object sender, EventArgs e)
        {
            string phone = userPN.Text;
            string name = userNM.Text;
            string surname = userSN.Text;
            string pass = userPW.Text;
            factory.user.Create_User(phone, name, surname, pass);
            
        }

        private void cost__TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            fillDGV_contracts();
            presenter.ShowClientContracts(factory, DGV_contracts, userid.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fillDGV_Reports(); 
            presenter.getReports(factory, DGV_contracts, selectRepID.Text);
        }

        private void selectRepID_TextChanged(object sender, EventArgs e)
        {

        }

       private void CalcProf_Click(object sender, EventArgs e)
        {
 
        }
        
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void log_butt_Click(object sender, EventArgs e)
        {
            string login = logtext.Text;
            string pass = passtext.Text;
            string role = "";
            bool success = true;
            try
            {
                factory = new Factory("127.0.0.1", "5432", login, pass, "kurs_backup");
                role = presenter.Check_Role(factory, login);
                MessageBox.Show(role);
            }
            catch (Exception ex)
            {
                success = false;
                MessageBox.Show("Проверьте соединение и корректность введенных данных" + ex.Message);
            }
            if (success)
            {
                tabControl.Visible = true;
                panelLogin.Dispose();
                if (role == "logist")
                {
                    tabPage4.Dispose();
                    tabPage2.Dispose();
                   // tabControl.TabPages["tabAdmin"].Dispose();
                }
                if (role == "captain")
                {
                    tabPage6.Dispose();
                    tabPage4.Dispose();
                    tabPage3.Dispose();
                   // tabControl.TabPages["tabTrainer"].Dispose();
                }
                if (role == "client")
                {
                    tabPage2.Dispose();
                    tabPage4.Dispose();
                    tabPage3.Dispose();
                    AddCtr.Visible = false;
                }
                if (role =="booker")
                {
                    tabPage2.Dispose();
                    tabPage6.Dispose();
                    tabPage3.Dispose();
                }
            }

        }

        private void logtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
