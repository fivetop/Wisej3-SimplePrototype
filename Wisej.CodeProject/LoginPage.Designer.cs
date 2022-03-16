namespace Wisej.CodeProject
{
    partial class LoginPage
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
            this.linkLabel1 = new Wisej.Web.LinkLabel();
            this.button1 = new Wisej.Web.Button();
            this.textBox2 = new Wisej.Web.TextBox();
            this.textBox1 = new Wisej.Web.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Dotted;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center;
            this.panel1.HeaderBackColor = System.Drawing.Color.FromArgb(255, 167, 0);
            this.panel1.HeaderSize = 40;
            this.panel1.Location = new System.Drawing.Point(193, 78);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(421, 344);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            this.panel1.Text = "LOGIN";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(247, 240);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.Text = "Forgot password";
            this.linkLabel1.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOGIN";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.AutoSize = false;
            this.textBox2.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.textBox2.Location = new System.Drawing.Point(63, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(292, 38);
            this.textBox2.TabIndex = 1;
            this.textBox2.Watermark = "Password";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.Location = new System.Drawing.Point(63, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Watermark = "User Name";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(807, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Panel panel1;
        private Web.LinkLabel linkLabel1;
        private Web.Button button1;
        private Web.TextBox textBox2;
        private Web.TextBox textBox1;
    }
}
