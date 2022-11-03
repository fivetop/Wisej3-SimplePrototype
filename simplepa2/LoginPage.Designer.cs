namespace simplepa2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.panel1 = new Wisej.Web.Panel();
            this.linkLabel1 = new Wisej.Web.LinkLabel();
            this.button1 = new Wisej.Web.Button();
            this.tloginpw = new Wisej.Web.TextBox();
            this.tloginid = new Wisej.Web.TextBox();
            this.dataSet1 = new simplepa2.DataSet1();
            this.userTreesBindingSource = new Wisej.Web.BindingSource(this.components);
            this.userTreesTableAdapter = new simplepa2.DataSet1TableAdapters.UserTreesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTreesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Dotted;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tloginpw);
            this.panel1.Controls.Add(this.tloginid);
            this.panel1.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center;
            this.panel1.HeaderBackColor = System.Drawing.Color.FromArgb(255, 167, 0);
            this.panel1.HeaderSize = 40;
            this.panel1.Location = new System.Drawing.Point(184, 160);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.Size = new System.Drawing.Size(319, 216);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(192, 186);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.Text = "Forgot password";
            this.linkLabel1.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOGIN";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tloginpw
            // 
            this.tloginpw.AutoSize = false;
            this.tloginpw.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.tloginpw.Location = new System.Drawing.Point(8, 64);
            this.tloginpw.Name = "tloginpw";
            this.tloginpw.PasswordChar = '*';
            this.tloginpw.Size = new System.Drawing.Size(292, 38);
            this.tloginpw.TabIndex = 1;
            this.tloginpw.Watermark = "Log-In Password";
            // 
            // tloginid
            // 
            this.tloginid.AutoSize = false;
            this.tloginid.Location = new System.Drawing.Point(8, 3);
            this.tloginid.Name = "tloginid";
            this.tloginid.Size = new System.Drawing.Size(292, 38);
            this.tloginid.TabIndex = 0;
            this.tloginid.Watermark = "Log-In ID";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTreesBindingSource
            // 
            this.userTreesBindingSource.DataMember = "UserTrees";
            this.userTreesBindingSource.DataSource = this.dataSet1;
            // 
            // userTreesTableAdapter
            // 
            this.userTreesTableAdapter.ClearBeforeFill = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.Controls.Add(this.panel1);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(695, 450);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTreesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.LinkLabel linkLabel1;
        private Wisej.Web.Button button1;
        private Wisej.Web.TextBox tloginpw;
        private Wisej.Web.TextBox tloginid;
        private DataSet1 dataSet1;
        private Wisej.Web.BindingSource userTreesBindingSource;
        private DataSet1TableAdapters.UserTreesTableAdapter userTreesTableAdapter;
    }
}
