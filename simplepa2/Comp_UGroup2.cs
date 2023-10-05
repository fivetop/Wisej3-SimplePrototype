using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2
{
    public partial class Comp_UGroup2 : Wisej.Web.UserControl
    {
        public string Filter { get; internal set; } = "";
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


        public Comp_UGroup2()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            comp_Site1.dataSet = gweb.dBSqlite.EMServerWithWholeColLoad(1);
            comp_Site1.reDraw();
        }

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {
            reDraw();
        }

        public void reDraw()
        {
            if(!GroupUse)
                comp_Group.Visible = false;

            Filter =  comp_Site1.selectedItem;
            combo_init();
        }

        public void combo_init()
		{
			if (Filter == "") return;
			var t1 = gweb.dBSqlite.Ds1.AssetGroups.Where(p => p.EMNAME == Filter).DistinctBy(p => p.Name);

			comp_Group.Items.Clear();
			foreach (var a1 in t1)
			{
				comp_Group.Items.Add(a1.Name);
			}
			if (comp_Group.Items.Count > 0)
				comp_Group.SelectedIndex = 0;
		}

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            GroupFilter = (string)comp_Group.SelectedItem;
            comp_UAsset1.Filter = Filter;
            comp_UAsset1.GroupFilter = GroupFilter;
            if (Filter == "" || GroupFilter == "") return;
            if (Filter == null || GroupFilter == null) return;
            comp_UAsset1.reDraw2();

        }

        internal void clear()
        {
            comp_UAsset1.clear();
            comp_Group.Items.Clear();
        }

        internal void setFilter()
        {
            comp_Site1.selectedItem = Filter;
            comp_Group.SelectedItem = GroupFilter;
        }
    }
}
