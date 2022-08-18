﻿using DataClass;
using System;
using System.Data;
using Wisej.Web;
using static Wisej.CodeProject.DataSet1;

namespace Wisej.CodeProject.win
{
    public partial class BSInManager : Wisej.Web.UserControl
    {
        public BSInManager()
        {
            InitializeComponent();
        }

        internal void reDraw()
        {
            //throw new NotImplementedException();
            BSInManager_Load(null, null);
        }

        private void BSInManager_Load(object sender, EventArgs e)
        {
            this.deviceChannelTableAdapter.Fill(this.dataSet1.DeviceChannel);
            this.deviceTableAdapter1.Fill(dataSet1.Device);

            foreach (var t1 in dataGridView3.Rows)
            {
                Button b1 = new Button();
                b1.Text = "즉시적용";
                b1.Dock = DockStyle.Fill;
                b1.Click += B1_Click;
                b1.ToolTipText = t1.Index.ToString();
                t1[5].Control = b1;
            }

            var dsp = this.dataSet1.Device.Where(p => p.device == 9);

            foreach (var t1 in dsp)
            {
                if (this.colDevicein.Items.Contains(t1.DeviceName) == false)
                    this.colDevicein.Items.Add(t1.DeviceName);
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Button t1 = (Button)sender;
            string s1 = t1.ToolTipText;
            int i1 = Int16.Parse(s1);

            DataGridViewRow r1 = dataGridView3.Rows[i1];

            DeviceChannelRow dataRow = (DeviceChannelRow)(r1.DataBoundItem as DataRowView).Row;


            this.deviceTableAdapter1.Fill(dataSet1.Device);
            var t4 = dataSet1.Device.FindByDeviceId(dataRow.DeviceId);

            string str1 = t4.ip;
            string str2 = dataRow.devicein;
            int i2 = (int)dataRow.deviceinch-1;
            int i3 = (int)t4.chCount;
            if (str1 == "" || str2 == "")
                return;
            AlertBox.Show("서버에 시스템 적용을 요청 하였습니다. - 약 1분 정도 소요됩니다.");

            MyDesktop myDesktop = (MyDesktop)Application.Desktop;
            myDesktop.sendSigR(eSignalRMsgType.eInChMove, str2, str1, i2, i3); // dsp, dsp_chno
            this.deviceChannelBindingSource.EndEdit();
            this.deviceChannelTableAdapter.Update(this.dataSet1.DeviceChannel);
        }

        private void dataGridView3_DataUpdated(object sender, DataGridViewDataUpdatedEventArgs e)
        {
            this.deviceTableAdapter1.Fill(dataSet1.Device);

            foreach (var t1 in dataGridView3.Rows)
            {
                var s1 = t1.Cells["Column1"].Value;
                if (s1 != null)
                    continue;
                var t3 = t1.DataBoundItem;
                DeviceChannelRow t2 = (DeviceChannelRow)((System.Data.DataRowView)t3).Row;
                var t4 = dataSet1.Device.FindByDeviceId (t2.DeviceId);
                t1.Cells["Column1"].Value = t4.DeviceName;
            }
        }
    }
}
