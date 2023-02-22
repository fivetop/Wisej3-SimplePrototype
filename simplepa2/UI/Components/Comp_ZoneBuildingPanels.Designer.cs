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
            this.pn_FloorZone = new Wisej.Web.Panel();
            this.pn_Building = new Wisej.Web.Panel();
            this.panel1 = new Wisej.Web.Panel();
            this.lb_buildingName = new Wisej.Web.Label();
            this.ch_building = new Wisej.Web.CheckBox();
            this.pn_Building.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_FloorZone
            // 
            this.pn_FloorZone.AutoSize = true;
            this.pn_FloorZone.BackColor = System.Drawing.Color.White;
            this.pn_FloorZone.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_FloorZone.Location = new System.Drawing.Point(100, 0);
            this.pn_FloorZone.Margin = new Wisej.Web.Padding(0);
            this.pn_FloorZone.Name = "pn_FloorZone";
            this.pn_FloorZone.Size = new System.Drawing.Size(1280, 55);
            this.pn_FloorZone.TabIndex = 7;
            // 
            // pn_Building
            // 
            this.pn_Building.BackColor = System.Drawing.Color.White;
            this.pn_Building.Controls.Add(this.panel1);
            this.pn_Building.Dock = Wisej.Web.DockStyle.Left;
            this.pn_Building.Location = new System.Drawing.Point(0, 0);
            this.pn_Building.Margin = new Wisej.Web.Padding(0);
            this.pn_Building.Name = "pn_Building";
            this.pn_Building.Padding = new Wisej.Web.Padding(5, 0, 5, 0);
            this.pn_Building.Size = new System.Drawing.Size(100, 55);
            this.pn_Building.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel1.Controls.Add(this.lb_buildingName);
            this.panel1.Controls.Add(this.ch_building);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 55);
            this.panel1.TabIndex = 138;
            // 
            // lb_buildingName
            // 
            this.lb_buildingName.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lb_buildingName.AutoEllipsis = true;
            this.lb_buildingName.BackColor = System.Drawing.Color.Transparent;
            this.lb_buildingName.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_buildingName.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb_buildingName.Location = new System.Drawing.Point(-1, 4);
            this.lb_buildingName.Margin = new Wisej.Web.Padding(0);
            this.lb_buildingName.Name = "lb_buildingName";
            this.lb_buildingName.Size = new System.Drawing.Size(90, 24);
            this.lb_buildingName.TabIndex = 136;
            this.lb_buildingName.Text = "건물명";
            this.lb_buildingName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ch_building
            // 
            this.ch_building.Anchor = Wisej.Web.AnchorStyles.Left;
            this.ch_building.BackColor = System.Drawing.Color.Transparent;
            this.ch_building.BackgroundImageLayout = Wisej.Web.ImageLayout.OriginalSize;
            this.ch_building.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ch_building.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.ch_building.Location = new System.Drawing.Point(15, 29);
            this.ch_building.Name = "ch_building";
            this.ch_building.Size = new System.Drawing.Size(60, 23);
            this.ch_building.TabIndex = 137;
            this.ch_building.Text = "선택";
            this.ch_building.CheckedChanged += new System.EventHandler(this.ch_building_CheckedChanged);
            // 
            // Comp_ZoneBuildingPanels
            // 
            this.Controls.Add(this.pn_FloorZone);
            this.Controls.Add(this.pn_Building);
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Margin = new Wisej.Web.Padding(0);
            this.Name = "Comp_ZoneBuildingPanels";
            this.Size = new System.Drawing.Size(1380, 55);
            this.pn_Building.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel pn_FloorZone;
        private Wisej.Web.Panel pn_Building;
        private Wisej.Web.Label lb_buildingName;
        private Wisej.Web.CheckBox ch_building;
        private Wisej.Web.Panel panel1;
    }
}
