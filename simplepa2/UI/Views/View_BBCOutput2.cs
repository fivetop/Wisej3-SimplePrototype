using DataClass;
using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;
using static simplepa2.DataSet1;


// 출력 관리
namespace simplepa2.UI.Views
{
    public partial class View_BBCOutput2 : Wisej.Web.UserControl
    {
        public View_BBCOutput2()
        {
            InitializeComponent();
        }

        #region // Init
        internal void reDraw()
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);
            disp_gridview();

            comp_Site1.dataSet = gweb.dBSqlite.EMServerWithWholeColLoad();
            comp_Site1.reDraw();
        }

        private void BSOutManager_Load(object sender, EventArgs e)
        {
            reDraw();
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
                t1[6].Control = b1;
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

            DeviceRow dataRow = (DeviceRow) (r1.DataBoundItem as DataRowView).Row;

            string str1 = dataRow.dsp_name;     // DSP name
            string str2 = dataRow.DeviceName;   // AMP name
            int i2 = dataRow.dsp_chno;          // DSP CH 17~31
            int i3 = dataRow.chspk;             // AMP ch 1 or 2

            if (str1 == "" || i2 == 0) return;

            AlertBox.Show("서버에 시스템 적용을 요청 하였습니다. - 약 5초 정도 소요됩니다.");
            gweb.mainFrame.sendSigR(eSignalRMsgType.eOutChMove, str2, str1, i2, i3, dataRow.EMNAME); // dsp, dsp_chno
        }

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedItem = sender as string;

            if (selectedItem == null) return;
            if (!selectedItem.Equals("전체"))
            {
                deviceBindingSource.Filter = ("EMNAME = '" + selectedItem + "'" + " AND device = 0");
            }
            else
            {
                deviceBindingSource.Filter = "device=0";
            }
            disp_gridview();
        }
        #endregion


        #region // not use

        #endregion

    }
}
