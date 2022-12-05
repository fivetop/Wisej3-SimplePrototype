namespace simplepa2.UI.Popups
{
    partial class Form_BBCZoneImport
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
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.동 = new Wisej.Web.DataGridViewColumn();
            this.층 = new Wisej.Web.DataGridViewColumn();
            this.존이름 = new Wisej.Web.DataGridViewColumn();
            this.스피커출력합 = new Wisej.Web.DataGridViewColumn();
            this.앰프정보 = new Wisej.Web.DataGridViewColumn();
            this.채널정보 = new Wisej.Web.DataGridViewColumn();
            this.ZPC여부 = new Wisej.Web.DataGridViewColumn();
            this.입력포트 = new Wisej.Web.DataGridViewColumn();
            this.출력포트 = new Wisej.Web.DataGridViewColumn();
            this.시스템확인 = new Wisej.Web.DataGridViewColumn();
            this.비고 = new Wisej.Web.DataGridViewColumn();
            this.panel2 = new Wisej.Web.Panel();
            this.button_sample = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.textBox1 = new Wisej.Web.TextBox();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.button1 = new Wisej.Web.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 564);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.동,
            this.층,
            this.존이름,
            this.스피커출력합,
            this.앰프정보,
            this.채널정보,
            this.ZPC여부,
            this.입력포트,
            this.출력포트,
            this.시스템확인,
            this.비고});
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1081, 513);
            this.dataGridView1.TabIndex = 0;
            // 
            // 동
            // 
            this.동.HeaderText = "동";
            this.동.Name = "동";
            // 
            // 층
            // 
            this.층.HeaderText = "층";
            this.층.Name = "층";
            // 
            // 존이름
            // 
            this.존이름.HeaderText = "존이름";
            this.존이름.Name = "존이름";
            // 
            // 스피커출력합
            // 
            this.스피커출력합.HeaderText = "스피커출력합";
            this.스피커출력합.Name = "스피커출력합";
            // 
            // 앰프정보
            // 
            this.앰프정보.HeaderText = "앰프정보";
            this.앰프정보.Name = "앰프정보";
            // 
            // 채널정보
            // 
            this.채널정보.HeaderText = "채널정보";
            this.채널정보.Name = "채널정보";
            // 
            // ZPC여부
            // 
            this.ZPC여부.HeaderText = "ZPC여부";
            this.ZPC여부.Name = "ZPC여부";
            // 
            // 입력포트
            // 
            this.입력포트.HeaderText = "입력포트";
            this.입력포트.Name = "입력포트";
            // 
            // 출력포트
            // 
            this.출력포트.HeaderText = "출력포트";
            this.출력포트.Name = "출력포트";
            // 
            // 시스템확인
            // 
            this.시스템확인.HeaderText = "시스템확인";
            this.시스템확인.Name = "시스템확인";
            // 
            // 비고
            // 
            this.비고.HeaderText = "비고";
            this.비고.Name = "비고";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 51);
            this.panel2.TabIndex = 0;
            // 
            // button_sample
            // 
            this.button_sample.Location = new System.Drawing.Point(3, 3);
            this.button_sample.Name = "button_sample";
            this.button_sample.Size = new System.Drawing.Size(100, 33);
            this.button_sample.TabIndex = 0;
            this.button_sample.Text = "선번샘플";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "파일열기";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 36);
            this.textBox1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_sample);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1081, 51);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "업로드";
            // 
            // Form_BBCZoneImport
            // 
            this.ClientSize = new System.Drawing.Size(1081, 564);
            this.Controls.Add(this.panel1);
            this.Name = "Form_BBCZoneImport";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Zone 정보 Import";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel panel1;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewColumn 동;
        private Wisej.Web.DataGridViewColumn 층;
        private Wisej.Web.DataGridViewColumn 존이름;
        private Wisej.Web.DataGridViewColumn 스피커출력합;
        private Wisej.Web.DataGridViewColumn 앰프정보;
        private Wisej.Web.DataGridViewColumn 채널정보;
        private Wisej.Web.DataGridViewColumn ZPC여부;
        private Wisej.Web.DataGridViewColumn 입력포트;
        private Wisej.Web.DataGridViewColumn 출력포트;
        private Wisej.Web.DataGridViewColumn 시스템확인;
        private Wisej.Web.DataGridViewColumn 비고;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Button button_sample;
        private Wisej.Web.Button button2;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.Button button1;
    }
}