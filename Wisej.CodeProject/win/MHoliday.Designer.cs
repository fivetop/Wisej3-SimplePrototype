namespace Wisej.CodeProject
{
	partial class MHoliday
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
            Wisej.Web.ComponentTool componentTool4 = new Wisej.Web.ComponentTool();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.ComponentTool componentTool5 = new Wisej.Web.ComponentTool();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colHolidayid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colHdate = new Wisej.Web.DataGridViewDateTimePickerColumn();
            this.colDescription = new Wisej.Web.DataGridViewTextBoxColumn();
            this.statusBar1 = new Wisej.Web.StatusBar();
            this.bindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.textBox1 = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.dateTimePicker1 = new Wisej.Web.DateTimePicker();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.holidaysTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.HolidaysTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colHolidayid,
            this.colHdate,
            this.colDescription});
            this.dataGridView1.Controls.Add(this.statusBar1);
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(30, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 298);
            this.dataGridView1.TabIndex = 1;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/square-add-button.svg?color=#3F76BF";
            componentTool1.Name = "Add";
            componentTool1.Position = Wisej.Web.LeftRightAlignment.Left;
            componentTool2.Enabled = false;
            componentTool2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/save-button.svg?color=#3FBF47";
            componentTool2.Name = "Save";
            componentTool2.Position = Wisej.Web.LeftRightAlignment.Left;
            componentTool3.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/refresh-button.svg?color=#003EFF";
            componentTool3.Name = "Reload";
            componentTool3.Position = Wisej.Web.LeftRightAlignment.Left;
            componentTool4.Enabled = false;
            componentTool4.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/rubbish-bin-delete-button.svg?color=#7A7A7A";
            componentTool4.Name = "Delete";
            this.dataGridView1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1,
            componentTool2,
            componentTool3,
            componentTool4});
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.dataGridView1_ToolClick);
            this.dataGridView1.CellToolClick += new Wisej.Web.DataGridViewToolClickEventHandler(this.dataGridView1_CellToolClick);
            this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
            // 
            // colHolidayid
            // 
            this.colHolidayid.DataPropertyName = "HolidayId";
            this.colHolidayid.HeaderText = "No";
            this.colHolidayid.Name = "colHolidayid";
            this.colHolidayid.Width = 60;
            // 
            // colHdate
            // 
            this.colHdate.DataPropertyName = "hDate";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.colHdate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colHdate.HeaderText = "날자";
            this.colHdate.Name = "colHdate";
            this.colHdate.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "내용";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 150;
            // 
            // statusBar1
            // 
            this.statusBar1.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.statusBar1.Location = new System.Drawing.Point(0, 274);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.ShowPanels = false;
            this.statusBar1.Size = new System.Drawing.Size(430, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "statusBar1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Holidays";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "Description", true));
            this.textBox1.Location = new System.Drawing.Point(132, 51);
            this.textBox1.Margin = new Wisej.Web.Padding(8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.Watermark = "Enter a name";
            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Margin = new Wisej.Web.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "내용";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Margin = new Wisej.Web.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "날자";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AutoSize = false;
            this.dateTimePicker1.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "hDate", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 8);
            this.dateTimePicker1.Margin = new Wisej.Web.Padding(8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 27);
            this.dateTimePicker1.TabIndex = 7;
            componentTool5.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/shining-sun.svg?color=#FFA700";
            this.dateTimePicker1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool5});
            this.dateTimePicker1.Value = new System.DateTime(2017, 8, 25, 17, 55, 6, 102);
            this.dateTimePicker1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.dateTimePicker1_ToolClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = Wisej.Web.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 28.88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 71.12F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 87);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // holidaysTableAdapter
            // 
            this.holidaysTableAdapter.ClearBeforeFill = true;
            // 
            // MHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 432);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/server-rack-with-three-levels.svg?color=#BF3" +
    "F3F";
            this.Name = "MHoliday";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
            this.Text = "휴일관리";
            this.Load += new System.EventHandler(this.DataBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataGridView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Web.DataGridView dataGridView1;
		private Web.TextBox textBox1;
		private Web.Label label1;
		private Web.Label label3;
		private Web.DateTimePicker dateTimePicker1;
		private Web.TableLayoutPanel tableLayoutPanel1;
		private Web.StatusBar statusBar1;
        private DataSet1 dataSet1;
        private Web.BindingSource bindingSource1;
        private DataSet1TableAdapters.HolidaysTableAdapter holidaysTableAdapter;
        private Web.DataGridViewTextBoxColumn colHolidayid;
        private Web.DataGridViewDateTimePickerColumn colHdate;
        private Web.DataGridViewTextBoxColumn colDescription;
    }
}