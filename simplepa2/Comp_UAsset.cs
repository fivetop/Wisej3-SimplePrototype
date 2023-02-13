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

        internal void clear()
        {
            comp_UFloors.Clear();
            this.Controls.Clear();
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
            // 메모리 복사 
            list = AssetRow2Asset(dt1, Filter);

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

            // 등록은 assetGroup 으로 처리 , 수정은 상위에서 받은 selAssetsRow 로 처리 
            if (selAssetsRow.Count() > 0)
            {
                foreach (var t1 in selAssetsRow)
                {
                    var z1 = comp_Zone.FirstOrDefault(p => p.assetRow.AssetId == t1.AssetId);
                    if (z1 == null) continue;
                    z1.Zone_Click(1);
                }
            }
            else 
            { 
                // 그룹에 포함된 존만 선택 
                foreach (var t1 in dt2)
                {
                    var z1 = comp_Zone.FirstOrDefault(p => p.assetRow.AssetId == t1.AssetId);
                    if (z1 == null) continue;
                    z1.Zone_Click(1);
                }
            }
        }

        private List<Assets> AssetRow2Asset(AssetsDataTable dt1, string filter)
        {
            List<Assets> list = new List<Assets>();

            foreach (var t1 in dt1)
            { 
                if(t1.emServer != filter) continue;
                Assets m2 = new Assets();
                m2.AssetId = t1.AssetId;
                m2.seq = t1.seq;
                m2.building = t1.building;
                m2.floorname = t1.floorname;
                m2.GroupName = t1.GroupName;
                m2.ZoneName = t1.ZoneName;
                m2.SpeakerName = t1.SpeakerName;
                m2.path = t1.path;
                m2.ch = t1.ch;
                m2.chk = 0; // t1.chk;
                list.Add(m2);
                /*
                m2.zpc = t1.zpc;
                m2.zpci = t1.zpci;
                m2.zpco = t1.zpco;
                m2.emServer = t1.emServer;
                if (m2.ch == 0)
                    m2.ch = 1;
                m2.floor = int.Parse(t1.array[11]) * 100 + int.Parse(t1.array[12]) * 10 + int.Parse(t1.array[13]);
                m2.em1 = 0;
                m2.em2 = 0;
                m2.em3 = 0;
                m2.emData = t1.emData;
                m2.ip = "";
                m2.state = "";
                m2.state_old = "";
                m2.DeviceId = 0;
                if (aa.Count() > 4)
                    m2.DeviceName = aa[6];
                */
            }
            return list;
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
