namespace simplepa2.UI.Views
{
    partial class View_HistoryBBS
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
            this.colEventbsid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송시작 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송종류 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송위치 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송내용 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송결과 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송소유자 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송음원 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송시간 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colWrite_Time = new Wisej.Web.DataGridViewDateTimePickerColumn();
            this.colEvent_Text = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colIp = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPath = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colAlarm = new Wisej.Web.DataGridViewTextBoxColumn();
            this.eventbsBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.panel1 = new Wisej.Web.Panel();
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
            this.eventbsTableAdapter = new simplepa2.DataSet1TableAdapters.EventbsTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventbsBindingSource)).BeginInit();
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
            this.colEventbsid,
            this.방송시작,
            this.방송종류,
            this.방송위치,
            this.방송내용,
            this.방송결과,
            this.방송소유자,
            this.방송음원,
            this.방송시간,
            this.colWrite_Time,
            this.colEvent_Text,
            this.colIp,
            this.colPath,
            this.colDevicename,
            this.colState,
            this.colAlarm});
            this.dataGridView1.DataSource = this.eventbsBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1320, 768);
            this.dataGridView1.TabIndex = 70;
            // 
            // colEventbsid
            // 
            this.colEventbsid.DataPropertyName = "EventbsId";
            this.colEventbsid.HeaderText = "EventbsId";
            this.colEventbsid.Name = "colEventbsid";
            this.colEventbsid.ReadOnly = true;
            // 
            // 방송시작
            // 
            this.방송시작.HeaderText = "방송시작";
            this.방송시작.Name = "방송시작";
            this.방송시작.Width = 200;
            // 
            // 방송종류
            // 
            this.방송종류.HeaderText = "방송종류";
            this.방송종류.Name = "방송종류";
            this.방송종류.Width = 150;
            // 
            // 방송위치
            // 
            this.방송위치.HeaderText = "방송위치";
            this.방송위치.Name = "방송위치";
            this.방송위치.Width = 150;
            // 
            // 방송내용
            // 
            this.방송내용.HeaderText = "방송내용";
            this.방송내용.Name = "방송내용";
            this.방송내용.Width = 150;
            // 
            // 방송결과
            // 
            this.방송결과.HeaderText = "방송결과";
            this.방송결과.Name = "방송결과";
            this.방송결과.Width = 80;
            // 
            // 방송소유자
            // 
            this.방송소유자.HeaderText = "방송소유자";
            this.방송소유자.Name = "방송소유자";
            this.방송소유자.Visible = false;
            this.방송소유자.Width = 150;
            // 
            // 방송음원
            // 
            this.방송음원.HeaderText = "방송음원";
            this.방송음원.Name = "방송음원";
            this.방송음원.Visible = false;
            this.방송음원.Width = 170;
            // 
            // 방송시간
            // 
            this.방송시간.HeaderText = "방송시간";
            this.방송시간.Name = "방송시간";
            this.방송시간.Visible = false;
            this.방송시간.Width = 200;
            // 
            // colWrite_Time
            // 
            this.colWrite_Time.DataPropertyName = "write_time";
            dataGridViewCellStyle1.Format = "G";
            this.colWrite_Time.DefaultCellStyle = dataGridViewCellStyle1;
            this.colWrite_Time.HeaderText = "write_time";
            this.colWrite_Time.Name = "colWrite_Time";
            // 
            // colEvent_Text
            // 
            this.colEvent_Text.DataPropertyName = "event_text";
            this.colEvent_Text.HeaderText = "event_text";
            this.colEvent_Text.Name = "colEvent_Text";
            // 
            // colIp
            // 
            this.colIp.DataPropertyName = "ip";
            this.colIp.HeaderText = "ip";
            this.colIp.Name = "colIp";
            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "path";
            this.colPath.HeaderText = "path";
            this.colPath.Name = "colPath";
            // 
            // colDevicename
            // 
            this.colDevicename.DataPropertyName = "DeviceName";
            this.colDevicename.HeaderText = "DeviceName";
            this.colDevicename.Name = "colDevicename";
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
            // eventbsBindingSource
            // 
            this.eventbsBindingSource.DataMember = "Eventbs";
            this.eventbsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
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
            this.panel1.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("@topLabel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(916, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 85;
            this.label2.Text = "방송타입";
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
            // eventbsTableAdapter
            // 
            this.eventbsTableAdapter.ClearBeforeFill = true;
            // 
            // View_HistoryBBS
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_HistoryBBS";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.View_HistoryBBS_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventbsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn 방송시작;
        private Wisej.Web.DataGridViewTextBoxColumn 방송시간;
        private Wisej.Web.DataGridViewTextBoxColumn 방송종류;
        private Wisej.Web.DataGridViewTextBoxColumn 방송내용;
        private Wisej.Web.DataGridViewTextBoxColumn 방송위치;
        private Wisej.Web.DataGridViewTextBoxColumn 방송음원;
        private Wisej.Web.DataGridViewTextBoxColumn 방송결과;
        private Wisej.Web.DataGridViewTextBoxColumn 방송소유자;
        private Wisej.Web.Panel panel1;
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
        private Wisej.Web.DataGridViewTextBoxColumn colEventbsid;
        private Wisej.Web.DataGridViewDateTimePickerColumn colWrite_Time;
        private Wisej.Web.DataGridViewTextBoxColumn colEvent_Text;
        private Wisej.Web.DataGridViewTextBoxColumn colIp;
        private Wisej.Web.DataGridViewTextBoxColumn colPath;
        private Wisej.Web.DataGridViewTextBoxColumn colDevicename;
        private Wisej.Web.DataGridViewTextBoxColumn colState;
        private Wisej.Web.DataGridViewTextBoxColumn colAlarm;
        private Wisej.Web.BindingSource eventbsBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.EventbsTableAdapter eventbsTableAdapter;
    }
}
