namespace simplepa2.UI.Views
{
    partial class View_BBSHolidayManage
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle6 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle7 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle8 = new Wisej.Web.DataGridViewCellStyle();
            this.bt_updateoradd = new Wisej.Web.Button();
            this.panel32 = new Wisej.Web.Panel();
            this.bt_openAddNewForm = new Wisej.Web.Button();
            this.cb_year = new Wisej.Web.ComboBox();
            this.label21 = new Wisej.Web.Label();
            this.label15 = new Wisej.Web.Label();
            this.panel21 = new Wisej.Web.Panel();
            this.panel22 = new Wisej.Web.Panel();
            this.panel89 = new Wisej.Web.Panel();
            this.panel36 = new Wisej.Web.Panel();
            this.tb_holidayDescription = new Wisej.Web.TextBox();
            this.label25 = new Wisej.Web.Label();
            this.panel35 = new Wisej.Web.Panel();
            this.dt_picker = new Wisej.Web.DateTimePicker();
            this.label24 = new Wisej.Web.Label();
            this.line5 = new Wisej.Web.Line();
            this.panel34 = new Wisej.Web.Panel();
            this.label23 = new Wisej.Web.Label();
            this.label22 = new Wisej.Web.Label();
            this.panel136 = new Wisej.Web.Panel();
            this.bt_delete = new Wisej.Web.Button();
            this.lb_text = new Wisej.Web.Label();
            this.panel1 = new Wisej.Web.Panel();
            this.panel48 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.dg_holidayList = new Wisej.Web.DataGridView();
            this.연도 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.날짜 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.휴일내역 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel55 = new Wisej.Web.Panel();
            this.panel20 = new Wisej.Web.Panel();
            this.label51 = new Wisej.Web.Label();
            this.cb_monthAPI = new Wisej.Web.ComboBox();
            this.label52 = new Wisej.Web.Label();
            this.bt_gonggongUpdate = new Wisej.Web.Button();
            this.dataSet11 = new simplepa2.DataSet1();
            this.holidaysTableAdapter1 = new simplepa2.DataSet1TableAdapters.HolidaysTableAdapter();
            this.holidaysYearListTableAdapter1 = new simplepa2.DataSet1TableAdapters.HolidaysYearListTableAdapter();
            this.holidaysDivideDateTableAdapter1 = new simplepa2.DataSet1TableAdapters.HolidaysDivideDateTableAdapter();
            this.panel32.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel89.SuspendLayout();
            this.panel36.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel34.SuspendLayout();
            this.panel136.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_holidayList)).BeginInit();
            this.panel55.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_updateoradd
            // 
            this.bt_updateoradd.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_updateoradd.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_updateoradd.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_updateoradd.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_updateoradd.Location = new System.Drawing.Point(620, 0);
            this.bt_updateoradd.Margin = new Wisej.Web.Padding(0);
            this.bt_updateoradd.Name = "bt_updateoradd";
            this.bt_updateoradd.Size = new System.Drawing.Size(100, 32);
            this.bt_updateoradd.TabIndex = 34;
            this.bt_updateoradd.Text = "추가";
            this.bt_updateoradd.Click += new System.EventHandler(this.bt_updateoradd_Click);
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.Transparent;
            this.panel32.Controls.Add(this.bt_openAddNewForm);
            this.panel32.Controls.Add(this.cb_year);
            this.panel32.Controls.Add(this.label21);
            this.panel32.Controls.Add(this.label15);
            this.panel32.Dock = Wisej.Web.DockStyle.Top;
            this.panel32.Location = new System.Drawing.Point(20, 20);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(540, 52);
            this.panel32.TabIndex = 50;
            // 
            // bt_openAddNewForm
            // 
            this.bt_openAddNewForm.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_openAddNewForm.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_openAddNewForm.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_openAddNewForm.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_openAddNewForm.Location = new System.Drawing.Point(440, 0);
            this.bt_openAddNewForm.Margin = new Wisej.Web.Padding(0);
            this.bt_openAddNewForm.Name = "bt_openAddNewForm";
            this.bt_openAddNewForm.Size = new System.Drawing.Size(100, 32);
            this.bt_openAddNewForm.TabIndex = 40;
            this.bt_openAddNewForm.Text = "신규";
            this.bt_openAddNewForm.Click += new System.EventHandler(this.bt_openAddNewForm_Click);
            // 
            // cb_year
            // 
            this.cb_year.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.cb_year.AutoSize = false;
            this.cb_year.DisplayMember = "Yearlist";
            this.cb_year.Location = new System.Drawing.Point(338, 0);
            this.cb_year.Margin = new Wisej.Web.Padding(0);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(88, 32);
            this.cb_year.TabIndex = 37;
            this.cb_year.SelectedIndexChanged += new System.EventHandler(this.cb_year_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("@topLabel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label21.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label21.Location = new System.Drawing.Point(287, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 32);
            this.label21.TabIndex = 36;
            this.label21.Text = "년";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.CssStyle = "\r\n";
            this.label15.Font = new System.Drawing.Font("@boxTitle", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 32);
            this.label15.TabIndex = 33;
            this.label15.Text = "휴일목록";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Controls.Add(this.panel136);
            this.panel21.Dock = Wisej.Web.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(620, 20);
            this.panel21.Name = "panel21";
            this.panel21.Padding = new Wisej.Web.Padding(20);
            this.panel21.Size = new System.Drawing.Size(760, 860);
            this.panel21.TabIndex = 56;
            // 
            // panel22
            // 
            this.panel22.AutoScroll = true;
            this.panel22.BackColor = System.Drawing.Color.Transparent;
            this.panel22.Controls.Add(this.panel89);
            this.panel22.Dock = Wisej.Web.DockStyle.Fill;
            this.panel22.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.panel22.Location = new System.Drawing.Point(20, 72);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(720, 768);
            this.panel22.TabIndex = 51;
            this.panel22.Text = "listPanel";
            // 
            // panel89
            // 
            this.panel89.AutoSize = true;
            this.panel89.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel89.Controls.Add(this.panel36);
            this.panel89.Controls.Add(this.panel35);
            this.panel89.Controls.Add(this.line5);
            this.panel89.Controls.Add(this.panel34);
            this.panel89.Dock = Wisej.Web.DockStyle.Top;
            this.panel89.Location = new System.Drawing.Point(0, 0);
            this.panel89.Name = "panel89";
            this.panel89.Padding = new Wisej.Web.Padding(20);
            this.panel89.Size = new System.Drawing.Size(720, 190);
            this.panel89.TabIndex = 159;
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.tb_holidayDescription);
            this.panel36.Controls.Add(this.label25);
            this.panel36.Dock = Wisej.Web.DockStyle.Top;
            this.panel36.Location = new System.Drawing.Point(20, 114);
            this.panel36.Name = "panel36";
            this.panel36.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel36.Size = new System.Drawing.Size(680, 56);
            this.panel36.TabIndex = 165;
            // 
            // tb_holidayDescription
            // 
            this.tb_holidayDescription.AutoSize = false;
            this.tb_holidayDescription.Dock = Wisej.Web.DockStyle.Left;
            this.tb_holidayDescription.Location = new System.Drawing.Point(123, 20);
            this.tb_holidayDescription.Name = "tb_holidayDescription";
            this.tb_holidayDescription.Size = new System.Drawing.Size(240, 36);
            this.tb_holidayDescription.TabIndex = 137;
            // 
            // label25
            // 
            this.label25.AutoEllipsis = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Dock = Wisej.Web.DockStyle.Left;
            this.label25.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label25.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label25.Location = new System.Drawing.Point(0, 20);
            this.label25.Margin = new Wisej.Web.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(123, 36);
            this.label25.TabIndex = 136;
            this.label25.Text = "휴일내역";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.dt_picker);
            this.panel35.Controls.Add(this.label24);
            this.panel35.Dock = Wisej.Web.DockStyle.Top;
            this.panel35.Location = new System.Drawing.Point(20, 58);
            this.panel35.Name = "panel35";
            this.panel35.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel35.Size = new System.Drawing.Size(680, 56);
            this.panel35.TabIndex = 164;
            // 
            // dt_picker
            // 
            this.dt_picker.BackColor = System.Drawing.Color.Transparent;
            this.dt_picker.CustomFormat = "yyyy-MM-dd";
            this.dt_picker.Dock = Wisej.Web.DockStyle.Left;
            this.dt_picker.Format = Wisej.Web.DateTimePickerFormat.Custom;
            this.dt_picker.Location = new System.Drawing.Point(123, 20);
            this.dt_picker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dt_picker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_picker.Name = "dt_picker";
            this.dt_picker.Size = new System.Drawing.Size(240, 36);
            this.dt_picker.TabIndex = 137;
            this.dt_picker.Value = new System.DateTime(2023, 1, 4, 16, 41, 57, 927);
            // 
            // label24
            // 
            this.label24.AutoEllipsis = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = Wisej.Web.DockStyle.Left;
            this.label24.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label24.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label24.Location = new System.Drawing.Point(0, 20);
            this.label24.Margin = new Wisej.Web.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 36);
            this.label24.TabIndex = 136;
            this.label24.Text = "날짜선택";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line5
            // 
            this.line5.Dock = Wisej.Web.DockStyle.Top;
            this.line5.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line5.Location = new System.Drawing.Point(20, 57);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(680, 1);
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
            this.label23.Text = "휴일 일반 정보";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoEllipsis = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(91, 153, 255);
            this.label22.CssStyle = "border-radius: 11px;";
            this.label22.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label22.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.label22.Location = new System.Drawing.Point(0, 1);
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
            this.panel136.Controls.Add(this.bt_delete);
            this.panel136.Controls.Add(this.bt_updateoradd);
            this.panel136.Controls.Add(this.lb_text);
            this.panel136.Dock = Wisej.Web.DockStyle.Top;
            this.panel136.Location = new System.Drawing.Point(20, 20);
            this.panel136.Name = "panel136";
            this.panel136.Size = new System.Drawing.Size(720, 52);
            this.panel136.TabIndex = 50;
            // 
            // bt_delete
            // 
            this.bt_delete.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_delete.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.bt_delete.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_delete.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_delete.Location = new System.Drawing.Point(510, 0);
            this.bt_delete.Margin = new Wisej.Web.Padding(0);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(100, 32);
            this.bt_delete.TabIndex = 35;
            this.bt_delete.Text = "삭제";
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // lb_text
            // 
            this.lb_text.CssStyle = "\r\n";
            this.lb_text.Font = new System.Drawing.Font("@boxTitle", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_text.Location = new System.Drawing.Point(0, 0);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(418, 32);
            this.lb_text.TabIndex = 33;
            this.lb_text.Text = "휴일 편집";
            this.lb_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = Wisej.Web.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(600, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 860);
            this.panel1.TabIndex = 55;
            // 
            // panel48
            // 
            this.panel48.BackColor = System.Drawing.Color.White;
            this.panel48.Controls.Add(this.panel2);
            this.panel48.Controls.Add(this.panel55);
            this.panel48.Controls.Add(this.panel32);
            this.panel48.Dock = Wisej.Web.DockStyle.Left;
            this.panel48.Location = new System.Drawing.Point(20, 20);
            this.panel48.Name = "panel48";
            this.panel48.Padding = new Wisej.Web.Padding(20);
            this.panel48.Size = new System.Drawing.Size(580, 860);
            this.panel48.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dg_holidayList);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.panel2.Location = new System.Drawing.Point(20, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 698);
            this.panel2.TabIndex = 165;
            this.panel2.Text = "listPanel";
            // 
            // dg_holidayList
            // 
            this.dg_holidayList.AutoGenerateColumns = false;
            this.dg_holidayList.AutoSize = true;
            dataGridViewCellStyle5.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.dg_holidayList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_holidayList.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.연도,
            this.날짜,
            this.휴일내역});
            this.dg_holidayList.Dock = Wisej.Web.DockStyle.Fill;
            this.dg_holidayList.Location = new System.Drawing.Point(0, 0);
            this.dg_holidayList.Name = "dg_holidayList";
            this.dg_holidayList.RowHeadersVisible = false;
            this.dg_holidayList.Size = new System.Drawing.Size(540, 698);
            this.dg_holidayList.TabIndex = 135;
            this.dg_holidayList.CellMouseClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dg_holidayList_CellMouseClick);
            // 
            // 연도
            // 
            this.연도.DataPropertyName = "Year";
            dataGridViewCellStyle6.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.연도.DefaultCellStyle = dataGridViewCellStyle6;
            this.연도.HeaderText = "연도";
            this.연도.Name = "연도";
            this.연도.Width = 90;
            // 
            // 날짜
            // 
            this.날짜.DataPropertyName = "hDate";
            dataGridViewCellStyle7.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.날짜.DefaultCellStyle = dataGridViewCellStyle7;
            this.날짜.HeaderText = "날짜";
            this.날짜.Name = "날짜";
            this.날짜.Width = 200;
            // 
            // 휴일내역
            // 
            this.휴일내역.DataPropertyName = "Description";
            dataGridViewCellStyle8.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.휴일내역.DefaultCellStyle = dataGridViewCellStyle8;
            this.휴일내역.HeaderText = "휴일내역";
            this.휴일내역.Name = "휴일내역";
            this.휴일내역.Width = 230;
            // 
            // panel55
            // 
            this.panel55.BackColor = System.Drawing.Color.White;
            this.panel55.Controls.Add(this.panel20);
            this.panel55.Controls.Add(this.label51);
            this.panel55.Controls.Add(this.cb_monthAPI);
            this.panel55.Controls.Add(this.label52);
            this.panel55.Controls.Add(this.bt_gonggongUpdate);
            this.panel55.Dock = Wisej.Web.DockStyle.Bottom;
            this.panel55.Location = new System.Drawing.Point(20, 770);
            this.panel55.Name = "panel55";
            this.panel55.Size = new System.Drawing.Size(540, 70);
            this.panel55.TabIndex = 164;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.panel20.Dock = Wisej.Web.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(540, 1);
            this.panel20.TabIndex = 140;
            // 
            // label51
            // 
            this.label51.CssStyle = "\r\n";
            this.label51.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label51.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label51.Location = new System.Drawing.Point(2, 18);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(180, 32);
            this.label51.TabIndex = 40;
            this.label51.Text = "공공데이터 API 공휴일 연동";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_monthAPI
            // 
            this.cb_monthAPI.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.cb_monthAPI.AutoSize = false;
            this.cb_monthAPI.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_monthAPI.Location = new System.Drawing.Point(285, 18);
            this.cb_monthAPI.Margin = new Wisej.Web.Padding(0);
            this.cb_monthAPI.Name = "cb_monthAPI";
            this.cb_monthAPI.Size = new System.Drawing.Size(96, 32);
            this.cb_monthAPI.TabIndex = 39;
            // 
            // label52
            // 
            this.label52.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label52.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label52.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label52.Location = new System.Drawing.Point(194, 18);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(80, 32);
            this.label52.TabIndex = 38;
            this.label52.Text = "월선택";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt_gonggongUpdate
            // 
            this.bt_gonggongUpdate.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_gonggongUpdate.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_gonggongUpdate.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_gonggongUpdate.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_gonggongUpdate.Location = new System.Drawing.Point(390, 18);
            this.bt_gonggongUpdate.Margin = new Wisej.Web.Padding(0);
            this.bt_gonggongUpdate.Name = "bt_gonggongUpdate";
            this.bt_gonggongUpdate.Size = new System.Drawing.Size(149, 32);
            this.bt_gonggongUpdate.TabIndex = 34;
            this.bt_gonggongUpdate.Text = "휴일 가져오기";
            this.bt_gonggongUpdate.Click += new System.EventHandler(this.bt_gonggongUpdate_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // holidaysTableAdapter1
            // 
            this.holidaysTableAdapter1.ClearBeforeFill = true;
            // 
            // holidaysYearListTableAdapter1
            // 
            this.holidaysYearListTableAdapter1.ClearBeforeFill = true;
            // 
            // holidaysDivideDateTableAdapter1
            // 
            this.holidaysDivideDateTableAdapter1.ClearBeforeFill = true;
            // 
            // View_BBSHolidayManage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel48);
            this.CssStyle = "background: /*#F0F0F0*/#eeeff8;";
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBSHolidayManage";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.panel32.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel89.ResumeLayout(false);
            this.panel36.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel35.PerformLayout();
            this.panel34.ResumeLayout(false);
            this.panel136.ResumeLayout(false);
            this.panel48.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_holidayList)).EndInit();
            this.panel55.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Button bt_updateoradd;
        private Wisej.Web.Panel panel32;
        private Wisej.Web.Label label15;
        private Wisej.Web.Panel panel21;
        private Wisej.Web.Panel panel22;
        private Wisej.Web.Panel panel89;
        private Wisej.Web.Panel panel36;
        private Wisej.Web.TextBox tb_holidayDescription;
        private Wisej.Web.Label label25;
        private Wisej.Web.Panel panel35;
        private Wisej.Web.Label label24;
        private Wisej.Web.Line line5;
        private Wisej.Web.Panel panel34;
        private Wisej.Web.Label label23;
        private Wisej.Web.Label label22;
        private Wisej.Web.Panel panel136;
        private Wisej.Web.Button bt_delete;
        private Wisej.Web.Label lb_text;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel48;
        private Wisej.Web.ComboBox cb_year;
        private Wisej.Web.Label label21;
        private Wisej.Web.Button bt_openAddNewForm;
        private Wisej.Web.Panel panel55;
        private Wisej.Web.Panel panel20;
        private Wisej.Web.Label label51;
        private Wisej.Web.ComboBox cb_monthAPI;
        private Wisej.Web.Label label52;
        private Wisej.Web.Button bt_gonggongUpdate;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.DataGridViewTextBoxColumn 연도;
        private Wisej.Web.DataGridViewTextBoxColumn 날짜;
        private Wisej.Web.DataGridViewTextBoxColumn 휴일내역;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.HolidaysTableAdapter holidaysTableAdapter1;
        private Wisej.Web.DataGridView dg_holidayList;
        private DataSet1TableAdapters.HolidaysYearListTableAdapter holidaysYearListTableAdapter1;
        private DataSet1TableAdapters.HolidaysDivideDateTableAdapter holidaysDivideDateTableAdapter1;
        private Wisej.Web.DateTimePicker dt_picker;
    }
}
