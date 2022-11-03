using DataClass;
using System;
using System.IO;
using Wisej.Web;

namespace simplepa2.win
{
    public partial class BSDeviceManager : Wisej.Web.UserControl
    {
        public BSDeviceManager()
        {
            InitializeComponent();
        }

        private void BSDeviceManager_Load(object sender, EventArgs e)
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simple myDesktop = (Simple)Application.MainPage;
            if (myDesktop.isSignalR())
            {
                //AlertBox.Show("서버에 전체 Scan을 요청 하였습니다. - 약 5분 정도 소요됩니다.");
                myDesktop.sendSigR(eSignalRMsgType.eScanAll); // dsp, dsp_chno
            }
            else
            {
                AlertBox.Show("취소되었습니다. - 서버 상태를 확인바랍니다.");
            }
        }

        internal void reDraw()
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);
        }

        private void dataGridView3_DataUpdated(object sender, DataGridViewDataUpdatedEventArgs e)
        {
            foreach (var t1 in dataGridView3.Rows)
            {
                dataGridView3.BeginEdit(true);
                foreach (var r1 in dataGridView3.Rows)
                {
                    var t2 = r1.Cells[3].Value;
                    if (t2.ToString() == "0")
                        r1.Cells[4].Value = "Amp";
                    else if (t2.ToString() == "2")
                        r1.Cells[4].Value = "DSP";
                    else if (t2.ToString() == "3")
                        r1.Cells[4].Value = "AVIO";
                    else if (t2.ToString() == "9")
                        r1.Cells[4].Value = "Computer";
                }
                dataGridView3.EndEdit();
            }
        }
    }
}
