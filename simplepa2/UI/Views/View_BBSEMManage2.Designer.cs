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
            this.button2 = new Wisej.Web.Button();
            this.ptop = new Wisej.Web.Panel();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.dataSet1 = new simplepa2.DataSet1();
            this.eMServerBindingSource = new Wisej.Web.BindingSource(this.components);
            this.eMServerTableAdapter = new simplepa2.DataSet1TableAdapters.EMServerTableAdapter();
            this.colEmserverid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState_Old = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEMNAME = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCom_Gpio = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCom_Rtype = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colNet_Local = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colNet_Dante = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Ctrl = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Dante = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.ptop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMServerBindingSource)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colEmserverid,
            this.colState,
            this.colEMNAME,
            this.colCom_Gpio,
            this.colCom_Rtype,
            this.colNet_Local,
            this.colNet_Dante,
            this.colDsp_Ctrl,
            this.colDsp_Dante,
            this.colState_Old});
            this.dataGridView1.DataSource = this.eMServerBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 484);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMServerBindingSource
            // 
            this.eMServerBindingSource.DataMember = "EMServer";
            this.eMServerBindingSource.DataSource = this.dataSet1;
            // 
            // eMServerTableAdapter
            // 
            this.eMServerTableAdapter.ClearBeforeFill = true;
            // 
            // colEmserverid
            // 
            this.colEmserverid.DataPropertyName = "EMServerId";
            this.colEmserverid.HeaderText = "번호";
            this.colEmserverid.Name = "colEmserverid";
            this.colEmserverid.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.DataPropertyName = "state";
            this.colState.HeaderText = "상태";
            this.colState.Name = "colState";
            // 
            // colState_Old
            // 
            this.colState_Old.DataPropertyName = "state_old";
            this.colState_Old.HeaderText = "이전상태";
            this.colState_Old.Name = "colState_Old";
            this.colState_Old.Visible = false;
            // 
            // colEMNAME
            // 
            this.colEMNAME.DataPropertyName = "EMNAME";
            this.colEMNAME.HeaderText = "EM이름";
            this.colEMNAME.Name = "colEMNAME";
            // 
            // colCom_Gpio
            // 
            this.colCom_Gpio.DataPropertyName = "com_gpio";
            this.colCom_Gpio.HeaderText = "GPIO";
            this.colCom_Gpio.Name = "colCom_Gpio";
            // 
            // colCom_Rtype
            // 
            this.colCom_Rtype.DataPropertyName = "com_Rtype";
            this.colCom_Rtype.HeaderText = "R형수신기";
            this.colCom_Rtype.Name = "colCom_Rtype";
            // 
            // colNet_Local
            // 
            this.colNet_Local.DataPropertyName = "net_local";
            this.colNet_Local.HeaderText = "내부IP";
            this.colNet_Local.Name = "colNet_Local";
            // 
            // colNet_Dante
            // 
            this.colNet_Dante.DataPropertyName = "net_dante";
            this.colNet_Dante.HeaderText = "단테IP";
            this.colNet_Dante.Name = "colNet_Dante";
            // 
            // colDsp_Ctrl
            // 
            this.colDsp_Ctrl.DataPropertyName = "dsp_ctrl";
            this.colDsp_Ctrl.HeaderText = "DSP제어IP";
            this.colDsp_Ctrl.Name = "colDsp_Ctrl";
            // 
            // colDsp_Dante
            // 
            this.colDsp_Dante.DataPropertyName = "dsp_dante";
            this.colDsp_Dante.HeaderText = "DSP단테IP";
            this.colDsp_Dante.Name = "colDsp_Dante";
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
            this.ptop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMServerBindingSource)).EndInit();
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
    }
}
