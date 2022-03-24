namespace Wisej.CodeProject
{
    partial class MEvent
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colEventvmid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colWrite_Time = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEvent_Text = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPath = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colIp = new Wisej.Web.DataGridViewTextBoxColumn();
            this.statusBar1 = new Wisej.Web.StatusBar();
            this.bindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.eventvmTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.EventvmTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colEventvmid,
            this.colWrite_Time,
            this.colEvent_Text,
            this.colPath,
            this.colState,
            this.colDevicename,
            this.colIp});
            this.dataGridView1.Controls.Add(this.statusBar1);
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Margin = new Wisej.Web.Padding(10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 14;
            this.dataGridView1.Size = new System.Drawing.Size(648, 297);
            this.dataGridView1.TabIndex = 1;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/refresh-button.svg?color=#003EFF";
            componentTool1.Name = "Reload";
            componentTool1.Position = Wisej.Web.LeftRightAlignment.Left;
            this.dataGridView1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            // 
            // colEventvmid
            // 
            this.colEventvmid.DataPropertyName = "EventVMId";
            this.colEventvmid.HeaderText = "No";
            this.colEventvmid.Name = "colEventvmid";
            this.colEventvmid.Width = 60;
            // 
            // colWrite_Time
            // 
            this.colWrite_Time.DataPropertyName = "write_time";
            dataGridViewCellStyle1.Format = "f";
            dataGridViewCellStyle1.NullValue = null;
            this.colWrite_Time.DefaultCellStyle = dataGridViewCellStyle1;
            this.colWrite_Time.HeaderText = "발생일자";
            this.colWrite_Time.Name = "colWrite_Time";
            this.colWrite_Time.Width = 180;
            // 
            // colEvent_Text
            // 
            this.colEvent_Text.DataPropertyName = "event_text";
            this.colEvent_Text.HeaderText = "발생 내용";
            this.colEvent_Text.Name = "colEvent_Text";
            this.colEvent_Text.Width = 150;
            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "path";
            this.colPath.HeaderText = "발생 지역";
            this.colPath.Name = "colPath";
            this.colPath.Width = 150;
            // 
            // colState
            // 
            this.colState.DataPropertyName = "state";
            this.colState.HeaderText = "상태";
            this.colState.Name = "colState";
            // 
            // colDevicename
            // 
            this.colDevicename.DataPropertyName = "DeviceName";
            this.colDevicename.HeaderText = "장비명";
            this.colDevicename.Name = "colDevicename";
            // 
            // colIp
            // 
            this.colIp.DataPropertyName = "ip";
            this.colIp.HeaderText = "IP정보";
            this.colIp.Name = "colIp";
            // 
            // statusBar1
            // 
            this.statusBar1.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.statusBar1.Location = new System.Drawing.Point(0, 273);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.ShowPanels = false;
            this.statusBar1.Size = new System.Drawing.Size(646, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "statusBar1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Eventvm";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventvmTableAdapter
            // 
            this.eventvmTableAdapter.ClearBeforeFill = true;
            // 
            // MEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 317);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MEvent";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
            this.Text = "알람이벤트";
            this.Load += new System.EventHandler(this.DataBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataGridView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.DataGridView dataGridView1;
        private Web.StatusBar statusBar1;
        private Web.DataGridViewTextBoxColumn colEventvmid;
        private Web.DataGridViewTextBoxColumn colEvent_Text;
        private Web.DataGridViewTextBoxColumn colIp;
        private Web.DataGridViewTextBoxColumn colPath;
        private Web.DataGridViewTextBoxColumn colDevicename;
        private Web.DataGridViewTextBoxColumn colState;
        private Web.BindingSource bindingSource1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.EventvmTableAdapter eventvmTableAdapter;
        private Web.DataGridViewTextBoxColumn colWrite_Time;
    }
}