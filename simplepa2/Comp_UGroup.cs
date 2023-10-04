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
        public bool GroupUse { get; internal set; } = true;

        public List<AssetsRow> SelAssets()
        {
            return comp_UAsset1.GetSelAssets();
        }

        public void SetSelAssets(List<AssetsRow>  v)
        {
            if (comp_UAsset1.selAssetsRow != null)
                comp_UAsset1.selAssetsRow = v;
        }


        public Comp_UGroup()
        {
            InitializeComponent();
        }

        public void reDraw()
        {
            if(!GroupUse)
                comboBox2.Visible = false;
            combo_init();
        }

        public void combo_init()
		{
			if (Filter == "") return;
			var t1 = gweb.dBSqlite.Ds1.AssetGroups.Where(p => p.EMNAME == Filter).DistinctBy(p => p.Name);

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
            comp_UAsset1.clear();
            comboBox2.Items.Clear();
        }

    }
}
