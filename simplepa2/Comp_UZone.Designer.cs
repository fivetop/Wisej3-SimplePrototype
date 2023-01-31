namespace simplepa2
{
    partial class Comp_UZone
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new Wisej.Web.Panel();
            this.Zone = new Wisej.Web.Label();
            this.styleSheet1 = new Wisej.Web.StyleSheet(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel1.Controls.Add(this.Zone);
            this.styleSheet1.SetCssClass(this.panel1, "rounded");
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.Size = new System.Drawing.Size(108, 41);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "test";
            // 
            // Zone
            // 
            this.Zone.AutoSize = true;
            this.Zone.BackColor = System.Drawing.Color.Transparent;
            this.Zone.Dock = Wisej.Web.DockStyle.Fill;
            this.Zone.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Zone.ForeColor = System.Drawing.Color.Gray;
            this.Zone.Location = new System.Drawing.Point(0, 0);
            this.Zone.Name = "Zone";
            this.Zone.Padding = new Wisej.Web.Padding(5);
            this.Zone.Size = new System.Drawing.Size(106, 39);
            this.Zone.TabIndex = 0;
            this.Zone.Text = "label1";
            this.Zone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Zone.Click += new System.EventHandler(this.Zone_Click);
            // 
            // styleSheet1
            // 
            this.styleSheet1.Styles = "\r\n.rounded\r\n{\r\n    border-radius: 10px;\r\n}\r\n\r\n";
            // 
            // UZone
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "UZone";
            this.Padding = new Wisej.Web.Padding(5);
            this.Size = new System.Drawing.Size(118, 51);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.StyleSheet styleSheet1;
        private Wisej.Web.Label Zone;
    }
}
