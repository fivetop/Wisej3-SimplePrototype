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
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool4 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool5 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool6 = new Wisej.Web.ComponentTool();
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
            this.textBox1 = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.textBox2 = new Wisej.Web.TextBox();
            this.label3 = new Wisej.Web.Label();
            this.dateTimePicker1 = new Wisej.Web.DateTimePicker();
            this.label4 = new Wisej.Web.Label();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.label5 = new Wisej.Web.Label();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.textBox3 = new Wisej.Web.TextBox();
            this.maskedTextBox1 = new Wisej.Web.MaskedTextBox();
            this.label6 = new Wisej.Web.Label();
            this.userTreesTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.UserTreesTableAdapter();
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
            this.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(37, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 311);
            this.dataGridView1.TabIndex = 1;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/square-add-button.svg?color=#3F76BF";
            componentTool1.Name = "Add";
            componentTool1.Position = Wisej.Web.LeftRightAlignment.Left;
            componentTool2.Enabled = false;
            componentTool2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/save-button.svg?color=#3FBF47";
            componentTool2.Name = "Save";
            componentTool2.Position = Wisej.Web.LeftRightAlignment.Left;
            componentTool3.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/refresh-button.svg?color=#003EFF";
            componentTool3.Name = "Reload";
            componentTool3.Position = Wisej.Web.LeftRightAlignment.Left;
            componentTool4.Enabled = false;
            componentTool4.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/rubbish-bin-delete-button.svg?color=#7A7A7A";
            componentTool4.Name = "Delete";
            this.dataGridView1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1,
            componentTool2,
            componentTool3,
            componentTool4});
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.dataGridView1_ToolClick);
            this.dataGridView1.CellToolClick += new Wisej.Web.DataGridViewToolClickEventHandler(this.dataGridView1_CellToolClick);
            this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
            // 
            // colUsertreeid
            // 
            this.colUsertreeid.DataPropertyName = "UserTreeId";
            this.colUsertreeid.HeaderText = "No";
            this.colUsertreeid.Name = "colUsertreeid";
            this.colUsertreeid.ReadOnly = true;
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
            this.statusBar1.Location = new System.Drawing.Point(0, 287);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.ShowPanels = false;
            this.statusBar1.Size = new System.Drawing.Size(837, 22);
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
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "user_name", true));
            this.textBox1.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(8, 58);
            this.textBox1.Margin = new Wisej.Web.Padding(8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.Watermark = "Enter a name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Wisej.Web.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new Wisej.Web.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "&User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = Wisej.Web.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(228, 8);
            this.label2.Margin = new Wisej.Web.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "&LogIn ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.AutoSize = false;
            this.textBox2.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "login_id", true));
            this.textBox2.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(228, 58);
            this.textBox2.Margin = new Wisej.Web.Padding(8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 34);
            this.textBox2.TabIndex = 3;
            this.textBox2.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textBox2_ToolClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = Wisej.Web.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(624, 8);
            this.label3.Margin = new Wisej.Web.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Date of Birth";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AutoSize = false;
            this.dateTimePicker1.Dock = Wisej.Web.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(624, 58);
            this.dateTimePicker1.Margin = new Wisej.Web.Padding(8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 34);
            this.dateTimePicker1.TabIndex = 7;
            componentTool5.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/shining-sun.svg?color=#FFA700";
            this.dateTimePicker1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool5});
            this.dateTimePicker1.Value = new System.DateTime(2017, 8, 25, 17, 55, 6, 102);
            this.dateTimePicker1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.dateTimePicker1_ToolClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = Wisej.Web.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(448, 8);
            this.label4.Margin = new Wisej.Web.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 34);
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
            this.comboBox1.Location = new System.Drawing.Point(448, 58);
            this.comboBox1.Margin = new Wisej.Web.Padding(8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 34);
            this.comboBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Dock = Wisej.Web.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(228, 108);
            this.label5.Margin = new Wisej.Web.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 34);
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
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 203);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // textBox3
            // 
            this.textBox3.AutoSize = false;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox3, 2);
            this.textBox3.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(223, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(390, 47);
            this.textBox3.TabIndex = 11;
            componentTool6.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/write-email-envelope-button.svg";
            componentTool6.Name = "Send Email";
            this.textBox3.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool6});
            this.textBox3.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textBox3_ToolClick);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.AutoSize = false;
            this.maskedTextBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "mobile", true));
            this.maskedTextBox1.Dock = Wisej.Web.DockStyle.Fill;
            this.maskedTextBox1.Location = new System.Drawing.Point(3, 153);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(214, 47);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Dock = Wisej.Web.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(8, 108);
            this.label6.Margin = new Wisej.Web.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "&Mobile";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userTreesTableAdapter
            // 
            this.userTreesTableAdapter.ClearBeforeFill = true;
            // 
            // MUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 610);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/server-rack-with-three-levels.svg?color=#BF3" +
    "F3F";
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
        private Web.TextBox textBox1;
        private Web.Label label1;
        private Web.Label label2;
        private Web.TextBox textBox2;
        private Web.Label label3;
        private Web.DateTimePicker dateTimePicker1;
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
    }
}