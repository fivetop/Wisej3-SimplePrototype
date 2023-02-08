namespace simplepa2.UI.Views
{
    partial class View_BBSPresetManage2
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
            this.pn_PresetList = new Wisej.Web.Panel();
            this.pn_PresetItemList = new Wisej.Web.Panel();
            this.pn_PresetTopPanel = new Wisej.Web.Panel();
            this.comp_Site1 = new simplepa2.UI.Components.Comp_Site();
            this.bt_AddPreset = new Wisej.Web.Button();
            this.label15 = new Wisej.Web.Label();
            this.pn_Spacer = new Wisej.Web.Panel();
            this.pn_PresetWrapper = new Wisej.Web.Panel();
            this.pn_PresetDetails = new Wisej.Web.Panel();
            this.panel32 = new Wisej.Web.Panel();
            this.panel45 = new Wisej.Web.Panel();
            this.comp_UGroup1 = new simplepa2.Comp_UGroup();
            this.panel91 = new Wisej.Web.Panel();
            this.label32 = new Wisej.Web.Label();
            this.label51 = new Wisej.Web.Label();
            this.panel33 = new Wisej.Web.Panel();
            this.comp_Music1 = new simplepa2.Comp_Music();
            this.line1 = new Wisej.Web.Line();
            this.panel43 = new Wisej.Web.Panel();
            this.label20 = new Wisej.Web.Label();
            this.label21 = new Wisej.Web.Label();
            this.panel46 = new Wisej.Web.Panel();
            this.panel89 = new Wisej.Web.Panel();
            this.panel35 = new Wisej.Web.Panel();
            this.label25 = new Wisej.Web.Label();
            this.puser_name = new Wisej.Web.TextBox();
            this.pName = new Wisej.Web.TextBox();
            this.label24 = new Wisej.Web.Label();
            this.line2 = new Wisej.Web.Line();
            this.panel34 = new Wisej.Web.Panel();
            this.label23 = new Wisej.Web.Label();
            this.label22 = new Wisej.Web.Label();
            this.panel136 = new Wisej.Web.Panel();
            this.button5 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.label66 = new Wisej.Web.Label();
            this.presetTableAdapter1 = new simplepa2.DataSet1TableAdapters.PresetTableAdapter();
            this.presetCTableAdapter1 = new simplepa2.DataSet1TableAdapters.PresetCTableAdapter();
            this.dataSet11 = new simplepa2.DataSet1();
            this.pn_PresetList.SuspendLayout();
            this.pn_PresetTopPanel.SuspendLayout();
            this.pn_PresetWrapper.SuspendLayout();
            this.pn_PresetDetails.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel45.SuspendLayout();
            this.panel91.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel43.SuspendLayout();
            this.panel89.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel34.SuspendLayout();
            this.panel136.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_PresetList
            // 
            this.pn_PresetList.BackColor = System.Drawing.Color.White;
            this.pn_PresetList.Controls.Add(this.pn_PresetItemList);
            this.pn_PresetList.Controls.Add(this.pn_PresetTopPanel);
            this.pn_PresetList.Dock = Wisej.Web.DockStyle.Left;
            this.pn_PresetList.Location = new System.Drawing.Point(20, 20);
            this.pn_PresetList.Name = "pn_PresetList";
            this.pn_PresetList.Padding = new Wisej.Web.Padding(20);
            this.pn_PresetList.Size = new System.Drawing.Size(580, 860);
            this.pn_PresetList.TabIndex = 41;
            // 
            // pn_PresetItemList
            // 
            this.pn_PresetItemList.AutoScroll = true;
            this.pn_PresetItemList.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_PresetItemList.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.pn_PresetItemList.Location = new System.Drawing.Point(20, 72);
            this.pn_PresetItemList.Name = "pn_PresetItemList";
            this.pn_PresetItemList.Selectable = true;
            this.pn_PresetItemList.ShowCloseButton = false;
            this.pn_PresetItemList.Size = new System.Drawing.Size(540, 768);
            this.pn_PresetItemList.TabIndex = 51;
            this.pn_PresetItemList.Text = "listPanel";
            // 
            // pn_PresetTopPanel
            // 
            this.pn_PresetTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.pn_PresetTopPanel.Controls.Add(this.comp_Site1);
            this.pn_PresetTopPanel.Controls.Add(this.bt_AddPreset);
            this.pn_PresetTopPanel.Controls.Add(this.label15);
            this.pn_PresetTopPanel.Dock = Wisej.Web.DockStyle.Top;
            this.pn_PresetTopPanel.Location = new System.Drawing.Point(20, 20);
            this.pn_PresetTopPanel.Name = "pn_PresetTopPanel";
            this.pn_PresetTopPanel.Size = new System.Drawing.Size(540, 52);
            this.pn_PresetTopPanel.TabIndex = 50;
            // 
            // comp_Site1
            // 
            this.comp_Site1.Location = new System.Drawing.Point(177, 0);
            this.comp_Site1.Name = "comp_Site1";
            this.comp_Site1.Size = new System.Drawing.Size(285, 34);
            this.comp_Site1.TabIndex = 99;
            // 
            // bt_AddPreset
            // 
            this.bt_AddPreset.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_AddPreset.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_AddPreset.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_AddPreset.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_AddPreset.Location = new System.Drawing.Point(465, 0);
            this.bt_AddPreset.Margin = new Wisej.Web.Padding(0);
            this.bt_AddPreset.Name = "bt_AddPreset";
            this.bt_AddPreset.Size = new System.Drawing.Size(75, 32);
            this.bt_AddPreset.TabIndex = 34;
            this.bt_AddPreset.Text = "추가";
            this.bt_AddPreset.Click += new System.EventHandler(this.bt_AddPreset_Click);
            // 
            // label15
            // 
            this.label15.CssStyle = "\r\n";
            this.label15.Font = new System.Drawing.Font("@boxTitle", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 32);
            this.label15.TabIndex = 33;
            this.label15.Text = "프리셋 리스트";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pn_Spacer
            // 
            this.pn_Spacer.BackColor = System.Drawing.Color.Transparent;
            this.pn_Spacer.Dock = Wisej.Web.DockStyle.Left;
            this.pn_Spacer.Location = new System.Drawing.Point(600, 20);
            this.pn_Spacer.Name = "pn_Spacer";
            this.pn_Spacer.Size = new System.Drawing.Size(20, 860);
            this.pn_Spacer.TabIndex = 46;
            // 
            // pn_PresetWrapper
            // 
            this.pn_PresetWrapper.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.pn_PresetWrapper.Controls.Add(this.pn_PresetDetails);
            this.pn_PresetWrapper.Controls.Add(this.pn_Spacer);
            this.pn_PresetWrapper.Controls.Add(this.pn_PresetList);
            this.pn_PresetWrapper.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_PresetWrapper.Location = new System.Drawing.Point(0, 0);
            this.pn_PresetWrapper.Margin = new Wisej.Web.Padding(0);
            this.pn_PresetWrapper.Name = "pn_PresetWrapper";
            this.pn_PresetWrapper.Padding = new Wisej.Web.Padding(20);
            this.pn_PresetWrapper.Size = new System.Drawing.Size(1400, 900);
            this.pn_PresetWrapper.TabIndex = 47;
            // 
            // pn_PresetDetails
            // 
            this.pn_PresetDetails.BackColor = System.Drawing.Color.White;
            this.pn_PresetDetails.Controls.Add(this.panel32);
            this.pn_PresetDetails.Controls.Add(this.panel136);
            this.pn_PresetDetails.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_PresetDetails.Location = new System.Drawing.Point(620, 20);
            this.pn_PresetDetails.Name = "pn_PresetDetails";
            this.pn_PresetDetails.Padding = new Wisej.Web.Padding(20);
            this.pn_PresetDetails.Size = new System.Drawing.Size(760, 860);
            this.pn_PresetDetails.TabIndex = 47;
            // 
            // panel32
            // 
            this.panel32.AutoScroll = true;
            this.panel32.Controls.Add(this.panel45);
            this.panel32.Controls.Add(this.panel33);
            this.panel32.Controls.Add(this.panel46);
            this.panel32.Controls.Add(this.panel89);
            this.panel32.Dock = Wisej.Web.DockStyle.Fill;
            this.panel32.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.panel32.Location = new System.Drawing.Point(20, 72);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(720, 768);
            this.panel32.TabIndex = 51;
            this.panel32.Text = "listPanel";
            // 
            // panel45
            // 
            this.panel45.AutoSize = true;
            this.panel45.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel45.Controls.Add(this.comp_UGroup1);
            this.panel45.Controls.Add(this.panel91);
            this.panel45.Dock = Wisej.Web.DockStyle.Fill;
            this.panel45.Location = new System.Drawing.Point(0, 300);
            this.panel45.Name = "panel45";
            this.panel45.Padding = new Wisej.Web.Padding(20);
            this.panel45.Size = new System.Drawing.Size(720, 468);
            this.panel45.TabIndex = 163;
            // 
            // comp_UGroup1
            // 
            this.comp_UGroup1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.comp_UGroup1.Dock = Wisej.Web.DockStyle.Fill;
            this.comp_UGroup1.Location = new System.Drawing.Point(20, 57);
            this.comp_UGroup1.Name = "comp_UGroup1";
            this.comp_UGroup1.Size = new System.Drawing.Size(680, 391);
            this.comp_UGroup1.TabIndex = 162;
            // 
            // panel91
            // 
            this.panel91.Controls.Add(this.label32);
            this.panel91.Controls.Add(this.label51);
            this.panel91.Dock = Wisej.Web.DockStyle.Top;
            this.panel91.Location = new System.Drawing.Point(20, 20);
            this.panel91.Name = "panel91";
            this.panel91.Size = new System.Drawing.Size(680, 37);
            this.panel91.TabIndex = 161;
            // 
            // label32
            // 
            this.label32.AutoEllipsis = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label32.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label32.Location = new System.Drawing.Point(32, 0);
            this.label32.Margin = new Wisej.Web.Padding(0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(437, 24);
            this.label32.TabIndex = 134;
            this.label32.Text = "방송 지역";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label51
            // 
            this.label51.AutoEllipsis = true;
            this.label51.BackColor = System.Drawing.Color.FromArgb(91, 153, 255);
            this.label51.CssStyle = "border-radius: 11px;";
            this.label51.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label51.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.label51.Location = new System.Drawing.Point(0, 2);
            this.label51.Margin = new Wisej.Web.Padding(0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(22, 22);
            this.label51.TabIndex = 133;
            this.label51.Text = "3";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel33.Controls.Add(this.comp_Music1);
            this.panel33.Controls.Add(this.line1);
            this.panel33.Controls.Add(this.panel43);
            this.panel33.Dock = Wisej.Web.DockStyle.Top;
            this.panel33.Location = new System.Drawing.Point(0, 132);
            this.panel33.Name = "panel33";
            this.panel33.Padding = new Wisej.Web.Padding(20, 20, 20, 0);
            this.panel33.Size = new System.Drawing.Size(720, 168);
            this.panel33.TabIndex = 161;
            // 
            // comp_Music1
            // 
            this.comp_Music1.Dock = Wisej.Web.DockStyle.Fill;
            this.comp_Music1.Location = new System.Drawing.Point(20, 58);
            this.comp_Music1.Name = "comp_Music1";
            this.comp_Music1.Size = new System.Drawing.Size(680, 110);
            this.comp_Music1.TabIndex = 162;
            // 
            // line1
            // 
            this.line1.Dock = Wisej.Web.DockStyle.Top;
            this.line1.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line1.Location = new System.Drawing.Point(20, 57);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(680, 1);
            // 
            // panel43
            // 
            this.panel43.Controls.Add(this.label20);
            this.panel43.Controls.Add(this.label21);
            this.panel43.Dock = Wisej.Web.DockStyle.Top;
            this.panel43.Location = new System.Drawing.Point(20, 20);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(680, 37);
            this.panel43.TabIndex = 161;
            // 
            // label20
            // 
            this.label20.AutoEllipsis = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label20.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label20.Location = new System.Drawing.Point(32, 0);
            this.label20.Margin = new Wisej.Web.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(437, 24);
            this.label20.TabIndex = 134;
            this.label20.Text = "음원선택";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoEllipsis = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(91, 153, 255);
            this.label21.CssStyle = "border-radius: 11px;";
            this.label21.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label21.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.label21.Location = new System.Drawing.Point(0, 2);
            this.label21.Margin = new Wisej.Web.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 22);
            this.label21.TabIndex = 133;
            this.label21.Text = "2";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel46
            // 
            this.panel46.Dock = Wisej.Web.DockStyle.Top;
            this.panel46.Location = new System.Drawing.Point(0, 122);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(720, 10);
            this.panel46.TabIndex = 160;
            // 
            // panel89
            // 
            this.panel89.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel89.Controls.Add(this.panel35);
            this.panel89.Controls.Add(this.line2);
            this.panel89.Controls.Add(this.panel34);
            this.panel89.Dock = Wisej.Web.DockStyle.Top;
            this.panel89.Location = new System.Drawing.Point(0, 0);
            this.panel89.Name = "panel89";
            this.panel89.Padding = new Wisej.Web.Padding(20);
            this.panel89.Size = new System.Drawing.Size(720, 122);
            this.panel89.TabIndex = 159;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.label25);
            this.panel35.Controls.Add(this.puser_name);
            this.panel35.Controls.Add(this.pName);
            this.panel35.Controls.Add(this.label24);
            this.panel35.Dock = Wisej.Web.DockStyle.Top;
            this.panel35.Location = new System.Drawing.Point(20, 58);
            this.panel35.Name = "panel35";
            this.panel35.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel35.Size = new System.Drawing.Size(680, 58);
            this.panel35.TabIndex = 164;
            // 
            // label25
            // 
            this.label25.AutoEllipsis = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label25.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label25.Location = new System.Drawing.Point(376, 10);
            this.label25.Margin = new Wisej.Web.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 36);
            this.label25.TabIndex = 136;
            this.label25.Text = "프리셋 작성자";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // puser_name
            // 
            this.puser_name.AutoSize = false;
            this.puser_name.Location = new System.Drawing.Point(472, 11);
            this.puser_name.Name = "puser_name";
            this.puser_name.ReadOnly = true;
            this.puser_name.Size = new System.Drawing.Size(165, 36);
            this.puser_name.TabIndex = 137;
            // 
            // pName
            // 
            this.pName.AutoSize = false;
            this.pName.Location = new System.Drawing.Point(95, 10);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(240, 36);
            this.pName.TabIndex = 137;
            // 
            // label24
            // 
            this.label24.AutoEllipsis = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label24.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label24.Location = new System.Drawing.Point(0, 11);
            this.label24.Margin = new Wisej.Web.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 36);
            this.label24.TabIndex = 136;
            this.label24.Text = "프리셋 이름";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line2
            // 
            this.line2.Dock = Wisej.Web.DockStyle.Top;
            this.line2.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line2.Location = new System.Drawing.Point(20, 57);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(680, 1);
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.label23);
            this.panel34.Controls.Add(this.label22);
            this.panel34.Dock = Wisej.Web.DockStyle.Top;
            this.panel34.Location = new System.Drawing.Point(20, 20);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(680, 37);
            this.panel34.TabIndex = 161;
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label23.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label23.Location = new System.Drawing.Point(32, 0);
            this.label23.Margin = new Wisej.Web.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(437, 24);
            this.label23.TabIndex = 134;
            this.label23.Text = "프리셋 일반 정보";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoEllipsis = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(91, 153, 255);
            this.label22.CssStyle = "border-radius: 11px;";
            this.label22.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label22.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.label22.Location = new System.Drawing.Point(0, 2);
            this.label22.Margin = new Wisej.Web.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 22);
            this.label22.TabIndex = 133;
            this.label22.Text = "1";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel136
            // 
            this.panel136.BackColor = System.Drawing.Color.Transparent;
            this.panel136.Controls.Add(this.button5);
            this.panel136.Controls.Add(this.button2);
            this.panel136.Controls.Add(this.label66);
            this.panel136.Dock = Wisej.Web.DockStyle.Top;
            this.panel136.Location = new System.Drawing.Point(20, 20);
            this.panel136.Name = "panel136";
            this.panel136.Size = new System.Drawing.Size(720, 52);
            this.panel136.TabIndex = 50;
            // 
            // button5
            // 
            this.button5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.button5.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button5.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button5.Location = new System.Drawing.Point(510, 0);
            this.button5.Margin = new Wisej.Web.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 32);
            this.button5.TabIndex = 35;
            this.button5.Text = "삭제";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button2.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button2.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button2.Location = new System.Drawing.Point(620, 0);
            this.button2.Margin = new Wisej.Web.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 34;
            this.button2.Text = "저장";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label66
            // 
            this.label66.CssStyle = "\r\n";
            this.label66.Font = new System.Drawing.Font("@boxTitle", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label66.Location = new System.Drawing.Point(0, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(418, 32);
            this.label66.TabIndex = 33;
            this.label66.Text = "프리셋 상세";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // presetTableAdapter1
            // 
            this.presetTableAdapter1.ClearBeforeFill = true;
            // 
            // presetCTableAdapter1
            // 
            this.presetCTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_BBSPresetManage2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pn_PresetWrapper);
            this.CssStyle = "background: /*#F0F0F0*/#eeeff8;";
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBSPresetManage2";
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.View_BBSPresetManage2_Load);
            this.pn_PresetList.ResumeLayout(false);
            this.pn_PresetTopPanel.ResumeLayout(false);
            this.pn_PresetWrapper.ResumeLayout(false);
            this.pn_PresetDetails.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.panel45.ResumeLayout(false);
            this.panel45.PerformLayout();
            this.panel91.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.panel33.PerformLayout();
            this.panel43.ResumeLayout(false);
            this.panel89.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.panel136.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pn_PresetList;
        private Wisej.Web.Panel pn_PresetItemList;
        private Wisej.Web.Panel pn_PresetTopPanel;
        private Wisej.Web.Button bt_AddPreset;
        private Wisej.Web.Label label15;
        private Wisej.Web.Panel pn_Spacer;
        private Wisej.Web.Panel pn_PresetWrapper;
        private Wisej.Web.Panel pn_PresetDetails;
        private Wisej.Web.Panel panel32;
        private Wisej.Web.Panel panel45;
        private Wisej.Web.Panel panel91;
        private Wisej.Web.Label label32;
        private Wisej.Web.Label label51;
        private Wisej.Web.Panel panel33;
        private Wisej.Web.Line line1;
        private Wisej.Web.Panel panel43;
        private Wisej.Web.Label label20;
        private Wisej.Web.Label label21;
        private Wisej.Web.Panel panel46;
        private Wisej.Web.Panel panel89;
        private Wisej.Web.TextBox puser_name;
        private Wisej.Web.Label label25;
        private Wisej.Web.Panel panel35;
        private Wisej.Web.TextBox pName;
        private Wisej.Web.Label label24;
        private Wisej.Web.Line line2;
        private Wisej.Web.Panel panel34;
        private Wisej.Web.Label label23;
        private Wisej.Web.Label label22;
        private Wisej.Web.Panel panel136;
        private Wisej.Web.Button button5;
        private Wisej.Web.Button button2;
        private Wisej.Web.Label label66;
        private DataSet1TableAdapters.PresetTableAdapter presetTableAdapter1;
        private DataSet1TableAdapters.PresetCTableAdapter presetCTableAdapter1;
        private DataSet1 dataSet11;
        private Components.Comp_Site comp_Site1;
        private Comp_Music comp_Music1;
        private Comp_UGroup comp_UGroup1;
    }
}
