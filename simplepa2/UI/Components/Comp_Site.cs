using System;
using System.Windows;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Components
{
    public partial class Comp_Site : Wisej.Web.UserControl
    {
        public Comp_Site()
        {
            InitializeComponent();
        }

        public void reDraw()
        {
            this.cb_SiteName.DataSource = null;
        }





    }
}
