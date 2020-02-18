namespace Kursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.selectRepID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddCtr = new System.Windows.Forms.Button();
            this.cost_ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_contracts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weight_ = new System.Windows.Forms.TextBox();
            this.SP_ = new System.Windows.Forms.ComboBox();
            this.DP_ = new System.Windows.Forms.ComboBox();
            this.IM_ = new System.Windows.Forms.CheckBox();
            this.calcCost = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddReport = new System.Windows.Forms.Button();
            this.DOA = new System.Windows.Forms.TextBox();
            this.L = new System.Windows.Forms.TextBox();
            this.CID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.userPW = new System.Windows.Forms.TextBox();
            this.userPN = new System.Windows.Forms.TextBox();
            this.userSN = new System.Windows.Forms.TextBox();
            this.userNM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.CalcProf = new System.Windows.Forms.Button();
            this.logtext = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.passtext = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Label();
            this.log_butt = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_contracts)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(871, 487);
            this.tabControl.TabIndex = 0;
            this.tabControl.Visible = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.selectRepID);
            this.tabPage6.Controls.Add(this.button2);
            this.tabPage6.Controls.Add(this.button1);
            this.tabPage6.Controls.Add(this.AddCtr);
            this.tabPage6.Controls.Add(this.cost_);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.DGV_contracts);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.weight_);
            this.tabPage6.Controls.Add(this.SP_);
            this.tabPage6.Controls.Add(this.DP_);
            this.tabPage6.Controls.Add(this.IM_);
            this.tabPage6.Controls.Add(this.calcCost);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(863, 461);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Contract";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // selectRepID
            // 
            this.selectRepID.Location = new System.Drawing.Point(507, 100);
            this.selectRepID.Name = "selectRepID";
            this.selectRepID.Size = new System.Drawing.Size(100, 20);
            this.selectRepID.TabIndex = 14;
            this.selectRepID.TextChanged += new System.EventHandler(this.selectRepID_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Show Reports on contract";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show contracts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // AddCtr
            // 
            this.AddCtr.Location = new System.Drawing.Point(649, 16);
            this.AddCtr.Name = "AddCtr";
            this.AddCtr.Size = new System.Drawing.Size(104, 23);
            this.AddCtr.TabIndex = 11;
            this.AddCtr.Text = "Add contract";
            this.AddCtr.UseVisualStyleBackColor = true;
            this.AddCtr.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cost_
            // 
            this.cost_.Location = new System.Drawing.Point(117, 205);
            this.cost_.Name = "cost_";
            this.cost_.Size = new System.Drawing.Size(121, 20);
            this.cost_.TabIndex = 10;
            this.cost_.TextChanged += new System.EventHandler(this.cost__TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cost";
            // 
            // DGV_contracts
            // 
            this.DGV_contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_contracts.Location = new System.Drawing.Point(3, 266);
            this.DGV_contracts.Name = "DGV_contracts";
            this.DGV_contracts.Size = new System.Drawing.Size(895, 259);
            this.DGV_contracts.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Strarting point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destination point";
            // 
            // weight_
            // 
            this.weight_.Location = new System.Drawing.Point(117, 18);
            this.weight_.Name = "weight_";
            this.weight_.Size = new System.Drawing.Size(121, 20);
            this.weight_.TabIndex = 4;
            // 
            // SP_
            // 
            this.SP_.AutoCompleteCustomSource.AddRange(new string[] {
            "Shanhai",
            "Singapur",
            "Rotterdam",
            "Pusan",
            "Nagoa",
            "Dampir",
            "Dubai",
            "Hamburg",
            "Iokogama",
            "Huston"});
            this.SP_.FormattingEnabled = true;
            this.SP_.Items.AddRange(new object[] {
            "Shanhai",
            "Singapur",
            "Rotterdam",
            "Pusan",
            "Nagoa",
            "Dampir",
            "Dubai",
            "Hamburg",
            "Iokogama",
            "Huston"});
            this.SP_.Location = new System.Drawing.Point(117, 57);
            this.SP_.Name = "SP_";
            this.SP_.Size = new System.Drawing.Size(121, 21);
            this.SP_.TabIndex = 3;
            this.SP_.SelectedIndexChanged += new System.EventHandler(this.SP__SelectedIndexChanged);
            // 
            // DP_
            // 
            this.DP_.AutoCompleteCustomSource.AddRange(new string[] {
            "Shanhai",
            "Singapur",
            "Rotterdam",
            "Pusan",
            "Nagoa",
            "Dampir",
            "Dubai",
            "Hamburg",
            "Iokogama",
            "Huston"});
            this.DP_.FormattingEnabled = true;
            this.DP_.Items.AddRange(new object[] {
            "Shanhai",
            "Singapur",
            "Rotterdam",
            "Pusan",
            "Nagoa",
            "Dampir",
            "Dubai",
            "Hamburg",
            "Iokogama",
            "Huston"});
            this.DP_.Location = new System.Drawing.Point(117, 97);
            this.DP_.Name = "DP_";
            this.DP_.Size = new System.Drawing.Size(121, 21);
            this.DP_.TabIndex = 2;
            // 
            // IM_
            // 
            this.IM_.AutoSize = true;
            this.IM_.Location = new System.Drawing.Point(134, 154);
            this.IM_.Name = "IM_";
            this.IM_.Size = new System.Drawing.Size(104, 17);
            this.IM_.TabIndex = 1;
            this.IM_.Text = "Make a contract";
            this.IM_.UseVisualStyleBackColor = true;
            this.IM_.CheckedChanged += new System.EventHandler(this.IM__CheckedChanged);
            // 
            // calcCost
            // 
            this.calcCost.Location = new System.Drawing.Point(24, 148);
            this.calcCost.Name = "calcCost";
            this.calcCost.Size = new System.Drawing.Size(87, 23);
            this.calcCost.TabIndex = 0;
            this.calcCost.Text = "Calculate cost";
            this.calcCost.UseVisualStyleBackColor = true;
            this.calcCost.Click += new System.EventHandler(this.calcCost_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddReport);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.DOA);
            this.tabPage2.Controls.Add(this.L);
            this.tabPage2.Controls.Add(this.CID);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(863, 461);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddReport
            // 
            this.AddReport.Location = new System.Drawing.Point(266, 313);
            this.AddReport.Name = "AddReport";
            this.AddReport.Size = new System.Drawing.Size(75, 23);
            this.AddReport.TabIndex = 6;
            this.AddReport.Text = "Add report";
            this.AddReport.UseVisualStyleBackColor = true;
            this.AddReport.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DOA
            // 
            this.DOA.Location = new System.Drawing.Point(333, 172);
            this.DOA.Name = "DOA";
            this.DOA.Size = new System.Drawing.Size(100, 20);
            this.DOA.TabIndex = 5;
            // 
            // L
            // 
            this.L.Location = new System.Drawing.Point(333, 127);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(100, 20);
            this.L.TabIndex = 4;
            this.L.TextChanged += new System.EventHandler(this.L_TextChanged);
            // 
            // CID
            // 
            this.CID.Location = new System.Drawing.Point(333, 82);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(100, 20);
            this.CID.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date of Arrival";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contract ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.userPW);
            this.tabPage3.Controls.Add(this.userPN);
            this.tabPage3.Controls.Add(this.userSN);
            this.tabPage3.Controls.Add(this.userNM);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.reg);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(863, 461);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Add user";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // userPW
            // 
            this.userPW.Location = new System.Drawing.Point(397, 245);
            this.userPW.Name = "userPW";
            this.userPW.Size = new System.Drawing.Size(100, 20);
            this.userPW.TabIndex = 8;
            // 
            // userPN
            // 
            this.userPN.Location = new System.Drawing.Point(397, 190);
            this.userPN.Name = "userPN";
            this.userPN.Size = new System.Drawing.Size(100, 20);
            this.userPN.TabIndex = 7;
            // 
            // userSN
            // 
            this.userSN.Location = new System.Drawing.Point(397, 143);
            this.userSN.Name = "userSN";
            this.userSN.Size = new System.Drawing.Size(100, 20);
            this.userSN.TabIndex = 6;
            // 
            // userNM
            // 
            this.userNM.Location = new System.Drawing.Point(397, 94);
            this.userNM.Name = "userNM";
            this.userNM.Size = new System.Drawing.Size(100, 20);
            this.userNM.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Surname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Phone number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Passsword";
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(375, 311);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(96, 23);
            this.reg.TabIndex = 0;
            this.reg.Text = "Register user";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.result);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.To);
            this.tabPage4.Controls.Add(this.from);
            this.tabPage4.Controls.Add(this.CalcProf);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(863, 461);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Calulculate Profit";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Result";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(345, 331);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(386, 136);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(386, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(245, 211);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(20, 13);
            this.To.TabIndex = 2;
            this.To.Text = "To";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(245, 139);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(30, 13);
            this.from.TabIndex = 1;
            this.from.Text = "From";
            // 
            // CalcProf
            // 
            this.CalcProf.Location = new System.Drawing.Point(342, 272);
            this.CalcProf.Name = "CalcProf";
            this.CalcProf.Size = new System.Drawing.Size(103, 23);
            this.CalcProf.TabIndex = 0;
            this.CalcProf.Text = "Calculate profit";
            this.CalcProf.UseVisualStyleBackColor = true;
            this.CalcProf.Click += new System.EventHandler(this.CalcProf_Click);
            // 
            // logtext
            // 
            this.logtext.Location = new System.Drawing.Point(188, 35);
            this.logtext.Name = "logtext";
            this.logtext.Size = new System.Drawing.Size(121, 20);
            this.logtext.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(96, 82);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(0, 13);
            this.pass.TabIndex = 1;
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(188, 82);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(121, 20);
            this.passtext.TabIndex = 4;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(98, 35);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(0, 13);
            this.log.TabIndex = 0;
            // 
            // log_butt
            // 
            this.log_butt.Location = new System.Drawing.Point(147, 150);
            this.log_butt.Name = "log_butt";
            this.log_butt.Size = new System.Drawing.Size(75, 23);
            this.log_butt.TabIndex = 6;
            this.log_butt.Text = "Login";
            this.log_butt.UseVisualStyleBackColor = true;
            this.log_butt.Click += new System.EventHandler(this.log_butt_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "login";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(404, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "pass";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.log_butt);
            this.panelLogin.Controls.Add(this.log);
            this.panelLogin.Controls.Add(this.label13);
            this.panelLogin.Controls.Add(this.pass);
            this.panelLogin.Controls.Add(this.logtext);
            this.panelLogin.Controls.Add(this.passtext);
            this.panelLogin.Location = new System.Drawing.Point(338, 109);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(423, 190);
            this.panelLogin.TabIndex = 9;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 562);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_contracts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox cost_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_contracts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weight_;
        private System.Windows.Forms.ComboBox SP_;
        private System.Windows.Forms.ComboBox DP_;
        private System.Windows.Forms.CheckBox IM_;
        private System.Windows.Forms.Button calcCost;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button AddReport;
        private System.Windows.Forms.TextBox DOA;
        private System.Windows.Forms.TextBox L;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddCtr;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox userPW;
        private System.Windows.Forms.TextBox userPN;
        private System.Windows.Forms.TextBox userSN;
        private System.Windows.Forms.TextBox userNM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Button CalcProf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox selectRepID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox logtext;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button log_butt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelLogin;
    }
}

