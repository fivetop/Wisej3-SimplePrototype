using DataClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Wisej.CodeProject;
using Wisej.CodeProject.DataSet1TableAdapters;
using static Wisej.CodeProject.DataSet1;

namespace Wisej.CodeProject
{
    public class DBSqlite
    {
        public DataSet1 ds1 { get; set; }
        public TableAdapterManager Tam { get; internal set; }

        public DBSqlite()
        {
        }

        public void DBInit()
        {
            try
            {
                ds1 = new DataSet1();
                Tam = new TableAdapterManager()
                {
                    AssetsTableAdapter = new AssetsTableAdapter(),
                    AssetGroupsTableAdapter = new AssetGroupsTableAdapter(),
                    BSTreeTableAdapter = new BSTreeTableAdapter(),
                    DeviceTableAdapter = new DeviceTableAdapter(),
                    DeviceChannelTableAdapter = new DeviceChannelTableAdapter(),
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
                Tam.AssetsTableAdapter.Fill(ds1.Assets);
                Tam.AssetGroupsTableAdapter.Fill(ds1.AssetGroups);
                Tam.BSTreeTableAdapter.Fill(ds1.BSTree);
                Tam.DeviceTableAdapter.Fill(ds1.Device);
                Tam.DeviceChannelTableAdapter.Fill(ds1.DeviceChannel);
                Tam.EventvmTableAdapter.Fill(ds1.Eventvm);
                Tam.FloorbasesTableAdapter.Fill(ds1.Floorbases);
                Tam.FloormapsTableAdapter.Fill(ds1.Floormaps);
                Tam.HolidaysTableAdapter.Fill(ds1.Holidays);
                Tam.InfoTreesTableAdapter.Fill(ds1.InfoTrees);
                Tam.MusicsTableAdapter.Fill(ds1.Musics);
                Tam.SimpleMultisTableAdapter.Fill(ds1.SimpleMultis);
                Tam.SimplepaTableAdapter.Fill(ds1.Simplepa);
                Tam.UserTreesTableAdapter.Fill(ds1.UserTrees);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        public void SaveAssets(EmSpeakerPosition t1)
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
                Tam.AssetsTableAdapter.Update(ds1.Assets);
            }
        }



        public void Delete(int idno)
        {
            try 
            { 
                var t2 = ds1.BSTree.Where(p => p.chno == idno);
                foreach (BSTreeRow t3 in t2)
                {
                    t3.Delete();
                }
                Tam.BSTreeTableAdapter.Update(ds1.BSTree);
            }
            catch (Exception e1)
            { 
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
                bSTree.MusicId = 0;
                bSTree.AssetId = t1;
                ds1.BSTree.Rows.Add(bSTree);
            }
            foreach (int t1 in msg.musicsRows)
            {
                BSTreeRow bSTree = ds1.BSTree.NewBSTreeRow();
                bSTree.chno = 100000 + chno;
                bSTree.MusicId = t1;
                bSTree.AssetId = 0;
                ds1.BSTree.Rows.Add(bSTree);
            }
            Tam.BSTreeTableAdapter.Update(ds1.BSTree);
            ds1.BSTree.AcceptChanges();

            var ab1 = ds1.Assets.Where(a1 => msg.assetsRows.Contains(a1.AssetId));
            var p1 = from p in ab1
                     select new AssetBase
                     {
                         AssetBaseId = (int)p.AssetId,
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
                         ch = p.ch,
                     };
            var t3 = ab1.ToList();
            play = p1.ToList();
            return play;
        }

        public void Save(object o1)
        {
            var t1 = o1.GetType();

            try
            {
                //switch (t1.BaseType.Name)
                switch (t1.Name)
                {
                    case "EventvmRow":
                        ds1.Eventvm.Rows.Add((EventvmRow)o1);
                        Tam.EventvmTableAdapter.Update(ds1.Eventvm);
                        break;
                    case "SimplepaRow":
                        ds1.Simplepa.Rows.Add((SimplepaRow)o1);
                        Tam.SimplepaTableAdapter.Update(ds1.Simplepa);
                        break;
                }
                //g.Log(t1.Name + " Save OK..");
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        public void Init()
        {
            SimplepaRow s = ds1.Simplepa.NewSimplepaRow();

            s.UserName = "엘에스전선";
            s.ServerIP = "192.168.1.1";
            s.SimplePAId = 1;
            s.SpeakerIconSize = 120;
            s.debug = 0;
            s.MapX = 4000;
            s.MapY = 4000;
            s.Zoom = 0.2;
            s.TileWidth = 180;
            s.EMServerIP = "127.0.0.1";
            s.Reserved1 = "0";
            s.Reserved2 = "0";
            s.Reserved3 = "0";
            s.Reserved4 = "0";
            s.Reserved5 = "1";
            s.Reserved6 = "P형수신기";
            s.Reserved7 = "http://www.radio-korea.com/embed/sbs-radio-love-fm-428824";
            s.Reserved8 = "http://www.radio-korea.com/embed/ytn-radio-401695";
            s.Reserved9 = "http://www.radio-korea.com/embed/ebs-fm-428830";
            s.Reserved10 = "";
            s.Reserved11 = "0";
            s.GPIOPort = "COM3";
            s.Rport = "COM4";
            s.EmMusic = "재난위험경보(3분).mp3";
            s.Reserved15 = "";
            s.Reserved16 = "";
            s.Reserved17 = 0;
            s.Jigsangbalhwa = 1;
            //s2.user = new List<UserTree>();
            //s2.holiday = new List<Holiday>();
            s.inputvolume = 0.5f;
            s.outputvolume = 0.5f;
            s.disp = 1;
            s.SpeakerTimer = 10;
            s.Multi_Ch = 3;
            s.SoundDeviceNum = 0;
            s.dsp_vol = 0;        // 초기 값
            s.dsp_vol_em = 0;     // 초기 값 
            s.sms_server = "https://sms.nicesms.co.kr/cpsms_utf8/cpsms.html";
            s.sms_id = "lscnssms";
            s.sms_pw = "3ef5afb7e743196d9e0726dba16b02d9";
            s.sms_rcvno = "";
            s.Pport = 0;
            ds1.Simplepa.Rows.Add(s);
            Tam.SimplepaTableAdapter.Update(ds1.Simplepa);

        }

        public void Remove(SimplepaRow s2)
        {
            ds1.Simplepa.RemoveSimplepaRow(s2);
            Tam.SimplepaTableAdapter.Update(ds1.Simplepa);
        }

        public void Eventvm(string event_text, string base_text, string state)
        {
            EventvmRow em = ds1.Eventvm.NewEventvmRow();
            em.write_time = DateTime.Now;
            em.event_text = event_text;
            em.path = base_text;
            em.state = state;
            em.alarm = 0;
            Save(em);
        }
        public void EventvmIP(AssetsRow t3)
        {
            EventvmRow em = ds1.Eventvm.NewEventvmRow();
            em.write_time = DateTime.Now;
            em.ip = t3.ip;
            em.path = t3.path;
            em.DeviceName = t3.DeviceName;
            em.state = t3.state;
            em.alarm = 2;
            this.Save(em);
        }

        // 스피커의 현재 상태 체크 
        public int getSpeakerState(string path)
        {
            var sAsset = ds1.Assets.First(p => p.path == path);
            if (sAsset != null)
            {
                if (sAsset.state == "On-Line")
                    return 1;
            }
            return 0;
        }


        /*
        var t1 = dbContext.AssetBases.Where(a1 => msg.assetsRows.Contains(a1.AssetBaseId));
        bSTree.AssetBases = t1.ToList(); // .ToList();
        var t2 = dbContext.Musics.Where(a1 => msg.musicsRows.Contains(a1.MusicId));
        bSTree.Musics = t2.ToList();
        */

    }
}
