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
			Application.ApplicationExit += Application_ApplicationExit;

			LoadData();
		}

		private void Application_ApplicationExit(object sender, EventArgs e)
		{
			// delete the session-cloned db file.
			this.eventvmTableAdapter.Connection.Close();
			this.eventvmTableAdapter.Connection.Dispose();
			this.eventvmTableAdapter.Adapter.Dispose();
		}

		private void SetStatusText(string text)
		{
			this.statusBar1.Text = text;
		}

		private void LoadData()
		{
			this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
			SetStatusText("Loaded " + this.bindingSource1.Count + " records.");
		}


    }
}
