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
            this.panel11 = new Wisej.Web.Panel();
            this.panel10 = new Wisej.Web.Panel();
            this.ch_floor = new Wisej.Web.CheckBox();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel8.Controls.Add(this.flowLayoutPanel1);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Dock = Wisej.Web.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new Wisej.Web.Padding(20);
            this.panel8.Size = new System.Drawing.Size(1600, 180);
            this.panel8.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1560, 90);
            this.flowLayoutPanel1.TabIndex = 164;
            // 
            // panel11
            // 
            this.panel11.Dock = Wisej.Web.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(20, 50);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1560, 20);
            this.panel11.TabIndex = 136;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.ch_floor);
            this.panel10.Dock = Wisej.Web.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(20, 20);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1560, 30);
            this.panel10.TabIndex = 52;
            // 
            // ch_floor
            // 
            this.ch_floor.BackColor = System.Drawing.Color.Transparent;
            this.ch_floor.BackgroundImageLayout = Wisej.Web.ImageLayout.OriginalSize;
            this.ch_floor.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ch_floor.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.ch_floor.Location = new System.Drawing.Point(0, 0);
            this.ch_floor.Name = "ch_floor";
            this.ch_floor.Size = new System.Drawing.Size(52, 23);
            this.ch_floor.TabIndex = 3;
            this.ch_floor.Text = "1층";
            this.ch_floor.CheckedChanged += new System.EventHandler(this.ch_floor_CheckedChanged);
            // 
            // Comp_ZoneFloorCardList
            // 
            this.Controls.Add(this.panel8);
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Margin = new Wisej.Web.Padding(0);
            this.Name = "Comp_ZoneFloorCardList";
            this.Size = new System.Drawing.Size(1600, 180);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel8;
        private Wisej.Web.Panel panel10;
        private Wisej.Web.CheckBox ch_floor;
        private Wisej.Web.Panel panel11;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
    }
}
