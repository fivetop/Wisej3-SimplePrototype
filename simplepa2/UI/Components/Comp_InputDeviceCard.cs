using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_InputDeviceCard : Wisej.Web.UserControl
    {
        private bool cardSelected; 
        public Comp_InputDeviceCard()
        {
            cardSelected = false;
            InitializeComponent();
        }

        private void Comp_InputDeviceCard_Click(object sender, EventArgs e)
        {
            cardSelected = !cardSelected;

            if (cardSelected)
            {
                this.BackColor = System.Drawing.Color.FromName("@tabSelected");
            }
            else
            {
                this.BackColor = System.Drawing.Color.FromName("@tabFace");
            }


            }
    }
}
