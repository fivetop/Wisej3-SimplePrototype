using System;
using Wisej.Web;

namespace pa_web.win
{
    public partial class MHolidayManager : Wisej.Web.UserControl
    {
        public MHolidayManager()
        {
            InitializeComponent();
        }
		private void MHolidayManager_Load(object sender, EventArgs e)
		{
			hLoadData();
		}

		private void hdataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			this.hdataGridView1.Tools["Save"].Enabled = true;
		}

		private void hdataGridView1_ToolClick(object sender, ToolClickEventArgs e)
		{
			switch (e.Tool.Name)
			{
				case "Save":
					hSaveData();
					break;

				case "Add":
					hAddNewRecord();
					break;

				case "Delete":
					hDeleteRecord();
					break;

				case "Reload":
					hLoadData();
					break;
			}
		}

		private void hDeleteRecord()
		{
			// this method shows server-side modal.

			try
			{
				var row = this.hdataGridView1.CurrentRow?.Index ?? -1;
				if (row > -1)
				{
					if (MessageBox.Show(
						"Are you sure you want to delete this record?",
						icon: MessageBoxIcon.Question,
						buttons: MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
					{
						this.holidaybindingSource2.RemoveCurrent();
						var count = this.holidaysTableAdapter.Update(this.dataSet1.Holidays);

						hSetStatusText("Deleted 1 record.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void hSaveData()
		{
			try
			{
				this.holidaybindingSource2.EndEdit();
				var count = this.holidaysTableAdapter.Update(this.dataSet1.Holidays);
				this.hdataGridView1.Tools["Save"].Enabled = false;

				AlertBox.Show("Saved!");
				hSetStatusText("Saved " + count + " records.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void hAddNewRecord()
		{
			try
			{
				this.holidaybindingSource2.AddNew();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void hSetStatusText(string text)
		{
			//this.hstatusBar1.Text = text;
		}

		private void hLoadData()
		{
			this.hdataGridView1.CellValueChanged -= new Wisej.Web.DataGridViewCellEventHandler(this.hdataGridView1_CellValueChanged);
			this.holidaysTableAdapter.Fill(this.dataSet1.Holidays);
			this.hdataGridView1.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.hdataGridView1_CellValueChanged);

			hSetStatusText("Loaded " + this.holidaybindingSource2.Count + " records.");
		}

		private void hdataGridView1_Enter(object sender, EventArgs e)
		{
			this.holidaybindingSource2.EndEdit();
		}

    }
}
