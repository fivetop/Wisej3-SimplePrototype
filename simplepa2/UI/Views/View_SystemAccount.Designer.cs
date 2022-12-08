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
            this.panel48 = new Wisej.Web.Panel();
            this.panel49 = new Wisej.Web.Panel();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.이름 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송시간 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송종류 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송내용 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.현재로그인 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.이전로그인 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.액션 = new Wisej.Web.DataGridViewButtonColumn();
            this.panel38 = new Wisej.Web.Panel();
            this.bt_AddNewUser = new Wisej.Web.Button();
            this.label17 = new Wisej.Web.Label();
            this.이메일주소 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel48.SuspendLayout();
            this.panel49.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel38.SuspendLayout();
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
            this.panel48.TabIndex = 49;
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
            this.이름,
            this.방송시간,
            this.방송종류,
            this.방송내용,
            this.현재로그인,
            this.이전로그인,
            this.이메일주소,
            this.액션});
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1320, 768);
            this.dataGridView1.TabIndex = 185;
            // 
            // 이름
            // 
            this.이름.HeaderText = "이름";
            this.이름.Name = "이름";
            // 
            // 방송시간
            // 
            this.방송시간.HeaderText = "엑세스제어";
            this.방송시간.Name = "방송시간";
            this.방송시간.Width = 150;
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
            this.현재로그인.Width = 150;
            // 
            // 이전로그인
            // 
            this.이전로그인.HeaderText = "이전로그인";
            this.이전로그인.Name = "이전로그인";
            this.이전로그인.Width = 150;
            // 
            // 액션
            // 
            this.액션.HeaderText = "액션";
            this.액션.Name = "액션";
            // 
            // panel38
            // 
            this.panel38.BackColor = System.Drawing.Color.Transparent;
            this.panel38.Controls.Add(this.bt_AddNewUser);
            this.panel38.Controls.Add(this.label17);
            this.panel38.Dock = Wisej.Web.DockStyle.Top;
            this.panel38.Location = new System.Drawing.Point(20, 20);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(1320, 52);
            this.panel38.TabIndex = 50;
            // 
            // bt_AddNewUser
            // 
            this.bt_AddNewUser.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_AddNewUser.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_AddNewUser.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_AddNewUser.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_AddNewUser.Location = new System.Drawing.Point(1220, 0);
            this.bt_AddNewUser.Margin = new Wisej.Web.Padding(0);
            this.bt_AddNewUser.Name = "bt_AddNewUser";
            this.bt_AddNewUser.Size = new System.Drawing.Size(100, 32);
            this.bt_AddNewUser.TabIndex = 34;
            this.bt_AddNewUser.Text = "신규유저";
            this.bt_AddNewUser.Click += new System.EventHandler(this.bt_AddNewUser_Click);
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
            // 이메일주소
            // 
            this.이메일주소.HeaderText = "이메일주소";
            this.이메일주소.Name = "이메일주소";
            // 
            // View_SystemAccount
            // 
            this.BackColor = System.Drawing.Color.FromName("@bBGall");
            this.Controls.Add(this.panel48);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_SystemAccount";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.panel48.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel38.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel panel48;
        private Wisej.Web.Panel panel49;
        private Wisej.Web.Panel panel38;
        private Wisej.Web.Button bt_AddNewUser;
        private Wisej.Web.Label label17;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn 이름;
        private Wisej.Web.DataGridViewTextBoxColumn 방송시간;
        private Wisej.Web.DataGridViewTextBoxColumn 방송종류;
        private Wisej.Web.DataGridViewTextBoxColumn 방송내용;
        private Wisej.Web.DataGridViewTextBoxColumn 현재로그인;
        private Wisej.Web.DataGridViewTextBoxColumn 이전로그인;
        private Wisej.Web.DataGridViewButtonColumn 액션;
        private Wisej.Web.DataGridViewTextBoxColumn 이메일주소;
    }
}
