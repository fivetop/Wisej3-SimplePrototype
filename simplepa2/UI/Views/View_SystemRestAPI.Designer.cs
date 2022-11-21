namespace simplepa2.UI.Views
{
    partial class View_SystemRestAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_SystemRestAPI));
            this.panel2 = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.label3 = new Wisej.Web.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(175, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 860);
            this.panel2.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.button1.CssStyle = resources.GetString("button1.CssStyle");
            this.button1.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button1.Location = new System.Drawing.Point(930, 807);
            this.button1.Margin = new Wisej.Web.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "키 재생성";
            // 
            // label3
            // 
            this.label3.CssStyle = "display: block;\r\n    height: 32px;\r\n    line-height: 32px;\r\n    text-align: left;" +
    "\r\n    color: #111;\r\n    font-size: 18px;\r\n    font-weight: 500;\r\n";
            this.label3.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Rest API";
            // 
            // View_SystemRestAPI
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_SystemRestAPI";
            this.Size = new System.Drawing.Size(1400, 900);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.Button button1;
        private Wisej.Web.Label label3;
    }
}
