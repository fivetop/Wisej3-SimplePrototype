﻿namespace simplepa2.UI.Views
{
    partial class View_BBCAmpFailover
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
            this.popTestButton = new Wisej.Web.Button();
            this.textBox1 = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // popTestButton
            // 
            this.popTestButton.Location = new System.Drawing.Point(726, 402);
            this.popTestButton.Name = "popTestButton";
            this.popTestButton.Size = new System.Drawing.Size(100, 27);
            this.popTestButton.TabIndex = 5;
            this.popTestButton.Text = "button1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Location = new System.Drawing.Point(446, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 32);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(162, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "방송설정-앰프Failover";
            // 
            // View_BBCAmpFailover
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.popTestButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCAmpFailover";
            this.Size = new System.Drawing.Size(1400, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button popTestButton;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.Label label1;
    }
}