namespace simplepa2.UI.Popups
{
    partial class Form_FilePlayerMusicSelector
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle6 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle7 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle8 = new Wisej.Web.DataGridViewCellStyle();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.panel4 = new Wisej.Web.Panel();
            this.dg_selectedMusicList = new Wisej.Web.DataGridView();
            this.MusicId = new Wisej.Web.DataGridViewTextBoxColumn();
            this.선택파일 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.duration_select = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel7 = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.panel5 = new Wisej.Web.Panel();
            this.bt_deSelect = new Wisej.Web.Button();
            this.bt_select = new Wisej.Web.Button();
            this.panel3 = new Wisej.Web.Panel();
            this.dg_musicList = new Wisej.Web.DataGridView();
            this.ID = new Wisej.Web.DataGridViewTextBoxColumn();
            this.FileName = new Wisej.Web.DataGridViewTextBoxColumn();
            this.FileContent = new Wisej.Web.DataGridViewTextBoxColumn();
            this.bindingMusicList = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.panel6 = new Wisej.Web.Panel();
            this.label17 = new Wisej.Web.Label();
            this.panel136 = new Wisej.Web.Panel();
            this.bt_enterList = new Wisej.Web.Button();
            this.bt_closeWindow = new Wisej.Web.Button();
            this.musicsTableAdapter = new simplepa2.DataSet1TableAdapters.MusicsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_selectedMusicList)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_musicList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingMusicList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel136.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel136);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(20);
            this.panel1.Size = new System.Drawing.Size(888, 603);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 511);
            this.panel2.TabIndex = 55;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dg_selectedMusicList);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = Wisej.Web.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(440, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 511);
            this.panel4.TabIndex = 1;
            // 
            // dg_selectedMusicList
            // 
            this.dg_selectedMusicList.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dg_selectedMusicList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_selectedMusicList.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.MusicId,
            this.선택파일,
            this.duration_select});
            this.dg_selectedMusicList.Dock = Wisej.Web.DockStyle.Fill;
            this.dg_selectedMusicList.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dg_selectedMusicList.Location = new System.Drawing.Point(0, 41);
            this.dg_selectedMusicList.MultiSelect = false;
            this.dg_selectedMusicList.Name = "dg_selectedMusicList";
            this.dg_selectedMusicList.RowHeadersVisible = false;
            this.dg_selectedMusicList.Size = new System.Drawing.Size(390, 470);
            this.dg_selectedMusicList.TabIndex = 1;
            this.dg_selectedMusicList.CellMouseDoubleClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dg_selectedMusicList_CellMouseDoubleClick);
            // 
            // MusicId
            // 
            this.MusicId.DataPropertyName = "MusicId";
            dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MusicId.DefaultCellStyle = dataGridViewCellStyle2;
            this.MusicId.HeaderText = "ID";
            this.MusicId.MinimumWidth = 50;
            this.MusicId.Name = "MusicId";
            this.MusicId.Width = 50;
            // 
            // 선택파일
            // 
            this.선택파일.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.선택파일.DataPropertyName = "FileName";
            dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.선택파일.DefaultCellStyle = dataGridViewCellStyle3;
            this.선택파일.HeaderText = "선택파일";
            this.선택파일.MinimumWidth = 230;
            this.선택파일.Name = "선택파일";
            this.선택파일.Width = 230;
            // 
            // duration_select
            // 
            this.duration_select.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.duration_select.DataPropertyName = "duration";
            dataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.duration_select.DefaultCellStyle = dataGridViewCellStyle4;
            this.duration_select.HeaderText = "재생시간";
            this.duration_select.MinimumWidth = 80;
            this.duration_select.Name = "duration_select";
            this.duration_select.Width = 80;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = Wisej.Web.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(390, 41);
            this.panel7.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Margin = new Wisej.Web.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 24);
            this.label1.TabIndex = 136;
            this.label1.Text = "선택 음원";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bt_deSelect);
            this.panel5.Controls.Add(this.bt_select);
            this.panel5.Dock = Wisej.Web.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(390, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 511);
            this.panel5.TabIndex = 1;
            // 
            // bt_deSelect
            // 
            this.bt_deSelect.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.bt_deSelect.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.bt_deSelect.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.bt_deSelect.BackgroundImageSource = "Images/music-crrl-1.png";
            this.bt_deSelect.Location = new System.Drawing.Point(9, 265);
            this.bt_deSelect.Name = "bt_deSelect";
            this.bt_deSelect.Size = new System.Drawing.Size(33, 33);
            this.bt_deSelect.TabIndex = 3;
            this.bt_deSelect.Click += new System.EventHandler(this.bt_deSelect_Click);
            // 
            // bt_select
            // 
            this.bt_select.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.bt_select.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.bt_select.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.bt_select.BackgroundImageSource = "Images/music-crrl-2.png";
            this.bt_select.Location = new System.Drawing.Point(9, 220);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(33, 33);
            this.bt_select.TabIndex = 2;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dg_musicList);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = Wisej.Web.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 511);
            this.panel3.TabIndex = 0;
            // 
            // dg_musicList
            // 
            this.dg_musicList.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dg_musicList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_musicList.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.ID,
            this.FileName,
            this.FileContent});
            this.dg_musicList.DataSource = this.bindingMusicList;
            this.dg_musicList.Dock = Wisej.Web.DockStyle.Fill;
            this.dg_musicList.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dg_musicList.Location = new System.Drawing.Point(0, 41);
            this.dg_musicList.MultiSelect = false;
            this.dg_musicList.Name = "dg_musicList";
            this.dg_musicList.RowHeadersVisible = false;
            this.dg_musicList.Selectable = true;
            this.dg_musicList.SelectionDelay = 30;
            this.dg_musicList.Size = new System.Drawing.Size(390, 470);
            this.dg_musicList.TabIndex = 0;
            this.dg_musicList.CellMouseDoubleClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dg_musicList_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "MusicId";
            dataGridViewCellStyle6.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ID.DefaultCellStyle = dataGridViewCellStyle6;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.DataPropertyName = "FileName";
            dataGridViewCellStyle7.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FileName.DefaultCellStyle = dataGridViewCellStyle7;
            this.FileName.HeaderText = "파일명";
            this.FileName.MinimumWidth = 120;
            this.FileName.Name = "FileName";
            this.FileName.Width = 120;
            // 
            // FileContent
            // 
            this.FileContent.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.FileContent.DataPropertyName = "FileContent";
            dataGridViewCellStyle8.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FileContent.DefaultCellStyle = dataGridViewCellStyle8;
            this.FileContent.HeaderText = "부가설명";
            this.FileContent.MinimumWidth = 100;
            this.FileContent.Name = "FileContent";
            // 
            // bindingMusicList
            // 
            this.bindingMusicList.DataMember = "Musics";
            this.bindingMusicList.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label17);
            this.panel6.Dock = Wisej.Web.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 41);
            this.panel6.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoEllipsis = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label17.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label17.Location = new System.Drawing.Point(0, 8);
            this.label17.Margin = new Wisej.Web.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(345, 24);
            this.label17.TabIndex = 135;
            this.label17.Text = "등록 음원 리스트";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel136
            // 
            this.panel136.BackColor = System.Drawing.Color.Transparent;
            this.panel136.Controls.Add(this.bt_enterList);
            this.panel136.Controls.Add(this.bt_closeWindow);
            this.panel136.Dock = Wisej.Web.DockStyle.Bottom;
            this.panel136.Location = new System.Drawing.Point(20, 531);
            this.panel136.Name = "panel136";
            this.panel136.Size = new System.Drawing.Size(848, 52);
            this.panel136.TabIndex = 54;
            // 
            // bt_enterList
            // 
            this.bt_enterList.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_enterList.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_enterList.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_enterList.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_enterList.Location = new System.Drawing.Point(640, 13);
            this.bt_enterList.Margin = new Wisej.Web.Padding(0);
            this.bt_enterList.Name = "bt_enterList";
            this.bt_enterList.Size = new System.Drawing.Size(100, 32);
            this.bt_enterList.TabIndex = 36;
            this.bt_enterList.Text = "입력";
            this.bt_enterList.Click += new System.EventHandler(this.bt_enterList_Click);
            // 
            // bt_closeWindow
            // 
            this.bt_closeWindow.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_closeWindow.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.bt_closeWindow.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_closeWindow.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_closeWindow.Location = new System.Drawing.Point(748, 13);
            this.bt_closeWindow.Margin = new Wisej.Web.Padding(0);
            this.bt_closeWindow.Name = "bt_closeWindow";
            this.bt_closeWindow.Size = new System.Drawing.Size(100, 32);
            this.bt_closeWindow.TabIndex = 35;
            this.bt_closeWindow.Text = "닫기";
            this.bt_closeWindow.Click += new System.EventHandler(this.bt_closeWindow_Click);
            // 
            // musicsTableAdapter
            // 
            this.musicsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_FilePlayerMusicSelector
            // 
            this.ClientSize = new System.Drawing.Size(888, 603);
            this.Controls.Add(this.panel1);
            this.HeaderBackColor = System.Drawing.Color.FromName("@button1BG");
            this.Name = "Form_FilePlayerMusicSelector";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "음원 선택기";
            this.Load += new System.EventHandler(this.Form_FilePlayerMusicSelector_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_selectedMusicList)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_musicList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingMusicList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel136.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel136;
        private Wisej.Web.Button bt_enterList;
        private Wisej.Web.Button bt_closeWindow;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Button bt_deSelect;
        private Wisej.Web.Button bt_select;
        private Wisej.Web.DataGridView dg_selectedMusicList;
        private Wisej.Web.DataGridView dg_musicList;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.MusicsTableAdapter musicsTableAdapter;
        private Wisej.Web.Panel panel7;
        private Wisej.Web.Panel panel6;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label17;
        private Wisej.Web.DataGridViewTextBoxColumn ID;
        private Wisej.Web.DataGridViewTextBoxColumn FileName;
        private Wisej.Web.DataGridViewTextBoxColumn FileContent;
        private Wisej.Web.DataGridViewTextBoxColumn MusicId;
        private Wisej.Web.DataGridViewTextBoxColumn 선택파일;
        private Wisej.Web.DataGridViewTextBoxColumn duration_select;
        private Wisej.Web.BindingSource bindingMusicList;
    }
}