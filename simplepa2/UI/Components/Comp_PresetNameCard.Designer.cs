namespace simplepa2.UI.Components
{
    partial class Comp_PresetNameCard
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
            this.pn_CardOutline = new Wisej.Web.Panel();
            this.lb_SubText = new Wisej.Web.Label();
            this.lb_MainText = new Wisej.Web.Label();
            this.pn_ImageFrame = new Wisej.Web.Panel();
            this.pn_Image = new Wisej.Web.Panel();
            this.pn_CardOutline.SuspendLayout();
            this.pn_ImageFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_CardOutline
            // 
            this.pn_CardOutline.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.pn_CardOutline.Controls.Add(this.lb_SubText);
            this.pn_CardOutline.Controls.Add(this.lb_MainText);
            this.pn_CardOutline.Controls.Add(this.pn_ImageFrame);
            this.pn_CardOutline.Dock = Wisej.Web.DockStyle.Top;
            this.pn_CardOutline.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.pn_CardOutline.Location = new System.Drawing.Point(0, 0);
            this.pn_CardOutline.Name = "pn_CardOutline";
            this.pn_CardOutline.Size = new System.Drawing.Size(540, 72);
            this.pn_CardOutline.TabIndex = 134;
            this.pn_CardOutline.Click += new System.EventHandler(this.pn_CardOutline_Click);
            // 
            // lb_SubText
            // 
            this.lb_SubText.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_SubText.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.lb_SubText.Location = new System.Drawing.Point(80, 38);
            this.lb_SubText.Name = "lb_SubText";
            this.lb_SubText.Size = new System.Drawing.Size(437, 20);
            this.lb_SubText.TabIndex = 4;
            this.lb_SubText.Text = "로비외 23곳 / 음원 3개";
            this.lb_SubText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_SubText.Click += new System.EventHandler(this.lb_SubText_Click);
            // 
            // lb_MainText
            // 
            this.lb_MainText.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_MainText.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.lb_MainText.Location = new System.Drawing.Point(80, 17);
            this.lb_MainText.Name = "lb_MainText";
            this.lb_MainText.Size = new System.Drawing.Size(437, 20);
            this.lb_MainText.TabIndex = 3;
            this.lb_MainText.Text = "[ADMIN 3층 주의 방송";
            this.lb_MainText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_MainText.Click += new System.EventHandler(this.lb_MainText_Click);
            // 
            // pn_ImageFrame
            // 
            this.pn_ImageFrame.BackColor = System.Drawing.Color.White;
            this.pn_ImageFrame.Controls.Add(this.pn_Image);
            this.pn_ImageFrame.CssStyle = "    width: 50px;\r\n    height: 50px;\r\n    border-radius: 15px;\r\n    background: #f" +
    "ff;\r\n    border: 1px solid /*#E0E3EB*/#dde4f3;";
            this.pn_ImageFrame.Location = new System.Drawing.Point(16, 13);
            this.pn_ImageFrame.Name = "pn_ImageFrame";
            this.pn_ImageFrame.Size = new System.Drawing.Size(50, 50);
            this.pn_ImageFrame.TabIndex = 0;
            // 
            // pn_Image
            // 
            this.pn_Image.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch;
            this.pn_Image.BackgroundImageSource = "Images/icon-ls-004.png";
            this.pn_Image.Location = new System.Drawing.Point(13, 13);
            this.pn_Image.Name = "pn_Image";
            this.pn_Image.Size = new System.Drawing.Size(24, 24);
            this.pn_Image.TabIndex = 0;
            // 
            // Comp_PresetNameCard
            // 
            this.Controls.Add(this.pn_CardOutline);
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Name = "Comp_PresetNameCard";
            this.Size = new System.Drawing.Size(540, 72);
            this.pn_CardOutline.ResumeLayout(false);
            this.pn_ImageFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pn_CardOutline;
        private Wisej.Web.Label lb_SubText;
        private Wisej.Web.Label lb_MainText;
        private Wisej.Web.Panel pn_ImageFrame;
        private Wisej.Web.Panel pn_Image;
    }
}
