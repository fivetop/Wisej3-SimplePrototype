namespace Wisej.CodeProject
{
	partial class Main
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
            this.panel1 = new Wisej.Web.Panel();
            this.button2 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colSeq = new Wisej.Web.DataGridViewTextBoxColumn();
            this.chk = new Wisej.Web.DataGridViewCheckBoxColumn();
            this.colPath = new Wisej.Web.DataGridViewTextBoxColumn();
            this.assetsBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.splitContainer2 = new Wisej.Web.SplitContainer();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.colFilename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFilecontent = new Wisej.Web.DataGridViewTextBoxColumn();
            this.assetsTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.AssetsTableAdapter();
            this.contextMenu1 = new Wisej.Web.ContextMenu();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.menuItem2 = new Wisej.Web.MenuItem();
            this.panel3 = new Wisej.Web.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.Size = new System.Drawing.Size(823, 80);
            this.panel1.TabIndex = 8;
            this.panel1.TabStop = true;
            // 
            // button2
            // 
            this.button2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/stop-button.svg";
            this.button2.Location = new System.Drawing.Point(182, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop";
            this.button2.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-arrow.svg";
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new Wisej.Web.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.TabStop = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.TabStop = true;
            this.splitContainer1.Size = new System.Drawing.Size(813, 406);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colSeq,
            this.chk,
            this.colPath});
            this.dataGridView1.DataSource = this.assetsBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 14;
            this.dataGridView1.RowHeadersWidthSizeMode = Wisej.Web.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ShowFocusCell = false;
            this.dataGridView1.Size = new System.Drawing.Size(378, 406);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colSeq
            // 
            this.colSeq.DataPropertyName = "seq";
            this.colSeq.HeaderText = "No";
            this.colSeq.Name = "colSeq";
            this.colSeq.Width = 50;
            // 
            // chk
            // 
            this.chk.DataPropertyName = "chk";
            this.chk.FalseValue = "0";
            this.chk.HeaderText = "ACT";
            this.chk.Name = "chk";
            this.chk.SortMode = Wisej.Web.DataGridViewColumnSortMode.Automatic;
            this.chk.TrueValue = "1";
            this.chk.Width = 40;
            // 
            // colPath
            // 
            this.colPath.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.colPath.DataPropertyName = "path";
            this.colPath.HeaderText = "지역";
            this.colPath.Name = "colPath";
            this.colPath.Width = 300;
            // 
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "Assets";
            this.assetsBindingSource.DataSource = this.dataSet1;
            this.assetsBindingSource.Sort = "seq";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = Wisej.Web.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            this.splitContainer2.Panel1.TabStop = true;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.TabStop = true;
            this.splitContainer2.Size = new System.Drawing.Size(429, 406);
            this.splitContainer2.SplitterDistance = 175;
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
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 14;
            this.dataGridView2.Size = new System.Drawing.Size(429, 175);
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
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            this.contextMenu1.Name = "contextMenu1";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Text = "menuItem1";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Text = "menuItem2";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(4);
            this.panel3.ShowCloseButton = false;
            this.panel3.Size = new System.Drawing.Size(823, 416);
            this.panel3.TabIndex = 7;
            this.panel3.TabStop = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 496);
            this.CloseBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "메인화면";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
        private Web.Panel panel1;
        private Web.Button button2;
        private Web.Button button1;
        private Web.SplitContainer splitContainer1;
        private Web.SplitContainer splitContainer2;
        private Web.DataGridView dataGridView1;
        private Web.DataGridViewCheckBoxColumn chk;
        private Web.DataGridViewTextBoxColumn colPath;
        private Web.BindingSource assetsBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter;
        private Web.DataGridViewTextBoxColumn colSeq;
        private Web.DataGridView dataGridView2;
        private Web.DataGridViewTextBoxColumn colFilename;
        private Web.DataGridViewTextBoxColumn colFilecontent;
        private Web.ContextMenu contextMenu1;
        private Web.MenuItem menuItem1;
        private Web.MenuItem menuItem2;
        private Web.Panel panel3;
    }
}