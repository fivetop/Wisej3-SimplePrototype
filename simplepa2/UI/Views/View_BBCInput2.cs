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

        #region // Init

        internal void reDraw()
        {
            //throw new NotImplementedException();
            BSInManager_Load(null, null);
        }

        private void BSInManager_Load(object sender, EventArgs e)
        {
            this.deviceChannelWithDeviceTableAdapter1.Fill(this.dataSet1.DeviceChannelWithDevice);
            this.deviceTableAdapter1.Fill(dataSet1.Device);

            comp_Site1.dataSet = gweb.mainFrame.dBSqlite.EMServerWithWholeColLoad();
            comp_Site1.reDraw();

            disp_gridview();
        }

        private void disp_gridview()
        {
            foreach (var t1 in dataGridView3.Rows)
            {
                Button b1 = new Button();
                b1.Text = "즉시적용";
                b1.Dock = DockStyle.Fill;
                b1.Click += B1_Click;
                b1.ToolTipText = t1.Index.ToString();
                t1["chkColumn0"].Control = b1;
            }
        }
        #endregion


        #region // button 

        private void B1_Click(object sender, EventArgs e)
        {
            Button t1 = (Button)sender;
            string s1 = t1.ToolTipText;
            int i1 = Int16.Parse(s1);

            DataGridViewRow r1 = dataGridView3.Rows[i1];

            DeviceChannelWithDeviceRow dataRow = (DeviceChannelWithDeviceRow)(r1.DataBoundItem as DataRowView).Row;

            this.deviceTableAdapter1.Fill(dataSet1.Device);
            var t4 = dataSet1.Device.FindByDeviceId(dataRow.DeviceId);

            if (dataRow.devicein == "")
                dataRow.devicein = dataRow.DanteModelName;
            string str1 = t4.ip;
            string str2 = dataRow.devicein;
            int i2 = (int)dataRow.deviceinch-1;
            int i3 = (int)t4.chCount;
            if (str1 == "" || str2 == "")
                return;
            AlertBox.Show("서버에 시스템 적용을 요청 하였습니다. - 약 1분 정도 소요됩니다.");

            gweb.mainFrame.sendSigR(eSignalRMsgType.eInChMove, str2, str1, i2, i3, t4.EMNAME); // dsp, dsp_chno
            this.deviceChannelBindingSource.EndEdit();
            //this.deviceChannelTableAdapter.Update(this.dataSet1.DeviceChannel);
        }

        private void dataGridView3_DataUpdated(object sender, DataGridViewDataUpdatedEventArgs e)
        {
        }
        #endregion

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedItem = sender as string;

            if (selectedItem == null)
                return;
            if (!selectedItem.Equals("전체"))
            {
                deviceChannelBindingSource.Filter = "EMNAME = '" + selectedItem + "'";
                this.dataGridView3.DataSource = deviceChannelBindingSource;
                disp_gridview();
            }
            else
            {
                deviceChannelBindingSource.Filter = "";
                this.dataGridView3.DataSource = deviceChannelBindingSource;
            }

            disp_gridview();
        }
    }
}
