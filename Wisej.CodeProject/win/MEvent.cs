using System;
using Wisej.Web;
using System.IO;
using System.Drawing;
using System.Configuration;

namespace Wisej.CodeProject
{
	public partial class MEvent : Form
	{
		public MEvent()
		{
			InitializeComponent();
		}

		private void DataBinding_Load(object sender, EventArgs e)
		{
			this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
		}
    }
}
