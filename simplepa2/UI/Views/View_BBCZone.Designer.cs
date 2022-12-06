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
            this.bt_WholeSelect = new Wisej.Web.Button();
            this.bt_ExportCSV = new Wisej.Web.Button();
            this.lb_BuildingName = new Wisej.Web.Label();
            this.cb_SiteName = new Wisej.Web.ComboBox();
            this.bt_StoreData = new Wisej.Web.Button();
            this.bt_SelectLoading = new Wisej.Web.Button();
            this.bt_ImportCSV = new Wisej.Web.Button();
            this.pn_ViewMain.SuspendLayout();
            this.pn_TopBar.SuspendLayout();
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
            this.pn_Contents.Dock = Wisej.Web.DockStyle.Top;
            this.pn_Contents.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.pn_Contents.Location = new System.Drawing.Point(20, 72);
            this.pn_Contents.Name = "pn_Contents";
            this.pn_Contents.Size = new System.Drawing.Size(1320, 770);
            this.pn_Contents.TabIndex = 52;
            this.pn_Contents.Text = "listPanel";
            // 
            // pn_TopBar
            // 
            this.pn_TopBar.BackColor = System.Drawing.Color.Transparent;
            this.pn_TopBar.Controls.Add(this.bt_WholeSelect);
            this.pn_TopBar.Controls.Add(this.bt_ExportCSV);
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
            // bt_WholeSelect
            // 
            this.bt_WholeSelect.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.bt_WholeSelect.CssStyle = resources.GetString("bt_WholeSelect.CssStyle");
            this.bt_WholeSelect.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_WholeSelect.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_WholeSelect.Location = new System.Drawing.Point(508, 1);
            this.bt_WholeSelect.Margin = new Wisej.Web.Padding(0);
            this.bt_WholeSelect.Name = "bt_WholeSelect";
            this.bt_WholeSelect.Size = new System.Drawing.Size(100, 32);
            this.bt_WholeSelect.TabIndex = 94;
            this.bt_WholeSelect.Text = "전체선택";
            this.bt_WholeSelect.Click += new System.EventHandler(this.bt_WholeSelect_Click);
            // 
            // bt_ExportCSV
            // 
            this.bt_ExportCSV.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_ExportCSV.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.bt_ExportCSV.CssStyle = resources.GetString("bt_ExportCSV.CssStyle");
            this.bt_ExportCSV.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_ExportCSV.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_ExportCSV.Location = new System.Drawing.Point(1110, 0);
            this.bt_ExportCSV.Margin = new Wisej.Web.Padding(0);
            this.bt_ExportCSV.Name = "bt_ExportCSV";
            this.bt_ExportCSV.Size = new System.Drawing.Size(100, 32);
            this.bt_ExportCSV.TabIndex = 93;
            this.bt_ExportCSV.Text = "Export CSV";
            this.bt_ExportCSV.Click += new System.EventHandler(this.bt_ExportCSV_Click);
            // 
            // lb_BuildingName
            // 
            this.lb_BuildingName.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_BuildingName.Location = new System.Drawing.Point(0, 0);
            this.lb_BuildingName.Name = "lb_BuildingName";
            this.lb_BuildingName.Size = new System.Drawing.Size(68, 32);
            this.lb_BuildingName.TabIndex = 92;
            this.lb_BuildingName.Text = "건물명";
            this.lb_BuildingName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_SiteName
            // 
            this.cb_SiteName.AutoSize = false;
            this.cb_SiteName.Location = new System.Drawing.Point(71, 0);
            this.cb_SiteName.Margin = new Wisej.Web.Padding(0);
            this.cb_SiteName.Name = "cb_SiteName";
            this.cb_SiteName.Size = new System.Drawing.Size(200, 32);
            this.cb_SiteName.TabIndex = 91;
            // 
            // bt_StoreData
            // 
            this.bt_StoreData.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.bt_StoreData.CssStyle = resources.GetString("bt_StoreData.CssStyle");
            this.bt_StoreData.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_StoreData.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_StoreData.Location = new System.Drawing.Point(398, 1);
            this.bt_StoreData.Margin = new Wisej.Web.Padding(0);
            this.bt_StoreData.Name = "bt_StoreData";
            this.bt_StoreData.Size = new System.Drawing.Size(100, 32);
            this.bt_StoreData.TabIndex = 90;
            this.bt_StoreData.Text = "변경저장";
            this.bt_StoreData.Click += new System.EventHandler(this.bt_StoreData_Click);
            // 
            // bt_SelectLoading
            // 
            this.bt_SelectLoading.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.bt_SelectLoading.CssStyle = resources.GetString("bt_SelectLoading.CssStyle");
            this.bt_SelectLoading.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_SelectLoading.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_SelectLoading.Location = new System.Drawing.Point(289, 0);
            this.bt_SelectLoading.Margin = new Wisej.Web.Padding(0);
            this.bt_SelectLoading.Name = "bt_SelectLoading";
            this.bt_SelectLoading.Size = new System.Drawing.Size(100, 32);
            this.bt_SelectLoading.TabIndex = 36;
            this.bt_SelectLoading.Text = "선택로딩";
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
            // View_BBCZone
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pn_ViewMain);
            this.CssStyle = "background: /*#F0F0F0*/#eeeff8;";
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCZone";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.View_BBCZone_Load);
            this.pn_ViewMain.ResumeLayout(false);
            this.pn_TopBar.ResumeLayout(false);
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
        private Wisej.Web.Button bt_ExportCSV;
        private Wisej.Web.Panel pn_Contents;
        private Wisej.Web.Button bt_WholeSelect;
    }
}
