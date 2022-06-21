using Wisej.Web;

namespace Wisej.CodeProject
{
    partial class UserControl1
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

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new Wisej.Web.Label();
            this.panel1 = new Wisej.Web.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(3);
            this.panel1.Size = new System.Drawing.Size(282, 60);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = true;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // UserControl1
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Padding = new Wisej.Web.Padding(3);
            this.Size = new System.Drawing.Size(296, 86);
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Panel panel1;
    }
}