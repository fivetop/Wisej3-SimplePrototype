using Newtonsoft.Json;
using simplepa2.Controller;
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
        List<Comp_UFloor> comp_UFloors = new List<Comp_UFloor>(); // 층 컨트롤
        List<Comp_UZone> comp_Zone = new List<Comp_UZone>(); // 존 컨트롤
        public List<AssetsRow> selAssetsRow = new List<AssetsRow>();


        public string Filter { get; internal set; }
        public string GroupFilter { get; internal set; }

        public Comp_UAsset()
        {
            InitializeComponent();
        }

        internal void reDraw()
        {
            List<Assets> list = new List<Assets>();
            list.Clear();
            comp_UFloors.Clear();
            this.Controls.Clear();

            // 디비투 이기종 테이블 리스트 복제 
            var dt1 = Helper.Table(assetsBindingSource);
            var l2 = Helper.DataTableToList<Assets>(dt1);

            if (l2.Count < 1) return;
            list = l2.Where(p=>p.emServer == Filter).ToList();

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
                fl.assetRow( t1);
            }
        }

        internal void reDraw2()
        {
            List<Assets> list = new List<Assets>();
            list.Clear();
            comp_UFloors.Clear();
            comp_Zone.Clear();
            this.Controls.Clear();

            // 디비투 이기종 테이블 리스트 복제 
            var dt1 = gweb.mainFrame.dBSqlite.Ds1.Assets;
            var dt2 = gweb.mainFrame.dBSqlite.Ds1.AssetGroups.Where(p=>p.Name == GroupFilter);
            var l2 = Helper.DataTableToList<Assets>(dt1);

            if (l2.Count < 1) return;
            list = l2.Where(p => p.emServer == Filter).ToList();

            // 그룹으로 층 생성 
            foreach (var t1 in list)
            {
                var fl = comp_UFloors.FirstOrDefault(p => p.지역명 == t1.GroupName);
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
                var t2 = fl.assetRow(t1);
                comp_Zone.Add(t2);
            }

            foreach (var t1 in dt2)
            {
                var z1 = comp_Zone.FirstOrDefault(p => p.assetRow.AssetId == t1.AssetId);
                if (z1 == null) continue;
                z1.Zone_Click(1);
            }
        }

        internal List<AssetsRow> GetSelAssets()
        {
            List<Assets> selAssets = new List<Assets>();

            foreach (var t1 in comp_Zone)
            {
                if (t1.assetRow.chk == 1)
                { 
                    selAssets.Add(t1.assetRow);
                    System.Diagnostics.Debug.WriteLine(t1.assetRow.ZoneName);
                }
            }

            // 이기종 리스트 복제 
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(selAssets);
            AssetsDataTable pDt = JsonConvert.DeserializeObject<AssetsDataTable>(json);
            selAssetsRow = pDt.ToList();
            return selAssetsRow;
        }
    }
}
