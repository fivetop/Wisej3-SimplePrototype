namespace simplepa2.win
{
    partial class ASchedule
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
            this.panel5 = new Wisej.Web.Panel();
            this.splitContainer3 = new Wisej.Web.SplitContainer();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel5.Controls.Add(this.splitContainer3);
            this.panel5.Dock = Wisej.Web.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new Wisej.Web.Padding(4);
            this.panel5.ShowCloseButton = false;
            this.panel5.Size = new System.Drawing.Size(900, 600);
            this.panel5.TabIndex = 9;
            this.panel5.TabStop = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(4, 4);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center;
            this.splitContainer3.Panel2.ShowCloseButton = false;
            this.splitContainer3.Panel2.ShowHeader = true;
            this.splitContainer3.Panel2.Text = "Scheduler";
            this.splitContainer3.Size = new System.Drawing.Size(890, 590);
            this.splitContainer3.SplitterDistance = 121;
            this.splitContainer3.TabIndex = 5;
            // 
            // ASchedule
            // 
            this.Controls.Add(this.panel5);
            this.Name = "ASchedule";
            this.Size = new System.Drawing.Size(900, 600);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel5;
        private Wisej.Web.SplitContainer splitContainer3;
    }
}
