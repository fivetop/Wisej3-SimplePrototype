using gClass;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisej.CodeProject;
using Wisej.CodeProject.DataSet1TableAdapters;
using static Wisej.CodeProject.DataSet1;

namespace LSmDNSW
{
    public class DBSqlite
    {
        public DataSet1 ds1 { get; set; }
        public TableAdapterManager dm1 { get; internal set; }

        public DBSqlite()
        {
        }

        public void DBInit()
        {
            try
            {
                ds1 = new DataSet1();
                dm1 = new TableAdapterManager()
                {
                    AssetBasesTableAdapter = new AssetBasesTableAdapter(),
                    AssetsTableAdapter = new AssetsTableAdapter(),
                    AssetGroupsTableAdapter = new AssetGroupsTableAdapter(),
                    BSTreeTableAdapter = new BSTreeTableAdapter(),
                    DeviceTableAdapter = new DeviceTableAdapter(),
                    EventvmTableAdapter = new EventvmTableAdapter(),
                    FloorbasesTableAdapter = new FloorbasesTableAdapter(),
                    FloormapsTableAdapter = new FloormapsTableAdapter(),
                    HolidaysTableAdapter = new HolidaysTableAdapter(),
                    InfoTreesTableAdapter = new InfoTreesTableAdapter(),
                    MusicsTableAdapter = new MusicsTableAdapter(),
                    SimpleMultisTableAdapter = new SimpleMultisTableAdapter(),
                    SimplepaTableAdapter = new SimplepaTableAdapter(),
                    UserTreesTableAdapter = new UserTreesTableAdapter(),
                };
                dm1.AssetBasesTableAdapter.Fill(ds1.AssetBases);
                dm1.AssetsTableAdapter.Fill(ds1.Assets);
                dm1.AssetGroupsTableAdapter.Fill(ds1.AssetGroups);
                dm1.BSTreeTableAdapter.Fill(ds1.BSTree);
                dm1.DeviceTableAdapter.Fill(ds1.Device);
                dm1.EventvmTableAdapter.Fill(ds1.Eventvm);
                dm1.FloorbasesTableAdapter.Fill(ds1.Floorbases);
                dm1.FloormapsTableAdapter.Fill(ds1.Floormaps);
                dm1.HolidaysTableAdapter.Fill(ds1.Holidays);
                dm1.InfoTreesTableAdapter.Fill(ds1.InfoTrees);
                dm1.MusicsTableAdapter.Fill(ds1.Musics);
                dm1.SimpleMultisTableAdapter.Fill(ds1.SimpleMultis);
                dm1.SimplepaTableAdapter.Fill(ds1.Simplepa);
                dm1.UserTreesTableAdapter.Fill(ds1.UserTrees);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        internal void SaveAssets(EmSpeakerPosition t1)
        {
            var aa = t1.file.Split(' ');

            var m3 = ds1.Assets.FirstOrDefault(p => p.GroupName == aa[1] && p.ZoneName == aa[2] && p.SpeakerName == aa[3] && p.ch == int.Parse(aa[5]));
            if (m3 == null)
            {
                AssetsRow m2 = ds1.Assets.NewAssetsRow();
                m2.seq = int.Parse(aa[0]);
                m2.GroupName = aa[1];
                m2.ZoneName = aa[2];
                m2.SpeakerName = aa[3];
                m2.path = aa[1] + " " + aa[2] + " " + aa[3];
                m2.ch = int.Parse(aa[5]);
                m2.chk = 0;
                m2.em1 = int.Parse(t1.array[6]);
                m2.em2 = int.Parse(t1.array[7]);
                m2.em3 = int.Parse(t1.array[8]);
                m2.ip = "";
                m2.state = "";
                m2.state_old = "";
                if (aa.Count() > 4)
                    m2.DeviceName = aa[4];
                ds1.Assets.Rows.Add(m2);
                dm1.AssetsTableAdapter.Update(ds1.Assets);
            }
        }

        public void DBCopy()
        {
            try
            {
                foreach (var t1 in gl.danteDevice._DanteDevice)
                {
                    var s1 = ds1.Device.FirstOrDefault(p=>p.DeviceName == t1.DeviceName && p.chspk == t1.chspk);
                    if (s1 != null)
                        continue;
                    DeviceRow m1 = ds1.Device.NewDeviceRow();
                    m1.chspk = t1.chspk;
                    m1.DanteModelName = t1.DanteModelName;
                    m1.DeviceName = t1.DeviceName;
                    m1.device = t1.device;
                    m1.dsp_chno = t1.dsp_chno;
                    m1.dsp_name = t1.dsp_name;
                    m1.dsp_off_ch1 = t1.dsp_off_ch1;
                    m1.dsp_off_ch2 = t1.dsp_off_ch2;
                    m1.dsp_vol = t1.dsp_vol;
                    m1.dsp_vol_em = t1.dsp_vol_em;
                    m1.emData = t1.emData;
                    m1.floor_em = t1.floor_em;
                    m1.ip = t1.ip;
                    m1.ip_dspctrl = t1.ip_dspctrl;
                    m1.name = t1.name;
                    m1.path = t1.path;
                    ds1.Device.Rows.Add(m1);
                }
                dm1.DeviceTableAdapter.Update(ds1.Device);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        public void ReadFloor()
        {
            // 폴더에서 자동으로 파일 확인후 디비에 등록 처리 
            var directoryInfo = new DirectoryInfo(gl.appPathServer + "Image");
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles("*.png").Concat(directoryInfo.GetFiles("*.svg"));

                foreach (var fileInfo in files)
                {
                    var aa = fileInfo.Name.Split(' ');
                    if (aa.Count() < 2)
                        continue;
                    var aa2 = aa[2].Split('.');
                    int aai = int.Parse(aa[0]);
                    var m3 = ds1.Floorbases.FirstOrDefault(p => p.buildingname == aa[1] && p.floor == aa2[0]);

                    if (m3 == null)
                    {
                        FloorbasesRow m2 = ds1.Floorbases.NewFloorbasesRow();
                        m2.buildingname = aa[1];
                        m2.floor = aa2[0];
                        m2.floororder = aai;
                        m2.filename = fileInfo.Name;
                        ds1.Floorbases.Rows.Add(m2);
                    }
                    else
                    {
                        m3.floororder = aai;
                        m3.filename = fileInfo.Name;
                    }
                    dm1.FloorbasesTableAdapter.Update(ds1.Floorbases);
                }
            }
        }

        // 나중에 디비는 모두 몰기 
        public List<AssetBase> db2List(SignalRMsg msg, int chno)
        {
            List<AssetBase> play = new List<AssetBase>();
            foreach (int t1 in msg.assetsRows)
            {
                BSTreeRow bSTree = ds1.BSTree.NewBSTreeRow();
                bSTree.chno = 100000 + chno;
                bSTree.AssetId = t1;
                bSTree.MusicId = 1;
                ds1.BSTree.Rows.Add(bSTree);
            }
            foreach (int t1 in msg.musicsRows)
            {
                BSTreeRow bSTree = ds1.BSTree.NewBSTreeRow();
                bSTree.chno = 100000 + chno;
                bSTree.AssetId = t1;
                bSTree.MusicId = 2;
                ds1.BSTree.Rows.Add(bSTree);
            }
            dm1.BSTreeTableAdapter.Update(ds1.BSTree);
            ds1.BSTree.AcceptChanges();

            var ab1 = ds1.AssetBases.Where(a1 => msg.assetsRows.Contains(a1.AssetBaseId));
            var p1 = from p in ab1
                     select new AssetBase
                     {
                         AssetBaseId = (int)p.AssetBaseId,
                         ip = p.ip,
                         GroupName = p.GroupName,
                         ZoneName = p.ZoneName,
                         SpeakerName = p.SpeakerName,
                         path = p.path,
                         floor = p.floor,
                         DeviceName = p.DeviceName,
                         state = p.state,
                         state_old = p.state_old,
                         chk = true,
                         seq = (int)p.seq,
                         ch = (p.ch == null) ? "0" : p.ch.ToString(),
                     };
            var t3 = ab1.ToList();
            play = p1.ToList();
            return play;
        }


    }
}
