namespace simplepa2.UI.Views
{
    partial class View_HistoryDevice
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
            this.colEventdeviceid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colWrite_Time = new Wisej.Web.DataGridViewDateTimePickerColumn();
            this.colPath = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEvent_Text = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.장비종류 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colIp = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colAlarm = new Wisej.Web.DataGridViewTextBoxColumn();
            this.카테고리 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.변경이력 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.상세 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.eventdeviceBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.panel3 = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.comboBox3 = new Wisej.Web.ComboBox();
            this.label6 = new Wisej.Web.Label();
            this.comboBox4 = new Wisej.Web.ComboBox();
            this.button4 = new Wisej.Web.Button();
            this.button5 = new Wisej.Web.Button();
            this.button6 = new Wisej.Web.Button();
            this.button7 = new Wisej.Web.Button();
            this.textBox1 = new Wisej.Web.TextBox();
            this.label7 = new Wisej.Web.Label();
            this.label8 = new Wisej.Web.Label();
            this.textBox4 = new Wisej.Web.TextBox();
            this.eventdeviceTableAdapter = new simplepa2.DataSet1TableAdapters.EventdeviceTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventdeviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
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
            this.colEventdeviceid,
            this.colWrite_Time,
            this.colPath,
            this.colEvent_Text,
            this.colDevicename,
            this.colIp,
            this.장비종류,
            this.colState,
            this.colAlarm,
            this.카테고리,
            this.변경이력,
            this.상세});
            this.dataGridView1.DataSource = this.eventdeviceBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1320, 768);
            this.dataGridView1.TabIndex = 68;
            // 
            // colEventdeviceid
            // 
            this.colEventdeviceid.DataPropertyName = "EventdeviceId";
            this.colEventdeviceid.HeaderText = "No";
            this.colEventdeviceid.Name = "colEventdeviceid";
            this.colEventdeviceid.ReadOnly = true;
            this.colEventdeviceid.Width = 60;
            // 
            // colWrite_Time
            // 
            this.colWrite_Time.DataPropertyName = "write_time";
            dataGridViewCellStyle1.Format = "G";
            this.colWrite_Time.DefaultCellStyle = dataGridViewCellStyle1;
            this.colWrite_Time.HeaderText = "발생시간";
            this.colWrite_Time.Name = "colWrite_Time";
            this.colWrite_Time.Width = 200;
            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "path";
            this.colPath.HeaderText = "장비위치";
            this.colPath.Name = "colPath";
            this.colPath.Width = 200;
            // 
            // colEvent_Text
            // 
            this.colEvent_Text.DataPropertyName = "event_text";
            this.colEvent_Text.HeaderText = "event_text";
            this.colEvent_Text.Name = "colEvent_Text";
            this.colEvent_Text.Width = 200;
            // 
            // colDevicename
            // 
            this.colDevicename.DataPropertyName = "DeviceName";
            this.colDevicename.HeaderText = "장비명";
            this.colDevicename.Name = "colDevicename";
            this.colDevicename.Width = 140;
            // 
            // 장비종류
            // 
            this.장비종류.HeaderText = "장비종류";
            this.장비종류.Name = "장비종류";
            this.장비종류.Width = 120;
            // 
            // colIp
            // 
            this.colIp.DataPropertyName = "ip";
            this.colIp.HeaderText = "IP주소";
            this.colIp.Name = "colIp";
            this.colIp.Width = 120;
            // 
            // colState
            // 
            this.colState.DataPropertyName = "state";
            this.colState.HeaderText = "state";
            this.colState.Name = "colState";
            // 
            // colAlarm
            // 
            this.colAlarm.DataPropertyName = "alarm";
            this.colAlarm.HeaderText = "alarm";
            this.colAlarm.Name = "colAlarm";
            // 
            // 카테고리
            // 
            this.카테고리.HeaderText = "카테고리";
            this.카테고리.Name = "카테고리";
            this.카테고리.Width = 150;
            // 
            // 변경이력
            // 
            this.변경이력.HeaderText = "변경이력";
            this.변경이력.Name = "변경이력";
            this.변경이력.Width = 80;
            // 
            // 상세
            // 
            this.상세.HeaderText = "상세";
            this.상세.Name = "상세";
            this.상세.Width = 200;
            // 
            // eventdeviceBindingSource
            // 
            this.eventdeviceBindingSource.DataMember = "Eventdevice";
            this.eventdeviceBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Dock = Wisej.Web.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.ShowCloseButton = false;
            this.panel3.Size = new System.Drawing.Size(1320, 52);
            this.panel3.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("@topLabel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(597, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 87;
            this.label1.Text = "이벤트";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBox3.AutoSize = false;
            this.comboBox3.Location = new System.Drawing.Point(689, 0);
            this.comboBox3.Margin = new Wisej.Web.Padding(0);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 32);
            this.comboBox3.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("@topLabel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(916, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 32);
            this.label6.TabIndex = 85;
            this.label6.Text = "장비명";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBox4.AutoSize = false;
            this.comboBox4.Location = new System.Drawing.Point(1008, 0);
            this.comboBox4.Margin = new Wisej.Web.Padding(0);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 32);
            this.comboBox4.TabIndex = 84;
            // 
            // button4
            // 
            this.button4.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button4.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button4.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button4.Location = new System.Drawing.Point(1218, 0);
            this.button4.Margin = new Wisej.Web.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 83;
            this.button4.Text = "검색";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.button5.BorderStyle = Wisej.Web.BorderStyle.None;
            this.button5.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button5.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.button5.Location = new System.Drawing.Point(504, 0);
            this.button5.Margin = new Wisej.Web.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 32);
            this.button5.TabIndex = 82;
            this.button5.Text = "6개월";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.button6.BorderStyle = Wisej.Web.BorderStyle.None;
            this.button6.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button6.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.button6.Location = new System.Drawing.Point(433, 0);
            this.button6.Margin = new Wisej.Web.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 32);
            this.button6.TabIndex = 81;
            this.button6.Text = "1개월";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.button7.BorderStyle = Wisej.Web.BorderStyle.None;
            this.button7.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button7.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.button7.Location = new System.Drawing.Point(363, 0);
            this.button7.Margin = new Wisej.Web.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 32);
            this.button7.TabIndex = 80;
            this.button7.Text = "1주일";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Location = new System.Drawing.Point(222, 0);
            this.textBox1.Margin = new Wisej.Web.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 32);
            this.textBox1.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(187, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 32);
            this.label7.TabIndex = 78;
            this.label7.Text = "~";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("@topLabel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 32);
            this.label8.TabIndex = 77;
            this.label8.Text = "날짜";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            this.textBox4.AutoSize = false;
            this.textBox4.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox4.Location = new System.Drawing.Point(54, 0);
            this.textBox4.Margin = new Wisej.Web.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 32);
            this.textBox4.TabIndex = 76;
            // 
            // eventdeviceTableAdapter
            // 
            this.eventdeviceTableAdapter.ClearBeforeFill = true;
            // 
            // View_HistoryDevice
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_HistoryDevice";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.View_HistoryDevice_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventdeviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn 장비종류;
        private Wisej.Web.DataGridViewTextBoxColumn 카테고리;
        private Wisej.Web.DataGridViewTextBoxColumn 변경이력;
        private Wisej.Web.DataGridViewTextBoxColumn 상세;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Label label1;
        private Wisej.Web.ComboBox comboBox3;
        private Wisej.Web.Label label6;
        private Wisej.Web.ComboBox comboBox4;
        private Wisej.Web.Button button4;
        private Wisej.Web.Button button5;
        private Wisej.Web.Button button6;
        private Wisej.Web.Button button7;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.Label label7;
        private Wisej.Web.Label label8;
        private Wisej.Web.TextBox textBox4;
        private Wisej.Web.DataGridViewTextBoxColumn colEventdeviceid;
        private Wisej.Web.DataGridViewDateTimePickerColumn colWrite_Time;
        private Wisej.Web.DataGridViewTextBoxColumn colEvent_Text;
        private Wisej.Web.DataGridViewTextBoxColumn colIp;
        private Wisej.Web.DataGridViewTextBoxColumn colPath;
        private Wisej.Web.DataGridViewTextBoxColumn colDevicename;
        private Wisej.Web.DataGridViewTextBoxColumn colState;
        private Wisej.Web.DataGridViewTextBoxColumn colAlarm;
        private Wisej.Web.BindingSource eventdeviceBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.EventdeviceTableAdapter eventdeviceTableAdapter;
    }
}
