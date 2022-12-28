namespace simplepa2.UI.Components
{
    partial class Comp_SiteCard
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
            this.pn_cardFrame = new Wisej.Web.Panel();
            this.pn_forthRow = new Wisej.Web.Panel();
            this.lb_EMStatus = new Wisej.Web.Label();
            this.lb_titleBServer = new Wisej.Web.Label();
            this.pn_thirdRow = new Wisej.Web.Panel();
            this.lb_EMName = new Wisej.Web.Label();
            this.lb_titleDescription = new Wisej.Web.Label();
            this.pn_secondRow = new Wisej.Web.Panel();
            this.lb_siteAddress = new Wisej.Web.Label();
            this.lb2 = new Wisej.Web.Label();
            this.pn_firstRow = new Wisej.Web.Panel();
            this.lb_siteNo = new Wisej.Web.Label();
            this.lb1 = new Wisej.Web.Label();
            this.pb_siteImage = new Wisej.Web.PictureBox();
            this.pn_spacer = new Wisej.Web.Panel();
            this.pn_topPanel = new Wisej.Web.Panel();
            this.bt_siteVerfiy = new Wisej.Web.Button();
            this.lb_siteName = new Wisej.Web.Label();
            this.pn_cardFrame.SuspendLayout();
            this.pn_forthRow.SuspendLayout();
            this.pn_thirdRow.SuspendLayout();
            this.pn_secondRow.SuspendLayout();
            this.pn_firstRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_siteImage)).BeginInit();
            this.pn_topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_cardFrame
            // 
            this.pn_cardFrame.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.pn_cardFrame.Controls.Add(this.pn_forthRow);
            this.pn_cardFrame.Controls.Add(this.pn_thirdRow);
            this.pn_cardFrame.Controls.Add(this.pn_secondRow);
            this.pn_cardFrame.Controls.Add(this.pn_firstRow);
            this.pn_cardFrame.Controls.Add(this.pb_siteImage);
            this.pn_cardFrame.Controls.Add(this.pn_spacer);
            this.pn_cardFrame.Controls.Add(this.pn_topPanel);
            this.pn_cardFrame.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_cardFrame.Location = new System.Drawing.Point(0, 0);
            this.pn_cardFrame.Name = "pn_cardFrame";
            this.pn_cardFrame.Padding = new Wisej.Web.Padding(20);
            this.pn_cardFrame.Size = new System.Drawing.Size(290, 390);
            this.pn_cardFrame.TabIndex = 174;
            // 
            // pn_forthRow
            // 
            this.pn_forthRow.Controls.Add(this.lb_EMStatus);
            this.pn_forthRow.Controls.Add(this.lb_titleBServer);
            this.pn_forthRow.Dock = Wisej.Web.DockStyle.Top;
            this.pn_forthRow.Location = new System.Drawing.Point(20, 329);
            this.pn_forthRow.Name = "pn_forthRow";
            this.pn_forthRow.Size = new System.Drawing.Size(250, 36);
            this.pn_forthRow.TabIndex = 168;
            // 
            // lb_EMStatus
            // 
            this.lb_EMStatus.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.lb_EMStatus.AutoEllipsis = true;
            this.lb_EMStatus.BackColor = System.Drawing.Color.FromName("@bStatusGreen");
            this.lb_EMStatus.CssStyle = "border-radius:15px";
            this.lb_EMStatus.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_EMStatus.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb_EMStatus.Location = new System.Drawing.Point(101, 9);
            this.lb_EMStatus.Margin = new Wisej.Web.Padding(0);
            this.lb_EMStatus.Name = "lb_EMStatus";
            this.lb_EMStatus.Size = new System.Drawing.Size(20, 20);
            this.lb_EMStatus.TabIndex = 146;
            this.lb_EMStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_titleBServer
            // 
            this.lb_titleBServer.AutoEllipsis = true;
            this.lb_titleBServer.BackColor = System.Drawing.Color.Transparent;
            this.lb_titleBServer.Dock = Wisej.Web.DockStyle.Left;
            this.lb_titleBServer.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_titleBServer.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb_titleBServer.Location = new System.Drawing.Point(0, 0);
            this.lb_titleBServer.Margin = new Wisej.Web.Padding(0);
            this.lb_titleBServer.Name = "lb_titleBServer";
            this.lb_titleBServer.Size = new System.Drawing.Size(100, 36);
            this.lb_titleBServer.TabIndex = 136;
            this.lb_titleBServer.Text = "서버상태";
            this.lb_titleBServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pn_thirdRow
            // 
            this.pn_thirdRow.Controls.Add(this.lb_EMName);
            this.pn_thirdRow.Controls.Add(this.lb_titleDescription);
            this.pn_thirdRow.Dock = Wisej.Web.DockStyle.Top;
            this.pn_thirdRow.Location = new System.Drawing.Point(20, 293);
            this.pn_thirdRow.Name = "pn_thirdRow";
            this.pn_thirdRow.Size = new System.Drawing.Size(250, 36);
            this.pn_thirdRow.TabIndex = 167;
            // 
            // lb_EMName
            // 
            this.lb_EMName.AutoEllipsis = true;
            this.lb_EMName.BackColor = System.Drawing.Color.Transparent;
            this.lb_EMName.Dock = Wisej.Web.DockStyle.Fill;
            this.lb_EMName.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_EMName.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb_EMName.Location = new System.Drawing.Point(100, 0);
            this.lb_EMName.Margin = new Wisej.Web.Padding(0);
            this.lb_EMName.Name = "lb_EMName";
            this.lb_EMName.Size = new System.Drawing.Size(150, 36);
            this.lb_EMName.TabIndex = 137;
            this.lb_EMName.Text = "대명리조트 강원";
            this.lb_EMName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_titleDescription
            // 
            this.lb_titleDescription.AutoEllipsis = true;
            this.lb_titleDescription.BackColor = System.Drawing.Color.Transparent;
            this.lb_titleDescription.Dock = Wisej.Web.DockStyle.Left;
            this.lb_titleDescription.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_titleDescription.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb_titleDescription.Location = new System.Drawing.Point(0, 0);
            this.lb_titleDescription.Margin = new Wisej.Web.Padding(0);
            this.lb_titleDescription.Name = "lb_titleDescription";
            this.lb_titleDescription.Size = new System.Drawing.Size(100, 36);
            this.lb_titleDescription.TabIndex = 136;
            this.lb_titleDescription.Text = "메인E.M";
            this.lb_titleDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pn_secondRow
            // 
            this.pn_secondRow.Controls.Add(this.lb_siteAddress);
            this.pn_secondRow.Controls.Add(this.lb2);
            this.pn_secondRow.Dock = Wisej.Web.DockStyle.Top;
            this.pn_secondRow.Location = new System.Drawing.Point(20, 257);
            this.pn_secondRow.Name = "pn_secondRow";
            this.pn_secondRow.Size = new System.Drawing.Size(250, 36);
            this.pn_secondRow.TabIndex = 166;
            // 
            // lb_siteAddress
            // 
            this.lb_siteAddress.AutoEllipsis = true;
            this.lb_siteAddress.BackColor = System.Drawing.Color.Transparent;
            this.lb_siteAddress.Dock = Wisej.Web.DockStyle.Fill;
            this.lb_siteAddress.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_siteAddress.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb_siteAddress.Location = new System.Drawing.Point(100, 0);
            this.lb_siteAddress.Margin = new Wisej.Web.Padding(0);
            this.lb_siteAddress.Name = "lb_siteAddress";
            this.lb_siteAddress.Size = new System.Drawing.Size(150, 36);
            this.lb_siteAddress.TabIndex = 137;
            this.lb_siteAddress.Text = "강원도 홍천";
            this.lb_siteAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Dock = Wisej.Web.DockStyle.Left;
            this.lb2.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb2.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb2.Location = new System.Drawing.Point(0, 0);
            this.lb2.Margin = new Wisej.Web.Padding(0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(100, 36);
            this.lb2.TabIndex = 136;
            this.lb2.Text = "사이트주소";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pn_firstRow
            // 
            this.pn_firstRow.Controls.Add(this.lb_siteNo);
            this.pn_firstRow.Controls.Add(this.lb1);
            this.pn_firstRow.Dock = Wisej.Web.DockStyle.Top;
            this.pn_firstRow.Location = new System.Drawing.Point(20, 211);
            this.pn_firstRow.Name = "pn_firstRow";
            this.pn_firstRow.Padding = new Wisej.Web.Padding(0, 10, 0, 0);
            this.pn_firstRow.Size = new System.Drawing.Size(250, 46);
            this.pn_firstRow.TabIndex = 165;
            // 
            // lb_siteNo
            // 
            this.lb_siteNo.AutoEllipsis = true;
            this.lb_siteNo.BackColor = System.Drawing.Color.Transparent;
            this.lb_siteNo.Dock = Wisej.Web.DockStyle.Fill;
            this.lb_siteNo.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_siteNo.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb_siteNo.Location = new System.Drawing.Point(100, 10);
            this.lb_siteNo.Margin = new Wisej.Web.Padding(0);
            this.lb_siteNo.Name = "lb_siteNo";
            this.lb_siteNo.Size = new System.Drawing.Size(150, 36);
            this.lb_siteNo.TabIndex = 137;
            this.lb_siteNo.Text = "2동";
            this.lb_siteNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb1
            // 
            this.lb1.AutoEllipsis = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Dock = Wisej.Web.DockStyle.Left;
            this.lb1.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb1.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb1.Location = new System.Drawing.Point(0, 10);
            this.lb1.Margin = new Wisej.Web.Padding(0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(100, 36);
            this.lb1.TabIndex = 136;
            this.lb1.Text = "사이트번호";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_siteImage
            // 
            this.pb_siteImage.BackColor = System.Drawing.Color.FromArgb(183, 183, 183);
            this.pb_siteImage.Dock = Wisej.Web.DockStyle.Top;
            this.pb_siteImage.ImageSource = "Images\\site_image_none_250x141.png";
            this.pb_siteImage.Location = new System.Drawing.Point(20, 70);
            this.pb_siteImage.Name = "pb_siteImage";
            this.pb_siteImage.Size = new System.Drawing.Size(250, 141);
            this.pb_siteImage.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            // 
            // pn_spacer
            // 
            this.pn_spacer.Dock = Wisej.Web.DockStyle.Top;
            this.pn_spacer.Location = new System.Drawing.Point(20, 50);
            this.pn_spacer.Name = "pn_spacer";
            this.pn_spacer.Size = new System.Drawing.Size(250, 20);
            this.pn_spacer.TabIndex = 136;
            // 
            // pn_topPanel
            // 
            this.pn_topPanel.BackColor = System.Drawing.Color.Transparent;
            this.pn_topPanel.Controls.Add(this.bt_siteVerfiy);
            this.pn_topPanel.Controls.Add(this.lb_siteName);
            this.pn_topPanel.Dock = Wisej.Web.DockStyle.Top;
            this.pn_topPanel.Location = new System.Drawing.Point(20, 20);
            this.pn_topPanel.Name = "pn_topPanel";
            this.pn_topPanel.Size = new System.Drawing.Size(250, 30);
            this.pn_topPanel.TabIndex = 52;
            // 
            // bt_siteVerfiy
            // 
            this.bt_siteVerfiy.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_siteVerfiy.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_siteVerfiy.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_siteVerfiy.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_siteVerfiy.Location = new System.Drawing.Point(190, 0);
            this.bt_siteVerfiy.Margin = new Wisej.Web.Padding(0);
            this.bt_siteVerfiy.Name = "bt_siteVerfiy";
            this.bt_siteVerfiy.Size = new System.Drawing.Size(60, 32);
            this.bt_siteVerfiy.TabIndex = 35;
            this.bt_siteVerfiy.Text = "수정";
            this.bt_siteVerfiy.Click += new System.EventHandler(this.bt_siteVerfiy_Click);
            // 
            // lb_siteName
            // 
            this.lb_siteName.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.lb_siteName.Dock = Wisej.Web.DockStyle.Fill;
            this.lb_siteName.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_siteName.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb_siteName.Location = new System.Drawing.Point(0, 0);
            this.lb_siteName.Name = "lb_siteName";
            this.lb_siteName.Size = new System.Drawing.Size(250, 30);
            this.lb_siteName.TabIndex = 17;
            this.lb_siteName.Text = "사이트명";
            this.lb_siteName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Comp_SiteCard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.Controls.Add(this.pn_cardFrame);
            this.Margin = new Wisej.Web.Padding(3, 3, 6, 3);
            this.Name = "Comp_SiteCard";
            this.Size = new System.Drawing.Size(290, 390);
            this.pn_cardFrame.ResumeLayout(false);
            this.pn_forthRow.ResumeLayout(false);
            this.pn_thirdRow.ResumeLayout(false);
            this.pn_secondRow.ResumeLayout(false);
            this.pn_firstRow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_siteImage)).EndInit();
            this.pn_topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pn_cardFrame;
        private Wisej.Web.Panel pn_forthRow;
        private Wisej.Web.Label lb_titleBServer;
        private Wisej.Web.Panel pn_thirdRow;
        private Wisej.Web.Label lb_EMName;
        private Wisej.Web.Label lb_titleDescription;
        private Wisej.Web.Panel pn_secondRow;
        private Wisej.Web.Label lb_siteAddress;
        private Wisej.Web.Label lb2;
        private Wisej.Web.Panel pn_firstRow;
        private Wisej.Web.Label lb1;
        private Wisej.Web.Panel pn_spacer;
        private Wisej.Web.Panel pn_topPanel;
        private Wisej.Web.Button bt_siteVerfiy;
        private Wisej.Web.Label lb_siteName;
        private Wisej.Web.PictureBox pb_siteImage;
        private Wisej.Web.Label lb_siteNo;
        private Wisej.Web.Label lb_EMStatus;
    }
}
