namespace simplepa2
{
    partial class Comp_UFloor
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
            this.panel1 = new Wisej.Web.Panel();
            this.Floor = new Wisej.Web.Label();
            this.f1 = new Wisej.Web.FlowLayoutPanel();
            this.shape1 = new Wisej.Web.Shape();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Floor);
            this.panel1.Dock = Wisej.Web.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.ForeColor = System.Drawing.Color.FromName("@bStatusRed");
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.MinimumSize = new System.Drawing.Size(90, 90);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.Size = new System.Drawing.Size(90, 98);
            this.panel1.TabIndex = 0;
            // 
            // Floor
            // 
            this.Floor.Dock = Wisej.Web.DockStyle.Fill;
            this.Floor.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Floor.ForeColor = System.Drawing.Color.Gray;
            this.Floor.Location = new System.Drawing.Point(0, 0);
            this.Floor.Name = "Floor";
            this.Floor.Padding = new Wisej.Web.Padding(5);
            this.Floor.Size = new System.Drawing.Size(90, 98);
            this.Floor.TabIndex = 0;
            this.Floor.Text = "Floor";
            this.Floor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Floor.Click += new System.EventHandler(this.label1_Click);
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.BackColor = System.Drawing.Color.Transparent;
            this.f1.Dock = Wisej.Web.DockStyle.Top;
            this.f1.Location = new System.Drawing.Point(95, 5);
            this.f1.MinimumSize = new System.Drawing.Size(0, 90);
            this.f1.Name = "f1";
            this.f1.Padding = new Wisej.Web.Padding(5);
            this.f1.Size = new System.Drawing.Size(329, 90);
            this.f1.TabIndex = 1;
            this.f1.SizeChanged += new System.EventHandler(this.f1_SizeChanged);
            // 
            // shape1
            // 
            this.shape1.BorderStyle.Color = System.Drawing.Color.FromArgb(91, 109, 205);
            this.shape1.BorderStyleBottom.Color = System.Drawing.Color.FromArgb(91, 109, 205);
            this.shape1.BorderStyleLeft.Color = System.Drawing.Color.FromArgb(91, 109, 205);
            this.shape1.BorderStyleRight.Color = System.Drawing.Color.FromArgb(91, 109, 205);
            this.shape1.BorderStyleTop.Color = System.Drawing.Color.FromArgb(91, 109, 205);
            this.shape1.Dock = Wisej.Web.DockStyle.Fill;
            this.shape1.Location = new System.Drawing.Point(5, 5);
            this.shape1.Name = "shape1";
            this.shape1.Size = new System.Drawing.Size(419, 98);
            // 
            // UFloor
            // 
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.f1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shape1);
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Name = "UFloor";
            this.Padding = new Wisej.Web.Padding(5, 5, 5, 0);
            this.Size = new System.Drawing.Size(429, 103);
            this.Load += new System.EventHandler(this.UFloor_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Label Floor;
        private Wisej.Web.FlowLayoutPanel f1;
        private Wisej.Web.Shape shape1;
    }
}
