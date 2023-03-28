namespace simplepa2.UI.Components
{
    partial class Comp_GroupNameCard
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
            this.panelCardBack = new Wisej.Web.Panel();
            this.lb_regionNo = new Wisej.Web.Label();
            this.label_GroupName = new Wisej.Web.Label();
            this.lb_cardNo = new Wisej.Web.Label();
            this.panelCardBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCardBack
            // 
            this.panelCardBack.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panelCardBack.Controls.Add(this.lb_regionNo);
            this.panelCardBack.Controls.Add(this.label_GroupName);
            this.panelCardBack.Controls.Add(this.lb_cardNo);
            this.panelCardBack.Dock = Wisej.Web.DockStyle.Fill;
            this.panelCardBack.Location = new System.Drawing.Point(0, 0);
            this.panelCardBack.Name = "panelCardBack";
            this.panelCardBack.Padding = new Wisej.Web.Padding(20);
            this.panelCardBack.Size = new System.Drawing.Size(440, 60);
            this.panelCardBack.TabIndex = 1;
            this.panelCardBack.Click += new System.EventHandler(this.panelCardBack_Click);
            // 
            // lb_regionNo
            // 
            this.lb_regionNo.Dock = Wisej.Web.DockStyle.Fill;
            this.lb_regionNo.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_regionNo.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.lb_regionNo.Location = new System.Drawing.Point(350, 20);
            this.lb_regionNo.Name = "lb_regionNo";
            this.lb_regionNo.Size = new System.Drawing.Size(70, 20);
            this.lb_regionNo.TabIndex = 4;
            this.lb_regionNo.Text = "5개 존";
            this.lb_regionNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_GroupName
            // 
            this.label_GroupName.Dock = Wisej.Web.DockStyle.Left;
            this.label_GroupName.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_GroupName.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.label_GroupName.Location = new System.Drawing.Point(50, 20);
            this.label_GroupName.Name = "label_GroupName";
            this.label_GroupName.Size = new System.Drawing.Size(300, 20);
            this.label_GroupName.TabIndex = 3;
            this.label_GroupName.Text = "파인동 전체 그룹";
            this.label_GroupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_GroupName.Click += new System.EventHandler(this.label_GroupName_Click);
            // 
            // lb_cardNo
            // 
            this.lb_cardNo.Dock = Wisej.Web.DockStyle.Left;
            this.lb_cardNo.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_cardNo.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.lb_cardNo.Location = new System.Drawing.Point(20, 20);
            this.lb_cardNo.Name = "lb_cardNo";
            this.lb_cardNo.Size = new System.Drawing.Size(30, 20);
            this.lb_cardNo.TabIndex = 5;
            this.lb_cardNo.Text = "1.";
            this.lb_cardNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Comp_GroupNameCard
            // 
            this.Controls.Add(this.panelCardBack);
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Name = "Comp_GroupNameCard";
            this.Size = new System.Drawing.Size(440, 60);
            this.panelCardBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panelCardBack;
        private Wisej.Web.Label label_GroupName;
        private Wisej.Web.Label lb_regionNo;
        private Wisej.Web.Label lb_cardNo;
    }
}
