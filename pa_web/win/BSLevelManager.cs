using DataClass;
using System;
using Wisej.Web;

namespace pa_web.win
{
    public partial class BSLevelManager : Wisej.Web.UserControl
    {
        public BSLevelManager()
        {
            InitializeComponent();
        }

        private void BSLevelManager_Load(object sender, EventArgs e)
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);

        }

        // 일반전체 데이터변경
        private void button1_Click(object sender, EventArgs e)
        {
            int t1 = comboBox1.SelectedIndex + 1;
            /*
            dataGridView1.BeginEdit(true);
            foreach(var r1 in dataGridView1.Rows)
            {
                r1.Cells[5].Value = t1;
            }
            dataGridView1.EndEdit();
            */

            foreach (var r1 in this.dataSet1.Device)
            {
                r1.dsp_vol = t1;
            }

        }

        // 비상전체 데이터변경
        private void button2_Click(object sender, EventArgs e)
        {
            int t1 = comboBox2.SelectedIndex + 1;

            foreach (var r1 in this.dataSet1.Device)
            {
                r1.dsp_vol_em = t1;
            }
        }

        // 시스템 적용 
        private void button3_Click(object sender, EventArgs e)
        {
            this.deviceTableAdapter.Update(this.dataSet1.Device);
            this.dataSet1.AcceptChanges();
            AlertBox.Show("서버에 시스템 적용을 요청 하였습니다. - 약 5분 정도 소요됩니다.");

            MyDesktop myDesktop = (MyDesktop)Application.Desktop;
            myDesktop.sendSigR(eSignalRMsgType.eVolume);
        }

        internal void reDraw()
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);
        }
    }
}
