using DataClass;
using System;
using System.IO;
using System.Text;
using Wisej.Web;

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
            this.bSTreeTableAdapter.Fill(this.dataSet1.BSTree);
        }

    }
}
