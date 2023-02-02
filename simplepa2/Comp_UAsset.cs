using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2
{
    public partial class Comp_UAsset : Wisej.Web.UserControl
    {
        internal BindingSource assetsBindingSource;
        List<AssetsRow> list = new List<AssetsRow>();
        List<Comp_UFloor> comp_UFloors = new List<Comp_UFloor>();

        public Comp_UAsset()
        {
            InitializeComponent();
        }

        internal void reDraw()
        {
            foreach (var t1 in assetsBindingSource.List)
            {
                var t2 = (AssetsRow)((DataRowView)t1).Row;
                list.Add(t2);
            }

            // 그룹으로 층 생성 
            foreach (var t1 in list)
            {
                var fl = comp_UFloors.FirstOrDefault(p=>p.지역명 == t1.GroupName);
                if (fl != null) continue;
                Comp_UFloor comp_UFloor = new Comp_UFloor();
                comp_UFloor.Dock = DockStyle.Top;
                comp_UFloor.지역명 = t1.GroupName;
                this.Controls.Add(comp_UFloor);
                comp_UFloors.Add(comp_UFloor);
            }

            // 해당 층에 해당 존 전송 
            foreach (var t1 in list)
            {
                var fl = comp_UFloors.FirstOrDefault(p => p.지역명 == t1.GroupName);
                if (fl == null) continue;
                fl.assetRow = t1;
            }

        }

        internal List<AssetsRow> GetSelAssets()
        {
            List<AssetsRow> selAssets = new List<AssetsRow>();

            foreach (var t1 in list)
            {
                if (t1.chk == 1)
                { 
                    selAssets.Add(t1);
                    //System.Diagnostics.Debug.WriteLine(t1.ZoneName);
                }
            }
            return selAssets;
        }
    }
}
