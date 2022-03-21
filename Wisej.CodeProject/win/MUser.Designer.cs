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
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colUsertreeid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colUser_Name = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLogin_Id = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colMobile = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colUser_Group = new Wisej.Web.DataGridViewTextBoxColumn();
            this.statusBar1 = new Wisej.Web.StatusBar();
            this.bindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.textusername = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.textloginid = new Wisej.Web.TextBox();
            this.label4 = new Wisej.Web.Label();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.label5 = new Wisej.Web.Label();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.textpassword2 = new Wisej.Web.TextBox();
            this.textpassword = new Wisej.Web.TextBox();
            this.label8 = new Wisej.Web.Label();
            this.label7 = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            this.maskedTextBox1 = new Wisej.Web.MaskedTextBox();
            this.textBox3 = new Wisej.Web.TextBox();
            this.userTreesTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.UserTreesTableAdapter();
            this.button3 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colUsertreeid,
            this.colUser_Name,
            this.colLogin_Id,
            this.colEmail,
            this.colMobile,
            this.colUser_Group});
            this.dataGridView1.Controls.Add(this.statusBar1);
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 260);
            this.dataGridView1.TabIndex = 1;
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
            // statusBar1
            // 
            this.statusBar1.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.statusBar1.Location = new System.Drawing.Point(0, 236);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.ShowPanels = false;
            this.statusBar1.Size = new System.Drawing.Size(762, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "statusBar1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "UserTrees";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textusername
            // 
            this.textusername.AutoSize = false;
            this.textusername.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "user_name", true));
            this.textusername.Dock = Wisej.Web.DockStyle.Fill;
            this.textusername.Location = new System.Drawing.Point(8, 34);
            this.textusername.Margin = new Wisej.Web.Padding(8);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(185, 20);
            this.textusername.TabIndex = 1;
            this.textusername.Watermark = "Enter a name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Wisej.Web.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new Wisej.Web.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "&User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = Wisej.Web.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(201, 0);
            this.label2.Margin = new Wisej.Web.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "&LogIn ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textloginid
            // 
            this.textloginid.AutoSize = false;
            this.textloginid.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "login_id", true));
            this.textloginid.Dock = Wisej.Web.DockStyle.Fill;
            this.textloginid.Location = new System.Drawing.Point(209, 34);
            this.textloginid.Margin = new Wisej.Web.Padding(8);
            this.textloginid.Name = "textloginid";
            this.textloginid.Size = new System.Drawing.Size(185, 20);
            this.textloginid.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = Wisej.Web.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(402, 0);
            this.label4.Margin = new Wisej.Web.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Level";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "user_group", true));
            this.comboBox1.Dock = Wisej.Web.DockStyle.Fill;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBox1.Location = new System.Drawing.Point(410, 34);
            this.comboBox1.Margin = new Wisej.Web.Padding(8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Location = new System.Drawing.Point(402, 62);
            this.label5.Margin = new Wisej.Web.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "E&Mail";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textpassword2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textpassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textusername, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textloginid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 129);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // textpassword2
            // 
            this.textpassword2.Anchor = Wisej.Web.AnchorStyles.Left;
            this.textpassword2.AutoSize = false;
            this.textpassword2.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "login_password2", true));
            this.textpassword2.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.textpassword2.Location = new System.Drawing.Point(209, 99);
            this.textpassword2.Margin = new Wisej.Web.Padding(8);
            this.textpassword2.Name = "textpassword2";
            this.textpassword2.PasswordChar = '*';
            this.textpassword2.Size = new System.Drawing.Size(167, 19);
            this.textpassword2.TabIndex = 15;
            this.textpassword2.Watermark = "Enter a name";
            // 
            // textpassword
            // 
            this.textpassword.Anchor = Wisej.Web.AnchorStyles.Left;
            this.textpassword.AutoSize = false;
            this.textpassword.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "login_password", true));
            this.textpassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.textpassword.Location = new System.Drawing.Point(8, 99);
            this.textpassword.Margin = new Wisej.Web.Padding(8);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.Size = new System.Drawing.Size(167, 19);
            this.textpassword.TabIndex = 14;
            this.textpassword.Watermark = "Enter a name";
            // 
            // label8
            // 
            this.label8.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.label8.Location = new System.Drawing.Point(0, 62);
            this.label8.Margin = new Wisej.Web.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.label7.Location = new System.Drawing.Point(201, 62);
            this.label7.Margin = new Wisej.Web.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password(확인)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label6.Location = new System.Drawing.Point(563, 0);
            this.label6.Margin = new Wisej.Web.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "&Mobile";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.maskedTextBox1.AutoSize = false;
            this.maskedTextBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "mobile", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(566, 29);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(198, 25);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.AutoSize = false;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox3, 2);
            this.textBox3.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "email", true));
            this.textBox3.Location = new System.Drawing.Point(405, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(324, 27);
            this.textBox3.TabIndex = 11;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/write-email-envelope-button.svg";
            componentTool1.Name = "Send Email";
            this.textBox3.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            // 
            // userTreesTableAdapter
            // 
            this.userTreesTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(667, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "삭제";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "신규";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "저장";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 452);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MUser";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
            this.Text = "사용자 관리";
            this.Load += new System.EventHandler(this.DataBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataGridView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.DataGridView dataGridView1;
        private Web.TextBox textusername;
        private Web.Label label1;
        private Web.Label label2;
        private Web.TextBox textloginid;
        private Web.Label label4;
        private Web.ComboBox comboBox1;
        private Web.TableLayoutPanel tableLayoutPanel1;
        private Web.Label label5;
        private Web.StatusBar statusBar1;
        private Web.DataGridViewTextBoxColumn colEmail;
        private Web.TextBox textBox3;
        private Web.MaskedTextBox maskedTextBox1;
        private Web.Label label6;
        private DataSet1 dataSet1;
        private Web.BindingSource bindingSource1;
        private DataSet1TableAdapters.UserTreesTableAdapter userTreesTableAdapter;
        private Web.DataGridViewTextBoxColumn colUsertreeid;
        private Web.DataGridViewTextBoxColumn colUser_Group;
        private Web.DataGridViewTextBoxColumn colUser_Name;
        private Web.DataGridViewTextBoxColumn colLogin_Id;
        private Web.DataGridViewTextBoxColumn colMobile;
        private Web.TextBox textpassword2;
        private Web.TextBox textpassword;
        private Web.Label label8;
        private Web.Label label7;
        private Web.Button button3;
        private Web.Button button2;
        private Web.Button button1;
    }
}