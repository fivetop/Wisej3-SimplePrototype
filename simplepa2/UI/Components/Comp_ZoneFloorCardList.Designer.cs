namespace simplepa2.UI.Components
{
    partial class Comp_ZoneFloorCardList
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
            this.panel7 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.panel1 = new Wisej.Web.Panel();
            this.floorCheck = new Wisej.Web.CheckBox();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel7.Controls.Add(this.flowLayoutPanel1);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Dock = Wisej.Web.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1390, 90);
            this.panel7.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1390, 55);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.floorCheck);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 35);
            this.panel1.TabIndex = 21;
            // 
            // floorCheck
            // 
            this.floorCheck.BackColor = System.Drawing.Color.Transparent;
            this.floorCheck.BackgroundImageLayout = Wisej.Web.ImageLayout.OriginalSize;
            this.floorCheck.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.floorCheck.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.floorCheck.Location = new System.Drawing.Point(12, 5);
            this.floorCheck.Name = "floorCheck";
            this.floorCheck.Size = new System.Drawing.Size(72, 24);
            this.floorCheck.TabIndex = 2;
            this.floorCheck.Text = "nFloor";
            this.floorCheck.CheckedChanged += new System.EventHandler(this.floorCheck_CheckedChanged);
            // 
            // Comp_ZoneFloorCardList
            // 
            this.Controls.Add(this.panel7);
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Name = "Comp_ZoneFloorCardList";
            this.Padding = new Wisej.Web.Padding(5);
            this.Size = new System.Drawing.Size(1400, 100);
            this.Load += new System.EventHandler(this.Comp_ZoneFloorCardList_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel7;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.CheckBox floorCheck;
    }
}
