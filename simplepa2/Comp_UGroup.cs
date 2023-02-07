using Microsoft.Ajax.Utilities;
using System;
using System.Data;
using Wisej.Web;

namespace simplepa2
{
    public partial class Comp_UGroup : Wisej.Web.UserControl
    {
        public string Filter { get; internal set; }

        public Comp_UGroup()
        {
            InitializeComponent();
        }

        public void reDraw()
        {
            comp_UAsset1.Filter = Filter;
            comp_UAsset1.reDraw2();

            combo_init();

        }

		public void combo_init()
		{
			if (Filter == "") return;
			var t1 = gweb.mainFrame.dBSqlite.Ds1.AssetGroups.Where(p => p.EMNAME == Filter).DistinctBy(p => p.Name);

			comboBox2.Items.Clear();
			foreach (var a1 in t1)
			{
				comboBox2.Items.Add(a1.Name);
			}
			if (comboBox2.Items.Count > 0)
				comboBox2.SelectedIndex = 0;
		}

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
