namespace Wisej.CodeProject.win
{
    partial class MHolidayManager
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
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.holidaysTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.HolidaysTableAdapter();
            this.panel6 = new Wisej.Web.Panel();
            this.tableLayoutPanel3 = new Wisej.Web.TableLayoutPanel();
            this.label7 = new Wisej.Web.Label();
            this.label8 = new Wisej.Web.Label();
            this.hdateTimePicker1 = new Wisej.Web.DateTimePicker();
            this.htextBox1 = new Wisej.Web.TextBox();
            this.hdataGridView1 = new Wisej.Web.DataGridView();
            this.colHolidayid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colHdate = new Wisej.Web.DataGridViewDateTimePickerColumn();
            this.colDescription = new Wisej.Web.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.holidaybindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdataGridView1)).BeginInit();
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
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel3);
            this.panel6.Controls.Add(this.hdataGridView1);
            this.panel6.Location = new System.Drawing.Point(16, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(519, 340);
            this.panel6.TabIndex = 6;
            this.panel6.TabStop = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = Wisej.Web.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 28.88F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 71.12F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.hdateTimePicker1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.htextBox1, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(333, 87);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.TabStop = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 51);
            this.label7.Margin = new Wisej.Web.Padding(8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "내용";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Margin = new Wisej.Web.Padding(8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "날자";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hdateTimePicker1
            // 
            this.hdateTimePicker1.AutoSize = false;
            this.hdateTimePicker1.DataBindings.Add(new Wisej.Web.Binding("Text", this.holidaybindingSource2, "hDate", true));
            this.hdateTimePicker1.Location = new System.Drawing.Point(104, 8);
            this.hdateTimePicker1.Margin = new Wisej.Web.Padding(8);
            this.hdateTimePicker1.Name = "hdateTimePicker1";
            this.hdateTimePicker1.Size = new System.Drawing.Size(207, 27);
            this.hdateTimePicker1.TabIndex = 7;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/shining-sun.svg?color=#FFA700";
            this.hdateTimePicker1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            this.hdateTimePicker1.Value = new System.DateTime(2017, 8, 25, 17, 55, 6, 102);
            // 
            // htextBox1
            // 
            this.htextBox1.AutoSize = false;
            this.htextBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.holidaybindingSource2, "Description", true));
            this.htextBox1.Location = new System.Drawing.Point(104, 51);
            this.htextBox1.Margin = new Wisej.Web.Padding(8);
            this.htextBox1.Name = "htextBox1";
            this.htextBox1.Size = new System.Drawing.Size(207, 28);
            this.htextBox1.TabIndex = 1;
            this.htextBox1.Watermark = "Enter a name";
            // 
            // hdataGridView1
            // 
            this.hdataGridView1.Anchor = Wisej.Web.AnchorStyles.None;
            this.hdataGridView1.AutoGenerateColumns = false;
            this.hdataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colHolidayid,
            this.colHdate,
            this.colDescription});
            this.hdataGridView1.DataSource = this.holidaybindingSource2;
            this.hdataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditOnEnter;
            this.hdataGridView1.Location = new System.Drawing.Point(3, 97);
            this.hdataGridView1.Name = "hdataGridView1";
            this.hdataGridView1.Size = new System.Drawing.Size(432, 200);
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
            // MHolidayManager
            // 
            this.Controls.Add(this.panel6);
            this.Name = "MHolidayManager";
            this.Size = new System.Drawing.Size(913, 650);
            this.Load += new System.EventHandler(this.MHolidayManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.holidaybindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.BindingSource holidaybindingSource2;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.HolidaysTableAdapter holidaysTableAdapter;
        private Web.Panel panel6;
        private Web.TableLayoutPanel tableLayoutPanel3;
        private Web.Label label7;
        private Web.Label label8;
        private Web.DateTimePicker hdateTimePicker1;
        private Web.TextBox htextBox1;
        private Web.DataGridView hdataGridView1;
        private Web.DataGridViewTextBoxColumn colHolidayid;
        private Web.DataGridViewDateTimePickerColumn colHdate;
        private Web.DataGridViewTextBoxColumn colDescription;
    }
}
