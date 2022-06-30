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
    // bsroom 초기화 필요 
    public class DBSqlite
    {
        public DataSet1 Ds1 { get; set; }
        public TableAdapterManager Tam { get; internal set; }

        public DBSqlite()
        {
        }

        public void DBInit()
        {
            try
            {
                Ds1 = new DataSet1();
                Tam = new TableAdapterManager()
                {
                    AssetsTableAdapter = new AssetsTableAdapter(),
                    AssetGroupsTableAdapter = new AssetGroupsTableAdapter(),
                    BSTreeTableAdapter = new BSTreeTableAdapter(),
                    BSroomTableAdapter = new BSroomTableAdapter(),
                    DeviceTableAdapter = new DeviceTableAdapter(),
                    DeviceChannelTableAdapter = new DeviceChannelTableAdapter(),
                    EMBsTableAdapter = new EMBsTableAdapter(),
                    EventvmTableAdapter = new EventvmTableAdapter(),
                    HolidaysTableAdapter = new HolidaysTableAdapter(),
                    MusicsTableAdapter = new MusicsTableAdapter(),
                    SimplepaTableAdapter = new SimplepaTableAdapter(),
                    UserTreesTableAdapter = new UserTreesTableAdapter(),
                };
                Tam.AssetsTableAdapter.Fill(Ds1.Assets);
                Tam.AssetGroupsTableAdapter.Fill(Ds1.AssetGroups);
                Tam.BSTreeTableAdapter.Fill(Ds1.BSTree);
                Tam.BSroomTableAdapter.Fill(Ds1.BSroom);
                Tam.DeviceTableAdapter.Fill(Ds1.Device);
                Tam.DeviceChannelTableAdapter.Fill(Ds1.DeviceChannel);
                Tam.EMBsTableAdapter.Fill(Ds1.EMBs);
                Tam.EventvmTableAdapter.Fill(Ds1.Eventvm);
                Tam.HolidaysTableAdapter.Fill(Ds1.Holidays);
                Tam.MusicsTableAdapter.Fill(Ds1.Musics);
                Tam.SimplepaTableAdapter.Fill(Ds1.Simplepa);
                Tam.UserTreesTableAdapter.Fill(Ds1.UserTrees);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        public void SaveAssets(EmSpeakerPosition t1)
        {
            Tam.AssetsTableAdapter.Fill(Ds1.Assets);
            var aa = t1.array;

            if (aa.Length < 12)
                return;
            var m3 = Ds1.Assets.FirstOrDefault(p => p.GroupName == aa[1] && p.ZoneName == aa[2] && p.SpeakerName == aa[3] && p.ch == int.Parse(aa[5]));
            if (m3 == null)
            {
                AssetsRow m2 = Ds1.Assets.NewAssetsRow();
                m2.seq = int.Parse(aa[0]);
                m2.building = aa[1];
                m2.floorname = aa[2];
                m2.GroupName = aa[1] + aa[2];
                m2.ZoneName = aa[3];
                m2.SpeakerName = aa[4];
                m2.path = aa[1] + " " + aa[2] + " " + aa[3] + " " + aa[4];
                m2.ch = int.Parse(t1.ch);
                m2.zpc = t1.zpc;
                m2.zpci = t1.zpci;
                m2.zpco = t1.zpco;

                if (m2.ch == 0)
                    m2.ch = 1;
                m2.chk = 0;
                m2.floor = int.Parse(t1.array[10]) * 100 + int.Parse(t1.array[11]) *10 + int.Parse(t1.array[12]);
                m2.emData = t1.emData;
                m2.ip = "";
                m2.state = "";
                m2.state_old = "";
                m2.DeviceId = 0;
                if (aa.Count() > 4)
                    m2.DeviceName = aa[5];
                Ds1.Assets.Rows.Add(m2);
                Tam.AssetsTableAdapter.Update(Ds1.Assets);
            }
        }

        public void updateAsset()
        {
            Tam.AssetsTableAdapter.Fill(Ds1.Assets);
            Tam.DeviceTableAdapter.Fill(Ds1.Device);

            foreach (var t1 in Ds1.Device)
            {
                var m1 = Ds1.Assets.FirstOrDefault(p=>p.DeviceName == t1.DeviceName && p.ch == t1.chspk);
                if (m1 == null)
                    continue;
                m1.DeviceId = t1.DeviceId;
                m1.ip = t1.ip;
                t1.AssetId = m1.AssetId; 
                t1.emData = m1.emData;
                t1.path = m1.path;
            }
            Tam.AssetsTableAdapter.Update(Ds1.Assets);
            Tam.DeviceTableAdapter.Update(Ds1.Device);
        }

        public void SaveEMBs()
        {
            Tam.EMBsTableAdapter.Fill(Ds1.EMBs);

            foreach (var t1 in Ds1.Device)
            {
                if (t1.emData == "")
                    continue;
                var m1 = Ds1.EMBs.FirstOrDefault(p => p.emData == t1.emData && p.DeviceId == t1.DeviceId);
                if (m1 != null)
                    continue;
                EMBsRow m2 = Ds1.EMBs.NewEMBsRow();
                m2.emData = t1.emData;
                m2.DeviceId = t1.DeviceId;
                m2.path = t1.path;
                Ds1.EMBs.Rows.Add(m2);
                Tam.EMBsTableAdapter.Update(Ds1.EMBs);
            }
        }

        public void Delete(int idno)
        {
            try 
            { 
                var t2 = Ds1.BSTree.Where(p => p.chno == idno);
                foreach (BSTreeRow t3 in t2)
                {
                    t3.Delete();
                }
                Tam.BSTreeTableAdapter.Update(Ds1.BSTree);
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
                BSTreeRow bSTree = Ds1.BSTree.NewBSTreeRow();
                bSTree.chno = 100000 + chno;
                bSTree.MusicId = 0;
                bSTree.AssetId = t1;
                Ds1.BSTree.Rows.Add(bSTree);
            }
            foreach (int t1 in msg.musicsRows)
            {
                BSTreeRow bSTree = Ds1.BSTree.NewBSTreeRow();
                bSTree.chno = 100000 + chno;
                bSTree.MusicId = t1;
                bSTree.AssetId = 0;
                Ds1.BSTree.Rows.Add(bSTree);
            }
            Tam.BSTreeTableAdapter.Update(Ds1.BSTree);
            Ds1.BSTree.AcceptChanges();

            var ab1 = Ds1.Assets.Where(a1 => msg.assetsRows.Contains(a1.AssetId));
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

        // dsp 저장후 상세정보 저장 
        // dsp ch info 저장 
        public void saveDBDSPCH(IEnumerable<Device> gs1)
        {
            Tam.DeviceTableAdapter.Fill(Ds1.Device);
            Tam.DeviceChannelTableAdapter.Fill(Ds1.DeviceChannel);
            try
            {
                foreach (var t1 in gs1)
                {
                    var s1 = Ds1.Device.FirstOrDefault(p => p.DeviceName == t1.DeviceName);
                    if (s1 == null)
                        continue;
                    t1.DeviceId = s1.DeviceId;
                    if (t1.ch.Count < 2)
                        continue;

                    var s2 = Ds1.DeviceChannel.Where(p => p.DeviceId == t1.DeviceId).ToList();
                    if (s2.Count() > 0)
                        continue;

                    for (int i = 0; i < t1.ch.Count; i++)
                    {
                        DeviceChannelRow r1 = Ds1.DeviceChannel.NewDeviceChannelRow();
                        r1.chno = t1.ch[i].chno;
                        r1.chname = t1.ch[i].chname[0];
                        r1.DeviceId = t1.DeviceId;
                        r1.dsp_out_ch1 = t1.dsp_out_ch1[i];
                        r1.dsp_out_ch2 = t1.dsp_out_ch2[i];
                        r1.io = 1;
                        r1.devicein = "";
                        r1.deviceinch = 0;
                        Ds1.DeviceChannel.Rows.Add(r1);
                    }

                    int num = 1;
                    if (t1.ch.Count < 17)
                        num = 17;

                    for (int i = 0; i < t1.ch.Count; i++)
                    {
                        DeviceChannelRow r1 = Ds1.DeviceChannel.NewDeviceChannelRow();
                        r1.chno = num.ToString();
                        r1.chname = "IN"+num.ToString();
                        r1.DeviceId = t1.DeviceId;
                        r1.dsp_out_ch1 = "";
                        r1.dsp_out_ch2 = "";
                        r1.io = 0;
                        r1.devicein = "";
                        r1.deviceinch = 0;
                        num++;
                        Ds1.DeviceChannel.Rows.Add(r1);
                    }
                    Tam.DeviceChannelTableAdapter.Update(Ds1.DeviceChannel);
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        // Device ADD
        public void NewDeviceRow(Device t1, int v)
        {
            DeviceRow m1 = Ds1.Device.NewDeviceRow();
            m1.DanteModelName = t1.DanteModelName;
            m1.DeviceName = t1.DeviceName;
            m1.device = t1.device;
            m1.ip = t1.ip;
            m1.ip_dspctrl = t1.ip_dspctrl;
            m1.name = t1.name;
            m1.chCount = t1.ch.Count();
            m1.chspk = v;
            m1.dsp_chno = 0;
            m1.dsp_name = "";
            m1.dsp_vol = 0;
            m1.dsp_vol_em = 0;
            m1.emData = "";
            m1.floor_em = 0;
            m1.path = "";
            Ds1.Device.Rows.Add(m1);
            Tam.DeviceTableAdapter.Update(Ds1.Device);
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
                        Ds1.Eventvm.Rows.Add((EventvmRow)o1);
                        Tam.EventvmTableAdapter.Update(Ds1.Eventvm);
                        break;
                    case "SimplepaRow":
                        Ds1.Simplepa.Rows.Add((SimplepaRow)o1);
                        Tam.SimplepaTableAdapter.Update(Ds1.Simplepa);
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
            SimplepaRow s = Ds1.Simplepa.NewSimplepaRow();

            s.UserName = "엘에스전선";
            s.ServerIP = "192.168.1.1";
            s.SimplePAId = 1;
            s.SpeakerIconSize = 120;
            s.debug = 0;
            s.MapX = 4000;
            s.MapY = 4000;
            s.Zoom = 0.2f;
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
            s.scalelength = 0;
            s.length = 0;
            Ds1.Simplepa.Rows.Add(s);
            Tam.SimplepaTableAdapter.Update(Ds1.Simplepa);


            for (int i = 0; i < 7; i++)
            { 
                var s1 = Ds1.BSroom.NewBSroomRow();
                s1.state = 0;
                s1.mode = 0;
                Ds1.BSroom.Rows.Add(s1);
                Tam.BSroomTableAdapter.Update(Ds1.BSroom);
            }
        }

        public void Remove(SimplepaRow s2)
        {
            Ds1.Simplepa.RemoveSimplepaRow(s2);
            Tam.SimplepaTableAdapter.Update(Ds1.Simplepa);
        }

        public void Eventvm(string event_text, string base_text, string state)
        {
            EventvmRow em = Ds1.Eventvm.NewEventvmRow();
            em.write_time = DateTime.Now;
            em.event_text = event_text;
            em.path = base_text;
            em.state = state;
            em.alarm = 0;
            Save(em);
        }
        public void EventvmIP(AssetsRow t3)
        {
            EventvmRow em = Ds1.Eventvm.NewEventvmRow();
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
            var sAsset = Ds1.Assets.First(p => p.path == path);
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
