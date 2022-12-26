namespace simplepa2.UI.Components
{
    partial class Comp_SiteDetailForm
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle36 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle37 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle38 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle39 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle40 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle41 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle42 = new Wisej.Web.DataGridViewCellStyle();
            this.panel3 = new Wisej.Web.Panel();
            this.panel8 = new Wisej.Web.Panel();
            this.dg_buildingStruct = new Wisej.Web.DataGridView();
            this.bd_id = new Wisej.Web.DataGridViewTextBoxColumn();
            this.bd_name = new Wisej.Web.DataGridViewTextBoxColumn();
            this.max_floor_no = new Wisej.Web.DataGridViewTextBoxColumn();
            this.under_floor_no = new Wisej.Web.DataGridViewTextBoxColumn();
            this.num_of_stairs = new Wisej.Web.DataGridViewTextBoxColumn();
            this.bd_fire_id = new Wisej.Web.DataGridViewTextBoxColumn();
            this.bd_description = new Wisej.Web.DataGridViewTextBoxColumn();
            this.line2 = new Wisej.Web.Line();
            this.panel34 = new Wisej.Web.Panel();
            this.bt_newBuilding = new Wisej.Web.Button();
            this.bt_selectBuildDelete = new Wisej.Web.Button();
            this.label2 = new Wisej.Web.Label();
            this.label22 = new Wisej.Web.Label();
            this.panel7 = new Wisej.Web.Panel();
            this.panel89 = new Wisej.Web.Panel();
            this.panel6 = new Wisej.Web.Panel();
            this.pb_sitePreImage = new Wisej.Web.PictureBox();
            this.pic_upload = new Wisej.Web.Upload();
            this.bt_deletePic = new Wisej.Web.Button();
            this.panel10 = new Wisej.Web.Panel();
            this.cb_emServer = new Wisej.Web.ComboBox();
            this.label7 = new Wisej.Web.Label();
            this.panel2 = new Wisej.Web.Panel();
            this.tb_siteDescrip = new Wisej.Web.TextBox();
            this.label6 = new Wisej.Web.Label();
            this.panel1 = new Wisej.Web.Panel();
            this.tb_siteContact = new Wisej.Web.TextBox();
            this.label5 = new Wisej.Web.Label();
            this.panel4 = new Wisej.Web.Panel();
            this.tb_siteAddr = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.panel35 = new Wisej.Web.Panel();
            this.tb_siteName = new Wisej.Web.TextBox();
            this.label24 = new Wisej.Web.Label();
            this.line5 = new Wisej.Web.Line();
            this.panel27 = new Wisej.Web.Panel();
            this.bt_delete = new Wisej.Web.Button();
            this.bt_store = new Wisej.Web.Button();
            this.label26 = new Wisej.Web.Label();
            this.panel22 = new Wisej.Web.Panel();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_buildingStruct)).BeginInit();
            this.panel34.SuspendLayout();
            this.panel89.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sitePreImage)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel27.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel89);
            this.panel3.Controls.Add(this.panel27);
            this.panel3.Controls.Add(this.panel22);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(20);
            this.panel3.Size = new System.Drawing.Size(660, 820);
            this.panel3.TabIndex = 181;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel8.Controls.Add(this.dg_buildingStruct);
            this.panel8.Controls.Add(this.line2);
            this.panel8.Controls.Add(this.panel34);
            this.panel8.Dock = Wisej.Web.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(20, 513);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new Wisej.Web.Padding(20);
            this.panel8.Size = new System.Drawing.Size(620, 287);
            this.panel8.TabIndex = 169;
            // 
            // dg_buildingStruct
            // 
            this.dg_buildingStruct.AutoGenerateColumns = false;
            this.dg_buildingStruct.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.bd_id,
            this.bd_name,
            this.max_floor_no,
            this.under_floor_no,
            this.num_of_stairs,
            this.bd_fire_id,
            this.bd_description});
            this.dg_buildingStruct.Dock = Wisej.Web.DockStyle.Fill;
            this.dg_buildingStruct.Location = new System.Drawing.Point(20, 58);
            this.dg_buildingStruct.Name = "dg_buildingStruct";
            this.dg_buildingStruct.RowHeadersVisible = false;
            this.dg_buildingStruct.Size = new System.Drawing.Size(580, 209);
            this.dg_buildingStruct.TabIndex = 171;
            this.dg_buildingStruct.CellMouseDoubleClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dg_buildingStruct_CellMouseDoubleClick);
            // 
            // bd_id
            // 
            this.bd_id.DataPropertyName = "bd_id";
            dataGridViewCellStyle36.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.bd_id.DefaultCellStyle = dataGridViewCellStyle36;
            this.bd_id.HeaderText = "빌딩ID";
            this.bd_id.MaximumWidth = 80;
            this.bd_id.Name = "bd_id";
            this.bd_id.Width = 60;
            // 
            // bd_name
            // 
            this.bd_name.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.bd_name.DataPropertyName = "bd_name";
            dataGridViewCellStyle37.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.bd_name.DefaultCellStyle = dataGridViewCellStyle37;
            this.bd_name.HeaderText = "빌딩명";
            this.bd_name.MaximumWidth = 180;
            this.bd_name.MinimumWidth = 50;
            this.bd_name.Name = "bd_name";
            this.bd_name.Width = 140;
            // 
            // max_floor_no
            // 
            this.max_floor_no.DataPropertyName = "max_floor_no";
            dataGridViewCellStyle38.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.max_floor_no.DefaultCellStyle = dataGridViewCellStyle38;
            this.max_floor_no.HeaderText = "최고층";
            this.max_floor_no.MaximumWidth = 80;
            this.max_floor_no.MinimumWidth = 20;
            this.max_floor_no.Name = "max_floor_no";
            this.max_floor_no.Width = 60;
            // 
            // under_floor_no
            // 
            this.under_floor_no.DataPropertyName = "under_floor_no";
            dataGridViewCellStyle39.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.under_floor_no.DefaultCellStyle = dataGridViewCellStyle39;
            this.under_floor_no.HeaderText = "지하층";
            this.under_floor_no.MaximumWidth = 80;
            this.under_floor_no.MinimumWidth = 20;
            this.under_floor_no.Name = "under_floor_no";
            this.under_floor_no.Width = 60;
            // 
            // num_of_stairs
            // 
            this.num_of_stairs.DataPropertyName = "num_of_stairs";
            dataGridViewCellStyle40.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.num_of_stairs.DefaultCellStyle = dataGridViewCellStyle40;
            this.num_of_stairs.HeaderText = "계단수";
            this.num_of_stairs.MaximumWidth = 80;
            this.num_of_stairs.MinimumWidth = 20;
            this.num_of_stairs.Name = "num_of_stairs";
            this.num_of_stairs.Width = 60;
            // 
            // bd_fire_id
            // 
            this.bd_fire_id.DataPropertyName = "bd_fire_id";
            dataGridViewCellStyle41.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.bd_fire_id.DefaultCellStyle = dataGridViewCellStyle41;
            this.bd_fire_id.HeaderText = "화재수신번호";
            this.bd_fire_id.MaximumWidth = 150;
            this.bd_fire_id.MinimumWidth = 20;
            this.bd_fire_id.Name = "bd_fire_id";
            // 
            // bd_description
            // 
            this.bd_description.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.bd_description.DataPropertyName = "bd_description";
            dataGridViewCellStyle42.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.bd_description.DefaultCellStyle = dataGridViewCellStyle42;
            this.bd_description.HeaderText = "부가설명";
            this.bd_description.MaximumWidth = 1000;
            this.bd_description.MinimumWidth = 100;
            this.bd_description.Name = "bd_description";
            // 
            // line2
            // 
            this.line2.Dock = Wisej.Web.DockStyle.Top;
            this.line2.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line2.Location = new System.Drawing.Point(20, 57);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(580, 1);
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.bt_newBuilding);
            this.panel34.Controls.Add(this.bt_selectBuildDelete);
            this.panel34.Controls.Add(this.label2);
            this.panel34.Controls.Add(this.label22);
            this.panel34.Dock = Wisej.Web.DockStyle.Top;
            this.panel34.Location = new System.Drawing.Point(20, 20);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(580, 37);
            this.panel34.TabIndex = 161;
            // 
            // bt_newBuilding
            // 
            this.bt_newBuilding.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_newBuilding.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_newBuilding.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_newBuilding.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_newBuilding.Location = new System.Drawing.Point(376, 0);
            this.bt_newBuilding.Margin = new Wisej.Web.Padding(0);
            this.bt_newBuilding.Name = "bt_newBuilding";
            this.bt_newBuilding.Size = new System.Drawing.Size(100, 32);
            this.bt_newBuilding.TabIndex = 165;
            this.bt_newBuilding.Text = "신규";
            this.bt_newBuilding.Click += new System.EventHandler(this.bt_newBuilding_Click);
            // 
            // bt_selectBuildDelete
            // 
            this.bt_selectBuildDelete.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_selectBuildDelete.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.bt_selectBuildDelete.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_selectBuildDelete.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_selectBuildDelete.Location = new System.Drawing.Point(480, 0);
            this.bt_selectBuildDelete.Margin = new Wisej.Web.Padding(0);
            this.bt_selectBuildDelete.Name = "bt_selectBuildDelete";
            this.bt_selectBuildDelete.Size = new System.Drawing.Size(100, 32);
            this.bt_selectBuildDelete.TabIndex = 163;
            this.bt_selectBuildDelete.Text = "선택수정";
            this.bt_selectBuildDelete.Click += new System.EventHandler(this.bt_selectBuildDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label2.Location = new System.Drawing.Point(32, 0);
            this.label2.Margin = new Wisej.Web.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 24);
            this.label2.TabIndex = 134;
            this.label2.Text = "관리 건물";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoEllipsis = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(91, 153, 255);
            this.label22.CssStyle = "border-radius: 11px;";
            this.label22.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label22.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.label22.Location = new System.Drawing.Point(0, 3);
            this.label22.Margin = new Wisej.Web.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 22);
            this.label22.TabIndex = 133;
            this.label22.Text = "★";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Dock = Wisej.Web.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(20, 493);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(620, 20);
            this.panel7.TabIndex = 168;
            // 
            // panel89
            // 
            this.panel89.AutoSize = true;
            this.panel89.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel89.Controls.Add(this.panel6);
            this.panel89.Controls.Add(this.panel10);
            this.panel89.Controls.Add(this.panel2);
            this.panel89.Controls.Add(this.panel1);
            this.panel89.Controls.Add(this.panel4);
            this.panel89.Controls.Add(this.panel35);
            this.panel89.Controls.Add(this.line5);
            this.panel89.Dock = Wisej.Web.DockStyle.Top;
            this.panel89.Location = new System.Drawing.Point(20, 72);
            this.panel89.Name = "panel89";
            this.panel89.Padding = new Wisej.Web.Padding(20);
            this.panel89.Size = new System.Drawing.Size(620, 421);
            this.panel89.TabIndex = 167;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pb_sitePreImage);
            this.panel6.Controls.Add(this.pic_upload);
            this.panel6.Controls.Add(this.bt_deletePic);
            this.panel6.Dock = Wisej.Web.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(20, 281);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel6.Size = new System.Drawing.Size(580, 120);
            this.panel6.TabIndex = 177;
            // 
            // pb_sitePreImage
            // 
            this.pb_sitePreImage.BackColor = System.Drawing.Color.FromArgb(183, 183, 183);
            this.pb_sitePreImage.Dock = Wisej.Web.DockStyle.Left;
            this.pb_sitePreImage.ImageSource = "Images\\site_image_none.png";
            this.pb_sitePreImage.Location = new System.Drawing.Point(0, 20);
            this.pb_sitePreImage.Name = "pb_sitePreImage";
            this.pb_sitePreImage.Size = new System.Drawing.Size(117, 100);
            this.pb_sitePreImage.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            // 
            // pic_upload
            // 
            this.pic_upload.AllowedFileTypes = "image/*";
            this.pic_upload.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pic_upload.Location = new System.Drawing.Point(126, 84);
            this.pic_upload.Name = "pic_upload";
            this.pic_upload.Size = new System.Drawing.Size(239, 36);
            this.pic_upload.TabIndex = 168;
            this.pic_upload.Text = "사진 업로드";
            this.pic_upload.Uploaded += new Wisej.Web.UploadedEventHandler(this.pic_upload_Uploaded);
            // 
            // bt_deletePic
            // 
            this.bt_deletePic.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.bt_deletePic.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_deletePic.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_deletePic.Location = new System.Drawing.Point(377, 85);
            this.bt_deletePic.Margin = new Wisej.Web.Padding(0);
            this.bt_deletePic.Name = "bt_deletePic";
            this.bt_deletePic.Size = new System.Drawing.Size(112, 32);
            this.bt_deletePic.TabIndex = 139;
            this.bt_deletePic.Text = "삭제";
            this.bt_deletePic.Click += new System.EventHandler(this.bt_deletePic_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cb_emServer);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Dock = Wisej.Web.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(20, 225);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel10.Size = new System.Drawing.Size(580, 56);
            this.panel10.TabIndex = 180;
            // 
            // cb_emServer
            // 
            this.cb_emServer.DisplayMember = "name";
            this.cb_emServer.Dock = Wisej.Web.DockStyle.Fill;
            this.cb_emServer.Location = new System.Drawing.Point(123, 20);
            this.cb_emServer.Name = "cb_emServer";
            this.cb_emServer.Size = new System.Drawing.Size(457, 36);
            this.cb_emServer.TabIndex = 139;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = Wisej.Web.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label7.Location = new System.Drawing.Point(0, 20);
            this.label7.Margin = new Wisej.Web.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 36);
            this.label7.TabIndex = 136;
            this.label7.Text = "메인 방송서버";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_siteDescrip);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 169);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel2.Size = new System.Drawing.Size(580, 56);
            this.panel2.TabIndex = 179;
            // 
            // tb_siteDescrip
            // 
            this.tb_siteDescrip.AutoSize = false;
            this.tb_siteDescrip.Dock = Wisej.Web.DockStyle.Fill;
            this.tb_siteDescrip.Location = new System.Drawing.Point(123, 20);
            this.tb_siteDescrip.Name = "tb_siteDescrip";
            this.tb_siteDescrip.Size = new System.Drawing.Size(457, 36);
            this.tb_siteDescrip.TabIndex = 138;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = Wisej.Web.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label6.Location = new System.Drawing.Point(0, 20);
            this.label6.Margin = new Wisej.Web.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 36);
            this.label6.TabIndex = 136;
            this.label6.Text = "사이트 설명";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_siteContact);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 113);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel1.Size = new System.Drawing.Size(580, 56);
            this.panel1.TabIndex = 169;
            // 
            // tb_siteContact
            // 
            this.tb_siteContact.AutoSize = false;
            this.tb_siteContact.Dock = Wisej.Web.DockStyle.Fill;
            this.tb_siteContact.Location = new System.Drawing.Point(123, 20);
            this.tb_siteContact.Name = "tb_siteContact";
            this.tb_siteContact.Size = new System.Drawing.Size(457, 36);
            this.tb_siteContact.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = Wisej.Web.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label5.Location = new System.Drawing.Point(0, 20);
            this.label5.Margin = new Wisej.Web.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 36);
            this.label5.TabIndex = 136;
            this.label5.Text = "연락처";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tb_siteAddr);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = Wisej.Web.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 57);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel4.Size = new System.Drawing.Size(580, 56);
            this.panel4.TabIndex = 168;
            // 
            // tb_siteAddr
            // 
            this.tb_siteAddr.AutoSize = false;
            this.tb_siteAddr.Dock = Wisej.Web.DockStyle.Fill;
            this.tb_siteAddr.Location = new System.Drawing.Point(123, 20);
            this.tb_siteAddr.Name = "tb_siteAddr";
            this.tb_siteAddr.Size = new System.Drawing.Size(457, 36);
            this.tb_siteAddr.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = Wisej.Web.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Margin = new Wisej.Web.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 136;
            this.label1.Text = "사이트 주소";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.tb_siteName);
            this.panel35.Controls.Add(this.label24);
            this.panel35.Dock = Wisej.Web.DockStyle.Top;
            this.panel35.Location = new System.Drawing.Point(20, 21);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(580, 36);
            this.panel35.TabIndex = 164;
            // 
            // tb_siteName
            // 
            this.tb_siteName.AutoSize = false;
            this.tb_siteName.Dock = Wisej.Web.DockStyle.Fill;
            this.tb_siteName.Location = new System.Drawing.Point(123, 0);
            this.tb_siteName.Name = "tb_siteName";
            this.tb_siteName.Size = new System.Drawing.Size(457, 36);
            this.tb_siteName.TabIndex = 138;
            // 
            // label24
            // 
            this.label24.AutoEllipsis = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = Wisej.Web.DockStyle.Left;
            this.label24.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label24.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label24.Location = new System.Drawing.Point(0, 0);
            this.label24.Margin = new Wisej.Web.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 36);
            this.label24.TabIndex = 136;
            this.label24.Text = "사이트명";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line5
            // 
            this.line5.Dock = Wisej.Web.DockStyle.Top;
            this.line5.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line5.Location = new System.Drawing.Point(20, 20);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(580, 1);
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.Transparent;
            this.panel27.Controls.Add(this.bt_delete);
            this.panel27.Controls.Add(this.bt_store);
            this.panel27.Controls.Add(this.label26);
            this.panel27.Dock = Wisej.Web.DockStyle.Top;
            this.panel27.Location = new System.Drawing.Point(20, 20);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(620, 52);
            this.panel27.TabIndex = 59;
            // 
            // bt_delete
            // 
            this.bt_delete.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_delete.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.bt_delete.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_delete.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_delete.Location = new System.Drawing.Point(520, 0);
            this.bt_delete.Margin = new Wisej.Web.Padding(0);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(100, 32);
            this.bt_delete.TabIndex = 35;
            this.bt_delete.Text = "삭제";
            // 
            // bt_store
            // 
            this.bt_store.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_store.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_store.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_store.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_store.Location = new System.Drawing.Point(413, 0);
            this.bt_store.Margin = new Wisej.Web.Padding(0);
            this.bt_store.Name = "bt_store";
            this.bt_store.Size = new System.Drawing.Size(100, 32);
            this.bt_store.TabIndex = 34;
            this.bt_store.Text = "저장";
            this.bt_store.Click += new System.EventHandler(this.bt_store_Click);
            // 
            // label26
            // 
            this.label26.CssStyle = "\r\n";
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label26.Location = new System.Drawing.Point(0, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(163, 32);
            this.label26.TabIndex = 33;
            this.label26.Text = "사이트 편집";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel22
            // 
            this.panel22.AutoScroll = true;
            this.panel22.Dock = Wisej.Web.DockStyle.Fill;
            this.panel22.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.panel22.Location = new System.Drawing.Point(20, 20);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(620, 780);
            this.panel22.TabIndex = 58;
            this.panel22.Text = "listPanel";
            // 
            // Comp_SiteDetailForm
            // 
            this.Controls.Add(this.panel3);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "Comp_SiteDetailForm";
            this.Size = new System.Drawing.Size(660, 820);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_buildingStruct)).EndInit();
            this.panel34.ResumeLayout(false);
            this.panel89.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_sitePreImage)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel3;
        private Wisej.Web.Panel panel8;
        private Wisej.Web.DataGridView dg_buildingStruct;
        private Wisej.Web.DataGridViewTextBoxColumn bd_name;
        private Wisej.Web.DataGridViewTextBoxColumn max_floor_no;
        private Wisej.Web.DataGridViewTextBoxColumn under_floor_no;
        private Wisej.Web.Button bt_selectBuildDelete;
        private Wisej.Web.Line line2;
        private Wisej.Web.Panel panel34;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label22;
        private Wisej.Web.Panel panel7;
        private Wisej.Web.Panel panel89;
        private Wisej.Web.Panel panel6;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.TextBox tb_siteAddr;
        private Wisej.Web.Label label1;
        private Wisej.Web.Panel panel35;
        private Wisej.Web.TextBox tb_siteName;
        private Wisej.Web.Label label24;
        private Wisej.Web.Line line5;
        private Wisej.Web.Panel panel27;
        private Wisej.Web.Button bt_delete;
        private Wisej.Web.Button bt_store;
        private Wisej.Web.Label label26;
        private Wisej.Web.Panel panel22;
        private Wisej.Web.Panel panel10;
        private Wisej.Web.ComboBox cb_emServer;
        private Wisej.Web.Label label7;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.TextBox tb_siteDescrip;
        private Wisej.Web.Label label6;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.TextBox tb_siteContact;
        private Wisej.Web.Label label5;
        private Wisej.Web.Button bt_newBuilding;
        private Wisej.Web.Upload pic_upload;
        private Wisej.Web.Button bt_deletePic;
        private Wisej.Web.PictureBox pb_sitePreImage;
        private Wisej.Web.DataGridViewTextBoxColumn num_of_stairs;
        private Wisej.Web.DataGridViewTextBoxColumn bd_fire_id;
        private Wisej.Web.DataGridViewTextBoxColumn bd_description;
        private Wisej.Web.DataGridViewTextBoxColumn bd_id;
    }
}
