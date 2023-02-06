using DataClass;
using System;
using Wisej.Web;


// 볼륨조정 처리 
namespace simplepa2.UI.Views
{
    public partial class View_BBCMusic2 : Wisej.Web.UserControl
    {
        public View_BBCMusic2()
        {
            InitializeComponent();
        }

        internal void reDraw()
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);
        }


        private void MainFrame_FocusEvent(object sender, EventArgs e)
        {
            if(sender == this)
                reDraw();
        }


        private void BSLevelManager_Load(object sender, EventArgs e)
        {
            gweb.mainFrame.FocusEvent += MainFrame_FocusEvent;
            reDraw();
        }

        // 일반전체 데이터변경
        private void button1_Click(object sender, EventArgs e)
        {
            int t1 = comboBox1.SelectedIndex + 1;
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

            gweb.mainFrame.sendSigR(eSignalRMsgType.eVolume);
        }

        /*
        dataGridView1.BeginEdit(true);
        foreach(var r1 in dataGridView1.Rows)
        {
            r1.Cells[5].Value = t1;
        }
        dataGridView1.EndEdit();
        */


    }
}
