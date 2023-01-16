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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            this.pn_fill = new Wisej.Web.Panel();
            this.panel_musicList = new Wisej.Web.Panel();
            this.mdataGridView1 = new Wisej.Web.DataGridView();
            this.colMusicid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.재생시간 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.FileContent = new Wisej.Web.DataGridViewTextBoxColumn();
            this.mbindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.dataSet11 = new simplepa2.DataSet1();
            this.pn_addArea = new Wisej.Web.Panel();
            this.line2 = new Wisej.Web.Line();
            this.bt_musicAdd = new Wisej.Web.Button();
            this.label24 = new Wisej.Web.Label();
            this.upload1 = new Wisej.Web.Upload();
            this.panel_player = new Wisej.Web.Panel();
            this.line1 = new Wisej.Web.Line();
            this.panel83 = new Wisej.Web.Panel();
            this.panel14 = new Wisej.Web.Panel();
            this.panel13 = new Wisej.Web.Panel();
            this.label6 = new Wisej.Web.Label();
            this.label7 = new Wisej.Web.Label();
            this.panel12 = new Wisej.Web.Panel();
            this.panel11 = new Wisej.Web.Panel();
            this.label5 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.pn_control = new Wisej.Web.Panel();
            this.panel24 = new Wisej.Web.Panel();
            this.panel22 = new Wisej.Web.Panel();
            this.panel23 = new Wisej.Web.Panel();
            this.panel20 = new Wisej.Web.Panel();
            this.panel21 = new Wisej.Web.Panel();
            this.panel18 = new Wisej.Web.Panel();
            this.panel19 = new Wisej.Web.Panel();
            this.panel17 = new Wisej.Web.Panel();
            this.panel16 = new Wisej.Web.Panel();
            this.pn_spacer = new Wisej.Web.Panel();
            this.pn_icon = new Wisej.Web.Panel();
            this.panel85 = new Wisej.Web.Panel();
            this.musicsTableAdapter1 = new simplepa2.DataSet1TableAdapters.MusicsTableAdapter();
            this.pn_fill.SuspendLayout();
            this.panel_musicList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.pn_addArea.SuspendLayout();
            this.panel_player.SuspendLayout();
            this.panel83.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.pn_control.SuspendLayout();
            this.pn_icon.SuspendLayout();
            this.SuspendLayout();
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
            this.pn_fill.Size = new System.Drawing.Size(1000, 360);
            this.pn_fill.TabIndex = 160;
            // 
            // panel_musicList
            // 
            this.panel_musicList.Controls.Add(this.mdataGridView1);
            this.panel_musicList.Dock = Wisej.Web.DockStyle.Top;
            this.panel_musicList.Location = new System.Drawing.Point(0, 131);
            this.panel_musicList.Name = "panel_musicList";
            this.panel_musicList.Padding = new Wisej.Web.Padding(5);
            this.panel_musicList.Size = new System.Drawing.Size(1000, 230);
            this.panel_musicList.TabIndex = 167;
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
            this.mdataGridView1.Location = new System.Drawing.Point(5, 5);
            this.mdataGridView1.Name = "mdataGridView1";
            this.mdataGridView1.RowHeadersVisible = false;
            this.mdataGridView1.RowHeadersWidth = 16;
            this.mdataGridView1.Size = new System.Drawing.Size(990, 220);
            this.mdataGridView1.TabIndex = 10;
            // 
            // colMusicid
            // 
            this.colMusicid.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.colMusicid.DataPropertyName = "MusicId";
            dataGridViewCellStyle1.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colMusicid.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMusicid.HeaderText = "No";
            this.colMusicid.MaximumWidth = 100;
            this.colMusicid.MinimumWidth = 70;
            this.colMusicid.Name = "colMusicid";
            this.colMusicid.ReadOnly = true;
            this.colMusicid.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FileName";
            dataGridViewCellStyle2.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "파일명";
            this.dataGridViewTextBoxColumn2.MaximumWidth = 450;
            this.dataGridViewTextBoxColumn2.MinimumWidth = 250;
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
            // 재생시간
            // 
            this.재생시간.DataPropertyName = "duration";
            dataGridViewCellStyle3.BackgroundImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.재생시간.DefaultCellStyle = dataGridViewCellStyle3;
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
            // mbindingSource1
            // 
            this.mbindingSource1.DataMember = "Musics";
            this.mbindingSource1.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pn_addArea
            // 
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
            this.bt_musicAdd.Location = new System.Drawing.Point(447, 20);
            this.bt_musicAdd.Margin = new Wisej.Web.Padding(0);
            this.bt_musicAdd.Name = "bt_musicAdd";
            this.bt_musicAdd.Size = new System.Drawing.Size(100, 32);
            this.bt_musicAdd.TabIndex = 172;
            this.bt_musicAdd.Text = "음원 추가";
            this.bt_musicAdd.Visible = false;
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
            this.label24.Size = new System.Drawing.Size(123, 36);
            this.label24.TabIndex = 171;
            this.label24.Text = "신규 파일";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // upload1
            // 
            this.upload1.CssStyle = "border-radius:6px;";
            this.upload1.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.upload1.Location = new System.Drawing.Point(126, 20);
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
            this.panel83.Controls.Add(this.panel14);
            this.panel83.Controls.Add(this.panel13);
            this.panel83.Controls.Add(this.panel12);
            this.panel83.Controls.Add(this.panel11);
            this.panel83.Controls.Add(this.pn_control);
            this.panel83.Controls.Add(this.pn_spacer);
            this.panel83.Controls.Add(this.pn_icon);
            this.panel83.Dock = Wisej.Web.DockStyle.Top;
            this.panel83.Location = new System.Drawing.Point(0, 0);
            this.panel83.Name = "panel83";
            this.panel83.Padding = new Wisej.Web.Padding(16, 11, 16, 11);
            this.panel83.Size = new System.Drawing.Size(1000, 72);
            this.panel83.TabIndex = 130;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Dock = Wisej.Web.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(567, 11);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 50);
            this.panel14.TabIndex = 143;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.label6);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Dock = Wisej.Web.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(423, 11);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new Wisej.Web.Padding(6, 0, 0, 0);
            this.panel13.Size = new System.Drawing.Size(144, 50);
            this.panel13.TabIndex = 142;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.label6.Dock = Wisej.Web.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("@ns400", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 135;
            this.label6.Text = "00:03:12 / 05:12:00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.label7.Dock = Wisej.Web.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("@ns700", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 134;
            this.label7.Text = "Let it be - old pop music";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(219, 222, 232);
            this.panel12.Dock = Wisej.Web.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(422, 11);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 50);
            this.panel12.TabIndex = 141;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Dock = Wisej.Web.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(278, 11);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new Wisej.Web.Padding(0, 0, 6, 0);
            this.panel11.Size = new System.Drawing.Size(144, 50);
            this.panel11.TabIndex = 140;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.label5.Dock = Wisej.Web.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("@ns400", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.label5.Location = new System.Drawing.Point(0, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 26);
            this.label5.TabIndex = 135;
            this.label5.Text = "File Player (MP3, Wav)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.label4.Dock = Wisej.Web.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("@ns700", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 134;
            this.label4.Text = "E.M 방송서버(DVS 1)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pn_control
            // 
            this.pn_control.BackColor = System.Drawing.Color.Transparent;
            this.pn_control.Controls.Add(this.panel24);
            this.pn_control.Controls.Add(this.panel22);
            this.pn_control.Controls.Add(this.panel23);
            this.pn_control.Controls.Add(this.panel20);
            this.pn_control.Controls.Add(this.panel21);
            this.pn_control.Controls.Add(this.panel18);
            this.pn_control.Controls.Add(this.panel19);
            this.pn_control.Controls.Add(this.panel17);
            this.pn_control.Controls.Add(this.panel16);
            this.pn_control.Dock = Wisej.Web.DockStyle.Left;
            this.pn_control.Location = new System.Drawing.Point(76, 11);
            this.pn_control.Name = "pn_control";
            this.pn_control.Padding = new Wisej.Web.Padding(0, 8, 0, 8);
            this.pn_control.Size = new System.Drawing.Size(202, 50);
            this.pn_control.TabIndex = 144;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.White;
            this.panel24.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.panel24.BackgroundImageSource = "Images/music-crrl-5.png";
            this.panel24.Dock = Wisej.Web.DockStyle.Left;
            this.panel24.Location = new System.Drawing.Point(160, 8);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(32, 34);
            this.panel24.TabIndex = 151;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.Transparent;
            this.panel22.Dock = Wisej.Web.DockStyle.Left;
            this.panel22.Location = new System.Drawing.Point(152, 8);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(8, 34);
            this.panel22.TabIndex = 150;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel23.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.panel23.BackgroundImageSource = "Images/music-crrl-4.png";
            this.panel23.Dock = Wisej.Web.DockStyle.Left;
            this.panel23.Location = new System.Drawing.Point(120, 8);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(32, 34);
            this.panel23.TabIndex = 149;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Transparent;
            this.panel20.Dock = Wisej.Web.DockStyle.Left;
            this.panel20.Location = new System.Drawing.Point(112, 8);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(8, 34);
            this.panel20.TabIndex = 148;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel21.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.panel21.BackgroundImageSource = "Images/music-crrl-3.png";
            this.panel21.Dock = Wisej.Web.DockStyle.Left;
            this.panel21.Location = new System.Drawing.Point(80, 8);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(32, 34);
            this.panel21.TabIndex = 147;
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
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.panel19.BackgroundImageSource = "Images/music-crrl-2.png";
            this.panel19.Dock = Wisej.Web.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(40, 8);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(32, 34);
            this.panel19.TabIndex = 145;
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
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.panel16.BackgroundImageSource = "Images/music-crrl-1.png";
            this.panel16.Dock = Wisej.Web.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 8);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(32, 34);
            this.panel16.TabIndex = 1;
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
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Name = "Comp_FilePlayer";
            this.Size = new System.Drawing.Size(1000, 360);
            this.Load += new System.EventHandler(this.Comp_FilePlayer_Load);
            this.pn_fill.ResumeLayout(false);
            this.panel_musicList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.pn_addArea.ResumeLayout(false);
            this.panel_player.ResumeLayout(false);
            this.panel83.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.pn_control.ResumeLayout(false);
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
        private Wisej.Web.Panel pn_control;
        private Wisej.Web.Panel panel24;
        private Wisej.Web.Panel panel22;
        private Wisej.Web.Panel panel23;
        private Wisej.Web.Panel panel20;
        private Wisej.Web.Panel panel21;
        private Wisej.Web.Panel panel18;
        private Wisej.Web.Panel panel19;
        private Wisej.Web.Panel panel17;
        private Wisej.Web.Panel panel16;
        private Wisej.Web.Panel panel14;
        private Wisej.Web.Panel panel13;
        private Wisej.Web.Label label6;
        private Wisej.Web.Label label7;
        private Wisej.Web.Panel panel12;
        private Wisej.Web.Panel panel11;
        private Wisej.Web.Label label5;
        private Wisej.Web.Label label4;
        private Wisej.Web.Panel pn_spacer;
        private Wisej.Web.Panel pn_icon;
        private Wisej.Web.Panel panel85;
        private Wisej.Web.Panel panel_musicList;
        private Wisej.Web.DataGridView mdataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colMusicid;
        private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Wisej.Web.DataGridViewTextBoxColumn 재생시간;
        private Wisej.Web.DataGridViewTextBoxColumn FileContent;
        private Wisej.Web.Line line2;
        private Wisej.Web.BindingSource mbindingSource1;
    }
}
