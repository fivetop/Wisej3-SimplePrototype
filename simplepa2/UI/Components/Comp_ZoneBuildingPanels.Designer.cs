namespace simplepa2.UI.Components
{
    partial class Comp_ZoneBuildingPanels
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
            this.pn_main = new Wisej.Web.Panel();
            this.panel10 = new Wisej.Web.Panel();
            this.lb_buildingName = new Wisej.Web.Label();
            this.label22 = new Wisej.Web.Label();
            this.pn_main.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_main
            // 
            this.pn_main.AutoSize = true;
            this.pn_main.BackColor = System.Drawing.Color.White;
            this.pn_main.Controls.Add(this.panel10);
            this.pn_main.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 0);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1380, 41);
            this.pn_main.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.lb_buildingName);
            this.panel10.Controls.Add(this.label22);
            this.panel10.Dock = Wisej.Web.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1380, 40);
            this.panel10.TabIndex = 52;
            // 
            // lb_buildingName
            // 
            this.lb_buildingName.AutoEllipsis = true;
            this.lb_buildingName.BackColor = System.Drawing.Color.Transparent;
            this.lb_buildingName.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_buildingName.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb_buildingName.Location = new System.Drawing.Point(39, 7);
            this.lb_buildingName.Margin = new Wisej.Web.Padding(0);
            this.lb_buildingName.Name = "lb_buildingName";
            this.lb_buildingName.Size = new System.Drawing.Size(344, 24);
            this.lb_buildingName.TabIndex = 136;
            this.lb_buildingName.Text = "건물명";
            this.lb_buildingName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoEllipsis = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(91, 153, 255);
            this.label22.CssStyle = "border-radius: 11px;";
            this.label22.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label22.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.label22.Location = new System.Drawing.Point(7, 10);
            this.label22.Margin = new Wisej.Web.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 22);
            this.label22.TabIndex = 135;
            this.label22.Text = "★";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comp_ZoneBuildingPanels
            // 
            this.Controls.Add(this.pn_main);
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Name = "Comp_ZoneBuildingPanels";
            this.Size = new System.Drawing.Size(1380, 41);
            this.pn_main.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel pn_main;
        private Wisej.Web.Panel panel10;
        private Wisej.Web.Label lb_buildingName;
        private Wisej.Web.Label label22;
    }
}
