namespace simplepa2.UI.Popups
{
    partial class Popup_BBCEmergencyBBSCustom
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
            this.panel2 = new Wisej.Web.Panel();
            this.방송결과 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송위치 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송내용 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.방송종류 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.층 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.button1 = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.label5 = new Wisej.Web.Label();
            this.건물 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.방송음원 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.panel3 = new Wisej.Web.Panel();
            this.line5 = new Wisej.Web.Line();
            this.button3 = new Wisej.Web.Button();
            this.button53 = new Wisej.Web.Button();
            this.label66 = new Wisej.Web.Label();
            this.panel136 = new Wisej.Web.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel136.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromName("@bgCardinCard");
            this.panel1.Dock = Wisej.Web.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 900);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel136);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(699, 900);
            this.panel2.TabIndex = 1;
            this.panel2.PanelCollapsed += new System.EventHandler(this.panel2_PanelCollapsed);
            // 
            // 방송결과
            // 
            this.방송결과.HeaderText = "포트번호";
            this.방송결과.Name = "방송결과";
            this.방송결과.Width = 90;
            // 
            // 방송위치
            // 
            this.방송위치.HeaderText = "채널";
            this.방송위치.Name = "방송위치";
            this.방송위치.Width = 70;
            // 
            // 방송내용
            // 
            this.방송내용.HeaderText = "앰프";
            this.방송내용.Name = "방송내용";
            this.방송내용.Width = 150;
            // 
            // 방송종류
            // 
            this.방송종류.HeaderText = "Zone이름";
            this.방송종류.Name = "방송종류";
            this.방송종류.Width = 90;
            // 
            // 층
            // 
            this.층.HeaderText = "층";
            this.층.Name = "층";
            this.층.Width = 50;
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button1.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button1.Location = new System.Drawing.Point(574, 13);
            this.button1.Margin = new Wisej.Web.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 102;
            this.button1.Text = "검색";
            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(210, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 32);
            this.label1.TabIndex = 101;
            this.label1.Text = "층수";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBox1.AutoSize = false;
            this.comboBox1.Location = new System.Drawing.Point(265, 14);
            this.comboBox1.Margin = new Wisej.Web.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 32);
            this.comboBox1.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(0, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 32);
            this.label5.TabIndex = 99;
            this.label5.Text = "건물명";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 건물
            // 
            this.건물.HeaderText = "건물";
            this.건물.Name = "건물";
            this.건물.Width = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.건물,
            this.층,
            this.방송종류,
            this.방송내용,
            this.방송위치,
            this.방송음원,
            this.방송결과});
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 748);
            this.dataGridView1.TabIndex = 78;
            // 
            // 방송음원
            // 
            this.방송음원.HeaderText = "컨트롤러ID";
            this.방송음원.Name = "방송음원";
            this.방송음원.Width = 80;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoSize = false;
            this.comboBox2.Location = new System.Drawing.Point(65, 14);
            this.comboBox2.Margin = new Wisej.Web.Padding(0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 32);
            this.comboBox2.TabIndex = 98;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.line5);
            this.panel3.Dock = Wisej.Web.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 60);
            this.panel3.TabIndex = 77;
            // 
            // line5
            // 
            this.line5.Dock = Wisej.Web.DockStyle.Top;
            this.line5.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line5.Location = new System.Drawing.Point(0, 0);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(659, 1);
            // 
            // button3
            // 
            this.button3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.button3.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button3.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button3.Location = new System.Drawing.Point(449, 0);
            this.button3.Margin = new Wisej.Web.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 35;
            this.button3.Text = "닫기";
            // 
            // button53
            // 
            this.button53.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button53.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button53.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button53.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button53.Location = new System.Drawing.Point(559, 0);
            this.button53.Margin = new Wisej.Web.Padding(0);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(100, 32);
            this.button53.TabIndex = 34;
            this.button53.Text = "추가";
            // 
            // label66
            // 
            this.label66.CssStyle = "\r\n";
            this.label66.Font = new System.Drawing.Font("@boxTitle", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label66.Location = new System.Drawing.Point(0, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(221, 32);
            this.label66.TabIndex = 33;
            this.label66.Text = "출력 위치 선택";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel136
            // 
            this.panel136.BackColor = System.Drawing.Color.Transparent;
            this.panel136.Controls.Add(this.button3);
            this.panel136.Controls.Add(this.button53);
            this.panel136.Controls.Add(this.label66);
            this.panel136.Dock = Wisej.Web.DockStyle.Top;
            this.panel136.Location = new System.Drawing.Point(20, 20);
            this.panel136.Name = "panel136";
            this.panel136.Size = new System.Drawing.Size(659, 52);
            this.panel136.TabIndex = 76;
            // 
            // Popup_BBCEmergencyBBSCustom
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Popup_BBCEmergencyBBSCustom";
            this.Size = new System.Drawing.Size(700, 900);
            this.Load += new System.EventHandler(this.Popup_BBCEmergencyBBSCustom_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel136.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn 건물;
        private Wisej.Web.DataGridViewTextBoxColumn 층;
        private Wisej.Web.DataGridViewTextBoxColumn 방송종류;
        private Wisej.Web.DataGridViewTextBoxColumn 방송내용;
        private Wisej.Web.DataGridViewTextBoxColumn 방송위치;
        private Wisej.Web.DataGridViewTextBoxColumn 방송음원;
        private Wisej.Web.DataGridViewTextBoxColumn 방송결과;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Button button1;
        private Wisej.Web.Label label1;
        private Wisej.Web.ComboBox comboBox1;
        private Wisej.Web.Label label5;
        private Wisej.Web.ComboBox comboBox2;
        private Wisej.Web.Line line5;
        private Wisej.Web.Panel panel136;
        private Wisej.Web.Button button3;
        private Wisej.Web.Button button53;
        private Wisej.Web.Label label66;
    }
}
