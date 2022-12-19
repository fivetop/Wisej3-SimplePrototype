namespace simplepa2.UI.Views
{
    partial class View_BBSHolidayManage2
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
            Wisej.Web.ComponentTool componentTool5 = new Wisej.Web.ComponentTool();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            this.holidaybindingSource2 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.holidaysTableAdapter = new simplepa2.DataSet1TableAdapters.HolidaysTableAdapter();
            this.ptop = new Wisej.Web.Panel();
            this.tableLayoutPanel3 = new Wisej.Web.TableLayoutPanel();
            this.label8 = new Wisej.Web.Label();
            this.hdateTimePicker1 = new Wisej.Web.DateTimePicker();
            this.label7 = new Wisej.Web.Label();
            this.htextBox1 = new Wisej.Web.TextBox();
            this.hdataGridView1 = new Wisej.Web.DataGridView();
            this.colHolidayid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colHdate = new Wisej.Web.DataGridViewDateTimePickerColumn();
            this.colDescription = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel1 = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.holidaybindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.ptop.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // holidaybindingSource2
            // 
            this.holidaybindingSource2.DataMember = "Holidays";
            this.holidaybindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // holidaysTableAdapter
            // 
            this.holidaysTableAdapter.ClearBeforeFill = true;
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.White;
            this.ptop.Controls.Add(this.tableLayoutPanel3);
            this.ptop.Dock = Wisej.Web.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(20, 20);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(873, 70);
            this.ptop.TabIndex = 6;
            this.ptop.TabStop = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 28.88F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 71.12F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 271F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.hdateTimePicker1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.htextBox1, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(16, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(653, 39);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.TabStop = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Margin = new Wisej.Web.Padding(8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "날자";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hdateTimePicker1
            // 
            this.hdateTimePicker1.AutoSize = false;
            this.hdateTimePicker1.DataBindings.Add(new Wisej.Web.Binding("Text", this.holidaybindingSource2, "hDate", true));
            this.hdateTimePicker1.Location = new System.Drawing.Point(102, 8);
            this.hdateTimePicker1.Margin = new Wisej.Web.Padding(8);
            this.hdateTimePicker1.Name = "hdateTimePicker1";
            this.hdateTimePicker1.Size = new System.Drawing.Size(207, 23);
            this.hdateTimePicker1.TabIndex = 7;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/shining-sun.svg?color=#FFA700";
            this.hdateTimePicker1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            this.hdateTimePicker1.Value = new System.DateTime(2017, 8, 25, 17, 55, 6, 102);
            // 
            // label7
            // 
            this.label7.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 8);
            this.label7.Margin = new Wisej.Web.Padding(8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "내용";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // htextBox1
            // 
            this.htextBox1.AutoSize = false;
            this.htextBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.holidaybindingSource2, "Description", true));
            this.htextBox1.Location = new System.Drawing.Point(389, 8);
            this.htextBox1.Margin = new Wisej.Web.Padding(8);
            this.htextBox1.Name = "htextBox1";
            this.htextBox1.Size = new System.Drawing.Size(207, 23);
            this.htextBox1.TabIndex = 1;
            this.htextBox1.Watermark = "Enter a name";
            // 
            // hdataGridView1
            // 
            this.hdataGridView1.AutoGenerateColumns = false;
            this.hdataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colHolidayid,
            this.colHdate,
            this.colDescription});
            this.hdataGridView1.DataSource = this.holidaybindingSource2;
            this.hdataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.hdataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditOnEnter;
            this.hdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.hdataGridView1.Name = "hdataGridView1";
            this.hdataGridView1.Size = new System.Drawing.Size(873, 540);
            this.hdataGridView1.TabIndex = 4;
            componentTool2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/square-add-button.svg?color=#3F76BF";
            componentTool2.Name = "Add";
            componentTool2.Position = Wisej.Web.LeftRightAlignment.Left;
            componentTool3.Enabled = false;
            componentTool3.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/save-button.svg?color=#3FBF47";
            componentTool3.Name = "Save";
            componentTool3.Position = Wisej.Web.LeftRightAlignment.Left;
            componentTool4.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/refresh-button.svg?color=#003EFF";
            componentTool4.Name = "Reload";
            componentTool4.Position = Wisej.Web.LeftRightAlignment.Left;
            componentTool5.Enabled = false;
            componentTool5.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/rubbish-bin-delete-button.svg?color=#7A7A7A";
            componentTool5.Name = "Delete";
            this.hdataGridView1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2,
            componentTool3,
            componentTool4,
            componentTool5});
            this.hdataGridView1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.hdataGridView1_ToolClick);
            this.hdataGridView1.Enter += new System.EventHandler(this.hdataGridView1_Enter);
            // 
            // colHolidayid
            // 
            this.colHolidayid.DataPropertyName = "HolidayId";
            this.colHolidayid.HeaderText = "No";
            this.colHolidayid.Name = "colHolidayid";
            this.colHolidayid.ReadOnly = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.hdataGridView1);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 540);
            this.panel1.TabIndex = 7;
            // 
            // View_BBSHolidayManage2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(239, 238, 248);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptop);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBSHolidayManage2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(913, 650);
            this.Load += new System.EventHandler(this.MHolidayManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.holidaybindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ptop.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.BindingSource holidaybindingSource2;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.HolidaysTableAdapter holidaysTableAdapter;
        private Wisej.Web.Panel ptop;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel3;
        private Wisej.Web.Label label7;
        private Wisej.Web.Label label8;
        private Wisej.Web.DateTimePicker hdateTimePicker1;
        private Wisej.Web.TextBox htextBox1;
        private Wisej.Web.DataGridView hdataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colHolidayid;
        private Wisej.Web.DataGridViewDateTimePickerColumn colHdate;
        private Wisej.Web.DataGridViewTextBoxColumn colDescription;
        private Wisej.Web.Panel panel1;
    }
}
