namespace simplepa2.UI.Widget
{
    partial class Widget_DeviceHeatMap
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
            this.panel47 = new Wisej.Web.Panel();
            this.pn_chart = new Wisej.Web.Panel();
            this.justGage1 = new Wisej.Web.Ext.JustGage.JustGage();
            this.line4 = new Wisej.Web.Line();
            this.panel113 = new Wisej.Web.Panel();
            this.label53 = new Wisej.Web.Label();
            this.fpn_heatMap = new Wisej.Web.FlowLayoutPanel();
            this.panel34.SuspendLayout();
            this.panel47.SuspendLayout();
            this.pn_chart.SuspendLayout();
            this.panel113.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel34
            // 
            this.panel34.AutoSize = true;
            this.panel34.BackColor = System.Drawing.Color.White;
            this.panel34.Controls.Add(this.panel47);
            this.panel34.Controls.Add(this.line4);
            this.panel34.Controls.Add(this.panel113);
            this.panel34.Dock = Wisej.Web.DockStyle.Fill;
            this.panel34.Location = new System.Drawing.Point(0, 0);
            this.panel34.Name = "panel34";
            this.panel34.Padding = new Wisej.Web.Padding(20);
            this.panel34.Size = new System.Drawing.Size(900, 246);
            this.panel34.TabIndex = 165;
            // 
            // panel47
            // 
            this.panel47.AutoScroll = true;
            this.panel47.Controls.Add(this.fpn_heatMap);
            this.panel47.Controls.Add(this.pn_chart);
            this.panel47.Dock = Wisej.Web.DockStyle.Top;
            this.panel47.Location = new System.Drawing.Point(20, 58);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(860, 162);
            this.panel47.TabIndex = 164;
            // 
            // pn_chart
            // 
            this.pn_chart.Controls.Add(this.justGage1);
            this.pn_chart.Dock = Wisej.Web.DockStyle.Left;
            this.pn_chart.Location = new System.Drawing.Point(0, 0);
            this.pn_chart.Name = "pn_chart";
            this.pn_chart.Padding = new Wisej.Web.Padding(5);
            this.pn_chart.Size = new System.Drawing.Size(200, 162);
            this.pn_chart.TabIndex = 0;
            // 
            // justGage1
            // 
            this.justGage1.Dock = Wisej.Web.DockStyle.Fill;
            this.justGage1.Location = new System.Drawing.Point(5, 5);
            this.justGage1.Minimum = 1F;
            this.justGage1.Name = "justGage1";
            this.justGage1.Size = new System.Drawing.Size(190, 152);
            this.justGage1.TabIndex = 0;
            this.justGage1.Text = "Device Status";
            this.justGage1.Value = 5F;
            // 
            // line4
            // 
            this.line4.Dock = Wisej.Web.DockStyle.Top;
            this.line4.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line4.Location = new System.Drawing.Point(20, 57);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(860, 1);
            // 
            // panel113
            // 
            this.panel113.Controls.Add(this.label53);
            this.panel113.Dock = Wisej.Web.DockStyle.Top;
            this.panel113.Location = new System.Drawing.Point(20, 20);
            this.panel113.Name = "panel113";
            this.panel113.Size = new System.Drawing.Size(860, 37);
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
            this.label53.Text = "장비 상태 (히트맵";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fpn_heatMap
            // 
            this.fpn_heatMap.Dock = Wisej.Web.DockStyle.Fill;
            this.fpn_heatMap.Location = new System.Drawing.Point(200, 0);
            this.fpn_heatMap.Name = "fpn_heatMap";
            this.fpn_heatMap.Padding = new Wisej.Web.Padding(10);
            this.fpn_heatMap.ScrollBars = Wisej.Web.ScrollBars.Vertical;
            this.fpn_heatMap.ShowCloseButton = false;
            this.fpn_heatMap.Size = new System.Drawing.Size(660, 162);
            this.fpn_heatMap.TabIndex = 1;
            // 
            // Widget_DeviceHeatMap
            // 
            this.Controls.Add(this.panel34);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "Widget_DeviceHeatMap";
            this.Size = new System.Drawing.Size(900, 246);
            this.panel34.ResumeLayout(false);
            this.panel47.ResumeLayout(false);
            this.pn_chart.ResumeLayout(false);
            this.panel113.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel34;
        private Wisej.Web.Panel panel47;
        private Wisej.Web.Line line4;
        private Wisej.Web.Panel panel113;
        private Wisej.Web.Label label53;
        private Wisej.Web.Panel pn_chart;
        private Wisej.Web.Ext.JustGage.JustGage justGage1;
        private Wisej.Web.FlowLayoutPanel fpn_heatMap;
    }
}
