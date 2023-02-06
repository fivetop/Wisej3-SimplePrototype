namespace simplepa2.UI.Views
{
    partial class View_BBSAnchor2
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
            this.dataSet1 = new simplepa2.DataSet1();
            this.assetsBindingSource = new Wisej.Web.BindingSource(this.components);
            this.assetsTableAdapter = new simplepa2.DataSet1TableAdapters.AssetsTableAdapter();
            this.panel4 = new Wisej.Web.Panel();
            this.comp_Site1 = new simplepa2.UI.Components.Comp_Site();
            this.btnStop = new Wisej.Web.Button();
            this.btnStart = new Wisej.Web.Button();
            this.panel3 = new Wisej.Web.Panel();
            this.splitContainer2 = new Wisej.Web.SplitContainer();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.colFilename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFilecontent = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel1 = new Wisej.Web.Panel();
            this.panel7 = new Wisej.Web.Panel();
            this.comp_UAsset1 = new simplepa2.Comp_UAsset();
            this.panel8 = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.panel5 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.panel35 = new Wisej.Web.Panel();
            this.label39 = new Wisej.Web.Label();
            this.label40 = new Wisej.Web.Label();
            this.label37 = new Wisej.Web.Label();
            this.label38 = new Wisej.Web.Label();
            this.label31 = new Wisej.Web.Label();
            this.label16 = new Wisej.Web.Label();
            this.panel41 = new Wisej.Web.Panel();
            this.label17 = new Wisej.Web.Label();
            this.panel6 = new Wisej.Web.Panel();
            this.panel9 = new Wisej.Web.Panel();
            this.label2 = new Wisej.Web.Label();
            this.panel10 = new Wisej.Web.Panel();
            this.label3 = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "Assets";
            this.assetsBindingSource.DataSource = this.dataSet1;
            this.assetsBindingSource.Sort = "seq";
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.comp_Site1);
            this.panel4.Controls.Add(this.btnStop);
            this.panel4.Controls.Add(this.btnStart);
            this.panel4.Dock = Wisej.Web.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 20);
            this.panel4.Name = "panel4";
            this.panel4.ShowCloseButton = false;
            this.panel4.Size = new System.Drawing.Size(1320, 52);
            this.panel4.TabIndex = 11;
            this.panel4.TabStop = true;
            // 
            // comp_Site1
            // 
            this.comp_Site1.Name = "comp_Site1";
            this.comp_Site1.TabIndex = 5;
            this.comp_Site1.SelectedValueChanged += new System.EventHandler(this.comp_Site1_SelectedValueChanged);
            // 
            // btnStop
            // 
            this.btnStop.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/stop-button.svg";
            this.btnStop.Location = new System.Drawing.Point(409, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 36);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-arrow.svg";
            this.btnStart.Location = new System.Drawing.Point(293, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 36);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel3.Controls.Add(this.splitContainer2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 72);
            this.panel3.Margin = new Wisej.Web.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.ShowCloseButton = false;
            this.panel3.Size = new System.Drawing.Size(1320, 768);
            this.panel3.TabIndex = 12;
            this.panel3.TabStop = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(550, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = Wisej.Web.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            this.splitContainer2.Panel1.Controls.Add(this.panel9);
            this.splitContainer2.Panel1.Padding = new Wisej.Web.Padding(20);
            this.splitContainer2.Panel1.TabStop = true;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel10);
            this.splitContainer2.Panel2.Padding = new Wisej.Web.Padding(20);
            this.splitContainer2.Panel2.TabStop = true;
            this.splitContainer2.Size = new System.Drawing.Size(768, 766);
            this.splitContainer2.SplitterDistance = 289;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colFilename,
            this.colFilecontent});
            this.dataGridView2.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView2.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(20, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 14;
            this.dataGridView2.Size = new System.Drawing.Size(726, 210);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellMouseClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = Wisej.Web.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(550, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 766);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.comp_UAsset1);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = Wisej.Web.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 190);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new Wisej.Web.Padding(20);
            this.panel7.ShowCloseButton = false;
            this.panel7.Size = new System.Drawing.Size(550, 576);
            this.panel7.TabIndex = 0;
            // 
            // comp_UAsset1
            // 
            this.comp_UAsset1.AutoScroll = true;
            this.comp_UAsset1.Dock = Wisej.Web.DockStyle.Fill;
            this.comp_UAsset1.Location = new System.Drawing.Point(20, 57);
            this.comp_UAsset1.Name = "comp_UAsset1";
            this.comp_UAsset1.Selectable = true;
            this.comp_UAsset1.Size = new System.Drawing.Size(510, 499);
            this.comp_UAsset1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = Wisej.Web.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(20, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(510, 37);
            this.panel8.TabIndex = 163;
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
            this.label1.Text = "방송 지역 선택";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.panel5.Dock = Wisej.Web.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 170);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(550, 20);
            this.panel5.TabIndex = 167;
            this.panel5.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel35);
            this.panel2.Controls.Add(this.panel41);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(550, 170);
            this.panel2.TabIndex = 51;
            this.panel2.Visible = false;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.label39);
            this.panel35.Controls.Add(this.label40);
            this.panel35.Controls.Add(this.label37);
            this.panel35.Controls.Add(this.label38);
            this.panel35.Controls.Add(this.label31);
            this.panel35.Controls.Add(this.label16);
            this.panel35.Dock = Wisej.Web.DockStyle.Fill;
            this.panel35.Location = new System.Drawing.Point(20, 57);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(510, 93);
            this.panel35.TabIndex = 163;
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.FromArgb(255, 84, 84);
            this.label39.CssStyle = "border-radius:30px";
            this.label39.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(399, 28);
            this.label39.Margin = new Wisej.Web.Padding(0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(60, 60);
            this.label39.TabIndex = 139;
            this.label39.Text = "대기";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("ns700", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label40.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label40.Location = new System.Drawing.Point(399, 0);
            this.label40.Margin = new Wisej.Web.Padding(0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(60, 20);
            this.label40.TabIndex = 138;
            this.label40.Text = "비상 방송";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.FromArgb(7, 216, 21);
            this.label37.CssStyle = "border-radius:30px";
            this.label37.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(280, 28);
            this.label37.Margin = new Wisej.Web.Padding(0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(60, 60);
            this.label37.TabIndex = 137;
            this.label37.Text = "대기";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("ns700", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label38.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label38.Location = new System.Drawing.Point(280, 0);
            this.label38.Margin = new Wisej.Web.Padding(0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(60, 20);
            this.label38.TabIndex = 136;
            this.label38.Text = "정비 상태";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(255, 84, 84);
            this.label31.CssStyle = "border-radius:30px";
            this.label31.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(165, 28);
            this.label31.Margin = new Wisej.Web.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(60, 60);
            this.label31.TabIndex = 135;
            this.label31.Text = "대기";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("ns700", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label16.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label16.Location = new System.Drawing.Point(165, 0);
            this.label16.Margin = new Wisej.Web.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 134;
            this.label16.Text = "방송 출력";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.label17);
            this.panel41.Dock = Wisej.Web.DockStyle.Top;
            this.panel41.Location = new System.Drawing.Point(20, 20);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(510, 37);
            this.panel41.TabIndex = 162;
            // 
            // label17
            // 
            this.label17.AutoEllipsis = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label17.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Margin = new Wisej.Web.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(437, 24);
            this.label17.TabIndex = 134;
            this.label17.Text = "방송 모니터링";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = Wisej.Web.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(20, 20);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new Wisej.Web.Padding(20);
            this.panel6.Size = new System.Drawing.Size(1360, 860);
            this.panel6.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = Wisej.Web.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(20, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(726, 37);
            this.panel9.TabIndex = 164;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new Wisej.Web.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 24);
            this.label2.TabIndex = 134;
            this.label2.Text = "방송 음원 선택";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label3);
            this.panel10.Dock = Wisej.Web.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(20, 20);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(726, 37);
            this.panel10.TabIndex = 165;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new Wisej.Web.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 24);
            this.label3.TabIndex = 134;
            this.label3.Text = "그룹 방송 선택";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // View_BBSAnchor2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel6);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBSAnchor2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.View_BBSAnchor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel41.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private Wisej.Web.BindingSource assetsBindingSource;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Button btnStop;
        private Wisej.Web.Button btnStart;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.SplitContainer splitContainer2;
        private Wisej.Web.DataGridView dataGridView2;
        private Wisej.Web.DataGridViewTextBoxColumn colFilename;
        private Wisej.Web.DataGridViewTextBoxColumn colFilecontent;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel35;
        private Wisej.Web.Label label39;
        private Wisej.Web.Label label40;
        private Wisej.Web.Label label37;
        private Wisej.Web.Label label38;
        private Wisej.Web.Label label31;
        private Wisej.Web.Label label16;
        private Wisej.Web.Panel panel41;
        private Wisej.Web.Label label17;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel5;
        private Components.Comp_Site comp_Site1;
        private Wisej.Web.Panel panel6;
        private Wisej.Web.Panel panel7;
        private Comp_UAsset comp_UAsset1;
        private Wisej.Web.Panel panel8;
        private Wisej.Web.Label label1;
        private Wisej.Web.Panel panel9;
        private Wisej.Web.Label label2;
        private Wisej.Web.Panel panel10;
        private Wisej.Web.Label label3;
    }
}
