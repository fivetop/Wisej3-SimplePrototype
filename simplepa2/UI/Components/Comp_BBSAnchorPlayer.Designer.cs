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
            this.pn_musicPlayer = new Wisej.Web.Panel();
            this.panel83_musicPanels = new Wisej.Web.Panel();
            this.dg_playList = new Wisej.Web.DataGridView();
            this.colFilename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFilecontent = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel82_spacer = new Wisej.Web.Panel();
            this.panel1 = new Wisej.Web.Panel();
            this.panel15 = new Wisej.Web.Panel();
            this.bt_filePlayerStop = new Wisej.Web.Button();
            this.panel22 = new Wisej.Web.Panel();
            this.bt_musicAdd = new Wisej.Web.Button();
            this.panel20 = new Wisej.Web.Panel();
            this.bt_filePlay = new Wisej.Web.Button();
            this.panel18 = new Wisej.Web.Panel();
            this.bt_playNext = new Wisej.Web.Button();
            this.panel17 = new Wisej.Web.Panel();
            this.bt_filePrevious = new Wisej.Web.Button();
            this.panel14 = new Wisej.Web.Panel();
            this.panel13 = new Wisej.Web.Panel();
            this.panel12 = new Wisej.Web.Panel();
            this.panel10 = new Wisej.Web.Panel();
            this.panel84 = new Wisej.Web.Panel();
            this.panel85 = new Wisej.Web.Panel();
            this.pn_musicTitle = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.panel2 = new Wisej.Web.Panel();
            this.lb_playTimeEnd = new Wisej.Web.Label();
            this.lb_playerSpacer = new Wisej.Web.Label();
            this.lb_playTimeStart = new Wisej.Web.Label();
            this.label7 = new Wisej.Web.Label();
            this.pn_musicPlayer.SuspendLayout();
            this.panel83_musicPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_playList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel84.SuspendLayout();
            this.pn_musicTitle.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.dg_playList.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colFilename,
            this.colFilecontent});
            this.dg_playList.Dock = Wisej.Web.DockStyle.Fill;
            this.dg_playList.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dg_playList.Location = new System.Drawing.Point(16, 95);
            this.dg_playList.Name = "dg_playList";
            this.dg_playList.RowHeadersWidth = 14;
            this.dg_playList.Size = new System.Drawing.Size(588, 494);
            this.dg_playList.TabIndex = 168;
            // 
            // colFilename
            // 
            this.colFilename.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.colFilename.DataPropertyName = "FileName";
            this.colFilename.HeaderText = "방송파일";
            this.colFilename.Name = "colFilename";
            this.colFilename.Width = 150;
            // 
            // colFilecontent
            // 
            this.colFilecontent.DataPropertyName = "duration";
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
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.Controls.Add(this.bt_filePlayerStop);
            this.panel15.Controls.Add(this.panel22);
            this.panel15.Controls.Add(this.bt_musicAdd);
            this.panel15.Controls.Add(this.panel20);
            this.panel15.Controls.Add(this.bt_filePlay);
            this.panel15.Controls.Add(this.panel18);
            this.panel15.Controls.Add(this.bt_playNext);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Controls.Add(this.bt_filePrevious);
            this.panel15.Dock = Wisej.Web.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(267, 11);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new Wisej.Web.Padding(0, 8, 0, 8);
            this.panel15.Size = new System.Drawing.Size(201, 50);
            this.panel15.TabIndex = 144;
            // 
            // bt_filePlayerStop
            // 
            this.bt_filePlayerStop.BackColor = System.Drawing.Color.White;
            this.bt_filePlayerStop.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.bt_filePlayerStop.BackgroundImageSource = "Images/music-crrl-5.png";
            this.bt_filePlayerStop.Dock = Wisej.Web.DockStyle.Left;
            this.bt_filePlayerStop.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.bt_filePlayerStop.Location = new System.Drawing.Point(160, 8);
            this.bt_filePlayerStop.Name = "bt_filePlayerStop";
            this.bt_filePlayerStop.Size = new System.Drawing.Size(32, 34);
            this.bt_filePlayerStop.TabIndex = 153;
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
            // bt_musicAdd
            // 
            this.bt_musicAdd.BackColor = System.Drawing.Color.White;
            this.bt_musicAdd.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.bt_musicAdd.BackgroundImageSource = "Images/music-crrl-4.png";
            this.bt_musicAdd.Dock = Wisej.Web.DockStyle.Left;
            this.bt_musicAdd.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.bt_musicAdd.Location = new System.Drawing.Point(120, 8);
            this.bt_musicAdd.Name = "bt_musicAdd";
            this.bt_musicAdd.Size = new System.Drawing.Size(32, 34);
            this.bt_musicAdd.TabIndex = 152;
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
            this.panel14.Location = new System.Drawing.Point(257, 11);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 50);
            this.panel14.TabIndex = 143;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.panel2);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Dock = Wisej.Web.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(77, 11);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new Wisej.Web.Padding(6, 0, 0, 0);
            this.panel13.Size = new System.Drawing.Size(180, 50);
            this.panel13.TabIndex = 142;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_playTimeEnd);
            this.panel2.Controls.Add(this.lb_playerSpacer);
            this.panel2.Controls.Add(this.lb_playTimeStart);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(6, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 26);
            this.panel2.TabIndex = 137;
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
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.label7.Dock = Wisej.Web.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("@ns700", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 24);
            this.label7.TabIndex = 134;
            this.label7.Text = "Playing File ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel84.ResumeLayout(false);
            this.pn_musicTitle.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private Wisej.Web.Button bt_filePlayerStop;
        private Wisej.Web.Panel panel22;
        private Wisej.Web.Button bt_musicAdd;
        private Wisej.Web.Panel panel20;
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
        private Wisej.Web.Label lb_playTimeEnd;
        private Wisej.Web.Label lb_playerSpacer;
        private Wisej.Web.Label lb_playTimeStart;
        private Wisej.Web.Label label7;
    }
}
