using DataClass;
using simplepa2.UI.Popups;
using System;
using System.IO;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBCDevice2 : Wisej.Web.UserControl
    {
        private Popup_BBCDeviceForm pop_BBCDeviceForm;

        public View_BBCDevice2()
        {
            InitializeComponent();
        }

        private void BSDeviceManager_Load(object sender, EventArgs e)
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);
        }

        private void popTestButton_Click(object sender, EventArgs e)
        {
            // show the gage popup.
            if (this.pop_BBCDeviceForm == null)
                this.pop_BBCDeviceForm = new Popup_BBCDeviceForm()
                {
                    Alignment = Placement.BottomRight
                };

            if (this.pop_BBCDeviceForm.Visible)
                this.pop_BBCDeviceForm.Close();
            else
                this.pop_BBCDeviceForm.ShowPopup(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gweb.mainFrame.isSignalR())
            {
                //AlertBox.Show("서버에 전체 Scan을 요청 하였습니다. - 약 5분 정도 소요됩니다.");
                gweb.mainFrame.sendSigR(eSignalRMsgType.eScanAll); // dsp, dsp_chno
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
                    var t2 = r1.Cells[4].Value;
                    if (t2.ToString() == "0")
                        r1.Cells[5].Value = "Amp";
                    else if (t2.ToString() == "2")
                        r1.Cells[5].Value = "DSP";
                    else if (t2.ToString() == "3")
                        r1.Cells[5].Value = "AVIO";
                    else if (t2.ToString() == "9")
                        r1.Cells[5].Value = "Computer";
                }
                dataGridView3.EndEdit();
            }
        }
    }
}
