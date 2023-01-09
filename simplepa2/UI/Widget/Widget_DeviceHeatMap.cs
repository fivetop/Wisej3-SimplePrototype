using simplepa2.UI.Components;
using System;
using Wisej.Web;

namespace simplepa2.UI.Widget
{
    public partial class Widget_DeviceHeatMap : Wisej.Web.UserControl
    {
        public Widget_DeviceHeatMap()
        {
            InitializeComponent();


            setupTestUI();
        }

        public void setupTestUI()
        {
            for(int i=0; i < 50; i++)
            {
                Comp_BBSDeckButton bts = new Comp_BBSDeckButton("Amp" + i, i);
                bts.Dock = DockStyle.None;
                fpn_heatMap.Controls.Add(bts);
            }
        }
    }
}
