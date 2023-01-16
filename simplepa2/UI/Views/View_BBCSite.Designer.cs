namespace simplepa2.UI.Views
{
    partial class View_BBCSite
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
            this.pn_contents = new Wisej.Web.Panel();
            this.pn_Spacer = new Wisej.Web.Panel();
            this.pn_listFrame = new Wisej.Web.Panel();
            this.fpn_sitePanel = new Wisej.Web.FlowLayoutPanel();
            this.pn_siteBar = new Wisej.Web.Panel();
            this.label23 = new Wisej.Web.Label();
            this.dataSet11 = new simplepa2.DataSet1();
            this.emServerNDeviceNameTableAdapter1 = new simplepa2.DataSet1TableAdapters.EMServerNDeviceNameTableAdapter();
            this.panel1.SuspendLayout();
            this.pn_listFrame.SuspendLayout();
            this.pn_siteBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pn_contents);
            this.panel1.Controls.Add(this.pn_Spacer);
            this.panel1.Controls.Add(this.pn_listFrame);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 860);
            this.panel1.TabIndex = 50;
            // 
            // pn_contents
            // 
            this.pn_contents.BackColor = System.Drawing.Color.White;
            this.pn_contents.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_contents.Location = new System.Drawing.Point(660, 0);
            this.pn_contents.Name = "pn_contents";
            this.pn_contents.Size = new System.Drawing.Size(700, 860);
            this.pn_contents.TabIndex = 180;
            // 
            // pn_Spacer
            // 
            this.pn_Spacer.BackColor = System.Drawing.Color.Transparent;
            this.pn_Spacer.Dock = Wisej.Web.DockStyle.Left;
            this.pn_Spacer.Location = new System.Drawing.Point(640, 0);
            this.pn_Spacer.Name = "pn_Spacer";
            this.pn_Spacer.Size = new System.Drawing.Size(20, 860);
            this.pn_Spacer.TabIndex = 179;
            // 
            // pn_listFrame
            // 
            this.pn_listFrame.BackColor = System.Drawing.Color.White;
            this.pn_listFrame.Controls.Add(this.fpn_sitePanel);
            this.pn_listFrame.Controls.Add(this.pn_siteBar);
            this.pn_listFrame.Dock = Wisej.Web.DockStyle.Left;
            this.pn_listFrame.Location = new System.Drawing.Point(0, 0);
            this.pn_listFrame.Name = "pn_listFrame";
            this.pn_listFrame.Padding = new Wisej.Web.Padding(20);
            this.pn_listFrame.Size = new System.Drawing.Size(640, 860);
            this.pn_listFrame.TabIndex = 178;
            // 
            // fpn_sitePanel
            // 
            this.fpn_sitePanel.Dock = Wisej.Web.DockStyle.Fill;
            this.fpn_sitePanel.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.fpn_sitePanel.Location = new System.Drawing.Point(20, 72);
            this.fpn_sitePanel.Name = "fpn_sitePanel";
            this.fpn_sitePanel.Size = new System.Drawing.Size(600, 768);
            this.fpn_sitePanel.TabIndex = 51;
            // 
            // pn_siteBar
            // 
            this.pn_siteBar.BackColor = System.Drawing.Color.Transparent;
            this.pn_siteBar.Controls.Add(this.label23);
            this.pn_siteBar.Dock = Wisej.Web.DockStyle.Top;
            this.pn_siteBar.Location = new System.Drawing.Point(20, 20);
            this.pn_siteBar.Name = "pn_siteBar";
            this.pn_siteBar.Size = new System.Drawing.Size(600, 52);
            this.pn_siteBar.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.CssStyle = "\r\n";
            this.label23.Font = new System.Drawing.Font("@boxTitle", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(223, 32);
            this.label23.TabIndex = 33;
            this.label23.Text = "등록 사이트";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emServerNDeviceNameTableAdapter1
            // 
            this.emServerNDeviceNameTableAdapter1.ClearBeforeFill = true;
            // 
            // View_BBCSite
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel1);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCSite";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.View_BBCSite_Load);
            this.panel1.ResumeLayout(false);
            this.pn_listFrame.ResumeLayout(false);
            this.pn_siteBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel pn_listFrame;
        private Wisej.Web.Panel pn_siteBar;
        private Wisej.Web.Label label23;
        private Wisej.Web.Panel pn_Spacer;
        private DataSet1 dataSet11;
        private Wisej.Web.FlowLayoutPanel fpn_sitePanel;
        private Wisej.Web.Panel pn_contents;
        private DataSet1TableAdapters.EMServerNDeviceNameTableAdapter emServerNDeviceNameTableAdapter1;
    }
}
