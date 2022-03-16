using System;
using Wisej.Web;

namespace Wisej.CodeProject
{
    public partial class MSet : Form
    {
        public MSet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_PanelCollapsed(object sender, EventArgs e)
        {

        }

        private void MSet_Load(object sender, EventArgs e)
        {
            Application.ApplicationExit += Application_ApplicationExit;
            LoadData();
        }

        private void LoadData()
        {
            this.simplepaTableAdapter.Fill(this.dataSet1.Simplepa);
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            // delete the session-cloned db file.
            this.simplepaTableAdapter.Connection.Close();
            this.simplepaTableAdapter.Connection.Dispose();
            this.simplepaTableAdapter.Adapter.Dispose();
        }
    }
}
