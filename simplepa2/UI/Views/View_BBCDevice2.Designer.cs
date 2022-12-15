namespace simplepa2.UI.Views
{
    partial class View_BBCDevice2
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
            this.panel2 = new Wisej.Web.Panel();
            this.dataGridView3 = new Wisej.Web.DataGridView();
            this.장비아이디 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.장비이름 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.장비종류 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.IP주소 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.카테고리 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.상태 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.발견시간 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.관리여부 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel1 = new Wisej.Web.Panel();
            this.button5 = new Wisej.Web.Button();
            this.button4 = new Wisej.Web.Button();
            this.popTestButton = new Wisej.Web.Button();
            this.label3 = new Wisej.Web.Label();
            this.textBox2 = new Wisej.Web.TextBox();
            this.dataSet11 = new simplepa2.DataSet1();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1360, 860);
            this.panel2.TabIndex = 51;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.장비아이디,
            this.장비이름,
            this.장비종류,
            this.IP주소,
            this.카테고리,
            this.상태,
            this.발견시간,
            this.관리여부});
            this.dataGridView3.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(20, 72);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1320, 768);
            this.dataGridView3.TabIndex = 67;
            // 
            // 장비아이디
            // 
            this.장비아이디.HeaderText = "장비아이디";
            this.장비아이디.Name = "장비아이디";
            this.장비아이디.Width = 200;
            // 
            // 장비이름
            // 
            this.장비이름.HeaderText = "장비이름";
            this.장비이름.Name = "장비이름";
            this.장비이름.Width = 200;
            // 
            // 장비종류
            // 
            this.장비종류.HeaderText = "장비종류";
            this.장비종류.Name = "장비종류";
            this.장비종류.Width = 140;
            // 
            // IP주소
            // 
            this.IP주소.HeaderText = "IP주소";
            this.IP주소.Name = "IP주소";
            this.IP주소.Width = 200;
            // 
            // 카테고리
            // 
            this.카테고리.HeaderText = "카테고리";
            this.카테고리.Name = "카테고리";
            this.카테고리.Width = 150;
            // 
            // 상태
            // 
            this.상태.HeaderText = "상태";
            this.상태.Name = "상태";
            this.상태.Width = 60;
            // 
            // 발견시간
            // 
            this.발견시간.HeaderText = "발견시간";
            this.발견시간.Name = "발견시간";
            this.발견시간.Width = 200;
            // 
            // 관리여부
            // 
            this.관리여부.HeaderText = "관리여부";
            this.관리여부.Name = "관리여부";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.popTestButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.Size = new System.Drawing.Size(1320, 52);
            this.panel1.TabIndex = 66;
            // 
            // button5
            // 
            this.button5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromName("@button1LeftBG");
            this.button5.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button5.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button5.Location = new System.Drawing.Point(1000, 0);
            this.button5.Margin = new Wisej.Web.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 32);
            this.button5.TabIndex = 85;
            this.button5.Text = "장비스캔";
            // 
            // button4
            // 
            this.button4.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button4.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button4.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button4.Location = new System.Drawing.Point(1110, 0);
            this.button4.Margin = new Wisej.Web.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 84;
            this.button4.Text = "수동변경";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // popTestButton
            // 
            this.popTestButton.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.popTestButton.BackColor = System.Drawing.Color.FromName("@button1RightBG");
            this.popTestButton.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.popTestButton.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.popTestButton.Location = new System.Drawing.Point(1218, 0);
            this.popTestButton.Margin = new Wisej.Web.Padding(0);
            this.popTestButton.Name = "popTestButton";
            this.popTestButton.Size = new System.Drawing.Size(100, 32);
            this.popTestButton.TabIndex = 83;
            this.popTestButton.Text = "이름변경";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("@topLabel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 77;
            this.label3.Text = "Ethernet Card";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.AutoSize = false;
            this.textBox2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox2.Location = new System.Drawing.Point(141, 0);
            this.textBox2.Margin = new Wisej.Web.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 32);
            this.textBox2.TabIndex = 76;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_BBCDevice
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCDevice";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.BSDeviceManager_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.DataGridView dataGridView3;
        private Wisej.Web.DataGridViewTextBoxColumn 장비아이디;
        private Wisej.Web.DataGridViewTextBoxColumn 장비이름;
        private Wisej.Web.DataGridViewTextBoxColumn 장비종류;
        private Wisej.Web.DataGridViewTextBoxColumn IP주소;
        private Wisej.Web.DataGridViewTextBoxColumn 카테고리;
        private Wisej.Web.DataGridViewTextBoxColumn 상태;
        private Wisej.Web.DataGridViewTextBoxColumn 발견시간;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button button5;
        private Wisej.Web.Button button4;
        private Wisej.Web.Button popTestButton;
        private Wisej.Web.Label label3;
        private Wisej.Web.TextBox textBox2;
        private Wisej.Web.DataGridViewTextBoxColumn 관리여부;
        private DataSet1 dataSet11;
    }
}
