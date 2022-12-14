using simplepa2.UI.Popups;
using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBSReservation : Wisej.Web.UserControl
    {
        private Form_BBSReservationAdd form_bbcReservationadd;

        public View_BBSReservation()
        {
            InitializeComponent();
        }

        private void View_BBSReservation_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
                    }

        private void label44_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // show the gage popup.
            if (this.form_bbcReservationadd == null)
            {
                this.form_bbcReservationadd = new Form_BBSReservationAdd();
                this.form_bbcReservationadd.ShowDialog();
            }
            else
            {
                this.form_bbcReservationadd.ShowDialog();
            }

        }
    }
}
