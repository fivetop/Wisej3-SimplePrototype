namespace simplepa2.UI.Views
{
    partial class View_BBSEMManage2
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
            this.colEmserverid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEMNAME = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSw_All = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSw_1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSw_2 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSw_3 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSw_4 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colNet_Dante = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCom_Gpio = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCom_Gpio_State = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCom_Rtype = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCom_Rtype_State = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Ctrl = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Dante = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState_Old = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colNet_Local = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmtest = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFire = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colErr = new Wisej.Web.DataGridViewTextBoxColumn();
            this.eMServerBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.panel5 = new Wisej.Web.Panel();
            this.button2 = new Wisej.Web.Button();
            this.ptop = new Wisej.Web.Panel();
            this.eMServerTableAdapter = new simplepa2.DataSet1TableAdapters.EMServerTableAdapter();
            this.bSTreeBindingSource = new Wisej.Web.BindingSource(this.components);
            this.bSTreeTableAdapter = new simplepa2.DataSet1TableAdapters.BSTreeTableAdapter();
            this.bsTreeCTableAdapter = new simplepa2.DataSet1TableAdapters.BSTreeCTableAdapter();
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            this.panel1 = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.colBstreeid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colChno = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPlaying = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colWtime = new Wisej.Web.DataGridViewDateTimePickerColumn();
            this.panel4 = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMServerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel5.SuspendLayout();
            this.ptop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSTreeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(860, 185);
            this.panel2.TabIndex = 7;
            this.panel2.TabStop = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colEmserverid,
            this.colState,
            this.colEMNAME,
            this.colSw_All,
            this.colSw_1,
            this.colSw_2,
            this.colSw_3,
            this.colSw_4,
            this.colNet_Dante,
            this.colCom_Gpio,
            this.colCom_Gpio_State,
            this.colCom_Rtype,
            this.colCom_Rtype_State,
            this.colDsp_Ctrl,
            this.colDsp_Dante,
            this.colState_Old,
            this.colNet_Local,
            this.colEmtest,
            this.colFire,
            this.colErr});
            this.dataGridView1.DataSource = this.eMServerBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(820, 105);
            this.dataGridView1.TabIndex = 0;
            // 
            // colEmserverid
            // 
            this.colEmserverid.DataPropertyName = "EMServerId";
            this.colEmserverid.HeaderText = "No";
            this.colEmserverid.Name = "colEmserverid";
            this.colEmserverid.ReadOnly = true;
            this.colEmserverid.Width = 60;
            // 
            // colState
            // 
            this.colState.DataPropertyName = "state";
            this.colState.HeaderText = "상태";
            this.colState.Name = "colState";
            this.colState.Width = 80;
            // 
            // colEMNAME
            // 
            this.colEMNAME.DataPropertyName = "EMNAME";
            this.colEMNAME.HeaderText = "EM이름";
            this.colEMNAME.Name = "colEMNAME";
            this.colEMNAME.Width = 120;
            // 
            // colSw_All
            // 
            this.colSw_All.DataPropertyName = "sw_all";
            this.colSw_All.HeaderText = "ALLsw";
            this.colSw_All.Name = "colSw_All";
            this.colSw_All.Width = 60;
            // 
            // colSw_1
            // 
            this.colSw_1.DataPropertyName = "sw_1";
            this.colSw_1.HeaderText = "1번sw";
            this.colSw_1.Name = "colSw_1";
            this.colSw_1.Width = 60;
            // 
            // colSw_2
            // 
            this.colSw_2.DataPropertyName = "sw_2";
            this.colSw_2.HeaderText = "2번sw";
            this.colSw_2.Name = "colSw_2";
            this.colSw_2.Width = 60;
            // 
            // colSw_3
            // 
            this.colSw_3.DataPropertyName = "sw_3";
            this.colSw_3.HeaderText = "3번sw";
            this.colSw_3.Name = "colSw_3";
            this.colSw_3.Width = 60;
            // 
            // colSw_4
            // 
            this.colSw_4.DataPropertyName = "sw_4";
            this.colSw_4.HeaderText = "4번sw";
            this.colSw_4.Name = "colSw_4";
            this.colSw_4.Width = 60;
            // 
            // colNet_Dante
            // 
            this.colNet_Dante.DataPropertyName = "net_dante";
            this.colNet_Dante.HeaderText = "IP(Dante)";
            this.colNet_Dante.Name = "colNet_Dante";
            this.colNet_Dante.Width = 110;
            // 
            // colCom_Gpio
            // 
            this.colCom_Gpio.DataPropertyName = "com_gpio";
            this.colCom_Gpio.HeaderText = "GPIO";
            this.colCom_Gpio.Name = "colCom_Gpio";
            // 
            // colCom_Gpio_State
            // 
            this.colCom_Gpio_State.DataPropertyName = "com_gpio_state";
            this.colCom_Gpio_State.HeaderText = "상태";
            this.colCom_Gpio_State.Name = "colCom_Gpio_State";
            this.colCom_Gpio_State.Width = 50;
            // 
            // colCom_Rtype
            // 
            this.colCom_Rtype.DataPropertyName = "com_Rtype";
            this.colCom_Rtype.HeaderText = "R형수신기";
            this.colCom_Rtype.Name = "colCom_Rtype";
            // 
            // colCom_Rtype_State
            // 
            this.colCom_Rtype_State.DataPropertyName = "com_Rtype_state";
            this.colCom_Rtype_State.HeaderText = "상태";
            this.colCom_Rtype_State.Name = "colCom_Rtype_State";
            this.colCom_Rtype_State.Width = 50;
            // 
            // colDsp_Ctrl
            // 
            this.colDsp_Ctrl.DataPropertyName = "dsp_ctrl";
            this.colDsp_Ctrl.HeaderText = "DSP제어IP";
            this.colDsp_Ctrl.Name = "colDsp_Ctrl";
            this.colDsp_Ctrl.Width = 110;
            // 
            // colDsp_Dante
            // 
            this.colDsp_Dante.DataPropertyName = "dsp_dante";
            this.colDsp_Dante.HeaderText = "DSP단테IP";
            this.colDsp_Dante.Name = "colDsp_Dante";
            this.colDsp_Dante.Width = 110;
            // 
            // colState_Old
            // 
            this.colState_Old.DataPropertyName = "state_old";
            this.colState_Old.HeaderText = "이전상태";
            this.colState_Old.Name = "colState_Old";
            this.colState_Old.Visible = false;
            // 
            // colNet_Local
            // 
            this.colNet_Local.DataPropertyName = "net_local";
            this.colNet_Local.HeaderText = "IP(Local)";
            this.colNet_Local.Name = "colNet_Local";
            this.colNet_Local.Visible = false;
            this.colNet_Local.Width = 110;
            // 
            // colEmtest
            // 
            this.colEmtest.DataPropertyName = "emtest";
            this.colEmtest.HeaderText = "emtest";
            this.colEmtest.Name = "colEmtest";
            this.colEmtest.Visible = false;
            // 
            // colFire
            // 
            this.colFire.DataPropertyName = "fire";
            this.colFire.HeaderText = "fire";
            this.colFire.Name = "colFire";
            this.colFire.Visible = false;
            // 
            // colErr
            // 
            this.colErr.DataPropertyName = "err";
            this.colErr.HeaderText = "err";
            this.colErr.Name = "colErr";
            this.colErr.Visible = false;
            // 
            // eMServerBindingSource
            // 
            this.eMServerBindingSource.DataMember = "EMServer";
            this.eMServerBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = Wisej.Web.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(20, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(820, 40);
            this.panel5.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "상태요청";
            this.button2.ToolTipText = "장비를 전체 검출하므로 시간이 필요합니다.";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.White;
            this.ptop.Controls.Add(this.panel2);
            this.ptop.Dock = Wisej.Web.DockStyle.Fill;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(860, 185);
            this.ptop.TabIndex = 6;
            this.ptop.TabStop = true;
            // 
            // eMServerTableAdapter
            // 
            this.eMServerTableAdapter.ClearBeforeFill = true;
            // 
            // bSTreeBindingSource
            // 
            this.bSTreeBindingSource.DataMember = "BSTree";
            this.bSTreeBindingSource.DataSource = this.dataSet1;
            // 
            // bSTreeTableAdapter
            // 
            this.bSTreeTableAdapter.ClearBeforeFill = true;
            // 
            // bsTreeCTableAdapter
            // 
            this.bsTreeCTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 20);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = Wisej.Web.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ptop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(862, 576);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 371);
            this.panel1.TabIndex = 8;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(20);
            this.panel3.Size = new System.Drawing.Size(860, 371);
            this.panel3.TabIndex = 7;
            this.panel3.TabStop = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colBstreeid,
            this.dataGridViewTextBoxColumn1,
            this.colChno,
            this.colPlaying,
            this.colWtime});
            this.dataGridView2.DataSource = this.bSTreeBindingSource;
            this.dataGridView2.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(20, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(820, 291);
            this.dataGridView2.TabIndex = 0;
            // 
            // colBstreeid
            // 
            this.colBstreeid.DataPropertyName = "BSTreeId";
            this.colBstreeid.HeaderText = "No";
            this.colBstreeid.Name = "colBstreeid";
            this.colBstreeid.ReadOnly = true;
            this.colBstreeid.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EMNAME";
            this.dataGridViewTextBoxColumn1.HeaderText = "EM서버";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // colChno
            // 
            this.colChno.DataPropertyName = "chno";
            this.colChno.HeaderText = "채널";
            this.colChno.Name = "colChno";
            this.colChno.Width = 80;
            // 
            // colPlaying
            // 
            this.colPlaying.DataPropertyName = "playing";
            this.colPlaying.HeaderText = "방송상태";
            this.colPlaying.Name = "colPlaying";
            this.colPlaying.Width = 120;
            // 
            // colWtime
            // 
            this.colWtime.DataPropertyName = "wtime";
            dataGridViewCellStyle1.Format = "G";
            this.colWtime.DefaultCellStyle = dataGridViewCellStyle1;
            this.colWtime.HeaderText = "시작시간";
            this.colWtime.Name = "colWtime";
            this.colWtime.Width = 200;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = Wisej.Web.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(820, 40);
            this.panel4.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "방송초기화";
            this.button1.ToolTipText = "해당 채널의 방송을 강제로 초기화 상태로 만드는 기능 입니다.";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // View_BBSEMManage2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.splitContainer1);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBSEMManage2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(902, 616);
            this.Load += new System.EventHandler(this.BSAsset_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMServerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ptop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSTreeBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.Button button2;
        private Wisej.Web.Panel ptop;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colEmserverid;
        private Wisej.Web.DataGridViewTextBoxColumn colState;
        private Wisej.Web.DataGridViewTextBoxColumn colEMNAME;
        private Wisej.Web.DataGridViewTextBoxColumn colCom_Gpio;
        private Wisej.Web.DataGridViewTextBoxColumn colCom_Rtype;
        private Wisej.Web.DataGridViewTextBoxColumn colNet_Local;
        private Wisej.Web.DataGridViewTextBoxColumn colNet_Dante;
        private Wisej.Web.DataGridViewTextBoxColumn colDsp_Ctrl;
        private Wisej.Web.DataGridViewTextBoxColumn colDsp_Dante;
        private Wisej.Web.DataGridViewTextBoxColumn colState_Old;
        private Wisej.Web.BindingSource eMServerBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.EMServerTableAdapter eMServerTableAdapter;
        private Wisej.Web.DataGridViewTextBoxColumn colCom_Gpio_State;
        private Wisej.Web.DataGridViewTextBoxColumn colCom_Rtype_State;
        private Wisej.Web.DataGridViewTextBoxColumn colSw_All;
        private Wisej.Web.DataGridViewTextBoxColumn colSw_1;
        private Wisej.Web.DataGridViewTextBoxColumn colSw_2;
        private Wisej.Web.DataGridViewTextBoxColumn colSw_3;
        private Wisej.Web.DataGridViewTextBoxColumn colSw_4;
        private Wisej.Web.DataGridViewTextBoxColumn colEmtest;
        private Wisej.Web.DataGridViewTextBoxColumn colFire;
        private Wisej.Web.DataGridViewTextBoxColumn colErr;
        private Wisej.Web.BindingSource bSTreeBindingSource;
        private DataSet1TableAdapters.BSTreeTableAdapter bSTreeTableAdapter;
        private DataSet1TableAdapters.BSTreeCTableAdapter bsTreeCTableAdapter;
        private Wisej.Web.SplitContainer splitContainer1;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.DataGridView dataGridView2;
        private Wisej.Web.DataGridViewTextBoxColumn colBstreeid;
        private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Wisej.Web.DataGridViewTextBoxColumn colChno;
        private Wisej.Web.DataGridViewTextBoxColumn colPlaying;
        private Wisej.Web.DataGridViewDateTimePickerColumn colWtime;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Button button1;
    }
}
