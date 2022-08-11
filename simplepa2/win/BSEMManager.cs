using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.win
{
    public partial class BSEMManager : Wisej.Web.UserControl
    {
        public BSEMManager()
        {
            InitializeComponent();
        }
        private void BSEMManager_Load(object sender, EventArgs e)
        {
            this.deviceTableAdapter.Fill(this.dataSet1.Device);
            this.emBsTableAdapter.Fill(this.dataSet1.EMBs);

            var EMBs = this.dataSet1.EMBs.OrderBy(p=>p.emData).DistinctBy(p => p.emData);

            comboBox1.Items.Clear();
            comboBox1.DisplayMember = "emData";
            comboBox1.ValueMember = "emData";
            foreach (var t1 in EMBs)
            {
                comboBox1.Items.Add(t1);
            }
            if(comboBox1.Items.Count > 1)
                comboBox1.SelectedIndex = 0;
        }

        internal void reDraw()
        {
            BSEMManager_Load(null, null);
            //throw new NotImplementedException();
        }

        public List<EMBsRow> selembs { get; set; } = new List<EMBsRow>();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EMBsRow sel = (EMBsRow)comboBox1.SelectedItem;

            if (sel == null)
                return;
            Selemdata = sel.emData;
            var t1 = this.dataSet1.EMBs.Where(p => p.emData == sel.emData);

            selembs.Clear();
            foreach (var r1 in t1)
            {
                selembs.Add(r1);
            }

            this.dataGridView2.DataSource = selembs;
            this.dataGridView2.Columns.Clear();
            this.dataGridView2.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] { this.colPath_1, this.colDeviceid_1 });
            this.dataGridView2.Refresh();
        }

        string Selemdata = "";
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var t1 = this.dataGridView1.CurrentRow.DataBoundItem;
            var t2 = (DeviceRow)((System.Data.DataRowView)t1).Row;

            if (t2 == null)
                return;
            if (Selemdata == "")
                return;
            var t3 = dataSet1.EMBs.FirstOrDefault(p=>p.emData == Selemdata && p.DeviceId == t2.DeviceId);
            if (t3 != null)
                return;
            EMBsRow r1 = dataSet1.EMBs.NewEMBsRow();
            r1.DeviceId = t2.DeviceId;
            r1.emData = Selemdata;
            r1.path = t2.path;
            dataSet1.EMBs.Rows.Add(r1);
            emBsTableAdapter.Update(dataSet1.EMBs);
            eMBsBindingSource.EndEdit();
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var t1 = (EMBsRow) this.dataGridView2.CurrentRow.DataBoundItem;
                if (t1 == null)
                    return;
                t1.Delete();
                emBsTableAdapter.Update(dataSet1.EMBs);
                eMBsBindingSource.EndEdit();
                comboBox1_SelectedIndexChanged(null, null);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
    }
}
