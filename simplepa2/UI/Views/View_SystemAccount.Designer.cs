namespace simplepa2.UI.Views
{
    partial class View_SystemAccount
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
            this.panel48 = new Wisej.Web.Panel();
            this.panel49 = new Wisej.Web.Panel();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.방송시간 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송종류 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송내용 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.현재로그인 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.이전로그인 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel38 = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.label17 = new Wisej.Web.Label();
            this.dataSet1 = new simplepa2.DataSet1();
            this.userTreesBindingSource = new Wisej.Web.BindingSource(this.components);
            this.userTreesTableAdapter = new simplepa2.DataSet1TableAdapters.UserTreesTableAdapter();
            this.colUsertreeid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colUser_Group = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colUser_Name = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLogin_Id = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLogin_Password = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLogin_Password2 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colMobile = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel48.SuspendLayout();
            this.panel49.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel38.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTreesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel48
            // 
            this.panel48.BackColor = System.Drawing.Color.White;
            this.panel48.Controls.Add(this.panel49);
            this.panel48.Controls.Add(this.panel38);
            this.panel48.Dock = Wisej.Web.DockStyle.Fill;
            this.panel48.Location = new System.Drawing.Point(20, 20);
            this.panel48.Name = "panel48";
            this.panel48.Padding = new Wisej.Web.Padding(20);
            this.panel48.Size = new System.Drawing.Size(1360, 860);
            this.panel48.TabIndex = 50;
            // 
            // panel49
            // 
            this.panel49.AutoScroll = true;
            this.panel49.Controls.Add(this.dataGridView1);
            this.panel49.Dock = Wisej.Web.DockStyle.Fill;
            this.panel49.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.panel49.Location = new System.Drawing.Point(20, 72);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(1320, 768);
            this.panel49.TabIndex = 51;
            this.panel49.Text = "listPanel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colUsertreeid,
            this.colUser_Name,
            this.방송시간,
            this.방송종류,
            this.방송내용,
            this.현재로그인,
            this.이전로그인,
            this.colMobile,
            this.colEmail,
            this.colUser_Group,
            this.colLogin_Id,
            this.colLogin_Password,
            this.colLogin_Password2});
            this.dataGridView1.DataSource = this.userTreesBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1320, 768);
            this.dataGridView1.TabIndex = 185;
            // 
            // 방송시간
            // 
            this.방송시간.HeaderText = "엑세스제어";
            this.방송시간.Name = "방송시간";
            this.방송시간.Width = 250;
            // 
            // 방송종류
            // 
            this.방송종류.HeaderText = "인증";
            this.방송종류.Name = "방송종류";
            this.방송종류.Width = 150;
            // 
            // 방송내용
            // 
            this.방송내용.HeaderText = "PW변경";
            this.방송내용.Name = "방송내용";
            this.방송내용.Width = 80;
            // 
            // 현재로그인
            // 
            this.현재로그인.HeaderText = "현재로그인";
            this.현재로그인.Name = "현재로그인";
            this.현재로그인.Width = 180;
            // 
            // 이전로그인
            // 
            this.이전로그인.HeaderText = "이전로그인";
            this.이전로그인.Name = "이전로그인";
            this.이전로그인.Width = 180;
            // 
            // panel38
            // 
            this.panel38.BackColor = System.Drawing.Color.Transparent;
            this.panel38.Controls.Add(this.button1);
            this.panel38.Controls.Add(this.label17);
            this.panel38.Dock = Wisej.Web.DockStyle.Top;
            this.panel38.Location = new System.Drawing.Point(20, 20);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(1320, 52);
            this.panel38.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button1.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button1.Location = new System.Drawing.Point(1220, 0);
            this.button1.Margin = new Wisej.Web.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "추가";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.CssStyle = "\r\n";
            this.label17.Font = new System.Drawing.Font("@boxTitle", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(223, 32);
            this.label17.TabIndex = 33;
            this.label17.Text = "사용자 리스트";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // colUsertreeid
            // 
            this.colUsertreeid.DataPropertyName = "UserTreeId";
            this.colUsertreeid.HeaderText = "번호";
            this.colUsertreeid.Name = "colUsertreeid";
            this.colUsertreeid.ReadOnly = true;
            // 
            // colUser_Group
            // 
            this.colUser_Group.DataPropertyName = "user_group";
            this.colUser_Group.HeaderText = "user_group";
            this.colUser_Group.Name = "colUser_Group";
            // 
            // colUser_Name
            // 
            this.colUser_Name.DataPropertyName = "user_name";
            this.colUser_Name.HeaderText = "이름";
            this.colUser_Name.Name = "colUser_Name";
            // 
            // colLogin_Id
            // 
            this.colLogin_Id.DataPropertyName = "login_id";
            this.colLogin_Id.HeaderText = "login_id";
            this.colLogin_Id.Name = "colLogin_Id";
            // 
            // colLogin_Password
            // 
            this.colLogin_Password.DataPropertyName = "login_password";
            this.colLogin_Password.HeaderText = "login_password";
            this.colLogin_Password.Name = "colLogin_Password";
            // 
            // colLogin_Password2
            // 
            this.colLogin_Password2.DataPropertyName = "login_password2";
            this.colLogin_Password2.HeaderText = "login_password2";
            this.colLogin_Password2.Name = "colLogin_Password2";
            // 
            // colMobile
            // 
            this.colMobile.DataPropertyName = "mobile";
            this.colMobile.HeaderText = "핸드폰";
            this.colMobile.Name = "colMobile";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "이메일";
            this.colEmail.Name = "colEmail";
            // 
            // View_SystemAccount
            // 
            this.BackColor = System.Drawing.Color.FromName("@bBGall");
            this.Controls.Add(this.panel48);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_SystemAccount";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.View_SystemAccount_Load);
            this.panel48.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel38.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTreesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel48;
        private Wisej.Web.Panel panel49;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn 방송시간;
        private Wisej.Web.DataGridViewTextBoxColumn 방송종류;
        private Wisej.Web.DataGridViewTextBoxColumn 방송내용;
        private Wisej.Web.DataGridViewTextBoxColumn 현재로그인;
        private Wisej.Web.DataGridViewTextBoxColumn 이전로그인;
        private Wisej.Web.Panel panel38;
        private Wisej.Web.Button button1;
        private Wisej.Web.Label label17;
        private Wisej.Web.DataGridViewTextBoxColumn colUsertreeid;
        private Wisej.Web.DataGridViewTextBoxColumn colUser_Name;
        private Wisej.Web.DataGridViewTextBoxColumn colMobile;
        private Wisej.Web.DataGridViewTextBoxColumn colEmail;
        private Wisej.Web.DataGridViewTextBoxColumn colUser_Group;
        private Wisej.Web.DataGridViewTextBoxColumn colLogin_Id;
        private Wisej.Web.DataGridViewTextBoxColumn colLogin_Password;
        private Wisej.Web.DataGridViewTextBoxColumn colLogin_Password2;
        private Wisej.Web.BindingSource userTreesBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.UserTreesTableAdapter userTreesTableAdapter;
    }
}
