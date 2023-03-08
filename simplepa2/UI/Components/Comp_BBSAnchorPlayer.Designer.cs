namespace simplepa2.UI.Components
{
    partial class Comp_BBSAnchorPlayer
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle6 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle7 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle8 = new Wisej.Web.DataGridViewCellStyle();
            this.pn_musicPlayer = new Wisej.Web.Panel();
            this.panel83_musicPanels = new Wisej.Web.Panel();
            this.dg_playList = new Wisej.Web.DataGridView();
            this.no = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFilename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFilecontent = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel82_spacer = new Wisej.Web.Panel();
            this.panel1 = new Wisej.Web.Panel();
            this.audioDefault = new Wisej.Web.Audio();
            this.panel15 = new Wisej.Web.Panel();
            this.bt_addFileList = new Wisej.Web.Button();
            this.pn_playside = new Wisej.Web.Panel();
            this.bt_filePlay = new Wisej.Web.Button();
            this.panel18 = new Wisej.Web.Panel();
            this.bt_playNext = new Wisej.Web.Button();
            this.panel17 = new Wisej.Web.Panel();
            this.bt_filePrevious = new Wisej.Web.Button();
            this.panel14 = new Wisej.Web.Panel();
            this.panel13 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.lb_playMax = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.lb_playCal = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.lb_FileContent = new Wisej.Web.Label();
            this.lb_playFileName = new Wisej.Web.Label();
            this.panel12 = new Wisej.Web.Panel();
            this.panel10 = new Wisej.Web.Panel();
            this.panel84 = new Wisej.Web.Panel();
            this.panel85 = new Wisej.Web.Panel();
            this.pn_musicTitle = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.animation1 = new Wisej.Web.Animation(this.components);
            this.pn_musicPlayer.SuspendLayout();
            this.panel83_musicPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_playList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel84.SuspendLayout();
            this.pn_musicTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_musicPlayer
            // 
            this.pn_musicPlayer.BackColor = System.Drawing.Color.White;
            this.pn_musicPlayer.Controls.Add(this.panel83_musicPanels);
            this.pn_musicPlayer.Controls.Add(this.pn_musicTitle);
            this.pn_musicPlayer.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_musicPlayer.Location = new System.Drawing.Point(0, 0);
            this.pn_musicPlayer.Name = "pn_musicPlayer";
            this.pn_musicPlayer.Padding = new Wisej.Web.Padding(20);
            this.pn_musicPlayer.Size = new System.Drawing.Size(660, 670);
            this.pn_musicPlayer.TabIndex = 170;
            // 
            // panel83_musicPanels
            // 
            this.panel83_musicPanels.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel83_musicPanels.Controls.Add(this.dg_playList);
            this.panel83_musicPanels.Controls.Add(this.panel82_spacer);
            this.panel83_musicPanels.Controls.Add(this.panel1);
            this.panel83_musicPanels.Dock = Wisej.Web.DockStyle.Top;
            this.panel83_musicPanels.Location = new System.Drawing.Point(20, 57);
            this.panel83_musicPanels.Name = "panel83_musicPanels";
            this.panel83_musicPanels.Padding = new Wisej.Web.Padding(16, 11, 16, 11);
            this.panel83_musicPanels.Size = new System.Drawing.Size(620, 600);
            this.panel83_musicPanels.TabIndex = 129;
            // 
            // dg_playList
            // 
            this.dg_playList.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dg_playList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_playList.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.no,
            this.colFilename,
            this.colFilecontent});
            this.dg_playList.Dock = Wisej.Web.DockStyle.Fill;
            this.dg_playList.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dg_playList.Location = new System.Drawing.Point(16, 95);
            this.dg_playList.Name = "dg_playList";
            this.dg_playList.RowHeadersVisible = false;
            this.dg_playList.RowHeadersWidth = 14;
            this.dg_playList.Size = new System.Drawing.Size(588, 494);
            this.dg_playList.TabIndex = 168;
            this.dg_playList.DoubleClick += new System.EventHandler(this.dg_playList_DoubleClick);
            // 
            // no
            // 
            this.no.DataPropertyName = "MusicId";
            dataGridViewCellStyle6.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.no.DefaultCellStyle = dataGridViewCellStyle6;
            this.no.Frozen = true;
            this.no.HeaderText = "번호";
            this.no.MinimumWidth = 80;
            this.no.Name = "no";
            // 
            // colFilename
            // 
            this.colFilename.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.colFilename.DataPropertyName = "FileName";
            dataGridViewCellStyle7.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Padding = new Wisej.Web.Padding(3, 0, 0, 0);
            this.colFilename.DefaultCellStyle = dataGridViewCellStyle7;
            this.colFilename.HeaderText = "방송파일";
            this.colFilename.Name = "colFilename";
            this.colFilename.Width = 150;
            // 
            // colFilecontent
            // 
            this.colFilecontent.DataPropertyName = "duration";
            dataGridViewCellStyle8.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colFilecontent.DefaultCellStyle = dataGridViewCellStyle8;
            this.colFilecontent.HeaderText = "재생시간";
            this.colFilecontent.Name = "colFilecontent";
            this.colFilecontent.Width = 120;
            // 
            // panel82_spacer
            // 
            this.panel82_spacer.Dock = Wisej.Web.DockStyle.Top;
            this.panel82_spacer.Location = new System.Drawing.Point(16, 83);
            this.panel82_spacer.Name = "panel82_spacer";
            this.panel82_spacer.Size = new System.Drawing.Size(588, 12);
            this.panel82_spacer.TabIndex = 130;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.audioDefault);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel84);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(16, 11);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(16, 11, 16, 11);
            this.panel1.Size = new System.Drawing.Size(588, 72);
            this.panel1.TabIndex = 145;
            // 
            // audioDefault
            // 
            this.audioDefault.Dock = Wisej.Web.DockStyle.Left;
            this.audioDefault.Location = new System.Drawing.Point(551, 11);
            this.audioDefault.Name = "audioDefault";
            this.audioDefault.Size = new System.Drawing.Size(296, 50);
            this.audioDefault.TabIndex = 145;
            this.audioDefault.Visible = false;
            this.audioDefault.Volume = 0.5D;
            this.audioDefault.Ended += new System.EventHandler(this.audioDefault_Ended);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.Controls.Add(this.bt_addFileList);
            this.panel15.Controls.Add(this.pn_playside);
            this.panel15.Controls.Add(this.bt_filePlay);
            this.panel15.Controls.Add(this.panel18);
            this.panel15.Controls.Add(this.bt_playNext);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Controls.Add(this.bt_filePrevious);
            this.panel15.Dock = Wisej.Web.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(387, 11);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new Wisej.Web.Padding(0, 8, 0, 8);
            this.panel15.Size = new System.Drawing.Size(164, 50);
            this.panel15.TabIndex = 144;
            // 
            // bt_addFileList
            // 
            this.bt_addFileList.BackColor = System.Drawing.Color.White;
            this.bt_addFileList.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.bt_addFileList.BackgroundImageSource = "Images/music-crrl-5.png";
            this.bt_addFileList.Dock = Wisej.Web.DockStyle.Left;
            this.bt_addFileList.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.bt_addFileList.Location = new System.Drawing.Point(120, 8);
            this.bt_addFileList.Name = "bt_addFileList";
            this.bt_addFileList.Size = new System.Drawing.Size(32, 34);
            this.bt_addFileList.TabIndex = 153;
            this.bt_addFileList.Click += new System.EventHandler(this.bt_addFileList_Click);
            // 
            // pn_playside
            // 
            this.pn_playside.BackColor = System.Drawing.Color.Transparent;
            this.pn_playside.Dock = Wisej.Web.DockStyle.Left;
            this.pn_playside.Location = new System.Drawing.Point(112, 8);
            this.pn_playside.Name = "pn_playside";
            this.pn_playside.Size = new System.Drawing.Size(8, 34);
            this.pn_playside.TabIndex = 148;
            // 
            // bt_filePlay
            // 
            this.bt_filePlay.BackColor = System.Drawing.Color.White;
            this.bt_filePlay.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.bt_filePlay.BackgroundImageSource = "Images/music-crrl-3.png";
            this.bt_filePlay.Dock = Wisej.Web.DockStyle.Left;
            this.bt_filePlay.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.bt_filePlay.Location = new System.Drawing.Point(80, 8);
            this.bt_filePlay.Name = "bt_filePlay";
            this.bt_filePlay.Size = new System.Drawing.Size(32, 34);
            this.bt_filePlay.TabIndex = 156;
            this.bt_filePlay.Click += new System.EventHandler(this.bt_filePlay_Click);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Transparent;
            this.panel18.Dock = Wisej.Web.DockStyle.Left;
            this.panel18.Location = new System.Drawing.Point(72, 8);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(8, 34);
            this.panel18.TabIndex = 146;
            // 
            // bt_playNext
            // 
            this.bt_playNext.BackColor = System.Drawing.Color.White;
            this.bt_playNext.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.bt_playNext.BackgroundImageSource = "Images/music-crrl-2.png";
            this.bt_playNext.Dock = Wisej.Web.DockStyle.Left;
            this.bt_playNext.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.bt_playNext.Location = new System.Drawing.Point(40, 8);
            this.bt_playNext.Name = "bt_playNext";
            this.bt_playNext.Size = new System.Drawing.Size(32, 34);
            this.bt_playNext.TabIndex = 154;
            this.bt_playNext.Click += new System.EventHandler(this.bt_playNext_Click);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Dock = Wisej.Web.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(32, 8);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(8, 34);
            this.panel17.TabIndex = 144;
            // 
            // bt_filePrevious
            // 
            this.bt_filePrevious.BackColor = System.Drawing.Color.White;
            this.bt_filePrevious.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.bt_filePrevious.BackgroundImageSource = "Images/music-crrl-1.png";
            this.bt_filePrevious.Dock = Wisej.Web.DockStyle.Left;
            this.bt_filePrevious.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.bt_filePrevious.Location = new System.Drawing.Point(0, 8);
            this.bt_filePrevious.Name = "bt_filePrevious";
            this.bt_filePrevious.Size = new System.Drawing.Size(32, 34);
            this.bt_filePrevious.TabIndex = 155;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Dock = Wisej.Web.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(377, 11);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 50);
            this.panel14.TabIndex = 143;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.panel2);
            this.panel13.Controls.Add(this.lb_playFileName);
            this.panel13.Dock = Wisej.Web.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(77, 11);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new Wisej.Web.Padding(6, 0, 0, 0);
            this.panel13.Size = new System.Drawing.Size(300, 50);
            this.panel13.TabIndex = 142;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_playMax);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lb_playCal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lb_FileContent);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(6, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 26);
            this.panel2.TabIndex = 137;
            // 
            // lb_playMax
            // 
            this.lb_playMax.AutoEllipsis = true;
            this.lb_playMax.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.lb_playMax.Dock = Wisej.Web.DockStyle.Left;
            this.lb_playMax.Font = new System.Drawing.Font("@ns400", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_playMax.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.lb_playMax.Location = new System.Drawing.Point(225, 0);
            this.lb_playMax.Name = "lb_playMax";
            this.lb_playMax.Size = new System.Drawing.Size(70, 26);
            this.lb_playMax.TabIndex = 139;
            this.lb_playMax.Text = "00:03:12";
            this.lb_playMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.label2.Dock = Wisej.Web.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("@ns400", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.label2.Location = new System.Drawing.Point(215, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 26);
            this.label2.TabIndex = 138;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_playCal
            // 
            this.lb_playCal.AutoEllipsis = true;
            this.lb_playCal.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.lb_playCal.Dock = Wisej.Web.DockStyle.Left;
            this.lb_playCal.Font = new System.Drawing.Font("@ns400", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_playCal.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.lb_playCal.Location = new System.Drawing.Point(145, 0);
            this.lb_playCal.Name = "lb_playCal";
            this.lb_playCal.Size = new System.Drawing.Size(70, 26);
            this.lb_playCal.TabIndex = 137;
            this.lb_playCal.Text = "00:00:00";
            this.lb_playCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.label3.Dock = Wisej.Web.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("@ns400", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.label3.Location = new System.Drawing.Point(135, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 26);
            this.label3.TabIndex = 141;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_FileContent
            // 
            this.lb_FileContent.AutoEllipsis = true;
            this.lb_FileContent.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.lb_FileContent.Dock = Wisej.Web.DockStyle.Left;
            this.lb_FileContent.Font = new System.Drawing.Font("@ns400", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_FileContent.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.lb_FileContent.Location = new System.Drawing.Point(0, 0);
            this.lb_FileContent.Name = "lb_FileContent";
            this.lb_FileContent.Size = new System.Drawing.Size(135, 26);
            this.lb_FileContent.TabIndex = 140;
            this.lb_FileContent.Text = "파일설명";
            this.lb_FileContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_playFileName
            // 
            this.animation1.GetAnimation(this.lb_playFileName).Duration = 500;
            this.animation1.GetAnimation(this.lb_playFileName).Event = "appear";
            this.animation1.GetAnimation(this.lb_playFileName).Name = "grow";
            this.lb_playFileName.AutoEllipsis = true;
            this.lb_playFileName.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.lb_playFileName.Dock = Wisej.Web.DockStyle.Top;
            this.lb_playFileName.Font = new System.Drawing.Font("@ns700", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_playFileName.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.lb_playFileName.Location = new System.Drawing.Point(6, 0);
            this.lb_playFileName.Name = "lb_playFileName";
            this.lb_playFileName.Size = new System.Drawing.Size(294, 24);
            this.lb_playFileName.TabIndex = 134;
            this.lb_playFileName.Text = "파일을 선택하세요";
            this.lb_playFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(219, 222, 232);
            this.panel12.Dock = Wisej.Web.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(76, 11);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 50);
            this.panel12.TabIndex = 141;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Dock = Wisej.Web.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(66, 11);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 50);
            this.panel10.TabIndex = 139;
            // 
            // panel84
            // 
            this.panel84.BackColor = System.Drawing.Color.White;
            this.panel84.Controls.Add(this.panel85);
            this.panel84.CssStyle = "    width: 50px;\r\n    height: 50px;\r\n    border-radius: 15px;\r\n    background: #f" +
    "ff;\r\n    border: 1px solid /*#E0E3EB*/#dde4f3;";
            this.panel84.Dock = Wisej.Web.DockStyle.Left;
            this.panel84.Location = new System.Drawing.Point(16, 11);
            this.panel84.Name = "panel84";
            this.panel84.Size = new System.Drawing.Size(50, 50);
            this.panel84.TabIndex = 0;
            // 
            // panel85
            // 
            this.panel85.CssStyle = "    background: #fff url(../images/icon-ls-001.png) center no-repeat;\r\n    backgr" +
    "ound-size: 24px 24px;";
            this.panel85.Location = new System.Drawing.Point(13, 13);
            this.panel85.Name = "panel85";
            this.panel85.Size = new System.Drawing.Size(24, 24);
            this.panel85.TabIndex = 0;
            // 
            // pn_musicTitle
            // 
            this.pn_musicTitle.Controls.Add(this.label1);
            this.pn_musicTitle.Dock = Wisej.Web.DockStyle.Top;
            this.pn_musicTitle.Location = new System.Drawing.Point(20, 20);
            this.pn_musicTitle.Name = "pn_musicTitle";
            this.pn_musicTitle.Size = new System.Drawing.Size(620, 37);
            this.pn_musicTitle.TabIndex = 162;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new Wisej.Web.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 24);
            this.label1.TabIndex = 134;
            this.label1.Text = "음원 선택";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Comp_BBSAnchorPlayer
            // 
            this.Controls.Add(this.pn_musicPlayer);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "Comp_BBSAnchorPlayer";
            this.Size = new System.Drawing.Size(660, 670);
            this.pn_musicPlayer.ResumeLayout(false);
            this.panel83_musicPanels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_playList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel84.ResumeLayout(false);
            this.pn_musicTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pn_musicPlayer;
        private Wisej.Web.Panel panel83_musicPanels;
        private Wisej.Web.DataGridView dg_playList;
        private Wisej.Web.DataGridViewTextBoxColumn colFilename;
        private Wisej.Web.DataGridViewTextBoxColumn colFilecontent;
        private Wisej.Web.Panel panel82_spacer;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel15;
        private Wisej.Web.Button bt_addFileList;
        private Wisej.Web.Panel pn_playside;
        private Wisej.Web.Button bt_filePlay;
        private Wisej.Web.Panel panel18;
        private Wisej.Web.Button bt_playNext;
        private Wisej.Web.Panel panel17;
        private Wisej.Web.Button bt_filePrevious;
        private Wisej.Web.Panel panel14;
        private Wisej.Web.Panel panel13;
        private Wisej.Web.Panel panel12;
        private Wisej.Web.Panel panel10;
        private Wisej.Web.Panel panel84;
        private Wisej.Web.Panel panel85;
        private Wisej.Web.Panel pn_musicTitle;
        private Wisej.Web.Label label1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Label lb_playCal;
        private Wisej.Web.Label lb_playFileName;
        private Wisej.Web.DataGridViewTextBoxColumn no;
        private Wisej.Web.Audio audioDefault;
        private Wisej.Web.Label lb_playMax;
        private Wisej.Web.Label label2;
        private Wisej.Web.Animation animation1;
        private Wisej.Web.Label lb_FileContent;
        private Wisej.Web.Label label3;
    }
}
