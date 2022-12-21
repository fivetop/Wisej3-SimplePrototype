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
            this.panel2 = new Wisej.Web.Panel();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colEmserverid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEMNAME = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCom_Gpio = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCom_Gpio_State = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCom_Rtype = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCom_Rtype_State = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colNet_Local = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colNet_Dante = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Ctrl = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Dante = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSw_All = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSw_1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSw_2 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSw_3 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSw_4 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState_Old = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmtest = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFire = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colErr = new Wisej.Web.DataGridViewTextBoxColumn();
            this.eMServerBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.button2 = new Wisej.Web.Button();
            this.ptop = new Wisej.Web.Panel();
            this.eMServerTableAdapter = new simplepa2.DataSet1TableAdapters.EMServerTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMServerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.ptop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 72);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(862, 524);
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
            this.colCom_Gpio,
            this.colCom_Gpio_State,
            this.colCom_Rtype,
            this.colCom_Rtype_State,
            this.colNet_Local,
            this.colNet_Dante,
            this.colDsp_Ctrl,
            this.colDsp_Dante,
            this.colSw_All,
            this.colSw_1,
            this.colSw_2,
            this.colSw_3,
            this.colSw_4,
            this.colState_Old,
            this.colEmtest,
            this.colFire,
            this.colErr});
            this.dataGridView1.DataSource = this.eMServerBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 484);
            this.dataGridView1.TabIndex = 0;
            // 
            // colEmserverid
            // 
            this.colEmserverid.DataPropertyName = "EMServerId";
            this.colEmserverid.HeaderText = "번호";
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
            // colNet_Local
            // 
            this.colNet_Local.DataPropertyName = "net_local";
            this.colNet_Local.HeaderText = "내부IP";
            this.colNet_Local.Name = "colNet_Local";
            this.colNet_Local.Width = 110;
            // 
            // colNet_Dante
            // 
            this.colNet_Dante.DataPropertyName = "net_dante";
            this.colNet_Dante.HeaderText = "단테IP";
            this.colNet_Dante.Name = "colNet_Dante";
            this.colNet_Dante.Width = 110;
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
            // colSw_All
            // 
            this.colSw_All.DataPropertyName = "sw_all";
            this.colSw_All.HeaderText = "ALL sw";
            this.colSw_All.Name = "colSw_All";
            this.colSw_All.Width = 80;
            // 
            // colSw_1
            // 
            this.colSw_1.DataPropertyName = "sw_1";
            this.colSw_1.HeaderText = "1번sw";
            this.colSw_1.Name = "colSw_1";
            this.colSw_1.Width = 80;
            // 
            // colSw_2
            // 
            this.colSw_2.DataPropertyName = "sw_2";
            this.colSw_2.HeaderText = "2번sw";
            this.colSw_2.Name = "colSw_2";
            this.colSw_2.Width = 80;
            // 
            // colSw_3
            // 
            this.colSw_3.DataPropertyName = "sw_3";
            this.colSw_3.HeaderText = "3번sw";
            this.colSw_3.Name = "colSw_3";
            this.colSw_3.Width = 80;
            // 
            // colSw_4
            // 
            this.colSw_4.DataPropertyName = "sw_4";
            this.colSw_4.HeaderText = "4번sw";
            this.colSw_4.Name = "colSw_4";
            this.colSw_4.Width = 80;
            // 
            // colState_Old
            // 
            this.colState_Old.DataPropertyName = "state_old";
            this.colState_Old.HeaderText = "이전상태";
            this.colState_Old.Name = "colState_Old";
            this.colState_Old.Visible = false;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 16);
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
            this.ptop.Controls.Add(this.button2);
            this.ptop.Dock = Wisej.Web.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(20, 20);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(862, 52);
            this.ptop.TabIndex = 6;
            this.ptop.TabStop = true;
            // 
            // eMServerTableAdapter
            // 
            this.eMServerTableAdapter.ClearBeforeFill = true;
            // 
            // View_BBSEMManage2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ptop);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBSEMManage2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(902, 616);
            this.Load += new System.EventHandler(this.BSAsset_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMServerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ptop.ResumeLayout(false);
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
    }
}
