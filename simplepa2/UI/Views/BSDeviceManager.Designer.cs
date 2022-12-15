namespace simplepa2.UI.Views
{
    partial class BSDeviceManager
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
            this.dataSet1 = new simplepa2.DataSet1();
            this.deviceBindingSource = new Wisej.Web.BindingSource(this.components);
            this.deviceTableAdapter = new simplepa2.DataSet1TableAdapters.DeviceTableAdapter();
            this.dataGridView3 = new Wisej.Web.DataGridView();
            this.colDeviceid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEMNAME = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colChspk = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevice = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Column0 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colIp = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Name = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPath_1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Chno = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Vol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Vol_Em = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ptop = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.panel2 = new Wisej.Web.Panel();
            this.button4 = new Wisej.Web.Button();
            this.popTestButton = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.ptop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataMember = "Device";
            this.deviceBindingSource.DataSource = this.dataSet1;
            // 
            // deviceTableAdapter
            // 
            this.deviceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colDeviceid,
            this.colEMNAME,
            this.colDevicename,
            this.colChspk,
            this.colDevice,
            this.Column0,
            this.colIp,
            this.colDsp_Name,
            this.colPath_1,
            this.colDsp_Chno,
            this.colDsp_Vol,
            this.colDsp_Vol_Em});
            this.dataGridView3.DataSource = this.deviceBindingSource;
            this.dataGridView3.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(20, 72);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(830, 484);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.DataUpdated += new Wisej.Web.DataGridViewDataUpdatedEventHandler(this.dataGridView3_DataUpdated);
            // 
            // colDeviceid
            // 
            this.colDeviceid.DataPropertyName = "DeviceId";
            this.colDeviceid.HeaderText = "No";
            this.colDeviceid.Name = "colDeviceid";
            this.colDeviceid.ReadOnly = true;
            this.colDeviceid.Width = 40;
            // 
            // colEMNAME
            // 
            this.colEMNAME.DataPropertyName = "EMNAME";
            this.colEMNAME.HeaderText = "지역";
            this.colEMNAME.Name = "colEMNAME";
            // 
            // colDevicename
            // 
            this.colDevicename.DataPropertyName = "DeviceName";
            this.colDevicename.HeaderText = "DeviceName";
            this.colDevicename.Name = "colDevicename";
            this.colDevicename.ReadOnly = true;
            this.colDevicename.Width = 150;
            // 
            // colChspk
            // 
            this.colChspk.DataPropertyName = "chspk";
            this.colChspk.HeaderText = "채널";
            this.colChspk.Name = "colChspk";
            this.colChspk.Width = 60;
            // 
            // colDevice
            // 
            this.colDevice.DataPropertyName = "device";
            this.colDevice.HeaderText = "device";
            this.colDevice.Name = "colDevice";
            this.colDevice.Visible = false;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "장치종류";
            this.Column0.Name = "Column0";
            // 
            // colIp
            // 
            this.colIp.DataPropertyName = "ip";
            this.colIp.HeaderText = "IP Address";
            this.colIp.Name = "colIp";
            this.colIp.ReadOnly = true;
            this.colIp.Width = 110;
            // 
            // colDsp_Name
            // 
            this.colDsp_Name.DataPropertyName = "dsp_name";
            this.colDsp_Name.HeaderText = "DSP";
            this.colDsp_Name.Name = "colDsp_Name";
            this.colDsp_Name.ReadOnly = true;
            this.colDsp_Name.Width = 120;
            // 
            // colPath_1
            // 
            this.colPath_1.DataPropertyName = "path";
            this.colPath_1.HeaderText = "위치";
            this.colPath_1.Name = "colPath_1";
            this.colPath_1.ReadOnly = true;
            this.colPath_1.Width = 180;
            // 
            // colDsp_Chno
            // 
            this.colDsp_Chno.DataPropertyName = "dsp_chno";
            this.colDsp_Chno.HeaderText = "DSP CH";
            this.colDsp_Chno.Name = "colDsp_Chno";
            this.colDsp_Chno.Visible = false;
            this.colDsp_Chno.Width = 60;
            // 
            // colDsp_Vol
            // 
            this.colDsp_Vol.DataPropertyName = "dsp_vol";
            this.colDsp_Vol.HeaderText = "볼륨";
            this.colDsp_Vol.Name = "colDsp_Vol";
            this.colDsp_Vol.Visible = false;
            this.colDsp_Vol.Width = 80;
            // 
            // colDsp_Vol_Em
            // 
            this.colDsp_Vol_Em.DataPropertyName = "dsp_vol_em";
            this.colDsp_Vol_Em.HeaderText = "볼륨(비상)";
            this.colDsp_Vol_Em.Name = "colDsp_Vol_Em";
            this.colDsp_Vol_Em.Visible = false;
            this.colDsp_Vol_Em.Width = 80;
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.White;
            this.ptop.Controls.Add(this.button4);
            this.ptop.Controls.Add(this.popTestButton);
            this.ptop.Controls.Add(this.button1);
            this.ptop.Dock = Wisej.Web.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(20, 20);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(830, 52);
            this.ptop.TabIndex = 4;
            this.ptop.TabStop = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(429, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "장비 스캔 요청";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.ptop);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(870, 576);
            this.panel2.TabIndex = 5;
            this.panel2.TabStop = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button4.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button4.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button4.Location = new System.Drawing.Point(605, 0);
            this.button4.Margin = new Wisej.Web.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 86;
            this.button4.Text = "수동변경";
            // 
            // popTestButton
            // 
            this.popTestButton.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.popTestButton.BackColor = System.Drawing.Color.FromName("@button1RightBG");
            this.popTestButton.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.popTestButton.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.popTestButton.Location = new System.Drawing.Point(713, 0);
            this.popTestButton.Margin = new Wisej.Web.Padding(0);
            this.popTestButton.Name = "popTestButton";
            this.popTestButton.Size = new System.Drawing.Size(100, 32);
            this.popTestButton.TabIndex = 85;
            this.popTestButton.Text = "이름변경";
            // 
            // BSDeviceManager
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "BSDeviceManager";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(910, 616);
            this.Load += new System.EventHandler(this.BSDeviceManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ptop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private Wisej.Web.BindingSource deviceBindingSource;
        private DataSet1TableAdapters.DeviceTableAdapter deviceTableAdapter;
        private Wisej.Web.DataGridView dataGridView3;
        private Wisej.Web.DataGridViewTextBoxColumn colDeviceid;
        private Wisej.Web.DataGridViewTextBoxColumn colIp;
        private Wisej.Web.DataGridViewTextBoxColumn colDevicename;
        private Wisej.Web.DataGridViewTextBoxColumn colDsp_Name;
        private Wisej.Web.DataGridViewTextBoxColumn colDsp_Chno;
        private Wisej.Web.DataGridViewTextBoxColumn colDsp_Vol;
        private Wisej.Web.DataGridViewTextBoxColumn colDsp_Vol_Em;
        private Wisej.Web.DataGridViewTextBoxColumn colPath_1;
        private Wisej.Web.Panel ptop;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Button button1;
        private Wisej.Web.DataGridViewTextBoxColumn Column0;
        private Wisej.Web.DataGridViewTextBoxColumn colChspk;
        private Wisej.Web.DataGridViewTextBoxColumn colDevice;
        private Wisej.Web.DataGridViewTextBoxColumn colEMNAME;
        private Wisej.Web.Button button4;
        private Wisej.Web.Button popTestButton;
    }
}
