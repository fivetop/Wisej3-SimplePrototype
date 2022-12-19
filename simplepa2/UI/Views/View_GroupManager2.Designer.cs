namespace simplepa2.UI.Views
{
    partial class View_GroupManager2
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
            this.assetGroupsTableAdapter = new simplepa2.DataSet1TableAdapters.AssetGroupsTableAdapter();
            this.assetsTableAdapter = new simplepa2.DataSet1TableAdapters.AssetsTableAdapter();
            this.gbindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.gdataGridView1 = new Wisej.Web.DataGridView();
            this.colAssetbaseid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new Wisej.Web.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.gbutton3 = new Wisej.Web.Button();
            this.gbutton2 = new Wisej.Web.Button();
            this.gbutton1 = new Wisej.Web.Button();
            this.tableLayoutPanel4 = new Wisej.Web.TableLayoutPanel();
            this.label9 = new Wisej.Web.Label();
            this.gcomboBox1 = new Wisej.Web.ComboBox();
            this.gtextBox1 = new Wisej.Web.TextBox();
            this.label10 = new Wisej.Web.Label();
            this.ptop = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.ptop.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // assetGroupsTableAdapter
            // 
            this.assetGroupsTableAdapter.ClearBeforeFill = true;
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
            this.gdataGridView1.Size = new System.Drawing.Size(872, 525);
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
            // gbutton3
            // 
            this.gbutton3.Location = new System.Drawing.Point(765, 13);
            this.gbutton3.Name = "gbutton3";
            this.gbutton3.Size = new System.Drawing.Size(85, 27);
            this.gbutton3.TabIndex = 15;
            this.gbutton3.Text = "삭제";
            this.gbutton3.Click += new System.EventHandler(this.gbutton3_Click);
            // 
            // gbutton2
            // 
            this.gbutton2.Location = new System.Drawing.Point(685, 13);
            this.gbutton2.Name = "gbutton2";
            this.gbutton2.Size = new System.Drawing.Size(74, 27);
            this.gbutton2.TabIndex = 14;
            this.gbutton2.Text = "등록";
            this.gbutton2.Click += new System.EventHandler(this.gbutton2_Click);
            // 
            // gbutton1
            // 
            this.gbutton1.Location = new System.Drawing.Point(601, 13);
            this.gbutton1.Name = "gbutton1";
            this.gbutton1.Size = new System.Drawing.Size(78, 27);
            this.gbutton1.TabIndex = 13;
            this.gbutton1.Text = "저장";
            this.gbutton1.Click += new System.EventHandler(this.gbutton1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25.12F));
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 74.88F));
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 129F));
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 156F));
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.gcomboBox1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.gtextBox1, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(21, 4);
            this.tableLayoutPanel4.Margin = new Wisej.Web.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(525, 46);
            this.tableLayoutPanel4.TabIndex = 11;
            this.tableLayoutPanel4.TabStop = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new Wisej.Web.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 46);
            this.label9.TabIndex = 0;
            this.label9.Text = "그룹명";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gcomboBox1
            // 
            this.gcomboBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.gcomboBox1.AutoSize = false;
            this.gcomboBox1.DisplayMember = "Name";
            this.gcomboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.gcomboBox1.Location = new System.Drawing.Point(68, 8);
            this.gcomboBox1.Margin = new Wisej.Web.Padding(8);
            this.gcomboBox1.Name = "gcomboBox1";
            this.gcomboBox1.Size = new System.Drawing.Size(163, 24);
            this.gcomboBox1.TabIndex = 5;
            this.gcomboBox1.ValueMember = "Name";
            this.gcomboBox1.SelectedIndexChanged += new System.EventHandler(this.gcomboBox1_SelectedIndexChanged);
            // 
            // gtextBox1
            // 
            this.gtextBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.gtextBox1.AutoSize = false;
            this.gtextBox1.Location = new System.Drawing.Point(376, 8);
            this.gtextBox1.Margin = new Wisej.Web.Padding(8);
            this.gtextBox1.Name = "gtextBox1";
            this.gtextBox1.Size = new System.Drawing.Size(141, 24);
            this.gtextBox1.TabIndex = 1;
            this.gtextBox1.Watermark = "Enter a name";
            // 
            // label10
            // 
            this.label10.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 0);
            this.label10.Margin = new Wisej.Web.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 46);
            this.label10.TabIndex = 2;
            this.label10.Text = "신규 그룹명(등록)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptop
            // 
            this.ptop.Controls.Add(this.tableLayoutPanel4);
            this.ptop.Controls.Add(this.gbutton3);
            this.ptop.Controls.Add(this.gbutton2);
            this.ptop.Controls.Add(this.gbutton1);
            this.ptop.Dock = Wisej.Web.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(20, 20);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(872, 70);
            this.ptop.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gdataGridView1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 525);
            this.panel2.TabIndex = 17;
            // 
            // View_GroupManager2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ptop);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_GroupManager2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(912, 635);
            this.Load += new System.EventHandler(this.MGroupManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ptop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.BindingSource gbindingSource2;
        private DataSet1 dataSet1;
        private Wisej.Web.BindingSource gbindingSource1;
        private DataSet1TableAdapters.AssetGroupsTableAdapter assetGroupsTableAdapter;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter;
        private Wisej.Web.DataGridView gdataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colAssetbaseid;
        private Wisej.Web.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Wisej.Web.Button gbutton3;
        private Wisej.Web.Button gbutton2;
        private Wisej.Web.Button gbutton1;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel4;
        private Wisej.Web.Label label9;
        private Wisej.Web.Label label10;
        private Wisej.Web.TextBox gtextBox1;
        private Wisej.Web.ComboBox gcomboBox1;
        private Wisej.Web.Panel ptop;
        private Wisej.Web.Panel panel2;
    }
}
