using System;
using Wisej.Web;

namespace Wisej.CodeProject.win
{
    public partial class BSDeviceManager : Wisej.Web.UserControl
    {
        public BSDeviceManager()
        {
            InitializeComponent();
        }

        private void BSDeviceManager_Load(object sender, EventArgs e)
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);

        }
    }
}
