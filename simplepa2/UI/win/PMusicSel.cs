using System;
using Wisej.Web;
using System.IO;
using System.Drawing;
using System.Configuration;
using static simplepa2.DataSet1;
using System.Collections.Generic;

namespace simplepa2
{
	public partial class PMusicSel : Form
	{
		public List<MusicsRow> SelMusic { get; set; } = new List<MusicsRow>();


		public PMusicSel()
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
			this.musicsTableAdapter.Connection.Close();
			this.musicsTableAdapter.Connection.Dispose();
			this.musicsTableAdapter.Adapter.Dispose();
		}

		public Wisej.Web.BindingSource bind { get; set;}  = new BindingSource();

		private void LoadData()
		{
			this.musicsTableAdapter.Fill(this.dataSet1.Musics);
			bind.DataSource = SelMusic;
			this.dataGridView2.DataSource = bind;
		}

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
			var t1 = this.dataGridView1.CurrentRow.DataBoundItem;
			SelMusic.Add((MusicsRow)((System.Data.DataRowView)t1).Row);
			this.dataGridView2.DataSource = null;
			this.dataGridView2.DataSource = bind;
		}

		private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
			if (SelMusic.Count == 0)
				return;
			try
			{
				var t1 = this.dataGridView2.CurrentRow.DataBoundItem;
				SelMusic.Remove((MusicsRow)t1);
				//this.dataGridView2.DataSource = null;
				//this.dataGridView2.DataSource = bind;
				dataGridView2.Refresh();
			}
			catch (Exception e1)
			{ 
			}
		}

		public event EventHandler EventMusic;

        private void button1_Click(object sender, EventArgs e)
        {
			EventMusic?.Invoke(this,e);
			// 메인에 이벤트 처리 
			this.Close();
        }
    }
}
