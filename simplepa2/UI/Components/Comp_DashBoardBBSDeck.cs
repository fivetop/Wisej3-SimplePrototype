using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_DashBoardBBSDeck : Wisej.Web.UserControl
    {
        public Comp_DashBoardBBSDeck()
        {
            InitializeComponent();

            setupUI();
        }

        public void setupUI()
        {

            // for example running
            for(int i = 8; i > 0; i-- )
            {
                Comp_BBSDeckButton bt = new Comp_BBSDeckButton("Ch" + i, i);

                pn_bbsButtonList.Controls.Add(bt);
            }
        }
    }
}
