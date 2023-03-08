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
            this.panel8 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.panel10 = new Wisej.Web.Panel();
            this.panel1 = new Wisej.Web.Panel();
            this.ch_floor = new Wisej.Web.CheckBox();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.flowLayoutPanel1);
            this.panel8.Dock = Wisej.Web.DockStyle.Fill;
            this.panel8.HeaderForeColor = System.Drawing.Color.Transparent;
            this.panel8.Location = new System.Drawing.Point(100, 0);
            this.panel8.Margin = new Wisej.Web.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new Wisej.Web.Padding(5);
            this.panel8.Size = new System.Drawing.Size(1500, 50);
            this.panel8.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Margin = new Wisej.Web.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1490, 40);
            this.flowLayoutPanel1.TabIndex = 164;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Dock = Wisej.Web.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new Wisej.Web.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new Wisej.Web.Padding(0, 5, 0, 5);
            this.panel10.Size = new System.Drawing.Size(100, 50);
            this.panel10.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel1.Controls.Add(this.ch_floor);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Margin = new Wisej.Web.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 40);
            this.panel1.TabIndex = 4;
            // 
            // ch_floor
            // 
            this.ch_floor.Anchor = Wisej.Web.AnchorStyles.Left;
            this.ch_floor.BackColor = System.Drawing.Color.Transparent;
            this.ch_floor.BackgroundImageLayout = Wisej.Web.ImageLayout.OriginalSize;
            this.ch_floor.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ch_floor.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.ch_floor.Location = new System.Drawing.Point(5, 10);
            this.ch_floor.Name = "ch_floor";
            this.ch_floor.Size = new System.Drawing.Size(50, 22);
            this.ch_floor.TabIndex = 3;
            this.ch_floor.Text = "1층";
            this.ch_floor.CheckedChanged += new System.EventHandler(this.ch_floor_CheckedChanged);
            // 
            // Comp_ZoneFloorCardList
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel10);
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Margin = new Wisej.Web.Padding(0);
            this.Name = "Comp_ZoneFloorCardList";
            this.Size = new System.Drawing.Size(1600, 50);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel8;
        private Wisej.Web.Panel panel10;
        private Wisej.Web.CheckBox ch_floor;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Panel panel1;
    }
}
