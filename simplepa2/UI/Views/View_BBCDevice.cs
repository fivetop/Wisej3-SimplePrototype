using DataClass;
using simplepa2.UI.Pages;
using simplepa2.UI.Popups;
using System;
using System.Data;
using System.IO;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBCDevice : Wisej.Web.UserControl
    {
        private Popup_BBCDeviceForm popup_bbcDeviceForm;

        public View_BBCDevice()
        {
            InitializeComponent();
        }

        #region // init

        private void BSDeviceManager_Load(object sender, EventArgs e)
        {
            reDraw();
            comp_Site1.dataSet = gweb.mainFrame.dBSqlite.EMServerWithWholeColLoad();
            comp_Site1.reDraw();
        }


        internal void reDraw()
        {
            this.deviceWithTypeTableAdapter1.Fill(this.dataSet11.DeviceWithType);            
            this.dg_deviceView.DataSource = dataSet11.DeviceWithType;
        }

        private void dataGridView3_DataUpdated(object sender, DataGridViewDataUpdatedEventArgs e)
        {
            foreach (var t1 in dg_deviceView.Rows)
            {
                dg_deviceView.BeginEdit(true);
                foreach (var r1 in dg_deviceView.Rows)
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
                dg_deviceView.EndEdit();
            }
        }
        #endregion

        #region // button 처리 

        private void button4_Click(object sender, EventArgs e)
        {
            // show the popup.
            if (this.popup_bbcDeviceForm == null)
                this.popup_bbcDeviceForm = new Popup_BBCDeviceForm()
                {
                    Alignment = Placement.BottomRight,
                    Height = this.Parent.Height
                };

            if (this.popup_bbcDeviceForm.Visible)
                this.popup_bbcDeviceForm.Close();
            else
            {
                this.popup_bbcDeviceForm.Height = this.Parent.Parent.Height;
                this.popup_bbcDeviceForm.ShowPopup(this.Parent);
            }
        }

        private void bt_scanStart_Click(object sender, EventArgs e)
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

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {            
            string selectedItem = sender as string; 

            if (!selectedItem.Equals("전체"))
                this.dg_deviceView.DataSource = dataSet11.DeviceWithType.Select("EMNAME = '" + selectedItem + "'");
            else
                this.dg_deviceView.DataSource = dataSet11.DeviceWithType;

        }

        private void bt_reloading_Click(object sender, EventArgs e)
        {
            reDraw();
        }
        #endregion

/*
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
*/

    }
}
