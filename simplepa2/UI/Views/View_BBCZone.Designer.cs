namespace simplepa2.UI.Views
{
    partial class View_BBCZone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_BBCZone));
            this.pn_ViewMain = new Wisej.Web.Panel();
            this.pn_Contents = new Wisej.Web.Panel();
            this.pn_TopBar = new Wisej.Web.Panel();
            this.comp_Site1 = new simplepa2.UI.Components.Comp_Site();
            this.bt_WholeSelect = new Wisej.Web.Button();
            this.bt_dataDelete = new Wisej.Web.Button();
            this.lb_BuildingName = new Wisej.Web.Label();
            this.cb_SiteName = new Wisej.Web.ComboBox();
            this.bt_StoreData = new Wisej.Web.Button();
            this.bt_SelectLoading = new Wisej.Web.Button();
            this.bt_ImportCSV = new Wisej.Web.Button();
            this.assetsTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetsTableAdapter();
            this.dataSet11 = new simplepa2.DataSet1();
            this.assetsSitenBuildingTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetsSitenBuildingTableAdapter();
            this.emServerWithWholeColTableAdapter1 = new simplepa2.DataSet1TableAdapters.EMServerWithWholeColTableAdapter();
            this.deviceTableAdapter1 = new simplepa2.DataSet1TableAdapters.DeviceTableAdapter();
            this.assetGroupsTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetGroupsTableAdapter();
            this.assetPresetGroupsTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetPresetGroupsTableAdapter();
            this.emServerTableAdapter1 = new simplepa2.DataSet1TableAdapters.EMServerTableAdapter();
            this.bsTreeTableAdapter1 = new simplepa2.DataSet1TableAdapters.BSTreeTableAdapter();
            this.pn_ViewMain.SuspendLayout();
            this.pn_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_ViewMain
            // 
            this.pn_ViewMain.Controls.Add(this.pn_Contents);
            this.pn_ViewMain.Controls.Add(this.pn_TopBar);
            this.pn_ViewMain.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_ViewMain.Location = new System.Drawing.Point(20, 20);
            this.pn_ViewMain.Name = "pn_ViewMain";
            this.pn_ViewMain.Padding = new Wisej.Web.Padding(20);
            this.pn_ViewMain.Size = new System.Drawing.Size(1360, 860);
            this.pn_ViewMain.TabIndex = 44;
            // 
            // pn_Contents
            // 
            this.pn_Contents.AutoScroll = true;
            this.pn_Contents.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_Contents.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.pn_Contents.Location = new System.Drawing.Point(20, 72);
            this.pn_Contents.Name = "pn_Contents";
            this.pn_Contents.Size = new System.Drawing.Size(1320, 768);
            this.pn_Contents.TabIndex = 52;
            this.pn_Contents.Text = "listPanel";
            // 
            // pn_TopBar
            // 
            this.pn_TopBar.BackColor = System.Drawing.Color.Transparent;
            this.pn_TopBar.Controls.Add(this.comp_Site1);
            this.pn_TopBar.Controls.Add(this.bt_WholeSelect);
            this.pn_TopBar.Controls.Add(this.bt_dataDelete);
            this.pn_TopBar.Controls.Add(this.lb_BuildingName);
            this.pn_TopBar.Controls.Add(this.cb_SiteName);
            this.pn_TopBar.Controls.Add(this.bt_StoreData);
            this.pn_TopBar.Controls.Add(this.bt_SelectLoading);
            this.pn_TopBar.Controls.Add(this.bt_ImportCSV);
            this.pn_TopBar.Dock = Wisej.Web.DockStyle.Top;
            this.pn_TopBar.Location = new System.Drawing.Point(20, 20);
            this.pn_TopBar.Name = "pn_TopBar";
            this.pn_TopBar.Size = new System.Drawing.Size(1320, 52);
            this.pn_TopBar.TabIndex = 51;
            // 
            // comp_Site1
            // 
            this.comp_Site1.Location = new System.Drawing.Point(399, 3);
            this.comp_Site1.Name = "comp_Site1";
            this.comp_Site1.TabIndex = 95;
            // 
            // bt_WholeSelect
            // 
            this.bt_WholeSelect.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.bt_WholeSelect.CssStyle = resources.GetString("bt_WholeSelect.CssStyle");
            this.bt_WholeSelect.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_WholeSelect.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_WholeSelect.Location = new System.Drawing.Point(283, 1);
            this.bt_WholeSelect.Margin = new Wisej.Web.Padding(0);
            this.bt_WholeSelect.Name = "bt_WholeSelect";
            this.bt_WholeSelect.Size = new System.Drawing.Size(100, 32);
            this.bt_WholeSelect.TabIndex = 94;
            this.bt_WholeSelect.Text = "전체선택";
            this.bt_WholeSelect.Click += new System.EventHandler(this.bt_WholeSelect_Click);
            // 
            // bt_dataDelete
            // 
            this.bt_dataDelete.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_dataDelete.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.bt_dataDelete.CssStyle = "    color: #fff !important;";
            this.bt_dataDelete.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_dataDelete.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_dataDelete.Location = new System.Drawing.Point(779, -1);
            this.bt_dataDelete.Margin = new Wisej.Web.Padding(0);
            this.bt_dataDelete.Name = "bt_dataDelete";
            this.bt_dataDelete.Size = new System.Drawing.Size(100, 32);
            this.bt_dataDelete.TabIndex = 93;
            this.bt_dataDelete.Text = "전체 삭제";
            this.bt_dataDelete.Visible = false;
            this.bt_dataDelete.Click += new System.EventHandler(this.bt_dataDelete_Click);
            // 
            // lb_BuildingName
            // 
            this.lb_BuildingName.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_BuildingName.Location = new System.Drawing.Point(0, 0);
            this.lb_BuildingName.Name = "lb_BuildingName";
            this.lb_BuildingName.Size = new System.Drawing.Size(68, 32);
            this.lb_BuildingName.TabIndex = 92;
            this.lb_BuildingName.Text = "사이트명";
            this.lb_BuildingName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_SiteName
            // 
            this.cb_SiteName.AutoSize = false;
            this.cb_SiteName.DisplayMember = "EMNAME";
            this.cb_SiteName.Items.AddRange(new object[] {
            "전체"});
            this.cb_SiteName.Location = new System.Drawing.Point(71, 0);
            this.cb_SiteName.Margin = new Wisej.Web.Padding(0);
            this.cb_SiteName.Name = "cb_SiteName";
            this.cb_SiteName.Size = new System.Drawing.Size(200, 32);
            this.cb_SiteName.TabIndex = 91;
            this.cb_SiteName.SelectedIndexChanged += new System.EventHandler(this.cb_SiteName_SelectedIndexChanged);
            // 
            // bt_StoreData
            // 
            this.bt_StoreData.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.bt_StoreData.CssStyle = resources.GetString("bt_StoreData.CssStyle");
            this.bt_StoreData.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_StoreData.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_StoreData.Location = new System.Drawing.Point(889, 1);
            this.bt_StoreData.Margin = new Wisej.Web.Padding(0);
            this.bt_StoreData.Name = "bt_StoreData";
            this.bt_StoreData.Size = new System.Drawing.Size(100, 32);
            this.bt_StoreData.TabIndex = 90;
            this.bt_StoreData.Text = "변경저장";
            this.bt_StoreData.Visible = false;
            this.bt_StoreData.Click += new System.EventHandler(this.bt_StoreData_Click);
            // 
            // bt_SelectLoading
            // 
            this.bt_SelectLoading.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_SelectLoading.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.bt_SelectLoading.CssStyle = resources.GetString("bt_SelectLoading.CssStyle");
            this.bt_SelectLoading.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_SelectLoading.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_SelectLoading.Location = new System.Drawing.Point(1003, 1);
            this.bt_SelectLoading.Margin = new Wisej.Web.Padding(0);
            this.bt_SelectLoading.Name = "bt_SelectLoading";
            this.bt_SelectLoading.Size = new System.Drawing.Size(100, 32);
            this.bt_SelectLoading.TabIndex = 36;
            this.bt_SelectLoading.Text = "재로딩";
            this.bt_SelectLoading.Visible = false;
            this.bt_SelectLoading.Click += new System.EventHandler(this.bt_SelectLoading_Click);
            // 
            // bt_ImportCSV
            // 
            this.bt_ImportCSV.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_ImportCSV.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.bt_ImportCSV.CssStyle = resources.GetString("bt_ImportCSV.CssStyle");
            this.bt_ImportCSV.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_ImportCSV.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_ImportCSV.Location = new System.Drawing.Point(1220, 1);
            this.bt_ImportCSV.Margin = new Wisej.Web.Padding(0);
            this.bt_ImportCSV.Name = "bt_ImportCSV";
            this.bt_ImportCSV.Size = new System.Drawing.Size(100, 32);
            this.bt_ImportCSV.TabIndex = 34;
            this.bt_ImportCSV.Text = "Import CSV";
            this.bt_ImportCSV.Click += new System.EventHandler(this.bt_ImportCSV_Click);
            // 
            // assetsTableAdapter1
            // 
            this.assetsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsSitenBuildingTableAdapter1
            // 
            this.assetsSitenBuildingTableAdapter1.ClearBeforeFill = true;
            // 
            // emServerWithWholeColTableAdapter1
            // 
            this.emServerWithWholeColTableAdapter1.ClearBeforeFill = true;
            // 
            // deviceTableAdapter1
            // 
            this.deviceTableAdapter1.ClearBeforeFill = true;
            // 
            // assetGroupsTableAdapter1
            // 
            this.assetGroupsTableAdapter1.ClearBeforeFill = true;
            // 
            // assetPresetGroupsTableAdapter1
            // 
            this.assetPresetGroupsTableAdapter1.ClearBeforeFill = true;
            // 
            // emServerTableAdapter1
            // 
            this.emServerTableAdapter1.ClearBeforeFill = true;
            // 
            // bsTreeTableAdapter1
            // 
            this.bsTreeTableAdapter1.ClearBeforeFill = true;
            // 
            // View_BBCZone
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pn_ViewMain);
            this.CssStyle = "background: /*#F0F0F0*/#eeeff8;";
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCZone";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.pn_ViewMain.ResumeLayout(false);
            this.pn_TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel pn_ViewMain;
        private Wisej.Web.Panel pn_TopBar;
        private Wisej.Web.Button bt_ImportCSV;
        private Wisej.Web.Button bt_SelectLoading;
        private Wisej.Web.Button bt_StoreData;
        private Wisej.Web.Label lb_BuildingName;
        private Wisej.Web.ComboBox cb_SiteName;
        private Wisej.Web.Button bt_dataDelete;
        private Wisej.Web.Panel pn_Contents;
        private Wisej.Web.Button bt_WholeSelect;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.AssetsSitenBuildingTableAdapter assetsSitenBuildingTableAdapter1;
        private DataSet1TableAdapters.EMServerWithWholeColTableAdapter emServerWithWholeColTableAdapter1;
        private DataSet1TableAdapters.DeviceTableAdapter deviceTableAdapter1;
        private DataSet1TableAdapters.AssetGroupsTableAdapter assetGroupsTableAdapter1;
        private DataSet1TableAdapters.AssetPresetGroupsTableAdapter assetPresetGroupsTableAdapter1;
        private DataSet1TableAdapters.EMServerTableAdapter emServerTableAdapter1;
        private DataSet1TableAdapters.BSTreeTableAdapter bsTreeTableAdapter1;
        private Components.Comp_Site comp_Site1;
    }
}
