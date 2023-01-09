using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_HistoryOutMsgs : Wisej.Web.UserControl
    {
        public View_HistoryOutMsgs()
        {
            InitializeComponent();
        }

        internal void reDraw()
        {
            this.eventpresetTableAdapter.Fill(this.dataSet1.Eventpreset);
        }

        private void View_HistoryOutMsgs_Load(object sender, EventArgs e)
        {
            reDraw();

        }
    }
}
