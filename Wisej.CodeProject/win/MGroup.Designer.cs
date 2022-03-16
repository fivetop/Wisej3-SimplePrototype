namespace Wisej.CodeProject
{
    partial class MGroup
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
            Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colAssetbaseid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.chk = new Wisej.Web.DataGridViewCheckBoxColumn();
            this.colPath = new Wisej.Web.DataGridViewTextBoxColumn();
            this.statusBar1 = new Wisej.Web.StatusBar();
            this.bindingSource2 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.textBox1 = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.assetGroupsTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.AssetGroupsTableAdapter();
            this.assetsTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.AssetsTableAdapter();
            this.bindingSource1 = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colAssetbaseid,
            this.chk,
            this.colPath});
            this.dataGridView1.Controls.Add(this.statusBar1);
            this.dataGridView1.DataSource = this.bindingSource2;
            this.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(13, 112);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowFocusCell = false;
            this.dataGridView1.Size = new System.Drawing.Size(485, 337);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colAssetbaseid
            // 
            this.colAssetbaseid.DataPropertyName = "AssetId";
            this.colAssetbaseid.HeaderText = "No";
            this.colAssetbaseid.Name = "colAssetbaseid";
            this.colAssetbaseid.Width = 40;
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
            this.colPath.DataPropertyName = "path";
            this.colPath.HeaderText = "지역";
            this.colPath.Name = "colPath";
            this.colPath.Width = 300;
            // 
            // statusBar1
            // 
            this.statusBar1.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.statusBar1.Location = new System.Drawing.Point(0, 313);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.ShowPanels = false;
            this.statusBar1.Size = new System.Drawing.Size(483, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "statusBar1";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Assets";
            this.bindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.textBox1.AutoSize = false;
            this.textBox1.Location = new System.Drawing.Point(250, 49);
            this.textBox1.Margin = new Wisej.Web.Padding(8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 25);
            this.textBox1.TabIndex = 1;
            componentTool1.ImageSource = "menu-overflow";
            componentTool1.Name = "Update";
            componentTool2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/save-button.svg?color=#3FBF47";
            componentTool2.Name = "Save";
            componentTool3.ImageSource = "Resources\\rubbish-bin-delete-button.svg";
            componentTool3.Name = "Del";
            this.textBox1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1,
            componentTool2,
            componentTool3});
            this.textBox1.Watermark = "Enter a name";
            this.textBox1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textBox1_ToolClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Wisej.Web.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new Wisej.Web.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "그룹명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = Wisej.Web.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(250, 8);
            this.label2.Margin = new Wisej.Web.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "신규등록";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBox1.AutoSize = false;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(8, 49);
            this.comboBox1.Margin = new Wisej.Web.Padding(8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 25);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "Name";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // assetGroupsTableAdapter
            // 
            this.assetGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Model.DataList);
            // 
            // MGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/server-rack-with-three-levels.svg?color=#BF3" +
    "F3F";
            this.Name = "MGroup";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
            this.Text = "그룹관리";
            this.Load += new System.EventHandler(this.DataBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataGridView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.DataGridView dataGridView1;
        private Web.TextBox textBox1;
        private Web.Label label1;
        private Web.Label label2;
        private Web.ComboBox comboBox1;
        private Web.TableLayoutPanel tableLayoutPanel1;
        private Web.StatusBar statusBar1;
        private Web.DataGridViewTextBoxColumn colAssetbaseid;
        private Web.DataGridViewTextBoxColumn colPath;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.AssetGroupsTableAdapter assetGroupsTableAdapter;
        private Web.BindingSource bindingSource1;
        private Web.DataGridViewCheckBoxColumn chk;
        private Web.BindingSource bindingSource2;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter;
    }
}