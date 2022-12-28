namespace simplepa2.UI.Pages
{
    partial class PA_Login
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
            this.dataSet1 = new simplepa2.DataSet1();
            this.userTreesBindingSource = new Wisej.Web.BindingSource(this.components);
            this.userTreesTableAdapter = new simplepa2.DataSet1TableAdapters.UserTreesTableAdapter();
            this.panel2 = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.panel4 = new Wisej.Web.Panel();
            this.tloginpw = new Wisej.Web.TextBox();
            this.panel5 = new Wisej.Web.Panel();
            this.tloginid = new Wisej.Web.TextBox();
            this.panel1 = new Wisej.Web.Panel();
            this.label3 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.linkLabel2 = new Wisej.Web.LinkLabel();
            this.panel3 = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTreesBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel2.AppearanceKey = "rounded-panel";
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tloginpw);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.tloginid);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.CssStyle = "border-radius:30px;";
            this.panel2.Location = new System.Drawing.Point(309, 145);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(48);
            this.panel2.Size = new System.Drawing.Size(392, 476);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = Wisej.Web.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("ns700", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.Location = new System.Drawing.Point(48, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "로그인";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel4
            // 
            this.panel4.Dock = Wisej.Web.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(48, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 34);
            this.panel4.TabIndex = 17;
            // 
            // tloginpw
            // 
            this.tloginpw.AutoSize = false;
            this.tloginpw.Dock = Wisej.Web.DockStyle.Top;
            this.tloginpw.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.tloginpw.Location = new System.Drawing.Point(48, 220);
            this.tloginpw.Name = "tloginpw";
            this.tloginpw.PasswordChar = '*';
            this.tloginpw.Size = new System.Drawing.Size(296, 38);
            this.tloginpw.TabIndex = 16;
            this.tloginpw.Watermark = "비밀번호";
            // 
            // panel5
            // 
            this.panel5.Dock = Wisej.Web.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(48, 186);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 34);
            this.panel5.TabIndex = 15;
            // 
            // tloginid
            // 
            this.tloginid.AutoSize = false;
            this.tloginid.Dock = Wisej.Web.DockStyle.Top;
            this.tloginid.Location = new System.Drawing.Point(48, 148);
            this.tloginid.Name = "tloginid";
            this.tloginid.Size = new System.Drawing.Size(296, 38);
            this.tloginid.TabIndex = 14;
            this.tloginid.Watermark = "아이디";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(48, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 100);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("@ns400", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(36, 36, 36);
            this.label3.Location = new System.Drawing.Point(0, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "아이디와 비밀번호를 입력하세요";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("ns700", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "로그인";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromName("@button1BG");
            this.linkLabel2.CausesValidation = false;
            this.linkLabel2.Font = new System.Drawing.Font("@ns500", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.linkLabel2.ForeColor = System.Drawing.Color.FromName("@button1BG");
            this.linkLabel2.LinkColor = System.Drawing.Color.FromName("@button1BG");
            this.linkLabel2.Location = new System.Drawing.Point(51, 371);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(185, 24);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.Text = "비밀번호를 잊으셨습니까?";
            // 
            // panel3
            // 
            this.panel3.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.CssStyle = "background: url(../images/login-logo.png) center no-repeat;\r\nbackground-size: 300" +
    "px 72px;";
            this.panel3.HeaderForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(357, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 72);
            this.panel3.TabIndex = 3;
            // 
            // PA_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.BackgroundImageSource = "Images/login-bg.jpg";
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "PA_Login";
            this.Size = new System.Drawing.Size(945, 599);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTreesBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private Wisej.Web.BindingSource userTreesBindingSource;
        private DataSet1TableAdapters.UserTreesTableAdapter userTreesTableAdapter;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.LinkLabel linkLabel2;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button button1;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.TextBox tloginpw;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.TextBox tloginid;
        private Wisej.Web.Panel panel3;
    }
}
