using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_HistorySystemChanges : Wisej.Web.UserControl
    {
        public View_HistorySystemChanges()
        {
            InitializeComponent();
        }

        private void View_HistorySystemChanges_Load(object sender, EventArgs e)
        {
            //dataSet1BindingSource.Filter = "[alarm]=0";
            //dataSet1BindingSource.Sort = "EventVMId DESC";
            reDraw();

        }
        internal void reDraw()
        {
            this.eventsyslogTableAdapter.Fill(this.dataSet1.Eventsyslog);
        }

        private void popTestButton_Click(object sender, EventArgs e)
        {
            reDraw();

        }
    }
}
