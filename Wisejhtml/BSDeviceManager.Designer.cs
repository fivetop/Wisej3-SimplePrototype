namespace Wisejhtml
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
            this.deviceBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataGridView3 = new Wisej.Web.DataGridView();
            this.colDeviceid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colChspk = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevice = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Column0 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colIp = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Name = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPath_1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Chno = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Vol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Vol_Em = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ptop = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.panel2 = new Wisej.Web.Panel();
            this.ptop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colDeviceid,
            this.colDevicename,
            this.colChspk,
            this.colDevice,
            this.Column0,
            this.colIp,
            this.colDsp_Name,
            this.colPath_1,
            this.colDsp_Chno,
            this.colDsp_Vol,
            this.colDsp_Vol_Em});
            this.dataGridView3.DataSource = this.deviceBindingSource;
            this.dataGridView3.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(910, 546);
            this.dataGridView3.TabIndex = 1;
            // 
            // colDeviceid
            // 
            this.colDeviceid.DataPropertyName = "DeviceId";
            this.colDeviceid.HeaderText = "No";
            this.colDeviceid.Name = "colDeviceid";
            this.colDeviceid.ReadOnly = true;
            this.colDeviceid.Width = 40;
            // 
            // colDevicename
            // 
            this.colDevicename.DataPropertyName = "DeviceName";
            this.colDevicename.HeaderText = "DeviceName";
            this.colDevicename.Name = "colDevicename";
            this.colDevicename.ReadOnly = true;
            this.colDevicename.Width = 150;
            // 
            // colChspk
            // 
            this.colChspk.DataPropertyName = "chspk";
            this.colChspk.HeaderText = "채널";
            this.colChspk.Name = "colChspk";
            this.colChspk.Width = 60;
            // 
            // colDevice
            // 
            this.colDevice.DataPropertyName = "device";
            this.colDevice.HeaderText = "device";
            this.colDevice.Name = "colDevice";
            this.colDevice.Visible = false;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "장치종류";
            this.Column0.Name = "Column0";
            // 
            // colIp
            // 
            this.colIp.DataPropertyName = "ip";
            this.colIp.HeaderText = "IP Address";
            this.colIp.Name = "colIp";
            this.colIp.ReadOnly = true;
            this.colIp.Width = 110;
            // 
            // colDsp_Name
            // 
            this.colDsp_Name.DataPropertyName = "dsp_name";
            this.colDsp_Name.HeaderText = "DSP";
            this.colDsp_Name.Name = "colDsp_Name";
            this.colDsp_Name.ReadOnly = true;
            this.colDsp_Name.Width = 120;
            // 
            // colPath_1
            // 
            this.colPath_1.DataPropertyName = "path";
            this.colPath_1.HeaderText = "위치";
            this.colPath_1.Name = "colPath_1";
            this.colPath_1.ReadOnly = true;
            this.colPath_1.Width = 180;
            // 
            // colDsp_Chno
            // 
            this.colDsp_Chno.DataPropertyName = "dsp_chno";
            this.colDsp_Chno.HeaderText = "DSP CH";
            this.colDsp_Chno.Name = "colDsp_Chno";
            this.colDsp_Chno.Visible = false;
            this.colDsp_Chno.Width = 60;
            // 
            // colDsp_Vol
            // 
            this.colDsp_Vol.DataPropertyName = "dsp_vol";
            this.colDsp_Vol.HeaderText = "볼륨";
            this.colDsp_Vol.Name = "colDsp_Vol";
            this.colDsp_Vol.Visible = false;
            this.colDsp_Vol.Width = 80;
            // 
            // colDsp_Vol_Em
            // 
            this.colDsp_Vol_Em.DataPropertyName = "dsp_vol_em";
            this.colDsp_Vol_Em.HeaderText = "볼륨(비상)";
            this.colDsp_Vol_Em.Name = "colDsp_Vol_Em";
            this.colDsp_Vol_Em.Visible = false;
            this.colDsp_Vol_Em.Width = 80;
            // 
            // ptop
            // 
            this.ptop.Controls.Add(this.button1);
            this.ptop.Dock = Wisej.Web.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(910, 70);
            this.ptop.TabIndex = 4;
            this.ptop.TabStop = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "장비 스캔 요청";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 546);
            this.panel2.TabIndex = 5;
            this.panel2.TabStop = true;
            // 
            // BSDeviceManager
            // 
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ptop);
            this.Name = "BSDeviceManager";
            this.Size = new System.Drawing.Size(910, 616);
            this.ptop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.BindingSource deviceBindingSource;
        private Wisej.Web.DataGridView dataGridView3;
        private Wisej.Web.DataGridViewTextBoxColumn colDeviceid;
        private Wisej.Web.DataGridViewTextBoxColumn colIp;
        private Wisej.Web.DataGridViewTextBoxColumn colDevicename;
        private Wisej.Web.DataGridViewTextBoxColumn colDsp_Name;
        private Wisej.Web.DataGridViewTextBoxColumn colDsp_Chno;
        private Wisej.Web.DataGridViewTextBoxColumn colDsp_Vol;
        private Wisej.Web.DataGridViewTextBoxColumn colDsp_Vol_Em;
        private Wisej.Web.DataGridViewTextBoxColumn colPath_1;
        private Wisej.Web.Panel ptop;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Button button1;
        private Wisej.Web.DataGridViewTextBoxColumn Column0;
        private Wisej.Web.DataGridViewTextBoxColumn colChspk;
        private Wisej.Web.DataGridViewTextBoxColumn colDevice;
    }
}
