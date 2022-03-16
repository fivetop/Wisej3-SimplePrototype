
using System;
using Wisej.Web;

namespace WebPage1
{
    public partial class Page1 : Page
    {
        
        public Page1()
        {

            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Application.Session.MsgCount != null)
                numericUpDown1.Value = int.Parse(Application.Session.MsgCount);
        }
    }
}
