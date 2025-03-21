﻿namespace simplepa2.UI.Views
{
    partial class View_HistoryFireSignal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            this.panel2 = new Wisej.Web.Panel();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colEventvmid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colWrite_Time = new Wisej.Web.DataGridViewDateTimePickerColumn();
            this.colPath = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEvent_Text = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState = new Wisej.Web.DataGridViewTextBoxColumn();
            this.수신반타입 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.포트번호 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.수신정보 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.수신명령 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.상세 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colIp = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colAlarm = new Wisej.Web.DataGridViewTextBoxColumn();
            this.eventvmBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.panel1 = new Wisej.Web.Panel();
            this.label5 = new Wisej.Web.Label();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.label2 = new Wisej.Web.Label();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.popTestButton = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.textBox3 = new Wisej.Web.TextBox();
            this.label4 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.textBox2 = new Wisej.Web.TextBox();
            this.eventvmTableAdapter = new simplepa2.DataSet1TableAdapters.EventvmTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventvmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1360, 860);
            this.panel2.TabIndex = 50;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colEventvmid,
            this.colWrite_Time,
            this.colPath,
            this.colEvent_Text,
            this.colState,
            this.수신반타입,
            this.포트번호,
            this.수신정보,
            this.수신명령,
            this.상세,
            this.colIp,
            this.colDevicename,
            this.colAlarm});
            this.dataGridView1.DataSource = this.eventvmBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1320, 768);
            this.dataGridView1.TabIndex = 67;
            // 
            // colEventvmid
            // 
            this.colEventvmid.DataPropertyName = "EventVMId";
            this.colEventvmid.HeaderText = "No";
            this.colEventvmid.Name = "colEventvmid";
            this.colEventvmid.ReadOnly = true;
            this.colEventvmid.Width = 60;
            // 
            // colWrite_Time
            // 
            this.colWrite_Time.DataPropertyName = "write_time";
            dataGridViewCellStyle1.Format = "G";
            this.colWrite_Time.DefaultCellStyle = dataGridViewCellStyle1;
            this.colWrite_Time.HeaderText = "수신시각";
            this.colWrite_Time.Name = "colWrite_Time";
            this.colWrite_Time.Width = 200;
            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "path";
            this.colPath.HeaderText = "수신위치";
            this.colPath.Name = "colPath";
            this.colPath.Width = 140;
            // 
            // colEvent_Text
            // 
            this.colEvent_Text.DataPropertyName = "event_text";
            this.colEvent_Text.HeaderText = "내용";
            this.colEvent_Text.Name = "colEvent_Text";
            this.colEvent_Text.Width = 120;
            // 
            // colState
            // 
            this.colState.DataPropertyName = "state";
            this.colState.HeaderText = "상태";
            this.colState.Name = "colState";
            this.colState.Width = 140;
            // 
            // 수신반타입
            // 
            this.수신반타입.HeaderText = "수신반타입";
            this.수신반타입.Name = "수신반타입";
            this.수신반타입.Width = 200;
            // 
            // 포트번호
            // 
            this.포트번호.HeaderText = "포트번호";
            this.포트번호.Name = "포트번호";
            this.포트번호.Width = 150;
            // 
            // 수신정보
            // 
            this.수신정보.HeaderText = "수신정보";
            this.수신정보.Name = "수신정보";
            this.수신정보.Width = 150;
            // 
            // 수신명령
            // 
            this.수신명령.HeaderText = "수신명령";
            this.수신명령.Name = "수신명령";
            this.수신명령.Width = 130;
            // 
            // 상세
            // 
            this.상세.HeaderText = "상세";
            this.상세.Name = "상세";
            this.상세.Width = 200;
            // 
            // colIp
            // 
            this.colIp.DataPropertyName = "ip";
            this.colIp.HeaderText = "ip";
            this.colIp.Name = "colIp";
            // 
            // colDevicename
            // 
            this.colDevicename.DataPropertyName = "DeviceName";
            this.colDevicename.HeaderText = "DeviceName";
            this.colDevicename.Name = "colDevicename";
            // 
            // colAlarm
            // 
            this.colAlarm.DataPropertyName = "alarm";
            this.colAlarm.HeaderText = "alarm";
            this.colAlarm.Name = "colAlarm";
            // 
            // eventvmBindingSource
            // 
            this.eventvmBindingSource.DataMember = "Eventvm";
            this.eventvmBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.popTestButton);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.Size = new System.Drawing.Size(1320, 52);
            this.panel1.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("@topLabel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(597, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 32);
            this.label5.TabIndex = 87;
            this.label5.Text = "이벤트";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBox2.AutoSize = false;
            this.comboBox2.Location = new System.Drawing.Point(689, 0);
            this.comboBox2.Margin = new Wisej.Web.Padding(0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 32);
            this.comboBox2.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("@topLabel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(916, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 85;
            this.label2.Text = "수신장비";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBox1.AutoSize = false;
            this.comboBox1.Location = new System.Drawing.Point(1008, 0);
            this.comboBox1.Margin = new Wisej.Web.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 32);
            this.comboBox1.TabIndex = 84;
            // 
            // popTestButton
            // 
            this.popTestButton.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.popTestButton.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.popTestButton.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.popTestButton.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.popTestButton.Location = new System.Drawing.Point(1218, 0);
            this.popTestButton.Margin = new Wisej.Web.Padding(0);
            this.popTestButton.Name = "popTestButton";
            this.popTestButton.Size = new System.Drawing.Size(100, 32);
            this.popTestButton.TabIndex = 83;
            this.popTestButton.Text = "검색";
            this.popTestButton.Click += new System.EventHandler(this.popTestButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.button3.BorderStyle = Wisej.Web.BorderStyle.None;
            this.button3.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button3.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.button3.Location = new System.Drawing.Point(504, 0);
            this.button3.Margin = new Wisej.Web.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 32);
            this.button3.TabIndex = 82;
            this.button3.Text = "6개월";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.button2.BorderStyle = Wisej.Web.BorderStyle.None;
            this.button2.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button2.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.button2.Location = new System.Drawing.Point(433, 0);
            this.button2.Margin = new Wisej.Web.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 32);
            this.button2.TabIndex = 81;
            this.button2.Text = "1개월";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.button1.BorderStyle = Wisej.Web.BorderStyle.None;
            this.button1.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.button1.Location = new System.Drawing.Point(363, 0);
            this.button1.Margin = new Wisej.Web.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 32);
            this.button1.TabIndex = 80;
            this.button1.Text = "1주일";
            // 
            // textBox3
            // 
            this.textBox3.AutoSize = false;
            this.textBox3.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox3.Location = new System.Drawing.Point(222, 0);
            this.textBox3.Margin = new Wisej.Web.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 32);
            this.textBox3.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(187, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 32);
            this.label4.TabIndex = 78;
            this.label4.Text = "~";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("@topLabel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 32);
            this.label3.TabIndex = 77;
            this.label3.Text = "날짜";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.AutoSize = false;
            this.textBox2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox2.Location = new System.Drawing.Point(54, 0);
            this.textBox2.Margin = new Wisej.Web.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 32);
            this.textBox2.TabIndex = 76;
            // 
            // eventvmTableAdapter
            // 
            this.eventvmTableAdapter.ClearBeforeFill = true;
            // 
            // View_HistoryFireSignal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_HistoryFireSignal";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.View_HistoryFireSignal_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventvmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn 수신반타입;
        private Wisej.Web.DataGridViewTextBoxColumn 포트번호;
        private Wisej.Web.DataGridViewTextBoxColumn 수신정보;
        private Wisej.Web.DataGridViewTextBoxColumn 수신명령;
        private Wisej.Web.DataGridViewTextBoxColumn 상세;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Label label5;
        private Wisej.Web.ComboBox comboBox2;
        private Wisej.Web.Label label2;
        private Wisej.Web.ComboBox comboBox1;
        private Wisej.Web.Button popTestButton;
        private Wisej.Web.Button button3;
        private Wisej.Web.Button button2;
        private Wisej.Web.Button button1;
        private Wisej.Web.TextBox textBox3;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label label3;
        private Wisej.Web.TextBox textBox2;
        private Wisej.Web.DataGridViewTextBoxColumn colEventvmid;
        private Wisej.Web.DataGridViewDateTimePickerColumn colWrite_Time;
        private Wisej.Web.DataGridViewTextBoxColumn colEvent_Text;
        private Wisej.Web.DataGridViewTextBoxColumn colIp;
        private Wisej.Web.DataGridViewTextBoxColumn colPath;
        private Wisej.Web.DataGridViewTextBoxColumn colDevicename;
        private Wisej.Web.DataGridViewTextBoxColumn colState;
        private Wisej.Web.DataGridViewTextBoxColumn colAlarm;
        private Wisej.Web.BindingSource eventvmBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.EventvmTableAdapter eventvmTableAdapter;
    }
}
