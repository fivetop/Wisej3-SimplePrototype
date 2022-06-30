namespace Wisej.CodeProject
{
    partial class MUser
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
            Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
            this.udataGridView1 = new Wisej.Web.DataGridView();
            this.colUsertreeid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colUser_Name = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLogin_Id = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colMobile = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colUser_Group = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ubindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.utextpassword2 = new Wisej.Web.TextBox();
            this.utextpassword = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.utextusername = new Wisej.Web.TextBox();
            this.ucomboBox1 = new Wisej.Web.ComboBox();
            this.label2 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.utextloginid = new Wisej.Web.TextBox();
            this.label8 = new Wisej.Web.Label();
            this.label7 = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            this.umaskedTextBox1 = new Wisej.Web.MaskedTextBox();
            this.label5 = new Wisej.Web.Label();
            this.utextBox3 = new Wisej.Web.TextBox();
            this.userTreesTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.UserTreesTableAdapter();
            this.ubutton3 = new Wisej.Web.Button();
            this.ubutton2 = new Wisej.Web.Button();
            this.ubutton1 = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.udataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // udataGridView1
            // 
            this.udataGridView1.AutoGenerateColumns = false;
            this.udataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colUsertreeid,
            this.colUser_Name,
            this.colLogin_Id,
            this.colEmail,
            this.colMobile,
            this.colUser_Group});
            this.udataGridView1.DataSource = this.ubindingSource1;
            this.udataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.udataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.udataGridView1.Location = new System.Drawing.Point(0, 0);
            this.udataGridView1.Name = "udataGridView1";
            this.udataGridView1.Size = new System.Drawing.Size(683, 392);
            this.udataGridView1.TabIndex = 1;
            // 
            // colUsertreeid
            // 
            this.colUsertreeid.DataPropertyName = "UserTreeId";
            this.colUsertreeid.HeaderText = "No";
            this.colUsertreeid.Name = "colUsertreeid";
            this.colUsertreeid.ReadOnly = true;
            this.colUsertreeid.Width = 60;
            // 
            // colUser_Name
            // 
            this.colUser_Name.DataPropertyName = "user_name";
            this.colUser_Name.HeaderText = "사용자명";
            this.colUser_Name.Name = "colUser_Name";
            // 
            // colLogin_Id
            // 
            this.colLogin_Id.DataPropertyName = "login_id";
            this.colLogin_Id.HeaderText = "로그인아이디";
            this.colLogin_Id.Name = "colLogin_Id";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "이메일";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 150;
            // 
            // colMobile
            // 
            this.colMobile.DataPropertyName = "mobile";
            this.colMobile.HeaderText = "전화번호";
            this.colMobile.Name = "colMobile";
            // 
            // colUser_Group
            // 
            this.colUser_Group.DataPropertyName = "user_group";
            this.colUser_Group.HeaderText = "사용자권한";
            this.colUser_Group.Name = "colUser_Group";
            // 
            // ubindingSource1
            // 
            this.ubindingSource1.DataMember = "UserTrees";
            this.ubindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.utextpassword2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.utextpassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.utextusername, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.utextloginid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ucomboBox1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.umaskedTextBox1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.utextBox3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // utextpassword2
            // 
            this.utextpassword2.AutoSize = false;
            this.utextpassword2.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "login_password2", true));
            this.utextpassword2.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.utextpassword2.Location = new System.Drawing.Point(8, 121);
            this.utextpassword2.Margin = new Wisej.Web.Padding(8);
            this.utextpassword2.Name = "utextpassword2";
            this.utextpassword2.PasswordChar = '*';
            this.utextpassword2.Size = new System.Drawing.Size(161, 26);
            this.utextpassword2.TabIndex = 15;
            this.utextpassword2.Watermark = "Enter a name";
            // 
            // utextpassword
            // 
            this.utextpassword.AutoSize = false;
            this.utextpassword.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "login_password", true));
            this.utextpassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.utextpassword.Location = new System.Drawing.Point(204, 121);
            this.utextpassword.Margin = new Wisej.Web.Padding(8);
            this.utextpassword.Name = "utextpassword";
            this.utextpassword.PasswordChar = '*';
            this.utextpassword.Size = new System.Drawing.Size(144, 26);
            this.utextpassword.TabIndex = 14;
            this.utextpassword.Watermark = "Enter a name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new Wisej.Web.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // utextusername
            // 
            this.utextusername.AutoSize = false;
            this.utextusername.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "user_name", true));
            this.utextusername.Dock = Wisej.Web.DockStyle.Fill;
            this.utextusername.Location = new System.Drawing.Point(8, 34);
            this.utextusername.Margin = new Wisej.Web.Padding(8);
            this.utextusername.Name = "utextusername";
            this.utextusername.Size = new System.Drawing.Size(180, 20);
            this.utextusername.TabIndex = 1;
            this.utextusername.Watermark = "Enter a name";
            // 
            // ucomboBox1
            // 
            this.ucomboBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.ucomboBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "user_group", true));
            this.ucomboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.ucomboBox1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.ucomboBox1.Location = new System.Drawing.Point(8, 193);
            this.ucomboBox1.Margin = new Wisej.Web.Padding(8);
            this.ucomboBox1.Name = "ucomboBox1";
            this.ucomboBox1.Size = new System.Drawing.Size(180, 22);
            this.ucomboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = Wisej.Web.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(196, 0);
            this.label2.Margin = new Wisej.Web.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "&LogIn ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 163);
            this.label4.Margin = new Wisej.Web.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Level";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // utextloginid
            // 
            this.utextloginid.AutoSize = false;
            this.utextloginid.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "login_id", true));
            this.utextloginid.Dock = Wisej.Web.DockStyle.Fill;
            this.utextloginid.Location = new System.Drawing.Point(204, 34);
            this.utextloginid.Margin = new Wisej.Web.Padding(8);
            this.utextloginid.Name = "utextloginid";
            this.utextloginid.Size = new System.Drawing.Size(181, 20);
            this.utextloginid.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 62);
            this.label8.Margin = new Wisej.Web.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(196, 62);
            this.label7.Margin = new Wisej.Web.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password(확인)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label6.Location = new System.Drawing.Point(196, 161);
            this.label6.Margin = new Wisej.Web.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "&Mobile";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // umaskedTextBox1
            // 
            this.umaskedTextBox1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.umaskedTextBox1.AutoSize = false;
            this.umaskedTextBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "mobile", true));
            this.umaskedTextBox1.Location = new System.Drawing.Point(199, 188);
            this.umaskedTextBox1.Mask = "(999) 000-0000";
            this.umaskedTextBox1.Name = "umaskedTextBox1";
            this.umaskedTextBox1.Size = new System.Drawing.Size(191, 34);
            this.umaskedTextBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 225);
            this.label5.Margin = new Wisej.Web.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "E&Mail";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // utextBox3
            // 
            this.utextBox3.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.utextBox3.AutoSize = false;
            this.utextBox3.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "email", true));
            this.utextBox3.Location = new System.Drawing.Point(199, 228);
            this.utextBox3.Name = "utextBox3";
            this.utextBox3.Size = new System.Drawing.Size(191, 27);
            this.utextBox3.TabIndex = 11;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/write-email-envelope-button.svg";
            componentTool1.Name = "Send Email";
            this.utextBox3.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            // 
            // userTreesTableAdapter
            // 
            this.userTreesTableAdapter.ClearBeforeFill = true;
            // 
            // ubutton3
            // 
            this.ubutton3.Location = new System.Drawing.Point(676, 15);
            this.ubutton3.Name = "ubutton3";
            this.ubutton3.Size = new System.Drawing.Size(100, 27);
            this.ubutton3.TabIndex = 7;
            this.ubutton3.Text = "삭제";
            this.ubutton3.Click += new System.EventHandler(this.ubutton3_Click);
            // 
            // ubutton2
            // 
            this.ubutton2.Location = new System.Drawing.Point(472, 15);
            this.ubutton2.Name = "ubutton2";
            this.ubutton2.Size = new System.Drawing.Size(100, 27);
            this.ubutton2.TabIndex = 6;
            this.ubutton2.Text = "신규";
            this.ubutton2.Click += new System.EventHandler(this.ubutton2_Click);
            // 
            // ubutton1
            // 
            this.ubutton1.Location = new System.Drawing.Point(574, 15);
            this.ubutton1.Name = "ubutton1";
            this.ubutton1.Size = new System.Drawing.Size(100, 27);
            this.ubutton1.TabIndex = 5;
            this.ubutton1.Text = "저장";
            this.ubutton1.Click += new System.EventHandler(this.ubutton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ubutton3);
            this.panel1.Controls.Add(this.ubutton1);
            this.panel1.Controls.Add(this.ubutton2);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 60);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 392);
            this.panel2.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.udataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.HeaderAlignment = Wisej.Web.HorizontalAlignment.Right;
            this.splitContainer1.Panel2.ShowHeader = true;
            this.splitContainer1.Size = new System.Drawing.Size(1149, 392);
            this.splitContainer1.SplitterDistance = 683;
            this.splitContainer1.TabIndex = 2;
            // 
            // MUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MUser";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
            this.Text = "사용자 관리";
            this.Load += new System.EventHandler(this.DataBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.DataGridView udataGridView1;
        private Web.TextBox utextusername;
        private Web.Label label1;
        private Web.Label label2;
        private Web.TextBox utextloginid;
        private Web.Label label4;
        private Web.ComboBox ucomboBox1;
        private Web.TableLayoutPanel tableLayoutPanel1;
        private Web.Label label5;
        private Web.DataGridViewTextBoxColumn colEmail;
        private Web.TextBox utextBox3;
        private Web.MaskedTextBox umaskedTextBox1;
        private Web.Label label6;
        private DataSet1 dataSet1;
        private Web.BindingSource ubindingSource1;
        private DataSet1TableAdapters.UserTreesTableAdapter userTreesTableAdapter;
        private Web.DataGridViewTextBoxColumn colUsertreeid;
        private Web.DataGridViewTextBoxColumn colUser_Group;
        private Web.DataGridViewTextBoxColumn colUser_Name;
        private Web.DataGridViewTextBoxColumn colLogin_Id;
        private Web.DataGridViewTextBoxColumn colMobile;
        private Web.TextBox utextpassword2;
        private Web.TextBox utextpassword;
        private Web.Label label8;
        private Web.Label label7;
        private Web.Button ubutton3;
        private Web.Button ubutton2;
        private Web.Button ubutton1;
        private Web.Panel panel1;
        private Web.Panel panel2;
        private Web.SplitContainer splitContainer1;
    }
}