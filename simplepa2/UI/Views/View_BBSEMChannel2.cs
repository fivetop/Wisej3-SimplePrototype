using DataClass;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Views
{
    public partial class View_BBSEMChannel2 : Wisej.Web.UserControl
    {

        public View_BBSEMChannel2()
        {
            InitializeComponent();
        }

        private void BSAsset_Load(object sender, EventArgs e)
        {
            reDraw();
        }

        internal void reDraw()
        {
            try
            {
                this.bSTreeTableAdapter.Fill(this.dataSet1.BSTree);
            }
            catch (Exception e1)
            { 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
//            this.bSTreeTableAdapter.Fill(this.dataSet1.BSTree);
//            this.bsTreeCTableAdapter.Fill(this.dataSet1.BSTreeC);

            var t1 = this.dataGridView1.CurrentRow.DataBoundItem;
            var t2 = (BSTreeRow)((System.Data.DataRowView)t1).Row;

            if (t2 == null)
                return;
            gweb.mainFrame.dBSqlite.BSTreeUpdate(t2.BSTreeId, "대기");
            gweb.mainFrame.dBSqlite.BSTreeCRemove(t2.BSTreeId);

            this.bSTreeTableAdapter.Fill(this.dataSet1.BSTree);
            this.bsTreeCTableAdapter.Fill(this.dataSet1.BSTreeC);
        }
    }
}
