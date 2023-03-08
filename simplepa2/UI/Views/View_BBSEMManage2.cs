using DataClass;
using System;
using System.IO;
using System.Text;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Views
{
    public partial class View_BBSEMManage2 : Wisej.Web.UserControl
    {

        public View_BBSEMManage2()
        {
            InitializeComponent();
        }

        private void BSAsset_Load(object sender, EventArgs e)
        {
            reDraw();
        }

        internal void reDraw()
        {
            this.bSTreeTableAdapter.Fill(this.dataSet1.BSTree);
            this.eMServerTableAdapter.Fill(this.dataSet1.EMServer);
        }

        // EM 상태 요청 처리 
        private void button2_Click(object sender, EventArgs e)
        {
            if (gweb.mainFrame.isSignalR())
            {
                gweb.mainFrame.sendSigR(eSignalRMsgType.eScanEM); // dsp, dsp_chno
            }
            else
            {
                AlertBox.Show("취소되었습니다. - 서버 상태를 확인바랍니다.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //            this.bSTreeTableAdapter.Fill(this.dataSet1.BSTree);
            //            this.bsTreeCTableAdapter.Fill(this.dataSet1.BSTreeC);

            var t1 = this.dataGridView2.CurrentRow.DataBoundItem;
            var t2 = (BSTreeRow)((System.Data.DataRowView)t1).Row;

            if (t2 == null)
                return;
            gweb.dBSqlite.BSTreeUpdate(t2.BSTreeId, "대기");
            gweb.dBSqlite.BSTreeCRemove(t2.BSTreeId);

            this.bSTreeTableAdapter.Fill(this.dataSet1.BSTree);
            this.bsTreeCTableAdapter.Fill(this.dataSet1.BSTreeC);

        }
    }
}
