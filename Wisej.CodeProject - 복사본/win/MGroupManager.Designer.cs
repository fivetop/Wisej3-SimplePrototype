namespace Wisej.CodeProject.win
{
    partial class MGroupManager
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
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.assetGroupsTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.AssetGroupsTableAdapter();
            this.assetsTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.AssetsTableAdapter();
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
            this.label10 = new Wisej.Web.Label();
            this.gtextBox1 = new Wisej.Web.TextBox();
            this.gcomboBox1 = new Wisej.Web.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.gdataGridView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.gdataGridView1.AutoGenerateColumns = false;
            this.gdataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colAssetbaseid,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.gdataGridView1.DataSource = this.gbindingSource2;
            this.gdataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.gdataGridView1.Location = new System.Drawing.Point(21, 135);
            this.gdataGridView1.MultiSelect = false;
            this.gdataGridView1.Name = "gdataGridView1";
            this.gdataGridView1.ShowFocusCell = false;
            this.gdataGridView1.Size = new System.Drawing.Size(776, 236);
            this.gdataGridView1.TabIndex = 12;
            this.gdataGridView1.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colAssetbaseid
            // 
            this.colAssetbaseid.DataPropertyName = "AssetId";
            this.colAssetbaseid.HeaderText = "No";
            this.colAssetbaseid.Name = "colAssetbaseid";
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
            this.gbutton3.Location = new System.Drawing.Point(395, 102);
            this.gbutton3.Name = "gbutton3";
            this.gbutton3.Size = new System.Drawing.Size(85, 27);
            this.gbutton3.TabIndex = 15;
            this.gbutton3.Text = "삭제";
            this.gbutton3.Click += new System.EventHandler(this.gbutton3_Click);
            // 
            // gbutton2
            // 
            this.gbutton2.Location = new System.Drawing.Point(292, 102);
            this.gbutton2.Name = "gbutton2";
            this.gbutton2.Size = new System.Drawing.Size(74, 27);
            this.gbutton2.TabIndex = 14;
            this.gbutton2.Text = "등록";
            this.gbutton2.Click += new System.EventHandler(this.gbutton2_Click);
            // 
            // gbutton1
            // 
            this.gbutton1.Location = new System.Drawing.Point(186, 102);
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
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.gtextBox1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.gcomboBox1, 0, 1);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("@default", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 26);
            this.tableLayoutPanel4.Margin = new Wisej.Web.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(787, 66);
            this.tableLayoutPanel4.TabIndex = 11;
            this.tableLayoutPanel4.TabStop = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = Wisej.Web.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new Wisej.Web.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(393, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "그룹명";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = Wisej.Web.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(393, 0);
            this.label10.Margin = new Wisej.Web.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(394, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "신규 그룹명(등록)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gtextBox1
            // 
            this.gtextBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.gtextBox1.AutoSize = false;
            this.gtextBox1.Location = new System.Drawing.Point(401, 34);
            this.gtextBox1.Margin = new Wisej.Web.Padding(8);
            this.gtextBox1.Name = "gtextBox1";
            this.gtextBox1.Size = new System.Drawing.Size(378, 24);
            this.gtextBox1.TabIndex = 1;
            this.gtextBox1.Watermark = "Enter a name";
            // 
            // gcomboBox1
            // 
            this.gcomboBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.gcomboBox1.AutoSize = false;
            this.gcomboBox1.DisplayMember = "Name";
            this.gcomboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.gcomboBox1.Location = new System.Drawing.Point(8, 34);
            this.gcomboBox1.Margin = new Wisej.Web.Padding(8);
            this.gcomboBox1.Name = "gcomboBox1";
            this.gcomboBox1.Size = new System.Drawing.Size(377, 24);
            this.gcomboBox1.TabIndex = 5;
            this.gcomboBox1.ValueMember = "Name";
            this.gcomboBox1.SelectedIndexChanged += new System.EventHandler(this.gcomboBox1_SelectedIndexChanged);
            // 
            // MGroupManager
            // 
            this.Controls.Add(this.gdataGridView1);
            this.Controls.Add(this.gbutton3);
            this.Controls.Add(this.gbutton2);
            this.Controls.Add(this.gbutton1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "MGroupManager";
            this.Size = new System.Drawing.Size(912, 635);
            this.Load += new System.EventHandler(this.MGroupManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.BindingSource gbindingSource2;
        private DataSet1 dataSet1;
        private Web.BindingSource gbindingSource1;
        private DataSet1TableAdapters.AssetGroupsTableAdapter assetGroupsTableAdapter;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter;
        private Web.DataGridView gdataGridView1;
        private Web.DataGridViewTextBoxColumn colAssetbaseid;
        private Web.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Web.Button gbutton3;
        private Web.Button gbutton2;
        private Web.Button gbutton1;
        private Web.TableLayoutPanel tableLayoutPanel4;
        private Web.Label label9;
        private Web.Label label10;
        private Web.TextBox gtextBox1;
        private Web.ComboBox gcomboBox1;
    }
}
