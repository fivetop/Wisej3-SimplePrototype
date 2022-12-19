namespace simplepa2.UI.Views
{
    partial class View_SystemAccount2
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
            this.dataSet1 = new simplepa2.DataSet1();
            this.ubindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.userTreesTableAdapter = new simplepa2.DataSet1TableAdapters.UserTreesTableAdapter();
            this.panel8 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            this.udataGridView1 = new Wisej.Web.DataGridView();
            this.colUsertreeid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colUser_Name = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLogin_Id = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colMobile = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colUser_Group = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ubutton3 = new Wisej.Web.Button();
            this.tableLayoutPanel6 = new Wisej.Web.TableLayoutPanel();
            this.utextpassword = new Wisej.Web.TextBox();
            this.label13 = new Wisej.Web.Label();
            this.utextloginid = new Wisej.Web.TextBox();
            this.label16 = new Wisej.Web.Label();
            this.label15 = new Wisej.Web.Label();
            this.umaskedTextBox1 = new Wisej.Web.MaskedTextBox();
            this.label19 = new Wisej.Web.Label();
            this.utextBox3 = new Wisej.Web.TextBox();
            this.utextusername = new Wisej.Web.TextBox();
            this.label14 = new Wisej.Web.Label();
            this.utextpassword2 = new Wisej.Web.TextBox();
            this.label17 = new Wisej.Web.Label();
            this.ucomboBox1 = new Wisej.Web.ComboBox();
            this.label18 = new Wisej.Web.Label();
            this.ubutton1 = new Wisej.Web.Button();
            this.ptop = new Wisej.Web.Panel();
            this.ubutton2 = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubindingSource1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udataGridView1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.ptop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ubindingSource1
            // 
            this.ubindingSource1.DataMember = "UserTrees";
            this.ubindingSource1.DataSource = this.dataSet1;
            // 
            // userTreesTableAdapter
            // 
            this.userTreesTableAdapter.ClearBeforeFill = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.ptop);
            this.panel8.Dock = Wisej.Web.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(20, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1064, 572);
            this.panel8.TabIndex = 1;
            this.panel8.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 502);
            this.panel2.TabIndex = 14;
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
            this.splitContainer1.Panel2.Controls.Add(this.ubutton3);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel6);
            this.splitContainer1.Panel2.Controls.Add(this.ubutton1);
            this.splitContainer1.Panel2.ShowHeader = true;
            this.splitContainer1.Size = new System.Drawing.Size(1064, 502);
            this.splitContainer1.SplitterDistance = 656;
            this.splitContainer1.TabIndex = 15;
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
            this.udataGridView1.Size = new System.Drawing.Size(656, 502);
            this.udataGridView1.TabIndex = 9;
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
            // ubutton3
            // 
            this.ubutton3.Anchor = Wisej.Web.AnchorStyles.None;
            this.ubutton3.Location = new System.Drawing.Point(261, 323);
            this.ubutton3.Name = "ubutton3";
            this.ubutton3.Size = new System.Drawing.Size(100, 30);
            this.ubutton3.TabIndex = 12;
            this.ubutton3.Text = "삭제";
            this.ubutton3.Click += new System.EventHandler(this.ubutton3_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 110F));
            this.tableLayoutPanel6.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.utextpassword, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.utextloginid, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.umaskedTextBox1, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.label19, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.utextBox3, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.utextusername, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.utextpassword2, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.ucomboBox1, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.label18, 0, 5);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(17, 8);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 7;
            this.tableLayoutPanel6.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(358, 256);
            this.tableLayoutPanel6.TabIndex = 8;
            this.tableLayoutPanel6.TabStop = true;
            // 
            // utextpassword
            // 
            this.utextpassword.AutoSize = false;
            this.utextpassword.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "login_password", true));
            this.utextpassword.Dock = Wisej.Web.DockStyle.Fill;
            this.utextpassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.utextpassword.Location = new System.Drawing.Point(118, 116);
            this.utextpassword.Margin = new Wisej.Web.Padding(8);
            this.utextpassword.Name = "utextpassword";
            this.utextpassword.PasswordChar = '*';
            this.utextpassword.Size = new System.Drawing.Size(232, 20);
            this.utextpassword.TabIndex = 14;
            this.utextpassword.Watermark = "Enter a name";
            // 
            // label13
            // 
            this.label13.Dock = Wisej.Web.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new Wisej.Web.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 36);
            this.label13.TabIndex = 0;
            this.label13.Text = "&User Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // utextloginid
            // 
            this.utextloginid.AutoSize = false;
            this.utextloginid.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "login_id", true));
            this.utextloginid.Dock = Wisej.Web.DockStyle.Fill;
            this.utextloginid.Location = new System.Drawing.Point(118, 44);
            this.utextloginid.Margin = new Wisej.Web.Padding(8);
            this.utextloginid.Name = "utextloginid";
            this.utextloginid.Size = new System.Drawing.Size(232, 20);
            this.utextloginid.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.Dock = Wisej.Web.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(0, 72);
            this.label16.Margin = new Wisej.Web.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 36);
            this.label16.TabIndex = 12;
            this.label16.Text = "Password";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = Wisej.Web.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(0, 144);
            this.label15.Margin = new Wisej.Web.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 36);
            this.label15.TabIndex = 4;
            this.label15.Text = "&Level";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // umaskedTextBox1
            // 
            this.umaskedTextBox1.AutoSize = false;
            this.umaskedTextBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "mobile", true));
            this.umaskedTextBox1.Dock = Wisej.Web.DockStyle.Fill;
            this.umaskedTextBox1.Location = new System.Drawing.Point(113, 183);
            this.umaskedTextBox1.Mask = "(999) 000-0000";
            this.umaskedTextBox1.Name = "umaskedTextBox1";
            this.umaskedTextBox1.Size = new System.Drawing.Size(242, 30);
            this.umaskedTextBox1.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = Wisej.Web.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(0, 216);
            this.label19.Margin = new Wisej.Web.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 40);
            this.label19.TabIndex = 10;
            this.label19.Text = "E&Mail";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // utextBox3
            // 
            this.utextBox3.AutoSize = false;
            this.utextBox3.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "email", true));
            this.utextBox3.Dock = Wisej.Web.DockStyle.Fill;
            this.utextBox3.Location = new System.Drawing.Point(113, 219);
            this.utextBox3.Name = "utextBox3";
            this.utextBox3.Size = new System.Drawing.Size(242, 34);
            this.utextBox3.TabIndex = 11;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/write-email-envelope-button.svg";
            componentTool1.Name = "Send Email";
            this.utextBox3.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            // 
            // utextusername
            // 
            this.utextusername.AutoSize = false;
            this.utextusername.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "user_name", true));
            this.utextusername.Dock = Wisej.Web.DockStyle.Fill;
            this.utextusername.Location = new System.Drawing.Point(118, 8);
            this.utextusername.Margin = new Wisej.Web.Padding(8);
            this.utextusername.Name = "utextusername";
            this.utextusername.Size = new System.Drawing.Size(232, 20);
            this.utextusername.TabIndex = 1;
            this.utextusername.Watermark = "Enter a name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = Wisej.Web.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(0, 36);
            this.label14.Margin = new Wisej.Web.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 36);
            this.label14.TabIndex = 2;
            this.label14.Text = "&LogIn ID";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // utextpassword2
            // 
            this.utextpassword2.AutoSize = false;
            this.utextpassword2.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "login_password2", true));
            this.utextpassword2.Dock = Wisej.Web.DockStyle.Fill;
            this.utextpassword2.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.utextpassword2.Location = new System.Drawing.Point(118, 80);
            this.utextpassword2.Margin = new Wisej.Web.Padding(8);
            this.utextpassword2.Name = "utextpassword2";
            this.utextpassword2.PasswordChar = '*';
            this.utextpassword2.Size = new System.Drawing.Size(232, 20);
            this.utextpassword2.TabIndex = 15;
            this.utextpassword2.Watermark = "Enter a name";
            // 
            // label17
            // 
            this.label17.Dock = Wisej.Web.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(0, 108);
            this.label17.Margin = new Wisej.Web.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 36);
            this.label17.TabIndex = 13;
            this.label17.Text = "Password(확인)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucomboBox1
            // 
            this.ucomboBox1.AutoSize = false;
            this.ucomboBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.ubindingSource1, "user_group", true));
            this.ucomboBox1.Dock = Wisej.Web.DockStyle.Fill;
            this.ucomboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.ucomboBox1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.ucomboBox1.Location = new System.Drawing.Point(118, 152);
            this.ucomboBox1.Margin = new Wisej.Web.Padding(8);
            this.ucomboBox1.Name = "ucomboBox1";
            this.ucomboBox1.Size = new System.Drawing.Size(232, 20);
            this.ucomboBox1.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.Dock = Wisej.Web.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(0, 180);
            this.label18.Margin = new Wisej.Web.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 36);
            this.label18.TabIndex = 8;
            this.label18.Text = "&Mobile";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ubutton1
            // 
            this.ubutton1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ubutton1.Location = new System.Drawing.Point(136, 323);
            this.ubutton1.Name = "ubutton1";
            this.ubutton1.Size = new System.Drawing.Size(100, 30);
            this.ubutton1.TabIndex = 10;
            this.ubutton1.Text = "저장";
            this.ubutton1.Click += new System.EventHandler(this.ubutton1_Click);
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.White;
            this.ptop.Controls.Add(this.ubutton2);
            this.ptop.Dock = Wisej.Web.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(1064, 70);
            this.ptop.TabIndex = 13;
            // 
            // ubutton2
            // 
            this.ubutton2.Anchor = Wisej.Web.AnchorStyles.None;
            this.ubutton2.Location = new System.Drawing.Point(939, 19);
            this.ubutton2.Name = "ubutton2";
            this.ubutton2.Size = new System.Drawing.Size(100, 30);
            this.ubutton2.TabIndex = 11;
            this.ubutton2.Text = "신규";
            this.ubutton2.Click += new System.EventHandler(this.ubutton2_Click);
            // 
            // View_SystemAccount2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel8);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_SystemAccount2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1104, 612);
            this.Load += new System.EventHandler(this.MUserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubindingSource1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udataGridView1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ptop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private Wisej.Web.BindingSource ubindingSource1;
        private DataSet1TableAdapters.UserTreesTableAdapter userTreesTableAdapter;
        private Wisej.Web.Panel panel8;
        private Wisej.Web.Button ubutton3;
        private Wisej.Web.Button ubutton1;
        private Wisej.Web.Button ubutton2;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel6;
        private Wisej.Web.TextBox utextpassword2;
        private Wisej.Web.TextBox utextpassword;
        private Wisej.Web.Label label13;
        private Wisej.Web.TextBox utextusername;
        private Wisej.Web.ComboBox ucomboBox1;
        private Wisej.Web.Label label14;
        private Wisej.Web.Label label15;
        private Wisej.Web.TextBox utextloginid;
        private Wisej.Web.Label label16;
        private Wisej.Web.Label label17;
        private Wisej.Web.Label label18;
        private Wisej.Web.MaskedTextBox umaskedTextBox1;
        private Wisej.Web.Label label19;
        private Wisej.Web.TextBox utextBox3;
        private Wisej.Web.DataGridView udataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colUsertreeid;
        private Wisej.Web.DataGridViewTextBoxColumn colUser_Name;
        private Wisej.Web.DataGridViewTextBoxColumn colLogin_Id;
        private Wisej.Web.DataGridViewTextBoxColumn colEmail;
        private Wisej.Web.DataGridViewTextBoxColumn colMobile;
        private Wisej.Web.DataGridViewTextBoxColumn colUser_Group;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.SplitContainer splitContainer1;
        private Wisej.Web.Panel ptop;
    }
}
