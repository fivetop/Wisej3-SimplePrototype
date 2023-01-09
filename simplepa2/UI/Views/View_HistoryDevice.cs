using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_HistoryDevice : Wisej.Web.UserControl
    {
        public View_HistoryDevice()
        {
            InitializeComponent();
        }

        internal void reDraw()
        {
            this.eventdeviceTableAdapter.Fill(this.dataSet1.Eventdevice);
        }

        private void View_HistoryDevice_Load(object sender, EventArgs e)
        {
            reDraw();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            reDraw();

        }
    }
}
