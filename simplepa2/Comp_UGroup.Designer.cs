namespace simplepa2
{
    partial class Comp_UGroup
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
            this.panel90 = new Wisej.Web.Panel();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.label31 = new Wisej.Web.Label();
            this.panel1 = new Wisej.Web.Panel();
            this.comp_UAsset1 = new simplepa2.Comp_UAsset();
            this.panel90.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel90
            // 
            this.panel90.Controls.Add(this.comboBox2);
            this.panel90.Controls.Add(this.label31);
            this.panel90.Dock = Wisej.Web.DockStyle.Top;
            this.panel90.Location = new System.Drawing.Point(4, 4);
            this.panel90.Name = "panel90";
            this.panel90.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel90.Size = new System.Drawing.Size(453, 42);
            this.panel90.TabIndex = 165;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoSize = false;
            this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox2.Location = new System.Drawing.Point(94, 0);
            this.comboBox2.Margin = new Wisej.Web.Padding(0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 36);
            this.comboBox2.TabIndex = 137;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.AutoEllipsis = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label31.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label31.Location = new System.Drawing.Point(9, 0);
            this.label31.Margin = new Wisej.Web.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(85, 36);
            this.label31.TabIndex = 136;
            this.label31.Text = "선택 지역";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.comp_UAsset1);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 46);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.Size = new System.Drawing.Size(453, 232);
            this.panel1.TabIndex = 166;
            // 
            // comp_UAsset1
            // 
            this.comp_UAsset1.AutoScroll = true;
            this.comp_UAsset1.Dock = Wisej.Web.DockStyle.Fill;
            this.comp_UAsset1.Name = "comp_UAsset1";
            this.comp_UAsset1.Size = new System.Drawing.Size(453, 232);
            this.comp_UAsset1.TabIndex = 0;
            // 
            // Comp_UGroup
            // 
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel90);
            this.Name = "Comp_UGroup";
            this.Padding = new Wisej.Web.Padding(4);
            this.Size = new System.Drawing.Size(461, 282);
            this.panel90.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Comp_UAsset comp_UAsset1;
        private Wisej.Web.Panel panel90;
        private Wisej.Web.ComboBox comboBox2;
        private Wisej.Web.Label label31;
        private Wisej.Web.Panel panel1;
    }
}
