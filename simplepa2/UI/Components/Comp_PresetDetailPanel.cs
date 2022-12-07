using simplepa2.UI.Views;
using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_PresetDetailPanel : Wisej.Web.UserControl
    {
        private Preset_DataList dataSet;
        private bool cardSelect;
        public Comp_PresetDetailPanel()
        {
            InitializeComponent();
        }

        public Comp_PresetDetailPanel(Preset_DataList dSet)
        {
            InitializeComponent();
            this.dataSet = dSet;
        }

        public void setUserInterfaceCard(Preset_DataList dataSet)
        {

        }
    }
}
