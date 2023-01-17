namespace simplepa2.UI.Components
{
    partial class Comp_FilePlayer
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
            Wisej.Web.DataGridView mdataGridView1;
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle6 = new Wisej.Web.DataGridViewCellStyle();
            this.Col_MusicId = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Col_FileName = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Col_duration = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Col_FileContent = new Wisej.Web.DataGridViewTextBoxColumn();
            this.mbindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.dataSet11 = new simplepa2.DataSet1();
            this.pn_fill = new Wisej.Web.Panel();
            this.panel_musicList = new Wisej.Web.Panel();
            this.pn_addArea = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.tb_description = new Wisej.Web.TextBox();
            this.line2 = new Wisej.Web.Line();
            this.bt_musicAdd = new Wisej.Web.Button();
            this.label24 = new Wisej.Web.Label();
            this.upload1 = new Wisej.Web.Upload();
            this.panel_player = new Wisej.Web.Panel();
            this.line1 = new Wisej.Web.Line();
            this.panel83 = new Wisej.Web.Panel();
            this.audioDefault = new Wisej.Web.Audio();
            this.panel14 = new Wisej.Web.Panel();
            this.panel13 = new Wisej.Web.Panel();
            this.panel1 = new Wisej.Web.Panel();
            this.lb_playTimeEnd = new Wisej.Web.Label();
            this.lb_playerSpacer = new Wisej.Web.Label();
            this.lb_playTimeStart = new Wisej.Web.Label();
            this.lb_selectContetns = new Wisej.Web.Label();
            this.pn_spacer = new Wisej.Web.Panel();
            this.pn_icon = new Wisej.Web.Panel();
            this.panel85 = new Wisej.Web.Panel();
            this.musicsTableAdapter1 = new simplepa2.DataSet1TableAdapters.MusicsTableAdapter();
            this.animationTextMoving = new Wisej.Web.Animation(this.components);
            mdataGridView1 = new Wisej.Web.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(mdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.pn_fill.SuspendLayout();
            this.panel_musicList.SuspendLayout();
            this.pn_addArea.SuspendLayout();
            this.panel_player.SuspendLayout();
            this.panel83.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_icon.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdataGridView1
            // 
            mdataGridView1.AccessibleName = "";
            mdataGridView1.AccessibleRole = Wisej.Web.AccessibleRole.ScrollBar;
            mdataGridView1.AutoGenerateColumns = false;
            mdataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.Col_MusicId,
            this.Col_FileName,
            this.Col_duration,
            this.Col_FileContent});
            mdataGridView1.DataSource = this.mbindingSource1;
            mdataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            mdataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            mdataGridView1.Location = new System.Drawing.Point(5, 5);
            mdataGridView1.MultiSelect = false;
            mdataGridView1.Name = "mdataGridView1";
            mdataGridView1.RowHeadersVisible = false;
            mdataGridView1.RowHeadersWidth = 16;
            mdataGridView1.Size = new System.Drawing.Size(990, 359);
            mdataGridView1.TabIndex = 10;
            mdataGridView1.CellMouseClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.mdataGridView1_CellMouseClick);
            // 
            // Col_MusicId
            // 
            this.Col_MusicId.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_MusicId.DataPropertyName = "MusicId";
            dataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Col_MusicId.DefaultCellStyle = dataGridViewCellStyle4;
            this.Col_MusicId.HeaderText = "No";
            this.Col_MusicId.MaximumWidth = 100;
            this.Col_MusicId.MinimumWidth = 70;
            this.Col_MusicId.Name = "Col_MusicId";
            this.Col_MusicId.ReadOnly = true;
            this.Col_MusicId.Width = 70;
            // 
            // Col_FileName
            // 
            this.Col_FileName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_FileName.DataPropertyName = "FileName";
            dataGridViewCellStyle5.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Col_FileName.DefaultCellStyle = dataGridViewCellStyle5;
            this.Col_FileName.HeaderText = "파일명";
            this.Col_FileName.MaximumWidth = 450;
            this.Col_FileName.MinimumWidth = 250;
            this.Col_FileName.Name = "Col_FileName";
            this.Col_FileName.Width = 300;
            // 
            // Col_duration
            // 
            this.Col_duration.DataPropertyName = "duration";
            dataGridViewCellStyle6.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Col_duration.DefaultCellStyle = dataGridViewCellStyle6;
            this.Col_duration.HeaderText = "재생시간";
            this.Col_duration.MinimumWidth = 100;
            this.Col_duration.Name = "Col_duration";
            this.Col_duration.Width = 120;
            // 
            // Col_FileContent
            // 
            this.Col_FileContent.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_FileContent.DataPropertyName = "FileContent";
            this.Col_FileContent.HeaderText = "부가 설명";
            this.Col_FileContent.MinimumWidth = 140;
            this.Col_FileContent.Name = "Col_FileContent";
            this.Col_FileContent.Width = 140;
            // 
            // mbindingSource1
            // 
            this.mbindingSource1.DataMember = "Musics";
            this.mbindingSource1.DataSource = this.dataSet11;
            this.mbindingSource1.RefreshValueOnChange = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pn_fill
            // 
            this.pn_fill.AutoSize = true;
            this.pn_fill.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.pn_fill.Controls.Add(this.panel_musicList);
            this.pn_fill.Controls.Add(this.pn_addArea);
            this.pn_fill.Controls.Add(this.panel_player);
            this.pn_fill.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_fill.Location = new System.Drawing.Point(0, 0);
            this.pn_fill.Name = "pn_fill";
            this.pn_fill.Size = new System.Drawing.Size(1000, 500);
            this.pn_fill.TabIndex = 160;
            // 
            // panel_musicList
            // 
            this.panel_musicList.Controls.Add(mdataGridView1);
            this.panel_musicList.Dock = Wisej.Web.DockStyle.Fill;
            this.panel_musicList.Location = new System.Drawing.Point(0, 131);
            this.panel_musicList.Name = "panel_musicList";
            this.panel_musicList.Padding = new Wisej.Web.Padding(5);
            this.panel_musicList.Size = new System.Drawing.Size(1000, 369);
            this.panel_musicList.TabIndex = 167;
            // 
            // pn_addArea
            // 
            this.pn_addArea.Controls.Add(this.label1);
            this.pn_addArea.Controls.Add(this.tb_description);
            this.pn_addArea.Controls.Add(this.line2);
            this.pn_addArea.Controls.Add(this.bt_musicAdd);
            this.pn_addArea.Controls.Add(this.label24);
            this.pn_addArea.Controls.Add(this.upload1);
            this.pn_addArea.Dock = Wisej.Web.DockStyle.Top;
            this.pn_addArea.Location = new System.Drawing.Point(0, 75);
            this.pn_addArea.Name = "pn_addArea";
            this.pn_addArea.Size = new System.Drawing.Size(1000, 56);
            this.pn_addArea.TabIndex = 164;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label1.Location = new System.Drawing.Point(429, 19);
            this.label1.Margin = new Wisej.Web.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 36);
            this.label1.TabIndex = 174;
            this.label1.Text = "부가 설명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(503, 20);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(218, 36);
            this.tb_description.TabIndex = 173;
            // 
            // line2
            // 
            this.line2.Dock = Wisej.Web.DockStyle.Top;
            this.line2.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line2.Location = new System.Drawing.Point(0, 0);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(1000, 1);
            // 
            // bt_musicAdd
            // 
            this.bt_musicAdd.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.bt_musicAdd.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_musicAdd.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_musicAdd.Location = new System.Drawing.Point(733, 21);
            this.bt_musicAdd.Margin = new Wisej.Web.Padding(0);
            this.bt_musicAdd.Name = "bt_musicAdd";
            this.bt_musicAdd.Size = new System.Drawing.Size(100, 32);
            this.bt_musicAdd.TabIndex = 172;
            this.bt_musicAdd.Text = "음원 추가";
            this.bt_musicAdd.Click += new System.EventHandler(this.bt_musicAdd_Click);
            // 
            // label24
            // 
            this.label24.AutoEllipsis = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label24.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label24.Location = new System.Drawing.Point(3, 17);
            this.label24.Margin = new Wisej.Web.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 36);
            this.label24.TabIndex = 171;
            this.label24.Text = "신규 파일";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // upload1
            // 
            this.upload1.AllowedFileTypes = ".mp3";
            this.upload1.CssStyle = "border-radius:10px;";
            this.upload1.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.upload1.Location = new System.Drawing.Point(80, 20);
            this.upload1.Name = "upload1";
            this.upload1.Size = new System.Drawing.Size(317, 32);
            this.upload1.TabIndex = 170;
            this.upload1.Text = "파일 업로드";
            this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
            // 
            // panel_player
            // 
            this.panel_player.Controls.Add(this.line1);
            this.panel_player.Controls.Add(this.panel83);
            this.panel_player.Dock = Wisej.Web.DockStyle.Top;
            this.panel_player.Location = new System.Drawing.Point(0, 0);
            this.panel_player.Name = "panel_player";
            this.panel_player.Size = new System.Drawing.Size(1000, 75);
            this.panel_player.TabIndex = 166;
            // 
            // line1
            // 
            this.line1.Dock = Wisej.Web.DockStyle.Top;
            this.line1.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line1.Location = new System.Drawing.Point(0, 72);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1000, 1);
            // 
            // panel83
            // 
            this.panel83.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel83.Controls.Add(this.audioDefault);
            this.panel83.Controls.Add(this.panel14);
            this.panel83.Controls.Add(this.panel13);
            this.panel83.Controls.Add(this.pn_spacer);
            this.panel83.Controls.Add(this.pn_icon);
            this.panel83.Dock = Wisej.Web.DockStyle.Top;
            this.panel83.Location = new System.Drawing.Point(0, 0);
            this.panel83.Name = "panel83";
            this.panel83.Padding = new Wisej.Web.Padding(16, 11, 16, 11);
            this.panel83.Size = new System.Drawing.Size(1000, 72);
            this.panel83.TabIndex = 130;
            // 
            // audioDefault
            // 
            this.audioDefault.Dock = Wisej.Web.DockStyle.Left;
            this.audioDefault.Location = new System.Drawing.Point(266, 11);
            this.audioDefault.Name = "audioDefault";
            this.audioDefault.Size = new System.Drawing.Size(417, 50);
            this.audioDefault.TabIndex = 137;
            this.audioDefault.Volume = 0.5D;
            this.audioDefault.VolumeChanged += new System.EventHandler(this.audioDefault_VolumeChanged);
            this.audioDefault.Paused += new System.EventHandler(this.audioDefault_Paused);
            this.audioDefault.Playing += new System.EventHandler(this.audioDefault_Playing);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Dock = Wisej.Web.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(256, 11);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 50);
            this.panel14.TabIndex = 143;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.panel1);
            this.panel13.Controls.Add(this.lb_selectContetns);
            this.panel13.Dock = Wisej.Web.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(76, 11);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new Wisej.Web.Padding(6, 0, 0, 0);
            this.panel13.Size = new System.Drawing.Size(180, 50);
            this.panel13.TabIndex = 142;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_playTimeEnd);
            this.panel1.Controls.Add(this.lb_playerSpacer);
            this.panel1.Controls.Add(this.lb_playTimeStart);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 26);
            this.panel1.TabIndex = 136;
            // 
            // lb_playTimeEnd
            // 
            this.lb_playTimeEnd.AutoEllipsis = true;
            this.lb_playTimeEnd.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.lb_playTimeEnd.Dock = Wisej.Web.DockStyle.Left;
            this.lb_playTimeEnd.Font = new System.Drawing.Font("@ns400", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_playTimeEnd.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.lb_playTimeEnd.Location = new System.Drawing.Point(95, 0);
            this.lb_playTimeEnd.Name = "lb_playTimeEnd";
            this.lb_playTimeEnd.Size = new System.Drawing.Size(80, 26);
            this.lb_playTimeEnd.TabIndex = 137;
            this.lb_playTimeEnd.Text = "00:03:12";
            this.lb_playTimeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_playerSpacer
            // 
            this.lb_playerSpacer.AutoEllipsis = true;
            this.lb_playerSpacer.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.lb_playerSpacer.Dock = Wisej.Web.DockStyle.Left;
            this.lb_playerSpacer.Font = new System.Drawing.Font("@ns400", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_playerSpacer.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.lb_playerSpacer.Location = new System.Drawing.Point(80, 0);
            this.lb_playerSpacer.Name = "lb_playerSpacer";
            this.lb_playerSpacer.Size = new System.Drawing.Size(15, 26);
            this.lb_playerSpacer.TabIndex = 136;
            this.lb_playerSpacer.Text = "/ ";
            this.lb_playerSpacer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_playTimeStart
            // 
            this.lb_playTimeStart.AutoEllipsis = true;
            this.lb_playTimeStart.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.lb_playTimeStart.Dock = Wisej.Web.DockStyle.Left;
            this.lb_playTimeStart.Font = new System.Drawing.Font("@ns400", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_playTimeStart.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.lb_playTimeStart.Location = new System.Drawing.Point(0, 0);
            this.lb_playTimeStart.Name = "lb_playTimeStart";
            this.lb_playTimeStart.Size = new System.Drawing.Size(80, 26);
            this.lb_playTimeStart.TabIndex = 135;
            this.lb_playTimeStart.Text = " 05:12:00";
            this.lb_playTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_selectContetns
            // 
            this.animationTextMoving.GetAnimation(this.lb_selectContetns).Event = "pointerover";
            this.animationTextMoving.GetAnimation(this.lb_selectContetns).Name = "popOut";
            this.lb_selectContetns.AutoEllipsis = true;
            this.lb_selectContetns.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.lb_selectContetns.Dock = Wisej.Web.DockStyle.Top;
            this.lb_selectContetns.Font = new System.Drawing.Font("@ns700", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_selectContetns.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.lb_selectContetns.Location = new System.Drawing.Point(6, 0);
            this.lb_selectContetns.Name = "lb_selectContetns";
            this.lb_selectContetns.Size = new System.Drawing.Size(174, 24);
            this.lb_selectContetns.TabIndex = 134;
            this.lb_selectContetns.Text = "Music File Name";
            this.lb_selectContetns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_spacer
            // 
            this.pn_spacer.BackColor = System.Drawing.Color.Transparent;
            this.pn_spacer.Dock = Wisej.Web.DockStyle.Left;
            this.pn_spacer.Location = new System.Drawing.Point(66, 11);
            this.pn_spacer.Name = "pn_spacer";
            this.pn_spacer.Size = new System.Drawing.Size(10, 50);
            this.pn_spacer.TabIndex = 139;
            // 
            // pn_icon
            // 
            this.pn_icon.BackColor = System.Drawing.Color.White;
            this.pn_icon.Controls.Add(this.panel85);
            this.pn_icon.CssStyle = "    width: 50px;\r\n    height: 50px;\r\n    border-radius: 15px;\r\n    background: #f" +
    "ff;\r\n    border: 1px solid /*#E0E3EB*/#dde4f3;";
            this.pn_icon.Dock = Wisej.Web.DockStyle.Left;
            this.pn_icon.Location = new System.Drawing.Point(16, 11);
            this.pn_icon.Name = "pn_icon";
            this.pn_icon.Size = new System.Drawing.Size(50, 50);
            this.pn_icon.TabIndex = 0;
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
            // musicsTableAdapter1
            // 
            this.musicsTableAdapter1.ClearBeforeFill = true;
            // 
            // Comp_FilePlayer
            // 
            this.Controls.Add(this.pn_fill);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "Comp_FilePlayer";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.Comp_FilePlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(mdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.pn_fill.ResumeLayout(false);
            this.panel_musicList.ResumeLayout(false);
            this.pn_addArea.ResumeLayout(false);
            this.pn_addArea.PerformLayout();
            this.panel_player.ResumeLayout(false);
            this.panel83.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pn_icon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel pn_fill;
        private Wisej.Web.Panel pn_addArea;
        private Wisej.Web.Upload upload1;
        private Wisej.Web.Label label24;
        private Wisej.Web.Button bt_musicAdd;
        private DataSet1TableAdapters.MusicsTableAdapter musicsTableAdapter1;
        private DataSet1 dataSet11;
        private Wisej.Web.Panel panel_player;
        private Wisej.Web.Line line1;
        private Wisej.Web.Panel panel83;
        private Wisej.Web.Panel panel14;
        private Wisej.Web.Panel pn_spacer;
        private Wisej.Web.Panel pn_icon;
        private Wisej.Web.Panel panel85;
        private Wisej.Web.Panel panel_musicList;
        private Wisej.Web.DataGridViewTextBoxColumn Col_MusicId;
        private Wisej.Web.DataGridViewTextBoxColumn Col_FileName;
        private Wisej.Web.DataGridViewTextBoxColumn Col_duration;
        private Wisej.Web.DataGridViewTextBoxColumn Col_FileContent;
        private Wisej.Web.Line line2;
        private Wisej.Web.Label label1;
        private Wisej.Web.TextBox tb_description;
        private Wisej.Web.BindingSource mbindingSource1;
        private Wisej.Web.Animation animationTextMoving;
        private Wisej.Web.Audio audioDefault;
        private Wisej.Web.Panel panel13;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Label lb_playTimeEnd;
        private Wisej.Web.Label lb_playerSpacer;
        private Wisej.Web.Label lb_playTimeStart;
        private Wisej.Web.Label lb_selectContetns;
    }
}
