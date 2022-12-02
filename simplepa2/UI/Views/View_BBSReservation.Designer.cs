namespace simplepa2.UI.Views
{
    partial class View_BBSReservation
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
            this.panel2 = new Wisej.Web.Panel();
            this.panel4 = new Wisej.Web.Panel();
            this.panel5 = new Wisej.Web.Panel();
            this.panel6 = new Wisej.Web.Panel();
            this.panel136 = new Wisej.Web.Panel();
            this.label66 = new Wisej.Web.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel136.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel136);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1360, 860);
            this.panel2.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = Wisej.Web.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.panel4.Location = new System.Drawing.Point(20, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1320, 768);
            this.panel4.TabIndex = 124;
            this.panel4.Text = "listPanel";
            // 
            // panel5
            // 
            this.panel5.Dock = Wisej.Web.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1320, 20);
            this.panel5.TabIndex = 129;
            // 
            // panel6
            // 
            this.panel6.Dock = Wisej.Web.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1320, 20);
            this.panel6.TabIndex = 127;
            // 
            // panel136
            // 
            this.panel136.BackColor = System.Drawing.Color.Transparent;
            this.panel136.Controls.Add(this.label66);
            this.panel136.Dock = Wisej.Web.DockStyle.Top;
            this.panel136.Location = new System.Drawing.Point(20, 20);
            this.panel136.Name = "panel136";
            this.panel136.Size = new System.Drawing.Size(1320, 52);
            this.panel136.TabIndex = 123;
            // 
            // label66
            // 
            this.label66.CssStyle = "\r\n";
            this.label66.Font = new System.Drawing.Font("@boxTitle", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label66.Location = new System.Drawing.Point(0, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(418, 32);
            this.label66.TabIndex = 33;
            this.label66.Text = "예약 방송 내역";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // View_BBSReservation
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Margin = new Wisej.Web.Padding(0);
            this.Name = "View_BBSReservation";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.View_BBSReservation_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel136.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.Panel panel6;
        private Wisej.Web.Panel panel136;
        private Wisej.Web.Label label66;
    }
}
