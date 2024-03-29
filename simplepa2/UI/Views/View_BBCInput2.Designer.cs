﻿namespace simplepa2.UI.Views
{
    partial class View_BBCInput2
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
            this.panel1 = new Wisej.Web.Panel();
            this.dataGridView3 = new Wisej.Web.DataGridView();
            this.colDevicechnnelid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEMNAME = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colChname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDantemodelname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDeviceinch = new Wisej.Web.DataGridViewComboBoxColumn();
            this.chkColumn0 = new Wisej.Web.DataGridViewButtonColumn();
            this.colDeviceid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.deviceChannelBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.panel2 = new Wisej.Web.Panel();
            this.comp_Site1 = new simplepa2.UI.Components.Comp_Site();
            this.ptop = new Wisej.Web.Panel();
            this.deviceTableAdapter1 = new simplepa2.DataSet1TableAdapters.DeviceTableAdapter();
            this.deviceChannelWithDeviceTableAdapter1 = new simplepa2.DataSet1TableAdapters.DeviceChannelWithDeviceTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceChannelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.ptop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 459);
            this.panel1.TabIndex = 5;
            this.panel1.TabStop = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowSortingDataSource = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colDevicechnnelid,
            this.colEMNAME,
            this.colDevicename,
            this.colChname,
            this.colDantemodelname,
            this.colDeviceinch,
            this.chkColumn0,
            this.colDeviceid});
            this.dataGridView3.DataSource = this.deviceChannelBindingSource;
            this.dataGridView3.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 52);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(758, 407);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.DataUpdated += new Wisej.Web.DataGridViewDataUpdatedEventHandler(this.dataGridView3_DataUpdated);
            // 
            // colDevicechnnelid
            // 
            this.colDevicechnnelid.DataPropertyName = "DeviceChnnelId";
            this.colDevicechnnelid.HeaderText = "No";
            this.colDevicechnnelid.Name = "colDevicechnnelid";
            this.colDevicechnnelid.ReadOnly = true;
            this.colDevicechnnelid.Width = 60;
            // 
            // colEMNAME
            // 
            this.colEMNAME.DataPropertyName = "EMNAME";
            this.colEMNAME.HeaderText = "지역";
            this.colEMNAME.Name = "colEMNAME";
            this.colEMNAME.Width = 120;
            // 
            // colDevicename
            // 
            this.colDevicename.DataPropertyName = "DeviceName";
            this.colDevicename.HeaderText = "DSP";
            this.colDevicename.Name = "colDevicename";
            this.colDevicename.Width = 120;
            // 
            // colChname
            // 
            this.colChname.DataPropertyName = "chname";
            this.colChname.HeaderText = "DSP CH";
            this.colChname.Name = "colChname";
            this.colChname.Width = 80;
            // 
            // colDantemodelname
            // 
            this.colDantemodelname.DataPropertyName = "DanteModelName";
            this.colDantemodelname.HeaderText = "입력장치";
            this.colDantemodelname.Name = "colDantemodelname";
            this.colDantemodelname.Width = 150;
            // 
            // colDeviceinch
            // 
            this.colDeviceinch.DataPropertyName = "deviceinch";
            this.colDeviceinch.HeaderText = "채널";
            this.colDeviceinch.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.colDeviceinch.Name = "colDeviceinch";
            // 
            // chkColumn0
            // 
            this.chkColumn0.HeaderText = "적용";
            this.chkColumn0.Name = "chkColumn0";
            this.chkColumn0.Text = "적용";
            this.chkColumn0.Width = 120;
            // 
            // colDeviceid
            // 
            this.colDeviceid.DataPropertyName = "DeviceId";
            this.colDeviceid.HeaderText = "DeviceId";
            this.colDeviceid.Name = "colDeviceid";
            this.colDeviceid.Visible = false;
            // 
            // deviceChannelBindingSource
            // 
            this.deviceChannelBindingSource.DataMember = "DeviceChannelWithDevice";
            this.deviceChannelBindingSource.DataSource = this.dataSet1;
            this.deviceChannelBindingSource.Filter = "";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comp_Site1);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.ShowCloseButton = false;
            this.panel2.Size = new System.Drawing.Size(758, 52);
            this.panel2.TabIndex = 67;
            // 
            // comp_Site1
            // 
            this.comp_Site1.Name = "comp_Site1";
            this.comp_Site1.TabIndex = 96;
            this.comp_Site1.SelectedValueChanged += new System.EventHandler(this.comp_Site1_SelectedValueChanged);
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.White;
            this.ptop.Controls.Add(this.panel1);
            this.ptop.Dock = Wisej.Web.DockStyle.Fill;
            this.ptop.Location = new System.Drawing.Point(20, 20);
            this.ptop.Name = "ptop";
            this.ptop.Padding = new Wisej.Web.Padding(20);
            this.ptop.Size = new System.Drawing.Size(798, 499);
            this.ptop.TabIndex = 6;
            this.ptop.TabStop = true;
            // 
            // deviceTableAdapter1
            // 
            this.deviceTableAdapter1.ClearBeforeFill = true;
            // 
            // deviceChannelWithDeviceTableAdapter1
            // 
            this.deviceChannelWithDeviceTableAdapter1.ClearBeforeFill = true;
            // 
            // View_BBCInput2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.ptop);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCInput2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(838, 539);
            this.Load += new System.EventHandler(this.BSInManager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceChannelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ptop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.DataGridView dataGridView3;
        private Wisej.Web.DataGridViewButtonColumn chkColumn0;
        private Wisej.Web.Panel ptop;
        private Wisej.Web.DataGridViewTextBoxColumn colDevicechnnelid;
        private Wisej.Web.DataGridViewTextBoxColumn colChname;
        private DataSet1 dataSet1;
        private Wisej.Web.DataGridViewTextBoxColumn colDeviceid;
        private DataSet1TableAdapters.DeviceTableAdapter deviceTableAdapter1;
        private Wisej.Web.DataGridViewComboBoxColumn colDeviceinch;
        private Wisej.Web.Panel panel2;
        private Components.Comp_Site comp_Site1;
        private Wisej.Web.BindingSource deviceChannelBindingSource;
        private DataSet1TableAdapters.DeviceChannelWithDeviceTableAdapter deviceChannelWithDeviceTableAdapter1;
        private Wisej.Web.DataGridViewTextBoxColumn colEMNAME;
        private Wisej.Web.DataGridViewTextBoxColumn colDevicename;
        private Wisej.Web.DataGridViewTextBoxColumn colDantemodelname;
    }
}
