using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_HistoryFireSignal : Wisej.Web.UserControl
    {
        public View_HistoryFireSignal()
        {
            InitializeComponent();
        }

        internal void reDraw()
        {
            this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
        }

        private void View_HistoryFireSignal_Load(object sender, EventArgs e)
        {
            reDraw();
        }

        private void popTestButton_Click(object sender, EventArgs e)
        {
            reDraw();

        }
    }
}
