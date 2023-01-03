namespace simplepa2.UI.Views
{
    partial class View_GroupPresetManager2
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
            this.gbindingSource2 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.assetsTableAdapter = new simplepa2.DataSet1TableAdapters.AssetsTableAdapter();
            this.gbindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.gdataGridView1 = new Wisej.Web.DataGridView();
            this.colAssetbaseid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new Wisej.Web.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.gbutton1 = new Wisej.Web.Button();
            this.tableLayoutPanel4 = new Wisej.Web.TableLayoutPanel();
            this.sitecomboBox1 = new Wisej.Web.ComboBox();
            this.label1 = new Wisej.Web.Label();
            this.gcomboBox1 = new Wisej.Web.ComboBox();
            this.label9 = new Wisej.Web.Label();
            this.ptop = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.assetPresetGroupsTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetPresetGroupsTableAdapter();
            this.sitebindingSource1 = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.ptop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitebindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbindingSource2
            // 
            this.gbindingSource2.DataMember = "Assets";
            this.gbindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // gdataGridView1
            // 
            this.gdataGridView1.AutoGenerateColumns = false;
            this.gdataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colAssetbaseid,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.gdataGridView1.DataSource = this.gbindingSource2;
            this.gdataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.gdataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.gdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.gdataGridView1.MultiSelect = false;
            this.gdataGridView1.Name = "gdataGridView1";
            this.gdataGridView1.ShowFocusCell = false;
            this.gdataGridView1.Size = new System.Drawing.Size(832, 503);
            this.gdataGridView1.TabIndex = 12;
            this.gdataGridView1.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colAssetbaseid
            // 
            this.colAssetbaseid.DataPropertyName = "AssetId";
            this.colAssetbaseid.HeaderText = "No";
            this.colAssetbaseid.Name = "colAssetbaseid";
            this.colAssetbaseid.ReadOnly = true;
            this.colAssetbaseid.Width = 40;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "chk";
            this.dataGridViewCheckBoxColumn1.FalseValue = "0";
            this.dataGridViewCheckBoxColumn1.HeaderText = "ACT";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.SortMode = Wisej.Web.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "1";
            this.dataGridViewCheckBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "path";
            this.dataGridViewTextBoxColumn1.HeaderText = "지역";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // gbutton1
            // 
            this.gbutton1.Location = new System.Drawing.Point(725, 3);
            this.gbutton1.Name = "gbutton1";
            this.gbutton1.Size = new System.Drawing.Size(78, 27);
            this.gbutton1.TabIndex = 13;
            this.gbutton1.Text = "저장";
            this.gbutton1.Click += new System.EventHandler(this.gbutton1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 8.05F));
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.65F));
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 10.34F));
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 34.74F));
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 13F));
            this.tableLayoutPanel4.Controls.Add(this.sitecomboBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.gbutton1, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.gcomboBox1, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel4.Dock = Wisej.Web.DockStyle.Top;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel4.Margin = new Wisej.Web.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.ShowCloseButton = false;
            this.tableLayoutPanel4.Size = new System.Drawing.Size(832, 52);
            this.tableLayoutPanel4.TabIndex = 11;
            this.tableLayoutPanel4.TabStop = true;
            // 
            // sitecomboBox1
            // 
            this.sitecomboBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.sitecomboBox1.AutoSize = false;
            this.sitecomboBox1.DisplayMember = "EMNAME";
            this.sitecomboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.sitecomboBox1.Location = new System.Drawing.Point(75, 8);
            this.sitecomboBox1.Margin = new Wisej.Web.Padding(8);
            this.sitecomboBox1.Name = "sitecomboBox1";
            this.sitecomboBox1.Size = new System.Drawing.Size(264, 24);
            this.sitecomboBox1.TabIndex = 15;
            this.sitecomboBox1.ValueMember = "Name";
            this.sitecomboBox1.SelectedIndexChanged += new System.EventHandler(this.gcomboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new Wisej.Web.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "사이트명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gcomboBox1
            // 
            this.gcomboBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.gcomboBox1.AutoSize = false;
            this.gcomboBox1.DisplayMember = "Name";
            this.gcomboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.gcomboBox1.Location = new System.Drawing.Point(441, 8);
            this.gcomboBox1.Margin = new Wisej.Web.Padding(8);
            this.gcomboBox1.Name = "gcomboBox1";
            this.gcomboBox1.Size = new System.Drawing.Size(273, 24);
            this.gcomboBox1.TabIndex = 5;
            this.gcomboBox1.ValueMember = "Name";
            this.gcomboBox1.SelectedIndexChanged += new System.EventHandler(this.gcomboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(382, 0);
            this.label9.Margin = new Wisej.Web.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "그룹명";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.White;
            this.ptop.Controls.Add(this.panel2);
            this.ptop.Controls.Add(this.tableLayoutPanel4);
            this.ptop.Dock = Wisej.Web.DockStyle.Fill;
            this.ptop.Location = new System.Drawing.Point(20, 20);
            this.ptop.Name = "ptop";
            this.ptop.Padding = new Wisej.Web.Padding(20);
            this.ptop.Size = new System.Drawing.Size(872, 595);
            this.ptop.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gdataGridView1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 503);
            this.panel2.TabIndex = 17;
            // 
            // assetPresetGroupsTableAdapter1
            // 
            this.assetPresetGroupsTableAdapter1.ClearBeforeFill = true;
            // 
            // View_GroupPresetManager2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.ptop);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_GroupPresetManager2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(912, 635);
            this.Load += new System.EventHandler(this.MGroupManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ptop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sitebindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.BindingSource gbindingSource2;
        private DataSet1 dataSet1;
        private Wisej.Web.BindingSource gbindingSource1;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter;
        private Wisej.Web.DataGridView gdataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colAssetbaseid;
        private Wisej.Web.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Wisej.Web.Button gbutton1;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel4;
        private Wisej.Web.Label label9;
        private Wisej.Web.ComboBox gcomboBox1;
        private Wisej.Web.Panel ptop;
        private Wisej.Web.Panel panel2;
        private DataSet1TableAdapters.AssetPresetGroupsTableAdapter assetPresetGroupsTableAdapter1;
        private Wisej.Web.ComboBox sitecomboBox1;
        private Wisej.Web.Label label1;
        private Wisej.Web.BindingSource sitebindingSource1;
    }
}
