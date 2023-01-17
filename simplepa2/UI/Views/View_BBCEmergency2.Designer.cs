namespace simplepa2.UI.Views
{
    partial class View_BBCEmergency2
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
            this.ptop = new Wisej.Web.Panel();
            this.comp_Site1 = new simplepa2.UI.Components.Comp_Site();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.panel2 = new Wisej.Web.Panel();
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colDeviceid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPath = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmdata = new Wisej.Web.DataGridViewTextBoxColumn();
            this.deviceBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.colPath_1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDeviceid_1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.eMBsBindingSource = new Wisej.Web.BindingSource(this.components);
            this.deviceTableAdapter = new simplepa2.DataSet1TableAdapters.DeviceTableAdapter();
            this.emBsTableAdapter = new simplepa2.DataSet1TableAdapters.EMBsTableAdapter();
            this.colEmbsid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmdata_1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEMNAME = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ptop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMBsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.White;
            this.ptop.Controls.Add(this.comp_Site1);
            this.ptop.Controls.Add(this.comboBox1);
            this.ptop.Dock = Wisej.Web.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(20, 20);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(756, 52);
            this.ptop.TabIndex = 4;
            this.ptop.TabStop = true;
            // 
            // comp_Site1
            // 
            this.comp_Site1.Margin = new Wisej.Web.Padding(0);
            this.comp_Site1.Name = "comp_Site1";
            this.comp_Site1.TabIndex = 97;
            this.comp_Site1.SelectedValueChanged += new System.EventHandler(this.comp_Site1_SelectedValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBox1.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.comboBox1.Label.Position = Wisej.Web.LabelPosition.Left;
            this.comboBox1.LabelText = "비상방송 층선택";
            this.comboBox1.Location = new System.Drawing.Point(334, 0);
            this.comboBox1.Margin = new Wisej.Web.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 34);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Controls.Add(this.ptop);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(796, 446);
            this.panel2.TabIndex = 6;
            this.panel2.TabStop = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 72);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.TabStop = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.TabStop = true;
            this.splitContainer1.Size = new System.Drawing.Size(756, 354);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colDeviceid,
            this.colDevicename,
            this.colPath,
            this.colEmdata});
            this.dataGridView1.DataSource = this.deviceBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(404, 354);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDoubleClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // colDeviceid
            // 
            this.colDeviceid.DataPropertyName = "DeviceId";
            this.colDeviceid.HeaderText = "No";
            this.colDeviceid.Name = "colDeviceid";
            this.colDeviceid.ReadOnly = true;
            this.colDeviceid.Width = 60;
            // 
            // colDevicename
            // 
            this.colDevicename.DataPropertyName = "DeviceName";
            this.colDevicename.HeaderText = "DeviceName";
            this.colDevicename.Name = "colDevicename";
            this.colDevicename.ReadOnly = true;
            this.colDevicename.Width = 150;
            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "path";
            this.colPath.HeaderText = "위치";
            this.colPath.Name = "colPath";
            this.colPath.ReadOnly = true;
            // 
            // colEmdata
            // 
            this.colEmdata.DataPropertyName = "emData";
            this.colEmdata.HeaderText = "층정보";
            this.colEmdata.Name = "colEmdata";
            this.colEmdata.ReadOnly = true;
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataMember = "Device";
            this.deviceBindingSource.DataSource = this.dataSet1;
            this.deviceBindingSource.Filter = "device=0";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colPath_1,
            this.colDeviceid_1,
            this.colEmbsid,
            this.colEmdata_1,
            this.colEMNAME});
            this.dataGridView2.DataSource = this.eMBsBindingSource;
            this.dataGridView2.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(336, 354);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellMouseDoubleClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // colPath_1
            // 
            this.colPath_1.DataPropertyName = "path";
            this.colPath_1.HeaderText = "위치";
            this.colPath_1.Name = "colPath_1";
            this.colPath_1.ReadOnly = true;
            this.colPath_1.Width = 200;
            // 
            // colDeviceid_1
            // 
            this.colDeviceid_1.DataPropertyName = "DeviceId";
            this.colDeviceid_1.HeaderText = "No";
            this.colDeviceid_1.Name = "colDeviceid_1";
            this.colDeviceid_1.ReadOnly = true;
            this.colDeviceid_1.Width = 60;
            // 
            // eMBsBindingSource
            // 
            this.eMBsBindingSource.DataMember = "EMBs";
            this.eMBsBindingSource.DataSource = this.dataSet1;
            // 
            // deviceTableAdapter
            // 
            this.deviceTableAdapter.ClearBeforeFill = true;
            // 
            // emBsTableAdapter
            // 
            this.emBsTableAdapter.ClearBeforeFill = true;
            // 
            // colEmbsid
            // 
            this.colEmbsid.DataPropertyName = "EMBsId";
            this.colEmbsid.HeaderText = "EMBsId";
            this.colEmbsid.Name = "colEmbsid";
            this.colEmbsid.ReadOnly = true;
            this.colEmbsid.Visible = false;
            // 
            // colEmdata_1
            // 
            this.colEmdata_1.DataPropertyName = "emData";
            this.colEmdata_1.HeaderText = "emData";
            this.colEmdata_1.Name = "colEmdata_1";
            this.colEmdata_1.Visible = false;
            // 
            // colEMNAME
            // 
            this.colEMNAME.DataPropertyName = "EMNAME";
            this.colEMNAME.HeaderText = "EMNAME";
            this.colEMNAME.Name = "colEMNAME";
            this.colEMNAME.Visible = false;
            // 
            // View_BBCEmergency2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCEmergency2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(836, 486);
            this.Load += new System.EventHandler(this.BSEMManager_Load);
            this.ptop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMBsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel ptop;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.ComboBox comboBox1;
        private Wisej.Web.SplitContainer splitContainer1;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colDeviceid;
        private Wisej.Web.DataGridViewTextBoxColumn colDevicename;
        private Wisej.Web.BindingSource deviceBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.DeviceTableAdapter deviceTableAdapter;
        private Wisej.Web.DataGridViewTextBoxColumn colEmdata;
        private Wisej.Web.DataGridViewTextBoxColumn colPath;
        private Wisej.Web.DataGridViewTextBoxColumn colDeviceid_1;
        private Wisej.Web.BindingSource eMBsBindingSource;
        private Wisej.Web.DataGridView dataGridView2;
        private DataSet1TableAdapters.EMBsTableAdapter emBsTableAdapter;
        private Wisej.Web.DataGridViewTextBoxColumn colPath_1;
        private Components.Comp_Site comp_Site1;
        private Wisej.Web.DataGridViewTextBoxColumn colEmbsid;
        private Wisej.Web.DataGridViewTextBoxColumn colEmdata_1;
        private Wisej.Web.DataGridViewTextBoxColumn colEMNAME;
    }
}
