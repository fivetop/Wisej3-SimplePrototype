namespace simplepa2.UI.Components
{
    partial class Comp_BBSAnchorZone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comp_BBSAnchorZone));
            this.emServerNDeviceNameTableAdapter1 = new simplepa2.DataSet1TableAdapters.EMServerNDeviceNameTableAdapter();
            this.emServerTableAdapter1 = new simplepa2.DataSet1TableAdapters.EMServerTableAdapter();
            this.assetPresetGroupsTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetPresetGroupsTableAdapter();
            this.assetGroupsTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetGroupsTableAdapter();
            this.deviceTableAdapter1 = new simplepa2.DataSet1TableAdapters.DeviceTableAdapter();
            this.emServerWithWholeColTableAdapter1 = new simplepa2.DataSet1TableAdapters.EMServerWithWholeColTableAdapter();
            this.assetsSitenBuildingTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetsSitenBuildingTableAdapter();
            this.dataSet11 = new simplepa2.DataSet1();
            this.bsTreeTableAdapter1 = new simplepa2.DataSet1TableAdapters.BSTreeTableAdapter();
            this.assetsTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetsTableAdapter();
            this.pn_Contents = new Wisej.Web.Panel();
            this.pn_TopBar = new Wisej.Web.Panel();
            this.pn_musicTitle = new Wisej.Web.Panel();
            this.label2 = new Wisej.Web.Label();
            this.comp_Site1 = new Wisej.Web.ComboBox();
            this.label1 = new Wisej.Web.Label();
            this.cb_groupList = new Wisej.Web.ComboBox();
            this.lb_BuildingName = new Wisej.Web.Label();
            this.bt_WholeSelect = new Wisej.Web.Button();
            this.pn_ViewMain = new Wisej.Web.Panel();
            this.panel1 = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.pn_TopBar.SuspendLayout();
            this.pn_musicTitle.SuspendLayout();
            this.pn_ViewMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emServerNDeviceNameTableAdapter1
            // 
            this.emServerNDeviceNameTableAdapter1.ClearBeforeFill = true;
            // 
            // emServerTableAdapter1
            // 
            this.emServerTableAdapter1.ClearBeforeFill = true;
            // 
            // assetPresetGroupsTableAdapter1
            // 
            this.assetPresetGroupsTableAdapter1.ClearBeforeFill = true;
            // 
            // assetGroupsTableAdapter1
            // 
            this.assetGroupsTableAdapter1.ClearBeforeFill = true;
            // 
            // deviceTableAdapter1
            // 
            this.deviceTableAdapter1.ClearBeforeFill = true;
            // 
            // emServerWithWholeColTableAdapter1
            // 
            this.emServerWithWholeColTableAdapter1.ClearBeforeFill = true;
            // 
            // assetsSitenBuildingTableAdapter1
            // 
            this.assetsSitenBuildingTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsTreeTableAdapter1
            // 
            this.bsTreeTableAdapter1.ClearBeforeFill = true;
            // 
            // assetsTableAdapter1
            // 
            this.assetsTableAdapter1.ClearBeforeFill = true;
            // 
            // pn_Contents
            // 
            this.pn_Contents.AutoScroll = true;
            this.pn_Contents.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_Contents.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.pn_Contents.Location = new System.Drawing.Point(20, 100);
            this.pn_Contents.Name = "pn_Contents";
            this.pn_Contents.Padding = new Wisej.Web.Padding(5);
            this.pn_Contents.Size = new System.Drawing.Size(660, 580);
            this.pn_Contents.TabIndex = 52;
            this.pn_Contents.Text = "listPanel";
            // 
            // pn_TopBar
            // 
            this.pn_TopBar.BackColor = System.Drawing.Color.Transparent;
            this.pn_TopBar.Controls.Add(this.pn_musicTitle);
            this.pn_TopBar.Dock = Wisej.Web.DockStyle.Top;
            this.pn_TopBar.Location = new System.Drawing.Point(20, 20);
            this.pn_TopBar.Name = "pn_TopBar";
            this.pn_TopBar.Size = new System.Drawing.Size(660, 40);
            this.pn_TopBar.TabIndex = 51;
            // 
            // pn_musicTitle
            // 
            this.pn_musicTitle.Controls.Add(this.label2);
            this.pn_musicTitle.Dock = Wisej.Web.DockStyle.Top;
            this.pn_musicTitle.Location = new System.Drawing.Point(0, 0);
            this.pn_musicTitle.Name = "pn_musicTitle";
            this.pn_musicTitle.Size = new System.Drawing.Size(660, 40);
            this.pn_musicTitle.TabIndex = 163;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = Wisej.Web.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new Wisej.Web.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 40);
            this.label2.TabIndex = 134;
            this.label2.Text = "방송 구역";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comp_Site1
            // 
            this.comp_Site1.AutoSize = false;
            this.comp_Site1.DisplayMember = "EMNAME";
            this.comp_Site1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comp_Site1.Items.AddRange(new object[] {
            "전체"});
            this.comp_Site1.Location = new System.Drawing.Point(62, 3);
            this.comp_Site1.Margin = new Wisej.Web.Padding(0);
            this.comp_Site1.Name = "comp_Site1";
            this.comp_Site1.Size = new System.Drawing.Size(151, 32);
            this.comp_Site1.TabIndex = 99;
            this.comp_Site1.SelectedIndexChanged += new System.EventHandler(this.comp_Site1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 98;
            this.label1.Text = "사이트";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_groupList
            // 
            this.cb_groupList.AutoSize = false;
            this.cb_groupList.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cb_groupList.Items.AddRange(new object[] {
            "전체"});
            this.cb_groupList.Location = new System.Drawing.Point(291, 3);
            this.cb_groupList.Margin = new Wisej.Web.Padding(0);
            this.cb_groupList.Name = "cb_groupList";
            this.cb_groupList.Size = new System.Drawing.Size(139, 32);
            this.cb_groupList.TabIndex = 97;
            // 
            // lb_BuildingName
            // 
            this.lb_BuildingName.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_BuildingName.Location = new System.Drawing.Point(228, 3);
            this.lb_BuildingName.Name = "lb_BuildingName";
            this.lb_BuildingName.Size = new System.Drawing.Size(68, 32);
            this.lb_BuildingName.TabIndex = 96;
            this.lb_BuildingName.Text = "그룹명";
            this.lb_BuildingName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_WholeSelect
            // 
            this.bt_WholeSelect.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.bt_WholeSelect.CssStyle = resources.GetString("bt_WholeSelect.CssStyle");
            this.bt_WholeSelect.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_WholeSelect.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_WholeSelect.Location = new System.Drawing.Point(448, 2);
            this.bt_WholeSelect.Margin = new Wisej.Web.Padding(0);
            this.bt_WholeSelect.Name = "bt_WholeSelect";
            this.bt_WholeSelect.Size = new System.Drawing.Size(100, 32);
            this.bt_WholeSelect.TabIndex = 94;
            this.bt_WholeSelect.Text = "전체선택";
            this.bt_WholeSelect.Click += new System.EventHandler(this.bt_WholeSelect_Click);
            // 
            // pn_ViewMain
            // 
            this.pn_ViewMain.BackColor = System.Drawing.Color.White;
            this.pn_ViewMain.Controls.Add(this.pn_Contents);
            this.pn_ViewMain.Controls.Add(this.panel1);
            this.pn_ViewMain.Controls.Add(this.pn_TopBar);
            this.pn_ViewMain.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_ViewMain.Location = new System.Drawing.Point(0, 0);
            this.pn_ViewMain.Name = "pn_ViewMain";
            this.pn_ViewMain.Padding = new Wisej.Web.Padding(20);
            this.pn_ViewMain.Size = new System.Drawing.Size(700, 700);
            this.pn_ViewMain.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comp_Site1);
            this.panel1.Controls.Add(this.bt_WholeSelect);
            this.panel1.Controls.Add(this.cb_groupList);
            this.panel1.Controls.Add(this.lb_BuildingName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 40);
            this.panel1.TabIndex = 53;
            // 
            // Comp_BBSAnchorZone
            // 
            this.Controls.Add(this.pn_ViewMain);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "Comp_BBSAnchorZone";
            this.Size = new System.Drawing.Size(700, 700);
            this.Load += new System.EventHandler(this.Comp_BBSAnchorZone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.pn_TopBar.ResumeLayout(false);
            this.pn_musicTitle.ResumeLayout(false);
            this.pn_ViewMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1TableAdapters.EMServerNDeviceNameTableAdapter emServerNDeviceNameTableAdapter1;
        private DataSet1TableAdapters.EMServerTableAdapter emServerTableAdapter1;
        private DataSet1TableAdapters.AssetPresetGroupsTableAdapter assetPresetGroupsTableAdapter1;
        private DataSet1TableAdapters.AssetGroupsTableAdapter assetGroupsTableAdapter1;
        private DataSet1TableAdapters.DeviceTableAdapter deviceTableAdapter1;
        private DataSet1TableAdapters.EMServerWithWholeColTableAdapter emServerWithWholeColTableAdapter1;
        private DataSet1TableAdapters.AssetsSitenBuildingTableAdapter assetsSitenBuildingTableAdapter1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.BSTreeTableAdapter bsTreeTableAdapter1;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter1;
        private Wisej.Web.Panel pn_Contents;
        private Wisej.Web.Panel pn_TopBar;
        private Wisej.Web.Panel pn_ViewMain;
        private Wisej.Web.Button bt_WholeSelect;
        private Wisej.Web.Label lb_BuildingName;
        private Wisej.Web.ComboBox cb_groupList;
        private Wisej.Web.ComboBox comp_Site1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Panel pn_musicTitle;
        private Wisej.Web.Label label2;
        private Wisej.Web.Panel panel1;
    }
}
