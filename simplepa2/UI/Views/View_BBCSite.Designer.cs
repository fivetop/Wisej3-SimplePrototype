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
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.panel1 = new Wisej.Web.Panel();
            this.comboBoxView2 = new Wisej.Web.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1400, 850);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxView2);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 50);
            this.panel1.TabIndex = 0;
            this.comboBoxView2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxView2.LabelText = "View";
            this.comboBoxView2.Location = new System.Drawing.Point(510, 3);
            this.comboBoxView2.Name = "comboBoxView2";
            this.comboBoxView2.Size = new System.Drawing.Size(213, 42);
            this.comboBoxView2.TabIndex = 6;
            this.comboBoxView2.Text = "LeftToRight";
            this.comboBoxView2.SelectedIndexChanged += new System.EventHandler(this.comboBoxView2_SelectedIndexChanged);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCSite";
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.View_BBCSite_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.ComboBox comboBoxView2;
    }
}
