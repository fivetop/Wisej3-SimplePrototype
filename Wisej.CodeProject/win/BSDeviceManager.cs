using DataClass;
using System;
using Wisej.Web;

namespace Wisej.CodeProject.win
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
            MyDesktop myDesktop = (MyDesktop)Application.Desktop;
            if (myDesktop.isSignalR())
            {
                AlertBox.Show("서버에 전체 Scan을 요청 하였습니다. - 약 5분 정도 소요됩니다.");
                myDesktop.sendSigR(eSignalRMsgType.eScanAll); // dsp, dsp_chno
            }
            else
            {
                AlertBox.Show("취소되었습니다. - 서버 상태를 확인바랍니다.");
            }
        }

        internal void reLoad()
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);
        }
    }
}
