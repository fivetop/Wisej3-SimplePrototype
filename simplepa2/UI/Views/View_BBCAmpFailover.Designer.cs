namespace simplepa2.UI.Views
{
    partial class View_BBCAmpFailover
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
            this.label2 = new Wisej.Web.Label();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.label1 = new Wisej.Web.Label();
            this.comboBox5 = new Wisej.Web.ComboBox();
            this.button2 = new Wisej.Web.Button();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.panel49 = new Wisej.Web.Panel();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.장비번호 = new Wisej.Web.DataGridViewColumn();
            this.컨트롤러이름 = new Wisej.Web.DataGridViewColumn();
            this.장비ID = new Wisej.Web.DataGridViewColumn();
            this.입력앰프 = new Wisej.Web.DataGridViewColumn();
            this.입력포트 = new Wisej.Web.DataGridViewColumn();
            this.출력번호 = new Wisej.Web.DataGridViewColumn();
            this.출력Zone = new Wisej.Web.DataGridViewColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel49.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel49);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1360, 860);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.comboBox5);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 60);
            this.panel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "컨트롤러";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBox2.AutoSize = false;
            this.comboBox2.Location = new System.Drawing.Point(800, 0);
            this.comboBox2.Margin = new Wisej.Web.Padding(0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(240, 32);
            this.comboBox2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label1.Location = new System.Drawing.Point(730, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "백업 앰프";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBox5.AutoSize = false;
            this.comboBox5.Location = new System.Drawing.Point(1050, 0);
            this.comboBox5.Margin = new Wisej.Web.Padding(0);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(160, 32);
            this.comboBox5.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button2.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button2.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button2.Location = new System.Drawing.Point(1220, 0);
            this.button2.Margin = new Wisej.Web.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "적용";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBox1.AutoSize = false;
            this.comboBox1.Location = new System.Drawing.Point(108, 0);
            this.comboBox1.Margin = new Wisej.Web.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 32);
            this.comboBox1.TabIndex = 22;
            // 
            // panel49
            // 
            this.panel49.AutoScroll = true;
            this.panel49.Controls.Add(this.dataGridView1);
            this.panel49.Dock = Wisej.Web.DockStyle.Fill;
            this.panel49.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.panel49.Location = new System.Drawing.Point(20, 80);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(1320, 760);
            this.panel49.TabIndex = 52;
            this.panel49.Text = "listPanel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.장비번호,
            this.컨트롤러이름,
            this.장비ID,
            this.입력앰프,
            this.입력포트,
            this.출력번호,
            this.출력Zone});
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1320, 760);
            this.dataGridView1.TabIndex = 0;
            // 
            // 장비번호
            // 
            this.장비번호.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.장비번호.HeaderText = "장비번호";
            this.장비번호.Name = "장비번호";
            this.장비번호.Resizable = Wisej.Web.DataGridViewTriState.True;
            // 
            // 컨트롤러이름
            // 
            this.컨트롤러이름.HeaderText = "컨트롤러이름";
            this.컨트롤러이름.Name = "컨트롤러이름";
            this.컨트롤러이름.Width = 200;
            // 
            // 장비ID
            // 
            this.장비ID.HeaderText = "장비ID";
            this.장비ID.Name = "장비ID";
            // 
            // 입력앰프
            // 
            this.입력앰프.HeaderText = "입력앰프";
            this.입력앰프.Name = "입력앰프";
            this.입력앰프.Width = 200;
            // 
            // 입력포트
            // 
            this.입력포트.HeaderText = "입력포트";
            this.입력포트.Name = "입력포트";
            // 
            // 출력번호
            // 
            this.출력번호.HeaderText = "출력번호";
            this.출력번호.Name = "출력번호";
            // 
            // 출력Zone
            // 
            this.출력Zone.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.None;
            this.출력Zone.HeaderText = "출력Zone";
            this.출력Zone.Name = "출력Zone";
            this.출력Zone.Width = 200;
            // 
            // View_BBCAmpFailover
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCAmpFailover";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button button2;
        private Wisej.Web.ComboBox comboBox5;
        private Wisej.Web.ComboBox comboBox2;
        private Wisej.Web.Label label1;
        private Wisej.Web.ComboBox comboBox1;
        private Wisej.Web.Panel panel49;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewColumn 장비번호;
        private Wisej.Web.DataGridViewColumn 컨트롤러이름;
        private Wisej.Web.DataGridViewColumn 장비ID;
        private Wisej.Web.DataGridViewColumn 입력앰프;
        private Wisej.Web.DataGridViewColumn 입력포트;
        private Wisej.Web.DataGridViewColumn 출력번호;
        private Wisej.Web.DataGridViewColumn 출력Zone;
    }
}
