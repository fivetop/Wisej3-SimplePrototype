namespace simplepa2.UI.Components
{
    partial class Comp_DashBoardBBSDeck
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
            this.panel8 = new Wisej.Web.Panel();
            this.panel38 = new Wisej.Web.Panel();
            this.bt_bbsExit = new Wisej.Web.Button();
            this.bt_enter = new Wisej.Web.Button();
            this.pn_button = new Wisej.Web.Panel();
            this.panel9 = new Wisej.Web.Panel();
            this.lb_EMNAME = new Wisej.Web.Label();
            this.label29 = new Wisej.Web.Label();
            this.panel8.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel8.Controls.Add(this.panel38);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = Wisej.Web.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new Wisej.Web.Padding(16, 11, 16, 11);
            this.panel8.Size = new System.Drawing.Size(856, 120);
            this.panel8.TabIndex = 135;
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.bt_bbsExit);
            this.panel38.Controls.Add(this.bt_enter);
            this.panel38.Controls.Add(this.pn_button);
            this.panel38.Dock = Wisej.Web.DockStyle.Top;
            this.panel38.Location = new System.Drawing.Point(16, 48);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(824, 60);
            this.panel38.TabIndex = 165;
            // 
            // bt_bbsExit
            // 
            this.bt_bbsExit.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_bbsExit.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.bt_bbsExit.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_bbsExit.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_bbsExit.Location = new System.Drawing.Point(747, 16);
            this.bt_bbsExit.Margin = new Wisej.Web.Padding(0);
            this.bt_bbsExit.Name = "bt_bbsExit";
            this.bt_bbsExit.Size = new System.Drawing.Size(70, 32);
            this.bt_bbsExit.TabIndex = 172;
            this.bt_bbsExit.Text = "강제종료";
            this.bt_bbsExit.Click += new System.EventHandler(this.bt_bbsExit_Click);
            // 
            // bt_enter
            // 
            this.bt_enter.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_enter.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_enter.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_enter.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_enter.Location = new System.Drawing.Point(674, 16);
            this.bt_enter.Margin = new Wisej.Web.Padding(0);
            this.bt_enter.Name = "bt_enter";
            this.bt_enter.Size = new System.Drawing.Size(70, 32);
            this.bt_enter.TabIndex = 171;
            this.bt_enter.Text = "입장";
            this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
            // 
            // pn_button
            // 
            this.pn_button.Dock = Wisej.Web.DockStyle.Left;
            this.pn_button.Location = new System.Drawing.Point(0, 0);
            this.pn_button.Name = "pn_button";
            this.pn_button.Padding = new Wisej.Web.Padding(5);
            this.pn_button.Size = new System.Drawing.Size(651, 60);
            this.pn_button.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lb_EMNAME);
            this.panel9.Controls.Add(this.label29);
            this.panel9.Dock = Wisej.Web.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(16, 11);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(824, 37);
            this.panel9.TabIndex = 163;
            // 
            // lb_EMNAME
            // 
            this.lb_EMNAME.AutoEllipsis = true;
            this.lb_EMNAME.BackColor = System.Drawing.Color.Transparent;
            this.lb_EMNAME.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_EMNAME.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb_EMNAME.Location = new System.Drawing.Point(103, 0);
            this.lb_EMNAME.Margin = new Wisej.Web.Padding(0);
            this.lb_EMNAME.Name = "lb_EMNAME";
            this.lb_EMNAME.Size = new System.Drawing.Size(120, 24);
            this.lb_EMNAME.TabIndex = 135;
            this.lb_EMNAME.Text = "지역명";
            this.lb_EMNAME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.AutoEllipsis = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label29.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label29.Location = new System.Drawing.Point(0, 0);
            this.label29.Margin = new Wisej.Web.Padding(0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(108, 24);
            this.label29.TabIndex = 134;
            this.label29.Text = "방송 사이트 -";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Comp_DashBoardBBSDeck
            // 
            this.Controls.Add(this.panel8);
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Name = "Comp_DashBoardBBSDeck";
            this.Size = new System.Drawing.Size(856, 120);
            this.panel8.ResumeLayout(false);
            this.panel38.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel8;
        private Wisej.Web.Panel panel38;
        private Wisej.Web.Button bt_bbsExit;
        private Wisej.Web.Button bt_enter;
        private Wisej.Web.Panel panel9;
        private Wisej.Web.Label label29;
        private Wisej.Web.Label lb_EMNAME;
        private Wisej.Web.Panel pn_button;
    }
}
