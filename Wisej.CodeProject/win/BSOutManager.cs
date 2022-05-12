using System;
using Wisej.Web;

namespace Wisej.CodeProject.win
{
    public partial class BSOutManager : Wisej.Web.UserControl
    {
        public BSOutManager()
        {
            InitializeComponent();
        }

        private void BSOutManager_Load(object sender, EventArgs e)
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);
        }
    }
}
