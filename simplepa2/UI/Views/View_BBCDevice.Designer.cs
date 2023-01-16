namespace simplepa2.UI.Views
{
    partial class View_BBCDevice
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle6 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle7 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle8 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle9 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle10 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle11 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle12 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle13 = new Wisej.Web.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_BBCDevice));
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            this.panel2 = new Wisej.Web.Panel();
            this.dg_deviceView = new Wisej.Web.DataGridView();
            this.DeviceId = new Wisej.Web.DataGridViewTextBoxColumn();
            this.device_Category = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Column0 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ip = new Wisej.Web.DataGridViewTextBoxColumn();
            this.단테모델명 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dsp_name = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ip_dspctrl = new Wisej.Web.DataGridViewTextBoxColumn();
            this.DSP채널 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dsp_chno = new Wisej.Web.DataGridViewTextBoxColumn();
            this.설치Zone = new Wisej.Web.DataGridViewTextBoxColumn();
            this.지역 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel1 = new Wisej.Web.Panel();
            this.comp_Site1 = new simplepa2.UI.Components.Comp_Site();
            this.bt_reloading = new Wisej.Web.Button();
            this.bt_scanStart = new Wisej.Web.Button();
            this.button4 = new Wisej.Web.Button();
            this.popTestButton = new Wisej.Web.Button();
            this.dataSet11 = new simplepa2.DataSet1();
            this.deviceTableAdapter1 = new simplepa2.DataSet1TableAdapters.DeviceTableAdapter();
            this.emServerNDeviceNameTableAdapter1 = new simplepa2.DataSet1TableAdapters.EMServerNDeviceNameTableAdapter();
            this.emServerWithWholeColTableAdapter1 = new simplepa2.DataSet1TableAdapters.EMServerWithWholeColTableAdapter();
            this.deviceWithTypeTableAdapter1 = new simplepa2.DataSet1TableAdapters.DeviceWithTypeTableAdapter();
            this.관리EM = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_deviceView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dg_deviceView);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1360, 860);
            this.panel2.TabIndex = 51;
            // 
            // dg_deviceView
            // 
            this.dg_deviceView.AutoGenerateColumns = false;
            this.dg_deviceView.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.DeviceId,
            this.관리EM,
            this.device_Category,
            this.Column0,
            this.ip,
            this.단테모델명,
            this.dsp_name,
            this.ip_dspctrl,
            this.DSP채널,
            this.dsp_chno,
            this.설치Zone,
            this.지역});
            this.dg_deviceView.Dock = Wisej.Web.DockStyle.Fill;
            this.dg_deviceView.Location = new System.Drawing.Point(20, 72);
            this.dg_deviceView.Name = "dg_deviceView";
            this.dg_deviceView.RowHeadersVisible = false;
            this.dg_deviceView.Size = new System.Drawing.Size(1320, 768);
            this.dg_deviceView.TabIndex = 67;
            // 
            // DeviceId
            // 
            this.DeviceId.DataPropertyName = "DeviceId";
            dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.DeviceId.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.DeviceId.HeaderStyle = dataGridViewCellStyle2;
            this.DeviceId.HeaderText = "장비ID";
            this.DeviceId.MinimumWidth = 50;
            this.DeviceId.Name = "DeviceId";
            this.DeviceId.Width = 60;
            // 
            // device_Category
            // 
            this.device_Category.DataPropertyName = "deviceType";
            dataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.device_Category.DefaultCellStyle = dataGridViewCellStyle4;
            this.device_Category.HeaderText = "타입";
            this.device_Category.MinimumWidth = 130;
            this.device_Category.Name = "device_Category";
            this.device_Category.Width = 150;
            // 
            // Column0
            // 
            this.Column0.DataPropertyName = "DeviceName";
            dataGridViewCellStyle5.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.Column0.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column0.HeaderText = "장비이름";
            this.Column0.MinimumWidth = 120;
            this.Column0.Name = "Column0";
            this.Column0.Width = 140;
            // 
            // ip
            // 
            this.ip.DataPropertyName = "ip";
            dataGridViewCellStyle6.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.ip.DefaultCellStyle = dataGridViewCellStyle6;
            this.ip.HeaderText = "IP 주소";
            this.ip.MinimumWidth = 120;
            this.ip.Name = "ip";
            this.ip.Width = 130;
            // 
            // 단테모델명
            // 
            this.단테모델명.DataPropertyName = "DanteModelName";
            dataGridViewCellStyle7.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.단테모델명.DefaultCellStyle = dataGridViewCellStyle7;
            this.단테모델명.HeaderText = "단테모델명";
            this.단테모델명.MinimumWidth = 170;
            this.단테모델명.Name = "단테모델명";
            this.단테모델명.Visible = false;
            this.단테모델명.Width = 200;
            // 
            // dsp_name
            // 
            this.dsp_name.DataPropertyName = "dsp_name";
            dataGridViewCellStyle8.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.dsp_name.DefaultCellStyle = dataGridViewCellStyle8;
            this.dsp_name.HeaderText = "연결DSP";
            this.dsp_name.MinimumWidth = 140;
            this.dsp_name.Name = "dsp_name";
            this.dsp_name.Width = 140;
            // 
            // ip_dspctrl
            // 
            this.ip_dspctrl.DataPropertyName = "ip_dspctrl";
            dataGridViewCellStyle9.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.ip_dspctrl.DefaultCellStyle = dataGridViewCellStyle9;
            this.ip_dspctrl.HeaderText = "DSP IP";
            this.ip_dspctrl.MinimumWidth = 120;
            this.ip_dspctrl.Name = "ip_dspctrl";
            this.ip_dspctrl.Width = 120;
            // 
            // DSP채널
            // 
            this.DSP채널.DataPropertyName = "dsp_chno";
            dataGridViewCellStyle10.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.DSP채널.DefaultCellStyle = dataGridViewCellStyle10;
            this.DSP채널.HeaderText = "DSP채널";
            this.DSP채널.MinimumWidth = 60;
            this.DSP채널.Name = "DSP채널";
            this.DSP채널.Width = 60;
            // 
            // dsp_chno
            // 
            this.dsp_chno.DataPropertyName = "dsp_chno";
            dataGridViewCellStyle11.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.dsp_chno.DefaultCellStyle = dataGridViewCellStyle11;
            this.dsp_chno.HeaderText = "관리DSP채널";
            this.dsp_chno.MinimumWidth = 80;
            this.dsp_chno.Name = "dsp_chno";
            this.dsp_chno.Visible = false;
            this.dsp_chno.Width = 80;
            // 
            // 설치Zone
            // 
            this.설치Zone.DataPropertyName = "ZoneName";
            dataGridViewCellStyle12.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.설치Zone.DefaultCellStyle = dataGridViewCellStyle12;
            this.설치Zone.HeaderText = "설치Zone";
            this.설치Zone.MinimumWidth = 100;
            this.설치Zone.Name = "설치Zone";
            // 
            // 지역
            // 
            this.지역.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.지역.DataPropertyName = "path";
            dataGridViewCellStyle13.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.지역.DefaultCellStyle = dataGridViewCellStyle13;
            this.지역.HeaderText = "지역";
            this.지역.MinimumWidth = 200;
            this.지역.Name = "지역";
            this.지역.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comp_Site1);
            this.panel1.Controls.Add(this.bt_reloading);
            this.panel1.Controls.Add(this.bt_scanStart);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.popTestButton);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.Size = new System.Drawing.Size(1320, 52);
            this.panel1.TabIndex = 66;
            // 
            // comp_Site1
            // 
            this.comp_Site1.Name = "comp_Site1";
            this.comp_Site1.TabIndex = 96;
            this.comp_Site1.SelectedValueChanged += new System.EventHandler(this.comp_Site1_SelectedValueChanged);
            // 
            // bt_reloading
            // 
            this.bt_reloading.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.bt_reloading.CssStyle = resources.GetString("bt_reloading.CssStyle");
            this.bt_reloading.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_reloading.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_reloading.Location = new System.Drawing.Point(747, 4);
            this.bt_reloading.Margin = new Wisej.Web.Padding(0);
            this.bt_reloading.Name = "bt_reloading";
            this.bt_reloading.Size = new System.Drawing.Size(100, 32);
            this.bt_reloading.TabIndex = 87;
            this.bt_reloading.Text = "재로딩";
            this.bt_reloading.Visible = false;
            this.bt_reloading.Click += new System.EventHandler(this.bt_reloading_Click);
            // 
            // bt_scanStart
            // 
            this.bt_scanStart.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_scanStart.BackColor = System.Drawing.Color.FromName("@button1LeftBG");
            this.bt_scanStart.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_scanStart.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_scanStart.Location = new System.Drawing.Point(1210, 4);
            this.bt_scanStart.Margin = new Wisej.Web.Padding(0);
            this.bt_scanStart.Name = "bt_scanStart";
            this.bt_scanStart.Size = new System.Drawing.Size(100, 32);
            this.bt_scanStart.TabIndex = 85;
            this.bt_scanStart.Text = "장비스캔";
            this.bt_scanStart.Click += new System.EventHandler(this.bt_scanStart_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button4.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button4.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button4.Location = new System.Drawing.Point(857, 4);
            this.button4.Margin = new Wisej.Web.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 84;
            this.button4.Text = "수동변경";
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // popTestButton
            // 
            this.popTestButton.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.popTestButton.BackColor = System.Drawing.Color.FromName("@button1RightBG");
            this.popTestButton.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.popTestButton.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.popTestButton.Location = new System.Drawing.Point(965, 4);
            this.popTestButton.Margin = new Wisej.Web.Padding(0);
            this.popTestButton.Name = "popTestButton";
            this.popTestButton.Size = new System.Drawing.Size(100, 32);
            this.popTestButton.TabIndex = 83;
            this.popTestButton.Text = "이름변경";
            this.popTestButton.Visible = false;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceTableAdapter1
            // 
            this.deviceTableAdapter1.ClearBeforeFill = true;
            // 
            // emServerNDeviceNameTableAdapter1
            // 
            this.emServerNDeviceNameTableAdapter1.ClearBeforeFill = true;
            // 
            // emServerWithWholeColTableAdapter1
            // 
            this.emServerWithWholeColTableAdapter1.ClearBeforeFill = true;
            // 
            // deviceWithTypeTableAdapter1
            // 
            this.deviceWithTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // 관리EM
            // 
            this.관리EM.DataPropertyName = "EMNAME";
            dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.관리EM.DefaultCellStyle = dataGridViewCellStyle3;
            this.관리EM.HeaderText = "관리EM";
            this.관리EM.MinimumWidth = 100;
            this.관리EM.Name = "관리EM";
            // 
            // View_BBCDevice
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCDevice";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.BSDeviceManager_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_deviceView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.DataGridView dg_deviceView;
        private Wisej.Web.DataGridViewTextBoxColumn DeviceId;
        private Wisej.Web.DataGridViewTextBoxColumn 단테모델명;
        private Wisej.Web.DataGridViewTextBoxColumn 지역;
        private Wisej.Web.DataGridViewTextBoxColumn ip;
        private Wisej.Web.DataGridViewTextBoxColumn device_Category;
        private Wisej.Web.DataGridViewTextBoxColumn dsp_name;
        private Wisej.Web.DataGridViewTextBoxColumn dsp_chno;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button bt_scanStart;
        private Wisej.Web.Button button4;
        private Wisej.Web.Button popTestButton;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.DeviceTableAdapter deviceTableAdapter1;
        private Wisej.Web.DataGridViewTextBoxColumn ip_dspctrl;
        private Wisej.Web.DataGridViewTextBoxColumn DSP채널;
        private DataSet1TableAdapters.EMServerNDeviceNameTableAdapter emServerNDeviceNameTableAdapter1;
        private Wisej.Web.DataGridViewTextBoxColumn Column0;
        private Wisej.Web.Button bt_reloading;
        private Components.Comp_Site comp_Site1;
        private DataSet1TableAdapters.EMServerWithWholeColTableAdapter emServerWithWholeColTableAdapter1;
        private DataSet1TableAdapters.DeviceWithTypeTableAdapter deviceWithTypeTableAdapter1;
        private Wisej.Web.DataGridViewTextBoxColumn 설치Zone;
        private Wisej.Web.DataGridViewTextBoxColumn 관리EM;
    }
}
