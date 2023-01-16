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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle6 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle7 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle8 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle9 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle10 = new Wisej.Web.DataGridViewCellStyle();
            this.panel1 = new Wisej.Web.Panel();
            this.dg_assetTextData = new Wisej.Web.DataGridView();
            this.Column0 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.동 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.존이름 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.스피커이름 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.앰프정보 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.채널정보 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ZPC = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ZPC입력 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ZPC출력 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.비상방송 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel2 = new Wisej.Web.Panel();
            this.panel136 = new Wisej.Web.Panel();
            this.upload1 = new Wisej.Web.Upload();
            this.button1 = new Wisej.Web.Button();
            this.button5 = new Wisej.Web.Button();
            this.bt_inputDecision = new Wisej.Web.Button();
            this.dataSet11 = new simplepa2.DataSet1();
            this.assetsTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_assetTextData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel136.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dg_assetTextData);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1081, 577);
            this.panel1.TabIndex = 1;
            // 
            // dg_assetTextData
            // 
            this.dg_assetTextData.AllowUserToOrderColumns = true;
            this.dg_assetTextData.AutoGenerateColumns = false;
            this.dg_assetTextData.AutoSize = true;
            this.dg_assetTextData.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_assetTextData.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.Column0,
            this.동,
            this.존이름,
            this.스피커이름,
            this.앰프정보,
            this.채널정보,
            this.ZPC,
            this.ZPC입력,
            this.ZPC출력,
            this.비상방송});
            this.dg_assetTextData.Dock = Wisej.Web.DockStyle.Fill;
            this.dg_assetTextData.Location = new System.Drawing.Point(20, 71);
            this.dg_assetTextData.MultiSelect = false;
            this.dg_assetTextData.Name = "dg_assetTextData";
            this.dg_assetTextData.Size = new System.Drawing.Size(1041, 486);
            this.dg_assetTextData.TabIndex = 0;
            // 
            // Column0
            // 
            this.Column0.DataPropertyName = "emServer";
            dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.Column0.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column0.HeaderText = "사이트명";
            this.Column0.Name = "Column0";
            // 
            // 동
            // 
            this.동.DataPropertyName = "building";
            dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.동.DefaultCellStyle = dataGridViewCellStyle2;
            this.동.HeaderText = "건물(층)";
            this.동.Name = "동";
            // 
            // 존이름
            // 
            this.존이름.DataPropertyName = "ZoneName";
            dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.존이름.DefaultCellStyle = dataGridViewCellStyle3;
            this.존이름.FillWeight = 120F;
            this.존이름.HeaderText = "존이름";
            this.존이름.MinimumWidth = 100;
            this.존이름.Name = "존이름";
            this.존이름.Width = 120;
            // 
            // 스피커이름
            // 
            this.스피커이름.DataPropertyName = "SpeakerName";
            dataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.스피커이름.DefaultCellStyle = dataGridViewCellStyle4;
            this.스피커이름.FillWeight = 120F;
            this.스피커이름.HeaderText = "스피커이름";
            this.스피커이름.MinimumWidth = 100;
            this.스피커이름.Name = "스피커이름";
            this.스피커이름.Width = 120;
            // 
            // 앰프정보
            // 
            this.앰프정보.DataPropertyName = "DeviceName";
            dataGridViewCellStyle5.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.앰프정보.DefaultCellStyle = dataGridViewCellStyle5;
            this.앰프정보.FillWeight = 120F;
            this.앰프정보.HeaderText = "앰프정보";
            this.앰프정보.MinimumWidth = 100;
            this.앰프정보.Name = "앰프정보";
            this.앰프정보.Width = 120;
            // 
            // 채널정보
            // 
            this.채널정보.DataPropertyName = "ch";
            dataGridViewCellStyle6.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.채널정보.DefaultCellStyle = dataGridViewCellStyle6;
            this.채널정보.FillWeight = 70F;
            this.채널정보.HeaderText = "채널정보";
            this.채널정보.MinimumWidth = 70;
            this.채널정보.Name = "채널정보";
            this.채널정보.Width = 70;
            // 
            // ZPC
            // 
            this.ZPC.DataPropertyName = "zpc";
            dataGridViewCellStyle7.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.ZPC.DefaultCellStyle = dataGridViewCellStyle7;
            this.ZPC.HeaderText = "ZPC";
            this.ZPC.MinimumWidth = 100;
            this.ZPC.Name = "ZPC";
            // 
            // ZPC입력
            // 
            this.ZPC입력.DataPropertyName = "zpci";
            dataGridViewCellStyle8.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.ZPC입력.DefaultCellStyle = dataGridViewCellStyle8;
            this.ZPC입력.FillWeight = 70F;
            this.ZPC입력.HeaderText = "ZPC입력";
            this.ZPC입력.MinimumWidth = 70;
            this.ZPC입력.Name = "ZPC입력";
            this.ZPC입력.Width = 70;
            // 
            // ZPC출력
            // 
            this.ZPC출력.DataPropertyName = "zpco";
            dataGridViewCellStyle9.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.ZPC출력.DefaultCellStyle = dataGridViewCellStyle9;
            this.ZPC출력.FillWeight = 70F;
            this.ZPC출력.HeaderText = "ZPC출력";
            this.ZPC출력.MinimumWidth = 70;
            this.ZPC출력.Name = "ZPC출력";
            this.ZPC출력.Width = 70;
            // 
            // 비상방송
            // 
            this.비상방송.DataPropertyName = "floor";
            dataGridViewCellStyle10.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.비상방송.DefaultCellStyle = dataGridViewCellStyle10;
            this.비상방송.FillWeight = 70F;
            this.비상방송.HeaderText = "비상방송";
            this.비상방송.MinimumWidth = 70;
            this.비상방송.Name = "비상방송";
            this.비상방송.Visible = false;
            this.비상방송.Width = 70;
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
            this.upload1.Location = new System.Drawing.Point(0, 0);
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
            this.button1.Location = new System.Drawing.Point(841, 0);
            this.button1.Margin = new Wisej.Web.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 36;
            this.button1.Text = "선번 샘플";
            this.button1.Visible = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.button5.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button5.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button5.Location = new System.Drawing.Point(941, 0);
            this.button5.Margin = new Wisej.Web.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 32);
            this.button5.TabIndex = 35;
            this.button5.Text = "선택 편집";
            this.button5.Visible = false;
            // 
            // bt_inputDecision
            // 
            this.bt_inputDecision.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_inputDecision.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_inputDecision.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_inputDecision.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_inputDecision.Location = new System.Drawing.Point(304, 0);
            this.bt_inputDecision.Margin = new Wisej.Web.Padding(0);
            this.bt_inputDecision.Name = "bt_inputDecision";
            this.bt_inputDecision.Size = new System.Drawing.Size(100, 32);
            this.bt_inputDecision.TabIndex = 34;
            this.bt_inputDecision.Text = "선번 입력";
            this.bt_inputDecision.Click += new System.EventHandler(this.bt_inputDecision_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsTableAdapter1
            // 
            this.assetsTableAdapter1.ClearBeforeFill = true;
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
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_assetTextData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel136.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel panel1;
        private Wisej.Web.DataGridView dg_assetTextData;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel136;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button button5;
        private Wisej.Web.Button bt_inputDecision;
        private Wisej.Web.Upload upload1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter1;
        private Wisej.Web.DataGridViewTextBoxColumn Column0;
        private Wisej.Web.DataGridViewTextBoxColumn 동;
        private Wisej.Web.DataGridViewTextBoxColumn 비상방송;
        private Wisej.Web.DataGridViewTextBoxColumn 존이름;
        private Wisej.Web.DataGridViewTextBoxColumn 스피커이름;
        private Wisej.Web.DataGridViewTextBoxColumn 앰프정보;
        private Wisej.Web.DataGridViewTextBoxColumn 채널정보;
        private Wisej.Web.DataGridViewTextBoxColumn ZPC;
        private Wisej.Web.DataGridViewTextBoxColumn ZPC입력;
        private Wisej.Web.DataGridViewTextBoxColumn ZPC출력;
    }
}