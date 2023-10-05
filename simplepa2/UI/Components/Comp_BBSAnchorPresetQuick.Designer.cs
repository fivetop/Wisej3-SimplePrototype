namespace simplepa2.UI.Components
{
    partial class Comp_BBSAnchorPresetQuick
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
            this.panel34 = new Wisej.Web.Panel();
            this.panelList = new Wisej.Web.Panel();
            this.line4 = new Wisej.Web.Line();
            this.panel113 = new Wisej.Web.Panel();
            this.label53 = new Wisej.Web.Label();
            this.presetTableAdapter1 = new simplepa2.DataSet1TableAdapters.PresetTableAdapter();
            this.presetCTableAdapter1 = new simplepa2.DataSet1TableAdapters.PresetCTableAdapter();
            this.dataSet11 = new simplepa2.DataSet1();
            this.panel34.SuspendLayout();
            this.panel113.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel34
            // 
            this.panel34.AutoSize = true;
            this.panel34.BackColor = System.Drawing.Color.White;
            this.panel34.Controls.Add(this.panelList);
            this.panel34.Controls.Add(this.line4);
            this.panel34.Controls.Add(this.panel113);
            this.panel34.Dock = Wisej.Web.DockStyle.Fill;
            this.panel34.Location = new System.Drawing.Point(0, 0);
            this.panel34.Name = "panel34";
            this.panel34.Padding = new Wisej.Web.Padding(20);
            this.panel34.Size = new System.Drawing.Size(806, 170);
            this.panel34.TabIndex = 166;
            // 
            // panelList
            // 
            this.panelList.AutoScroll = true;
            this.panelList.Dock = Wisej.Web.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(20, 58);
            this.panelList.Name = "panelList";
            this.panelList.ShowCloseButton = false;
            this.panelList.Size = new System.Drawing.Size(766, 92);
            this.panelList.TabIndex = 164;
            // 
            // line4
            // 
            this.line4.Dock = Wisej.Web.DockStyle.Top;
            this.line4.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line4.Location = new System.Drawing.Point(20, 57);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(766, 1);
            // 
            // panel113
            // 
            this.panel113.Controls.Add(this.label53);
            this.panel113.Dock = Wisej.Web.DockStyle.Top;
            this.panel113.Location = new System.Drawing.Point(20, 20);
            this.panel113.Name = "panel113";
            this.panel113.Size = new System.Drawing.Size(766, 37);
            this.panel113.TabIndex = 161;
            // 
            // label53
            // 
            this.label53.AutoEllipsis = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label53.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label53.Location = new System.Drawing.Point(0, 0);
            this.label53.Margin = new Wisej.Web.Padding(0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(437, 24);
            this.label53.TabIndex = 134;
            this.label53.Text = "Preset Quick Bar";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // presetTableAdapter1
            // 
            this.presetTableAdapter1.ClearBeforeFill = true;
            // 
            // presetCTableAdapter1
            // 
            this.presetCTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Comp_BBSAnchorPresetQuick
            // 
            this.Controls.Add(this.panel34);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "Comp_BBSAnchorPresetQuick";
            this.Size = new System.Drawing.Size(806, 170);
            this.Load += new System.EventHandler(this.Comp_BBSAnchorPresetQuick_Load);
            this.panel34.ResumeLayout(false);
            this.panel113.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel34;
        private Wisej.Web.Panel panelList;
        private Wisej.Web.Line line4;
        private Wisej.Web.Panel panel113;
        private Wisej.Web.Label label53;
        private DataSet1TableAdapters.PresetTableAdapter presetTableAdapter1;
        private DataSet1TableAdapters.PresetCTableAdapter presetCTableAdapter1;
        private DataSet1 dataSet11;
    }
}
