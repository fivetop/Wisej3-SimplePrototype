namespace simplepa2.UI.Components
{
    partial class Comp_GroupNameCard
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
            this.panelCardBack = new Wisej.Web.Panel();
            this.label_GroupName = new Wisej.Web.Label();
            this.panelCardBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCardBack
            // 
            this.panelCardBack.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panelCardBack.Controls.Add(this.label_GroupName);
            this.panelCardBack.Dock = Wisej.Web.DockStyle.Fill;
            this.panelCardBack.Location = new System.Drawing.Point(0, 0);
            this.panelCardBack.Name = "panelCardBack";
            this.panelCardBack.Size = new System.Drawing.Size(523, 60);
            this.panelCardBack.TabIndex = 1;
            this.panelCardBack.Click += new System.EventHandler(this.panelCardBack_Click);
            // 
            // label_GroupName
            // 
            this.label_GroupName.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_GroupName.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.label_GroupName.Location = new System.Drawing.Point(20, 18);
            this.label_GroupName.Name = "label_GroupName";
            this.label_GroupName.Size = new System.Drawing.Size(491, 20);
            this.label_GroupName.TabIndex = 3;
            this.label_GroupName.Text = "파인동 전체 그룹";
            this.label_GroupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Comp_GroupNameCard
            // 
            this.Controls.Add(this.panelCardBack);
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Name = "Comp_GroupNameCard";
            this.Size = new System.Drawing.Size(523, 60);
            this.panelCardBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panelCardBack;
        private Wisej.Web.Label label_GroupName;
    }
}
