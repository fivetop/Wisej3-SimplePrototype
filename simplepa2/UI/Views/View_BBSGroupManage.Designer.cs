namespace simplepa2.UI.Views
{
    partial class View_BBSGroupManage
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
            this.pn_GroupListMain = new Wisej.Web.Panel();
            this.pn_GroupList = new Wisej.Web.Panel();
            this.pn_GroupListTop = new Wisej.Web.Panel();
            this.bt_GroupAdd = new Wisej.Web.Button();
            this.lb_GroupName = new Wisej.Web.Label();
            this.pn_Spacer = new Wisej.Web.Panel();
            this.pn_GroupDetails = new Wisej.Web.Panel();
            this.cb_SiteName = new Wisej.Web.ComboBox();
            this.pn_GroupListMain.SuspendLayout();
            this.pn_GroupListTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_GroupListMain
            // 
            this.pn_GroupListMain.BackColor = System.Drawing.Color.White;
            this.pn_GroupListMain.Controls.Add(this.pn_GroupList);
            this.pn_GroupListMain.Controls.Add(this.pn_GroupListTop);
            this.pn_GroupListMain.Dock = Wisej.Web.DockStyle.Left;
            this.pn_GroupListMain.Location = new System.Drawing.Point(20, 20);
            this.pn_GroupListMain.Name = "pn_GroupListMain";
            this.pn_GroupListMain.Padding = new Wisej.Web.Padding(20);
            this.pn_GroupListMain.Size = new System.Drawing.Size(580, 860);
            this.pn_GroupListMain.TabIndex = 44;
            // 
            // pn_GroupList
            // 
            this.pn_GroupList.AutoScroll = true;
            this.pn_GroupList.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_GroupList.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.pn_GroupList.Location = new System.Drawing.Point(20, 72);
            this.pn_GroupList.Name = "pn_GroupList";
            this.pn_GroupList.Size = new System.Drawing.Size(540, 768);
            this.pn_GroupList.TabIndex = 51;
            this.pn_GroupList.Text = "listPanel";
            // 
            // pn_GroupListTop
            // 
            this.pn_GroupListTop.BackColor = System.Drawing.Color.Transparent;
            this.pn_GroupListTop.Controls.Add(this.cb_SiteName);
            this.pn_GroupListTop.Controls.Add(this.bt_GroupAdd);
            this.pn_GroupListTop.Controls.Add(this.lb_GroupName);
            this.pn_GroupListTop.Dock = Wisej.Web.DockStyle.Top;
            this.pn_GroupListTop.Location = new System.Drawing.Point(20, 20);
            this.pn_GroupListTop.Name = "pn_GroupListTop";
            this.pn_GroupListTop.Size = new System.Drawing.Size(540, 52);
            this.pn_GroupListTop.TabIndex = 50;
            // 
            // bt_GroupAdd
            // 
            this.bt_GroupAdd.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_GroupAdd.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_GroupAdd.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_GroupAdd.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_GroupAdd.Location = new System.Drawing.Point(440, 0);
            this.bt_GroupAdd.Margin = new Wisej.Web.Padding(0);
            this.bt_GroupAdd.Name = "bt_GroupAdd";
            this.bt_GroupAdd.Size = new System.Drawing.Size(100, 32);
            this.bt_GroupAdd.TabIndex = 34;
            this.bt_GroupAdd.Text = "추가";
            // 
            // lb_GroupName
            // 
            this.lb_GroupName.CssStyle = "\r\n";
            this.lb_GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_GroupName.Location = new System.Drawing.Point(0, 0);
            this.lb_GroupName.Name = "lb_GroupName";
            this.lb_GroupName.Size = new System.Drawing.Size(223, 32);
            this.lb_GroupName.TabIndex = 33;
            this.lb_GroupName.Text = "그룹 리스트";
            this.lb_GroupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pn_Spacer
            // 
            this.pn_Spacer.BackColor = System.Drawing.Color.Transparent;
            this.pn_Spacer.Dock = Wisej.Web.DockStyle.Left;
            this.pn_Spacer.Location = new System.Drawing.Point(600, 20);
            this.pn_Spacer.Name = "pn_Spacer";
            this.pn_Spacer.Size = new System.Drawing.Size(20, 860);
            this.pn_Spacer.TabIndex = 47;
            // 
            // pn_GroupDetails
            // 
            this.pn_GroupDetails.BackColor = System.Drawing.Color.White;
            this.pn_GroupDetails.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_GroupDetails.Location = new System.Drawing.Point(620, 20);
            this.pn_GroupDetails.Name = "pn_GroupDetails";
            this.pn_GroupDetails.Padding = new Wisej.Web.Padding(20);
            this.pn_GroupDetails.Size = new System.Drawing.Size(760, 860);
            this.pn_GroupDetails.TabIndex = 48;
            // 
            // cb_SiteName
            // 
            this.cb_SiteName.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.cb_SiteName.AutoSize = false;
            this.cb_SiteName.Location = new System.Drawing.Point(261, 1);
            this.cb_SiteName.Name = "cb_SiteName";
            this.cb_SiteName.Size = new System.Drawing.Size(161, 32);
            this.cb_SiteName.TabIndex = 35;
            this.cb_SiteName.SelectedIndexChanged += new System.EventHandler(this.cb_SiteName_SelectedIndexChanged);
            // 
            // View_BBSGroupManage
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.pn_GroupDetails);
            this.Controls.Add(this.pn_Spacer);
            this.Controls.Add(this.pn_GroupListMain);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBSGroupManage";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.pn_GroupListMain.ResumeLayout(false);
            this.pn_GroupListTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel pn_GroupListMain;
        private Wisej.Web.Panel pn_GroupList;
        private Wisej.Web.Panel pn_GroupListTop;
        private Wisej.Web.Button bt_GroupAdd;
        private Wisej.Web.Label lb_GroupName;
        private Wisej.Web.Panel pn_Spacer;
        private Wisej.Web.Panel pn_GroupDetails;
        private Wisej.Web.ComboBox cb_SiteName;
    }
}
