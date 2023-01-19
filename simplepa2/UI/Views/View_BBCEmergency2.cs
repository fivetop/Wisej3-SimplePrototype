using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Views
{
    public partial class View_BBCEmergency2 : Wisej.Web.UserControl
    {
        public View_BBCEmergency2()
        {
            InitializeComponent();
        }

        private void BSEMManager_Load(object sender, EventArgs e)
        {
            reDraw();
        }

        private void disp_gridview()
        {
        }

        internal void reDraw()
        {
            gweb.mainFrame.dBSqlite.SaveEMBs();
            this.deviceTableAdapter.Fill(this.dataSet1.Device);
            this.emBsTableAdapter.Fill(this.dataSet1.EMBs);

            disp_gridview();

            comp_Site1.dataSet = gweb.mainFrame.dBSqlite.EMServerWithWholeColLoad();
            comp_Site1.reDraw();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EMBsRow sel = (EMBsRow)comboBox1.SelectedItem;

            if (sel == null)
                return;
            Selemdata = sel.emData;
            eMBsBindingSource.Filter = "emData ='"+Selemdata+"'";
        }

        string Selemdata = "";
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
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
                r1.EMNAME = t2.EMNAME;
                dataSet1.EMBs.Rows.Add(r1);
                emBsTableAdapter.Update(dataSet1.EMBs);
                eMBsBindingSource.EndEdit();
                this.emBsTableAdapter.Fill(this.dataSet1.EMBs);
                comboBox1_SelectedIndexChanged(null, null);
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (this.dataGridView2.RowCount < 2) return;
                var t1 = this.dataGridView2.CurrentRow.DataBoundItem;
                var t2 = (EMBsRow)((System.Data.DataRowView)t1).Row;
                if (t1 == null) return;
                if (t2 == null) return;
                t2.Delete();
                emBsTableAdapter.Update(dataSet1.EMBs);
                eMBsBindingSource.EndEdit();
                comboBox1_SelectedIndexChanged(null, null);
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
        }

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedItem = sender as string;

            if (selectedItem == null || selectedItem == "")
                return;
            if (!selectedItem.Equals("전체"))
            {
                deviceBindingSource.Filter = ("EMNAME = '" + selectedItem + "'" + " AND device = 0");
                eMBsBindingSource.Filter = ("EMNAME = '" + selectedItem + "'");
            }
            else
            {
                deviceBindingSource.Filter = "device=0";
                eMBsBindingSource.Filter = "";
            }

            // combobox 
            IEnumerable<EMBsRow> EMBs;

            if (selectedItem.Equals("전체"))
            {
                EMBs = this.dataSet1.EMBs.OrderBy(p => p.emData).DistinctBy(p => p.emData);
            }
            else
            {
                EMBs = this.dataSet1.EMBs.Where(p => p.EMNAME == selectedItem).OrderBy(p => p.emData).DistinctBy(p => p.emData);
            }

            comboBox1.Items.Clear();
            comboBox1.DisplayMember = "emData";
            comboBox1.ValueMember = "emData";
            //comboBox1.DataSource = EMBs;
            foreach (var t1 in EMBs)
            {
                comboBox1.Items.Add(t1);
            }
            if (comboBox1.Items.Count > 1)
                comboBox1.SelectedIndex = 0;

            disp_gridview();
        }

    }
}
