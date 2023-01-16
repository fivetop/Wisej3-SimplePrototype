namespace simplepa2.UI.Views
{
    partial class View_BBSMusicManage2
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            this.mbindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.musicsTableAdapter = new simplepa2.DataSet1TableAdapters.MusicsTableAdapter();
            this.ptop = new Wisej.Web.Panel();
            this.mbuttonAdd = new Wisej.Web.Button();
            this.mupload1 = new Wisej.Web.Upload();
            this.mdataGridView1 = new Wisej.Web.DataGridView();
            this.colMusicid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel1 = new Wisej.Web.Panel();
            this.재생시간 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.FileContent = new Wisej.Web.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.ptop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbindingSource1
            // 
            this.mbindingSource1.DataMember = "Musics";
            this.mbindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musicsTableAdapter
            // 
            this.musicsTableAdapter.ClearBeforeFill = true;
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.White;
            this.ptop.Controls.Add(this.mbuttonAdd);
            this.ptop.Controls.Add(this.mupload1);
            this.ptop.Dock = Wisej.Web.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(20, 20);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(825, 52);
            this.ptop.TabIndex = 1;
            this.ptop.TabStop = true;
            // 
            // mbuttonAdd
            // 
            this.mbuttonAdd.Location = new System.Drawing.Point(324, 3);
            this.mbuttonAdd.Name = "mbuttonAdd";
            this.mbuttonAdd.Size = new System.Drawing.Size(57, 27);
            this.mbuttonAdd.TabIndex = 12;
            this.mbuttonAdd.Text = "등록";
            this.mbuttonAdd.Click += new System.EventHandler(this.mbuttonAdd_Click);
            // 
            // mupload1
            // 
            this.mupload1.AllowedFileTypes = ".mp3";
            this.mupload1.ButtonPosition = System.Drawing.ContentAlignment.MiddleLeft;
            this.mupload1.Location = new System.Drawing.Point(0, 0);
            this.mupload1.Name = "mupload1";
            this.mupload1.Size = new System.Drawing.Size(318, 33);
            this.mupload1.TabIndex = 10;
            this.mupload1.Text = "파일";
            this.mupload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.mupload1_Uploaded);
            // 
            // mdataGridView1
            // 
            this.mdataGridView1.AutoGenerateColumns = false;
            this.mdataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colMusicid,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.재생시간,
            this.FileContent});
            this.mdataGridView1.DataSource = this.mbindingSource1;
            this.mdataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.mdataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.mdataGridView1.Location = new System.Drawing.Point(20, 72);
            this.mdataGridView1.Name = "mdataGridView1";
            this.mdataGridView1.RowHeadersVisible = false;
            this.mdataGridView1.RowHeadersWidth = 16;
            this.mdataGridView1.Size = new System.Drawing.Size(825, 485);
            this.mdataGridView1.TabIndex = 9;
            // 
            // colMusicid
            // 
            this.colMusicid.DataPropertyName = "MusicId";
            this.colMusicid.HeaderText = "No";
            this.colMusicid.Name = "colMusicid";
            this.colMusicid.ReadOnly = true;
            this.colMusicid.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn2.HeaderText = "파일명";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FileContent";
            this.dataGridViewTextBoxColumn3.HeaderText = "내용";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.mdataGridView1);
            this.panel1.Controls.Add(this.ptop);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(20);
            this.panel1.Size = new System.Drawing.Size(865, 577);
            this.panel1.TabIndex = 2;
            // 
            // 재생시간
            // 
            this.재생시간.DataPropertyName = "duration";
            dataGridViewCellStyle1.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.재생시간.DefaultCellStyle = dataGridViewCellStyle1;
            this.재생시간.HeaderText = "재생시간";
            this.재생시간.MinimumWidth = 100;
            this.재생시간.Name = "재생시간";
            this.재생시간.Width = 120;
            // 
            // FileContent
            // 
            this.FileContent.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.FileContent.DataPropertyName = "FileContent";
            this.FileContent.HeaderText = "부가설명";
            this.FileContent.MinimumWidth = 140;
            this.FileContent.Name = "FileContent";
            this.FileContent.Width = 140;
            // 
            // View_BBSMusicManage2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel1);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBSMusicManage2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(905, 617);
            this.Load += new System.EventHandler(this.MMusicManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ptop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.BindingSource mbindingSource1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.MusicsTableAdapter musicsTableAdapter;
        private Wisej.Web.Panel ptop;
        private Wisej.Web.DataGridView mdataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colMusicid;
        private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Wisej.Web.Button mbuttonAdd;
        private Wisej.Web.Upload mupload1;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.DataGridViewTextBoxColumn 재생시간;
        private Wisej.Web.DataGridViewTextBoxColumn FileContent;
    }
}
