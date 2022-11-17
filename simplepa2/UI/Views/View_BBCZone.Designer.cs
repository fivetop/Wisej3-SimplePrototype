namespace simplepa2.UI.Views
{
    partial class View_BBCZone
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
            this.panel2 = new Wisej.Web.Panel();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colAssetid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colGroupname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colZonename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSpeakername = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCh = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmdata = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDeviceid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colIp = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState_Old = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colChk = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSeq = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPath = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFloor = new Wisej.Web.DataGridViewTextBoxColumn();
            this.assetsBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.upload1 = new Wisej.Web.Upload();
            this.button2 = new Wisej.Web.Button();
            this.ptop = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.assetsTableAdapter = new simplepa2.DataSet1TableAdapters.AssetsTableAdapter();
            this.colEmserver = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.ptop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 546);
            this.panel2.TabIndex = 7;
            this.panel2.TabStop = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colAssetid,
            this.colEmserver,
            this.colGroupname,
            this.colZonename,
            this.colSpeakername,
            this.colDevicename,
            this.colCh,
            this.colEmdata,
            this.colDeviceid,
            this.colIp,
            this.colState,
            this.colState_Old,
            this.colChk,
            this.colSeq,
            this.colPath,
            this.colFloor});
            this.dataGridView1.DataSource = this.assetsBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(902, 546);
            this.dataGridView1.TabIndex = 0;
            // 
            // colAssetid
            // 
            this.colAssetid.DataPropertyName = "AssetId";
            this.colAssetid.HeaderText = "자산No";
            this.colAssetid.Name = "colAssetid";
            this.colAssetid.ReadOnly = true;
            this.colAssetid.Width = 60;
            // 
            // colGroupname
            // 
            this.colGroupname.DataPropertyName = "GroupName";
            this.colGroupname.HeaderText = "GroupName";
            this.colGroupname.Name = "colGroupname";
            // 
            // colZonename
            // 
            this.colZonename.DataPropertyName = "ZoneName";
            this.colZonename.HeaderText = "ZoneName";
            this.colZonename.Name = "colZonename";
            this.colZonename.Width = 120;
            // 
            // colSpeakername
            // 
            this.colSpeakername.DataPropertyName = "SpeakerName";
            this.colSpeakername.HeaderText = "SpeakerName";
            this.colSpeakername.Name = "colSpeakername";
            // 
            // colDevicename
            // 
            this.colDevicename.DataPropertyName = "DeviceName";
            this.colDevicename.HeaderText = "DeviceName";
            this.colDevicename.Name = "colDevicename";
            this.colDevicename.Width = 120;
            // 
            // colCh
            // 
            this.colCh.DataPropertyName = "ch";
            this.colCh.HeaderText = "채널";
            this.colCh.Name = "colCh";
            this.colCh.Width = 60;
            // 
            // colEmdata
            // 
            this.colEmdata.DataPropertyName = "emData";
            this.colEmdata.HeaderText = "층정보";
            this.colEmdata.Name = "colEmdata";
            this.colEmdata.Width = 120;
            // 
            // colDeviceid
            // 
            this.colDeviceid.DataPropertyName = "DeviceId";
            this.colDeviceid.HeaderText = "장비No";
            this.colDeviceid.Name = "colDeviceid";
            this.colDeviceid.Width = 60;
            // 
            // colIp
            // 
            this.colIp.DataPropertyName = "ip";
            this.colIp.HeaderText = "ip";
            this.colIp.Name = "colIp";
            this.colIp.Width = 120;
            // 
            // colState
            // 
            this.colState.DataPropertyName = "state";
            this.colState.HeaderText = "state";
            this.colState.Name = "colState";
            this.colState.Visible = false;
            // 
            // colState_Old
            // 
            this.colState_Old.DataPropertyName = "state_old";
            this.colState_Old.HeaderText = "state_old";
            this.colState_Old.Name = "colState_Old";
            this.colState_Old.Visible = false;
            // 
            // colChk
            // 
            this.colChk.DataPropertyName = "chk";
            this.colChk.HeaderText = "chk";
            this.colChk.Name = "colChk";
            this.colChk.Visible = false;
            // 
            // colSeq
            // 
            this.colSeq.DataPropertyName = "seq";
            this.colSeq.HeaderText = "seq";
            this.colSeq.Name = "colSeq";
            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "path";
            this.colPath.HeaderText = "path";
            this.colPath.Name = "colPath";
            this.colPath.Visible = false;
            // 
            // colFloor
            // 
            this.colFloor.DataPropertyName = "floor";
            this.colFloor.HeaderText = "층정보";
            this.colFloor.Name = "colFloor";
            this.colFloor.Visible = false;
            this.colFloor.Width = 60;
            // 
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "Assets";
            this.assetsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // upload1
            // 
            this.upload1.ButtonPosition = System.Drawing.ContentAlignment.MiddleLeft;
            this.upload1.Location = new System.Drawing.Point(10, 19);
            this.upload1.Name = "upload1";
            this.upload1.Size = new System.Drawing.Size(243, 30);
            this.upload1.TabIndex = 4;
            this.upload1.Text = "선번장 읽기";
            this.upload1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "적용";
            this.button2.ToolTipText = "장비를 전체 검출하므로 시간이 필요합니다.";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ptop
            // 
            this.ptop.Controls.Add(this.upload1);
            this.ptop.Controls.Add(this.button2);
            this.ptop.Controls.Add(this.button1);
            this.ptop.Dock = Wisej.Web.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(902, 70);
            this.ptop.TabIndex = 6;
            this.ptop.TabStop = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "삭제";
            this.button1.ToolTipText = "선택된 레크드를 삭제합니다.";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // colEmserver
            // 
            this.colEmserver.DataPropertyName = "emServer";
            this.colEmserver.HeaderText = "emServer";
            this.colEmserver.Name = "colEmserver";
            this.colEmserver.Width = 140;
            // 
            // View_BBCZone
            // 
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ptop);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCZone";
            this.Size = new System.Drawing.Size(902, 616);
            this.Load += new System.EventHandler(this.BSAsset_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ptop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colAssetid;
        private Wisej.Web.DataGridViewTextBoxColumn colGroupname;
        private Wisej.Web.DataGridViewTextBoxColumn colZonename;
        private Wisej.Web.DataGridViewTextBoxColumn colSpeakername;
        private Wisej.Web.DataGridViewTextBoxColumn colDevicename;
        private Wisej.Web.DataGridViewTextBoxColumn colCh;
        private Wisej.Web.DataGridViewTextBoxColumn colDeviceid;
        private Wisej.Web.DataGridViewTextBoxColumn colIp;
        private Wisej.Web.DataGridViewTextBoxColumn colState;
        private Wisej.Web.DataGridViewTextBoxColumn colState_Old;
        private Wisej.Web.DataGridViewTextBoxColumn colChk;
        private Wisej.Web.DataGridViewTextBoxColumn colSeq;
        private Wisej.Web.DataGridViewTextBoxColumn colPath;
        private Wisej.Web.DataGridViewTextBoxColumn colFloor;
        private Wisej.Web.BindingSource assetsBindingSource;
        private DataSet1 dataSet1;
        private Wisej.Web.Upload upload1;
        private Wisej.Web.Button button2;
        private Wisej.Web.Panel ptop;
        private Wisej.Web.Button button1;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter;
        private Wisej.Web.DataGridViewTextBoxColumn colEmdata;
        private Wisej.Web.DataGridViewTextBoxColumn colEmserver;
    }
}
