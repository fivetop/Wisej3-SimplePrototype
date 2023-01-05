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
            this.panel136 = new Wisej.Web.Panel();
            this.upload1 = new Wisej.Web.Upload();
            this.button1 = new Wisej.Web.Button();
            this.button5 = new Wisej.Web.Button();
            this.bt_inputDecision = new Wisej.Web.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel136.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1081, 577);
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1041, 486);
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
            this.panel2.Controls.Add(this.panel136);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 51);
            this.panel2.TabIndex = 0;
            // 
            // panel136
            // 
            this.panel136.BackColor = System.Drawing.Color.Transparent;
            this.panel136.Controls.Add(this.upload1);
            this.panel136.Controls.Add(this.button1);
            this.panel136.Controls.Add(this.button5);
            this.panel136.Controls.Add(this.bt_inputDecision);
            this.panel136.Dock = Wisej.Web.DockStyle.Top;
            this.panel136.Location = new System.Drawing.Point(0, 0);
            this.panel136.Name = "panel136";
            this.panel136.Size = new System.Drawing.Size(1041, 52);
            this.panel136.TabIndex = 53;
            // 
            // upload1
            // 
            this.upload1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.upload1.CssStyle = "border-radius:6px;";
            this.upload1.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.upload1.Location = new System.Drawing.Point(112, 0);
            this.upload1.Name = "upload1";
            this.upload1.Size = new System.Drawing.Size(292, 32);
            this.upload1.TabIndex = 169;
            this.upload1.Text = "파일 업로드";
            this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button1.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new Wisej.Web.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 36;
            this.button1.Text = "선번 샘플";
            // 
            // button5
            // 
            this.button5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.button5.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button5.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button5.Location = new System.Drawing.Point(831, 0);
            this.button5.Margin = new Wisej.Web.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 32);
            this.button5.TabIndex = 35;
            this.button5.Text = "선택 편집";
            // 
            // bt_inputDecision
            // 
            this.bt_inputDecision.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_inputDecision.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_inputDecision.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_inputDecision.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_inputDecision.Location = new System.Drawing.Point(941, 0);
            this.bt_inputDecision.Margin = new Wisej.Web.Padding(0);
            this.bt_inputDecision.Name = "bt_inputDecision";
            this.bt_inputDecision.Size = new System.Drawing.Size(100, 32);
            this.bt_inputDecision.TabIndex = 34;
            this.bt_inputDecision.Text = "선번 입력";
            this.bt_inputDecision.Click += new System.EventHandler(this.bt_inputDecision_Click);
            // 
            // Form_BBCZoneImport
            // 
            this.ClientSize = new System.Drawing.Size(1081, 577);
            this.Controls.Add(this.panel1);
            this.HeaderBackColor = System.Drawing.Color.FromName("@button1BG");
            this.Name = "Form_BBCZoneImport";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Zone 정보 Import";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel136.ResumeLayout(false);
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
        private Wisej.Web.Panel panel136;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button button5;
        private Wisej.Web.Button bt_inputDecision;
        private Wisej.Web.Upload upload1;
    }
}