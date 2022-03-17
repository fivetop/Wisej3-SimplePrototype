using gClass;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisej.CodeProject;
using Wisej.CodeProject.DataSet1TableAdapters;
using static Wisej.CodeProject.DataSet1;

namespace pa
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
                    AssetsTableAdapter = new AssetsTableAdapter(),
                    AssetGroupsTableAdapter = new AssetGroupsTableAdapter(),
                    BSTreeTableAdapter = new BSTreeTableAdapter(),
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
                dm1.AssetsTableAdapter.Fill(ds1.Assets);
                dm1.AssetGroupsTableAdapter.Fill(ds1.AssetGroups);
                dm1.BSTreeTableAdapter.Fill(ds1.BSTree);
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

        public void DBCopy()
        {
            try
            {
                foreach (var t1 in ds1.Assets)
                {
                    AssetsRow m1 = ds1.Assets.NewAssetsRow();
                    m1.AssetId = 1;
                    m1.ch = 1;
                    m1.chk = t1.chk;
                    m1.DeviceName = t1.DeviceName;
                    m1.floor = t1.floor;
                    m1.GroupName = t1.GroupName;
                    m1.ip = t1.ip;
                    m1.path = t1.path;
                    m1.seq = t1.seq;
                    m1.SpeakerName = t1.SpeakerName;
                    m1.state = t1.state;
                    m1.state_old = t1.state_old;
                    m1.ZoneName = t1.ZoneName;
                    ds1.Assets.Rows.Add(m1);
                }
                dm1.AssetsTableAdapter.Update(ds1.Assets);

                foreach (var t1 in gl._MusicList.music)
                {
                    MusicsRow m1 = ds1.Musics.NewMusicsRow();
                    m1.duration = t1.duration;
                    m1.FileContent = t1.FileContent;
                    m1.FileName = t1.FileName;
                    m1.FilePlay = t1.FilePlay;
                    m1.InfoTreeId = 0;
                    //m1.MusicId = t1.MusicId;
                    m1.SimpleMultiId = 0;
                    ds1.Musics.Rows.Add(m1);
                }
                dm1.MusicsTableAdapter.Update(ds1.Musics);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        internal void Delete(int idno)
        {
            try 
            { 
                var t2 = ds1.BSTree.Where(p => p.chno == idno);
                foreach (BSTreeRow t3 in t2)
                {
                    t3.Delete();
                }
                dm1.BSTreeTableAdapter.Update(ds1.BSTree);
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
            dm1.BSTreeTableAdapter.Update(ds1.BSTree);
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
                         ch = (p.ch == null) ? "0" : p.ch.ToString(),
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
                        dm1.EventvmTableAdapter.Update(ds1.Eventvm);
                        break;
                    case "SimplepaRow":
                        ds1.Simplepa.Rows.Add((SimplepaRow)o1);
                        dm1.SimplepaTableAdapter.Update(ds1.Simplepa);
                        break;
                }
                //g.Log(t1.Name + " Save OK..");
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
                g.Log(t1.Name + " Save Fail..");
            }
        }

        internal void Init(SimplepaRow s)
        {
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
            s.Reserved14 = "재난위험경보(3분).mp3";
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
        }

        internal void Remove(SimplepaRow s2)
        {
            ds1.Simplepa.RemoveSimplepaRow(s2);
            dm1.SimplepaTableAdapter.Update(ds1.Simplepa);
        }

        internal void Eventvm(string event_text, string base_text, string state)
        {
            EventvmRow em = ds1.Eventvm.NewEventvmRow();
            em.write_time = DateTime.Now;
            em.event_text = event_text;
            em.path = base_text;
            em.state = state;
            Save(em);
        }
        internal void EventvmIP(Asset t3)
        {
            EventvmRow em = ds1.Eventvm.NewEventvmRow();
            em.write_time = DateTime.Now;
            em.ip = t3.ip;
            em.path = t3.path;
            em.DeviceName = t3.DeviceName;
            em.state = t3.state;
            this.Save(em);
        }

        /*
        var t1 = dbContext.AssetBases.Where(a1 => msg.assetsRows.Contains(a1.AssetBaseId));
        bSTree.AssetBases = t1.ToList(); // .ToList();
        var t2 = dbContext.Musics.Where(a1 => msg.musicsRows.Contains(a1.MusicId));
        bSTree.Musics = t2.ToList();
        */

    }
}
