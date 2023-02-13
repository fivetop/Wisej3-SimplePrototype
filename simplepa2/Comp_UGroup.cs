using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2
{
    public partial class Comp_UGroup : Wisej.Web.UserControl
    {
        public string Filter { get; internal set; }
        public string GroupFilter { get; internal set; }

        List<AssetsRow> _SelAssets;
        public List<AssetsRow> SelAssets
        {
            get 
            {
                return comp_UAsset1.GetSelAssets();
            }
            set
            {
                _SelAssets = value;
                comp_UAsset1.selAssetsRow = value;
            }
        }


        public Comp_UGroup()
        {
            InitializeComponent();
        }

        public void reDraw()
        {
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

            GroupFilter = (string)comboBox2.SelectedItem;
            comp_UAsset1.Filter = Filter;
            comp_UAsset1.GroupFilter = GroupFilter;
            if (Filter == "" || GroupFilter == "") return;
            if (Filter == null || GroupFilter == null) return;
            comp_UAsset1.reDraw2();

        }

        internal void clear()
        {
            SelAssets.Clear();
            comp_UAsset1.clear();
            comboBox2.Items.Clear();
        }

    }
}
