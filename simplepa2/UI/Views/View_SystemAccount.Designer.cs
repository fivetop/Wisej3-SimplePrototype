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
            this.panel1 = new Wisej.Web.Panel();
            this.panel48 = new Wisej.Web.Panel();
            this.panel49 = new Wisej.Web.Panel();
            this.panel38 = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.label17 = new Wisej.Web.Label();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.이름 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송시간 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송종류 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송내용 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.현재로그인 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.이전로그인 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel3 = new Wisej.Web.Panel();
            this.panel32 = new Wisej.Web.Panel();
            this.panel89 = new Wisej.Web.Panel();
            this.panel37 = new Wisej.Web.Panel();
            this.label26 = new Wisej.Web.Label();
            this.panel36 = new Wisej.Web.Panel();
            this.label25 = new Wisej.Web.Label();
            this.panel35 = new Wisej.Web.Panel();
            this.textBox5 = new Wisej.Web.TextBox();
            this.label24 = new Wisej.Web.Label();
            this.line2 = new Wisej.Web.Line();
            this.panel34 = new Wisej.Web.Panel();
            this.label23 = new Wisej.Web.Label();
            this.label22 = new Wisej.Web.Label();
            this.panel136 = new Wisej.Web.Panel();
            this.button5 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.label66 = new Wisej.Web.Label();
            this.comboBox3 = new Wisej.Web.ComboBox();
            this.comboBox4 = new Wisej.Web.ComboBox();
            this.panel48.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel38.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel89.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel36.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel34.SuspendLayout();
            this.panel136.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = Wisej.Web.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(860, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 860);
            this.panel1.TabIndex = 50;
            // 
            // panel48
            // 
            this.panel48.BackColor = System.Drawing.Color.White;
            this.panel48.Controls.Add(this.panel49);
            this.panel48.Controls.Add(this.panel38);
            this.panel48.Dock = Wisej.Web.DockStyle.Left;
            this.panel48.Location = new System.Drawing.Point(20, 20);
            this.panel48.Name = "panel48";
            this.panel48.Padding = new Wisej.Web.Padding(20);
            this.panel48.Size = new System.Drawing.Size(840, 860);
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
            this.panel49.Size = new System.Drawing.Size(800, 768);
            this.panel49.TabIndex = 51;
            this.panel49.Text = "listPanel";
            // 
            // panel38
            // 
            this.panel38.BackColor = System.Drawing.Color.Transparent;
            this.panel38.Controls.Add(this.button1);
            this.panel38.Controls.Add(this.label17);
            this.panel38.Dock = Wisej.Web.DockStyle.Top;
            this.panel38.Location = new System.Drawing.Point(20, 20);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(800, 52);
            this.panel38.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button1.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button1.Location = new System.Drawing.Point(700, 0);
            this.button1.Margin = new Wisej.Web.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "추가";
            // 
            // label17
            // 
            this.label17.CssStyle = "\r\n";
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(223, 32);
            this.label17.TabIndex = 33;
            this.label17.Text = "사용자 리스트";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.이름,
            this.방송시간,
            this.방송종류,
            this.방송내용,
            this.현재로그인,
            this.이전로그인});
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 768);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel32);
            this.panel3.Controls.Add(this.panel136);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(880, 20);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(20);
            this.panel3.Size = new System.Drawing.Size(500, 860);
            this.panel3.TabIndex = 51;
            // 
            // panel32
            // 
            this.panel32.AutoScroll = true;
            this.panel32.Controls.Add(this.panel89);
            this.panel32.Dock = Wisej.Web.DockStyle.Fill;
            this.panel32.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.panel32.Location = new System.Drawing.Point(20, 72);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(460, 768);
            this.panel32.TabIndex = 51;
            this.panel32.Text = "listPanel";
            // 
            // panel89
            // 
            this.panel89.AutoSize = true;
            this.panel89.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel89.Controls.Add(this.panel37);
            this.panel89.Controls.Add(this.panel36);
            this.panel89.Controls.Add(this.panel35);
            this.panel89.Controls.Add(this.line2);
            this.panel89.Controls.Add(this.panel34);
            this.panel89.Dock = Wisej.Web.DockStyle.Top;
            this.panel89.Location = new System.Drawing.Point(0, 0);
            this.panel89.Name = "panel89";
            this.panel89.Padding = new Wisej.Web.Padding(20);
            this.panel89.Size = new System.Drawing.Size(460, 246);
            this.panel89.TabIndex = 159;
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.comboBox4);
            this.panel37.Controls.Add(this.label26);
            this.panel37.Dock = Wisej.Web.DockStyle.Top;
            this.panel37.Location = new System.Drawing.Point(20, 170);
            this.panel37.Name = "panel37";
            this.panel37.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel37.Size = new System.Drawing.Size(420, 56);
            this.panel37.TabIndex = 166;
            // 
            // label26
            // 
            this.label26.AutoEllipsis = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Dock = Wisej.Web.DockStyle.Left;
            this.label26.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label26.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label26.Location = new System.Drawing.Point(0, 20);
            this.label26.Margin = new Wisej.Web.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(123, 36);
            this.label26.TabIndex = 136;
            this.label26.Text = "인증";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.comboBox3);
            this.panel36.Controls.Add(this.label25);
            this.panel36.Dock = Wisej.Web.DockStyle.Top;
            this.panel36.Location = new System.Drawing.Point(20, 114);
            this.panel36.Name = "panel36";
            this.panel36.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel36.Size = new System.Drawing.Size(420, 56);
            this.panel36.TabIndex = 165;
            // 
            // label25
            // 
            this.label25.AutoEllipsis = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Dock = Wisej.Web.DockStyle.Left;
            this.label25.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label25.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label25.Location = new System.Drawing.Point(0, 20);
            this.label25.Margin = new Wisej.Web.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(123, 36);
            this.label25.TabIndex = 136;
            this.label25.Text = "엑세스 제어";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.textBox5);
            this.panel35.Controls.Add(this.label24);
            this.panel35.Dock = Wisej.Web.DockStyle.Top;
            this.panel35.Location = new System.Drawing.Point(20, 58);
            this.panel35.Name = "panel35";
            this.panel35.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel35.Size = new System.Drawing.Size(420, 56);
            this.panel35.TabIndex = 164;
            // 
            // textBox5
            // 
            this.textBox5.AutoSize = false;
            this.textBox5.Dock = Wisej.Web.DockStyle.Left;
            this.textBox5.Location = new System.Drawing.Point(123, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(240, 36);
            this.textBox5.TabIndex = 137;
            // 
            // label24
            // 
            this.label24.AutoEllipsis = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = Wisej.Web.DockStyle.Left;
            this.label24.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label24.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label24.Location = new System.Drawing.Point(0, 20);
            this.label24.Margin = new Wisej.Web.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 36);
            this.label24.TabIndex = 136;
            this.label24.Text = "사용자 이름";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line2
            // 
            this.line2.Dock = Wisej.Web.DockStyle.Top;
            this.line2.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line2.Location = new System.Drawing.Point(20, 57);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(420, 1);
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.label23);
            this.panel34.Controls.Add(this.label22);
            this.panel34.Dock = Wisej.Web.DockStyle.Top;
            this.panel34.Location = new System.Drawing.Point(20, 20);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(420, 37);
            this.panel34.TabIndex = 161;
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("default", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label23.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label23.Location = new System.Drawing.Point(32, 0);
            this.label23.Margin = new Wisej.Web.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(437, 24);
            this.label23.TabIndex = 134;
            this.label23.Text = "사용자 일반 정보";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoEllipsis = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(91, 153, 255);
            this.label22.CssStyle = "border-radius: 11px;";
            this.label22.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label22.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.label22.Location = new System.Drawing.Point(0, 1);
            this.label22.Margin = new Wisej.Web.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 22);
            this.label22.TabIndex = 133;
            this.label22.Text = "★";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel136
            // 
            this.panel136.BackColor = System.Drawing.Color.Transparent;
            this.panel136.Controls.Add(this.button5);
            this.panel136.Controls.Add(this.button2);
            this.panel136.Controls.Add(this.label66);
            this.panel136.Dock = Wisej.Web.DockStyle.Top;
            this.panel136.Location = new System.Drawing.Point(20, 20);
            this.panel136.Name = "panel136";
            this.panel136.Size = new System.Drawing.Size(460, 52);
            this.panel136.TabIndex = 50;
            // 
            // button5
            // 
            this.button5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.button5.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button5.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button5.Location = new System.Drawing.Point(250, 0);
            this.button5.Margin = new Wisej.Web.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 32);
            this.button5.TabIndex = 35;
            this.button5.Text = "삭제";
            // 
            // button2
            // 
            this.button2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button2.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button2.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button2.Location = new System.Drawing.Point(360, 0);
            this.button2.Margin = new Wisej.Web.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 34;
            this.button2.Text = "추가";
            // 
            // label66
            // 
            this.label66.CssStyle = "\r\n";
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label66.Location = new System.Drawing.Point(0, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(418, 32);
            this.label66.TabIndex = 33;
            this.label66.Text = "사용자 편집";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoSize = false;
            this.comboBox3.Dock = Wisej.Web.DockStyle.Left;
            this.comboBox3.Location = new System.Drawing.Point(123, 20);
            this.comboBox3.Margin = new Wisej.Web.Padding(0);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(240, 36);
            this.comboBox3.TabIndex = 138;
            // 
            // comboBox4
            // 
            this.comboBox4.AutoSize = false;
            this.comboBox4.Dock = Wisej.Web.DockStyle.Left;
            this.comboBox4.Location = new System.Drawing.Point(123, 20);
            this.comboBox4.Margin = new Wisej.Web.Padding(0);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(240, 36);
            this.comboBox4.TabIndex = 139;
            // 
            // View_SystemAccount
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel48);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_SystemAccount";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.panel48.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            this.panel38.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.panel89.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            this.panel36.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.panel136.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel48;
        private Wisej.Web.Panel panel49;
        private Wisej.Web.Panel panel38;
        private Wisej.Web.Button button1;
        private Wisej.Web.Label label17;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn 이름;
        private Wisej.Web.DataGridViewTextBoxColumn 방송시간;
        private Wisej.Web.DataGridViewTextBoxColumn 방송종류;
        private Wisej.Web.DataGridViewTextBoxColumn 방송내용;
        private Wisej.Web.DataGridViewTextBoxColumn 현재로그인;
        private Wisej.Web.DataGridViewTextBoxColumn 이전로그인;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Panel panel32;
        private Wisej.Web.Panel panel89;
        private Wisej.Web.Panel panel37;
        private Wisej.Web.ComboBox comboBox4;
        private Wisej.Web.Label label26;
        private Wisej.Web.Panel panel36;
        private Wisej.Web.ComboBox comboBox3;
        private Wisej.Web.Label label25;
        private Wisej.Web.Panel panel35;
        private Wisej.Web.TextBox textBox5;
        private Wisej.Web.Label label24;
        private Wisej.Web.Line line2;
        private Wisej.Web.Panel panel34;
        private Wisej.Web.Label label23;
        private Wisej.Web.Label label22;
        private Wisej.Web.Panel panel136;
        private Wisej.Web.Button button5;
        private Wisej.Web.Button button2;
        private Wisej.Web.Label label66;
    }
}
