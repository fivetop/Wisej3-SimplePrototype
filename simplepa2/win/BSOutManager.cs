using DataClass;
using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.win
{
    public partial class BSOutManager : Wisej.Web.UserControl
    {
        public BSOutManager()
        {
            InitializeComponent();
        }

        private void BSOutManager_Load(object sender, EventArgs e)
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);

            foreach (var t1 in dataGridView3.Rows)
            {
                Button b1 = new Button();
                b1.Text = "즉시적용";
                b1.Dock = DockStyle.Fill;
                b1.Click += B1_Click;
                b1.ToolTipText = t1.Index.ToString();
                t1[6].Control = b1;
            }

            var dsp = this.dataSet1.Device.Where(p=>p.device == 2);

            foreach (var t1 in dsp)
            {
                if(this.colDsp_Name.Items.Contains(t1.DeviceName) == false)
                    this.colDsp_Name.Items.Add(t1.DeviceName);
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Button t1 = (Button)sender;
            string s1 = t1.ToolTipText;
            int i1 = Int16.Parse(s1);

            DataGridViewRow r1 = dataGridView3.Rows[i1];

            DeviceRow dataRow = (DeviceRow) (r1.DataBoundItem as DataRowView).Row;

            string str1 = dataRow.dsp_name;
            string str2 = dataRow.DeviceName;
            int i2 = dataRow.dsp_chno;
            int i3 = dataRow.chspk;


            if (str1 == "" || i2 == 0)
                return;

            AlertBox.Show("서버에 시스템 적용을 요청 하였습니다. - 약 5분 정도 소요됩니다.");

            Simplepa3 myDesktop = (Simplepa3)Application.MainPage;
            myDesktop.sendSigR(eSignalRMsgType.eOutChMove, str2, str1, i2, i3); // dsp, dsp_chno
        }

        internal void reDraw()
        {
            BSOutManager_Load  (null, null);
        }
    }
}
