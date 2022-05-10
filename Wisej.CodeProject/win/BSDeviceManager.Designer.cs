namespace Wisej.CodeProject.win
{
    partial class BSDeviceManager
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
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.deviceBindingSource = new Wisej.Web.BindingSource(this.components);
            this.deviceTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.DeviceTableAdapter();
            this.dataGridView3 = new Wisej.Web.DataGridView();
            this.colDeviceid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colIp = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Name = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Chno = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Vol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Vol_Em = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPath_1 = new Wisej.Web.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataMember = "Device";
            this.deviceBindingSource.DataSource = this.dataSet1;
            // 
            // deviceTableAdapter
            // 
            this.deviceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colDeviceid,
            this.colDevicename,
            this.colIp,
            this.colDsp_Name,
            this.colDsp_Chno,
            this.colDsp_Vol,
            this.colDsp_Vol_Em,
            this.colPath_1});
            this.dataGridView3.DataSource = this.deviceBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(18, 27);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(871, 279);
            this.dataGridView3.TabIndex = 1;
            // 
            // colDeviceid
            // 
            this.colDeviceid.DataPropertyName = "DeviceId";
            this.colDeviceid.HeaderText = "No";
            this.colDeviceid.Name = "colDeviceid";
            this.colDeviceid.Width = 40;
            // 
            // colIp
            // 
            this.colIp.DataPropertyName = "ip";
            this.colIp.HeaderText = "IP Address";
            this.colIp.Name = "colIp";
            // 
            // colDevicename
            // 
            this.colDevicename.DataPropertyName = "DeviceName";
            this.colDevicename.HeaderText = "DeviceName";
            this.colDevicename.Name = "colDevicename";
            this.colDevicename.Width = 140;
            // 
            // colDsp_Name
            // 
            this.colDsp_Name.DataPropertyName = "dsp_name";
            this.colDsp_Name.HeaderText = "DSP";
            this.colDsp_Name.Name = "colDsp_Name";
            this.colDsp_Name.Width = 120;
            // 
            // colDsp_Chno
            // 
            this.colDsp_Chno.DataPropertyName = "dsp_chno";
            this.colDsp_Chno.HeaderText = "DSP CH";
            this.colDsp_Chno.Name = "colDsp_Chno";
            this.colDsp_Chno.Width = 60;
            // 
            // colDsp_Vol
            // 
            this.colDsp_Vol.DataPropertyName = "dsp_vol";
            this.colDsp_Vol.HeaderText = "볼륨";
            this.colDsp_Vol.Name = "colDsp_Vol";
            this.colDsp_Vol.Width = 80;
            // 
            // colDsp_Vol_Em
            // 
            this.colDsp_Vol_Em.DataPropertyName = "dsp_vol_em";
            this.colDsp_Vol_Em.HeaderText = "볼륨(비상)";
            this.colDsp_Vol_Em.Name = "colDsp_Vol_Em";
            this.colDsp_Vol_Em.Width = 80;
            // 
            // colPath_1
            // 
            this.colPath_1.DataPropertyName = "path";
            this.colPath_1.HeaderText = "위치";
            this.colPath_1.Name = "colPath_1";
            this.colPath_1.Width = 180;
            // 
            // BSDeviceManager
            // 
            this.Controls.Add(this.dataGridView3);
            this.Name = "BSDeviceManager";
            this.Size = new System.Drawing.Size(910, 616);
            this.Load += new System.EventHandler(this.BSDeviceManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private Web.BindingSource deviceBindingSource;
        private DataSet1TableAdapters.DeviceTableAdapter deviceTableAdapter;
        private Web.DataGridView dataGridView3;
        private Web.DataGridViewTextBoxColumn colDeviceid;
        private Web.DataGridViewTextBoxColumn colIp;
        private Web.DataGridViewTextBoxColumn colDevicename;
        private Web.DataGridViewTextBoxColumn colDsp_Name;
        private Web.DataGridViewTextBoxColumn colDsp_Chno;
        private Web.DataGridViewTextBoxColumn colDsp_Vol;
        private Web.DataGridViewTextBoxColumn colDsp_Vol_Em;
        private Web.DataGridViewTextBoxColumn colPath_1;
    }
}
