using System;
using Wisej.Web;

namespace Wisej.FullCalendar
{
    public partial class Desktop1 : Desktop
    {
        public Desktop1()
        {
            InitializeComponent();
        }

        private void Desktop1_Load(object sender, EventArgs e)
        {
            new MainPage().Show();
        }
    }
}
