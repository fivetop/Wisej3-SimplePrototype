using DataClass;
using System;
using System.Data;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

// 입력 채널 관리
namespace simplepa2.UI.Views
{
    public partial class View_BBCInput2 : Wisej.Web.UserControl
    {
        public View_BBCInput2()
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
                t1["Column0"].Control = b1;
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

            gweb.mainFrame.sendSigR(eSignalRMsgType.eInChMove, str2, str1, i2, i3); // dsp, dsp_chno
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
                if (t4 == null) continue;
                t1.Cells["Column2"].Value = t4.EMNAME;
                t1.Cells["Column1"].Value = t4.DeviceName;

                var t5 = dataSet1.Device.FirstOrDefault(p=>p.ip_dspctrl == t4.ip_dspctrl && p.device == 9); 
                if (t5 == null) continue;
                t1.Cells["colDevicein"].Value = t5.DeviceName;
                if(int.Parse(t2.chno) < 25)
                    t1.Cells["colDeviceinch"].Value = (int.Parse(t2.chno) -16).ToString();
            }
        }
    }
}
