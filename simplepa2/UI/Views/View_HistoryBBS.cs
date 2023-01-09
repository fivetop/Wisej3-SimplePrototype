using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_HistoryBBS : Wisej.Web.UserControl
    {
        public View_HistoryBBS()
        {
            InitializeComponent();
        }

        internal void reDraw()
        {
            this.eventbsTableAdapter.Fill(this.dataSet1.Eventbs);
        }

        private void View_HistoryBBS_Load(object sender, EventArgs e)
        {
            reDraw();

        }
    }
}
