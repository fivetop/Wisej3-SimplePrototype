using DataClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using simplepa2;
using simplepa2.DataSet1TableAdapters;
using static simplepa2.DataSet1;
using System.Windows.Forms;
using System.Data;
using System.Web.UI;

namespace simplepa2
{
    // bsroom 초기화 필요 
    public class DBController
    {
        public DataSet1 Ds1 { get; set; }
        public TableAdapterManager Tam { get; internal set; }

        public DBController()
        {
        }

        #region // Database 초기화 처리
        public void DBInit()
        {
            try
            {
                Ds1 = new DataSet1();
                Tam = new TableAdapterManager()
                {
                    AssetsTableAdapter = new AssetsTableAdapter(),
                    AssetGroupsTableAdapter = new AssetGroupsTableAdapter(),
                    AssetPresetGroupsTableAdapter = new AssetPresetGroupsTableAdapter(),
                    BSTreeTableAdapter = new BSTreeTableAdapter(),
                    BSTreeCTableAdapter = new BSTreeCTableAdapter(),
                    BSroomTableAdapter = new BSroomTableAdapter(),
                    DeviceTableAdapter = new DeviceTableAdapter(),
                    DeviceChannelTableAdapter = new DeviceChannelTableAdapter(),
                    EMBsTableAdapter = new EMBsTableAdapter(),
                    EventvmTableAdapter = new EventvmTableAdapter(),
                    EventsyslogTableAdapter = new EventsyslogTableAdapter(),
                    EventdeviceTableAdapter = new EventdeviceTableAdapter(),
                    EventpresetTableAdapter = new EventpresetTableAdapter(),
                    EventbsTableAdapter = new EventbsTableAdapter(),
                    HolidaysTableAdapter = new HolidaysTableAdapter(),
                    MusicsTableAdapter = new MusicsTableAdapter(),
                    SimplepaTableAdapter = new SimplepaTableAdapter(),
                    UserTreesTableAdapter = new UserTreesTableAdapter(),
                    EMServerTableAdapter = new EMServerTableAdapter(),
                };
                Tam.AssetsTableAdapter.Fill(Ds1.Assets);
                Tam.AssetGroupsTableAdapter.Fill(Ds1.AssetGroups);
                Tam.AssetPresetGroupsTableAdapter.Fill(Ds1.AssetPresetGroups);
                Tam.BSTreeTableAdapter.Fill(Ds1.BSTree);
                Tam.BSTreeCTableAdapter.Fill(Ds1.BSTreeC);
                Tam.BSroomTableAdapter.Fill(Ds1.BSroom);
                Tam.DeviceTableAdapter.Fill(Ds1.Device);
                Tam.DeviceChannelTableAdapter.Fill(Ds1.DeviceChannel);
                Tam.EMBsTableAdapter.Fill(Ds1.EMBs);
                Tam.EventvmTableAdapter.Fill(Ds1.Eventvm);
                Tam.HolidaysTableAdapter.Fill(Ds1.Holidays);
                Tam.MusicsTableAdapter.Fill(Ds1.Musics);
                Tam.SimplepaTableAdapter.Fill(Ds1.Simplepa);
                Tam.UserTreesTableAdapter.Fill(Ds1.UserTrees);
                Tam.EMServerTableAdapter.Fill(Ds1.EMServer);
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
        }



        #endregion


        #region // 선번장으로 부터 기본 테이블 만들기 
        internal void AssetGroupsSave()
        {
            Tam.AssetsTableAdapter.Fill(Ds1.Assets);
            Tam.EMServerTableAdapter.Fill(Ds1.EMServer);
            Tam.AssetPresetGroupsTableAdapter.Fill(Ds1.AssetPresetGroups);

            foreach (var em in Ds1.EMServer)
            {
                string ENNAME = em.EMNAME + "GROUP";

                var m3 = Ds1.AssetPresetGroups.FirstOrDefault(p => p.Name == ENNAME);

                if (m3 != null)
                    return;

                foreach (AssetsRow a1 in Ds1.Assets)
                {
                    AssetGroupsRow m2 = Ds1.AssetGroups.NewAssetGroupsRow();
                    if (a1.emServer != em.EMNAME)
                        continue;
                    m2.Name = ENNAME;
                    m2.AssetId = a1.AssetId;
                    m2.EMNAME = a1.emServer;
                    Ds1.AssetGroups.Rows.Add(m2);
                    Tam.AssetGroupsTableAdapter.Update(Ds1.AssetGroups);
                }
            }
        }



        internal void AssetPresetSave()
        {
            List<string> preset = new List<string>();
            preset.Add("PRESET1");
            preset.Add("PRESET2");
            preset.Add("PRESET3");
            preset.Add("PRESET4");

            Tam.AssetsTableAdapter.Fill(Ds1.Assets);
            Tam.AssetPresetGroupsTableAdapter.Fill(Ds1.AssetPresetGroups);

            var m3 = Ds1.AssetPresetGroups.FirstOrDefault(p => p.Name == "PRESET1");

            if (m3 != null) 
                return;

            for (int i=0; i < 4;i++)
            { 
                foreach (AssetsRow a1 in Ds1.Assets)
                { 
                    AssetPresetGroupsRow m2 = Ds1.AssetPresetGroups.NewAssetPresetGroupsRow();
                    m2.Name = preset[i];
                    m2.AssetId = a1.AssetId;
                    m2.EMNAME = a1.emServer;
                    m2.chk = 1;
                    Ds1.AssetPresetGroups.Rows.Add(m2);
                    Tam.AssetPresetGroupsTableAdapter.Update(Ds1.AssetPresetGroups);
                }
            }
        }



        #endregion


        #region // Assets 자산관리 부분 
        public void SaveAssets(EmSpeakerPosition t1)
        {
            Tam.AssetsTableAdapter.Fill(Ds1.Assets);
            var aa = t1.array;

            if (aa.Length < 12)
                return;
            int ch = int.Parse(t1.ch);
            var m3 = Ds1.Assets.FirstOrDefault(p => p.DeviceName == aa[6] && p.ch == ch);

            if (m3 != null) return;

            AssetsRow m2 = Ds1.Assets.NewAssetsRow();
            m2.seq = int.Parse(aa[0]);
            m2.building = aa[2];
            m2.floorname = aa[3];
            m2.GroupName = aa[2] + aa[3];
            m2.ZoneName = aa[4];
            m2.SpeakerName = aa[5];
            m2.path = aa[1] + " " + aa[2] + " " + aa[3] + " " + aa[4] + " " + aa[5];
            m2.ch = int.Parse(t1.ch);
            m2.zpc = t1.zpc;
            m2.zpci = t1.zpci;
            m2.zpco = t1.zpco;
            m2.emServer = t1.emServer;

            if (m2.ch == 0)
                m2.ch = 1;
            m2.chk = 0;
            m2.floor = int.Parse(t1.array[11]) * 100 + int.Parse(t1.array[12]) *10 + int.Parse(t1.array[13]);
            m2.emData = t1.emData;
            m2.ip = "";
            m2.state = "";
            m2.state_old = "";
            m2.DeviceId = 0;
            if (aa.Count() > 4)
                m2.DeviceName = aa[6];
            Ds1.Assets.Rows.Add(m2);
            Tam.AssetsTableAdapter.Update(Ds1.Assets);
        }

        // 장비스캔 후 자산정보와 장비 정보를 1대1로 맵핑 처리 
        public void LinkAssetDevice()
        {
            Tam.AssetsTableAdapter.Fill(Ds1.Assets);
            Tam.DeviceTableAdapter.Fill(Ds1.Device);

            foreach (var d1 in Ds1.Device)
            {
                var a1 = Ds1.Assets.FirstOrDefault(p=>p.DeviceName == d1.DeviceName && p.ch == d1.chspk);
                if (a1 == null) continue;
                // 자산 정보에 디바이스 아이디 와 아이피 
                // 장비 정보에 자산아이디, 비상방송 정보, 패스 정보 
                a1.DeviceId = d1.DeviceId;
                a1.ip = d1.ip;
                d1.AssetId = a1.AssetId; 
                d1.emData = a1.emData;
                d1.path = a1.path;
                d1.EMNAME = a1.emServer;
            }
            Tam.AssetsTableAdapter.Update(Ds1.Assets);
            Tam.DeviceTableAdapter.Update(Ds1.Device);
        }

        // 자산에서 스피커의 현재 상태 체크 
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


        #endregion

        #region // AssetBase 자산관리 기초 부분 
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


        #endregion

        #region // BSTree 방송 처리 관리 부분 

        internal async Task<bool> BSTreeCRemove(int bSTreeId)
        {
            Tam.BSTreeCTableAdapter.Fill(Ds1.BSTreeC);
            var drs = Ds1.BSTreeC.Where(p =>p.BSTreeId == bSTreeId);

            if(drs != null && drs.Count() > 0)
            {
                foreach(BSTreeCRow row in drs)
                {
                    //Ds1.BSTreeC.Rows.Remove(row);
                    row.Delete();
                }
            }
            Tam.BSTreeCTableAdapter.Update(Ds1.BSTreeC);
            return true;
        }

        // 기존 방송중 점유된 지역이 없는지 점검
        // 있으면 true 
        internal string BSTreeCCheck(List<AssetsRow> selAsset)
        {
            string ret = "";
            Tam.BSTreeCTableAdapter.Fill(Ds1.BSTreeC);

            foreach (var t1 in selAsset)
            {
                var drs = Ds1.BSTreeC.FirstOrDefault(p => p.AssetId == t1.AssetId);
                if (drs != null && drs.user_name != "")
                    return drs.user_name;
            }
            return ret;
        }


        internal async Task<bool> BSTreeCSave(int bSTreeId, List<AssetsRow> selAsset, List<MusicsRow> selMusic, string user_name )
        {
            Tam.BSTreeCTableAdapter.Fill(Ds1.BSTreeC);

            foreach (var t1 in selAsset)
            {
                BSTreeCRow m2 = Ds1.BSTreeC.NewBSTreeCRow();
                m2.BSTreeId = bSTreeId;
                m2.AssetId  = t1.AssetId;
                m2.MusicId = 0;
                m2.user_name = user_name;
                Ds1.BSTreeC.Rows.Add(m2);
                Tam.BSTreeCTableAdapter.Update(Ds1.BSTreeC);
            }

            foreach (var t1 in selMusic)
            {
                BSTreeCRow m2 = Ds1.BSTreeC.NewBSTreeCRow();
                m2.BSTreeId = bSTreeId;
                m2.AssetId = 0;
                m2.MusicId = t1.MusicId;
                Ds1.BSTreeC.Rows.Add(m2);
                Tam.BSTreeCTableAdapter.Update(Ds1.BSTreeC);
            }
            return true;
        }


        internal int BSTreeGetFreeCh(AssetsRow selAsset)
        {
            BSTreeRow ret = null;

            Tam.BSTreeTableAdapter.Fill(Ds1.BSTree);

            var m3 = Ds1.BSTree.Where(p => p.EMNAME == selAsset.emServer);
            if (m3.Count() > 0)
            {
                foreach (var m1 in m3)
                {
                    if (m1.playing == "대기")
                    { 
                        ret = m1;
                        return ret.BSTreeId;
                    }
                }
            }
            return 0;
        }

        // 대기, 방송시작, 방송중, 방송종료, 방송중지
        // 초기 생성시 2-8 까지 생성 1번은 비상방송 용 
        public void BSTreeSave(EmSpeakerPosition t1)
        {
            Tam.BSTreeTableAdapter.Fill(Ds1.BSTree);

            var m3 = Ds1.BSTree.FirstOrDefault(p => p.EMNAME == t1.emServer);
            if (m3 == null)
            {
                for (int i = 1; i < 9; i++)
                { 
                    BSTreeRow m2 = Ds1.BSTree.NewBSTreeRow();
                    m2.EMNAME = t1.emServer;
                    m2.chno = i;
                    m2.playing = "대기";
                    m2.wtime = DateTime.Now;
                    Ds1.BSTree.Rows.Add(m2);
                    Tam.BSTreeTableAdapter.Update(Ds1.BSTree);
                }
            }
        }

        internal async Task<bool> BSTreeUpdate(int BSTreeId, string ps1)
        {
            try
            {
                Tam.BSTreeTableAdapter.Fill(Ds1.BSTree);
                var drs = Ds1.BSTree.FirstOrDefault(p => p.BSTreeId == BSTreeId);
                drs.playing = ps1;
                drs.wtime = DateTime.Now;
                Tam.BSTreeTableAdapter.Update(Ds1.BSTree);
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }

            return true;
        }


        public void BSTreeDelete(int idno)
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

        internal BSTreeRow BSTreeGet(int bSTreeId)
        {
            var t2 = Ds1.BSTree.FirstOrDefault(p => p.BSTreeId == bSTreeId);
            return t2;
        }


        #endregion


        #region // EMServer 부분 

        internal List<string> EMServerWithWholeColLoad()
        {
            List<string> list = new List<string>();
            Tam.EMServerTableAdapter.Fill(Ds1.EMServer);
            list.Add("전체");
            foreach (var m1 in Ds1.EMServer)
            {
                list.Add(m1.EMNAME);
            }
            return list;
        }


        internal int EMServerGetState(AssetsRow assetsRow)
        {
            int ret = 0;
            Tam.EMServerTableAdapter.Fill(Ds1.EMServer);

            var m3 = Ds1.EMServer.FirstOrDefault(p => p.EMNAME == assetsRow.emServer && p.state == "ONLINE");
            if (m3 == null)
                return ret;
            return m3.EMServerId;
        }

        public void EMServerSave(EmSpeakerPosition t1)
        {
            Tam.EMServerTableAdapter.Fill(Ds1.EMServer);

            var m3 = Ds1.EMServer.FirstOrDefault(p => p.EMNAME == t1.emServer);
            if (m3 != null) return;

            try
            {
                EMServerRow m2 = Ds1.EMServer.NewEMServerRow();
                m2.EMNAME = t1.emServer;
                m2.state = "";
                m2.state_old = "";
                m2.com_gpio = "";
                m2.com_Rtype = "";
                m2.net_local = "";
                m2.net_dante = "";
                m2.dsp_ctrl = "";
                m2.dsp_dante = "";
                m2.com_gpio_state = 0;
                m2.com_Rtype_state = 0;
                m2.sw_all = 0;
                m2.sw_1 = 0;
                m2.sw_2 = 0;
                m2.sw_3 = 0;
                m2.sw_4 = 0;
                m2.err = 0;
                m2.fire = 0;
                m2.emtest = 0;
                m2.em_address = "";
                m2.em_description = "";
                m2.em_images= "";
                Ds1.EMServer.Rows.Add(m2);
                Tam.EMServerTableAdapter.Update(Ds1.EMServer);
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
        }

        public void EMServerupdate(string EMNAME, string state)
        {
            try
            {
                Tam.EMServerTableAdapter.Fill(Ds1.EMServer);

                var m3 = Ds1.EMServer.FirstOrDefault(p => p.EMNAME == EMNAME);
                if (m3 == null)
                    return;
                m3.state_old = m3.state;
                m3.state = state;
                Tam.EMServerTableAdapter.Update(Ds1.EMServer);
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
        }

        public void EMServerupdatePreset(string EMNAME, int po, int onoff)
        {
            Tam.EMServerTableAdapter.Fill(Ds1.EMServer);

            var m3 = Ds1.EMServer.FirstOrDefault(p => p.EMNAME == EMNAME);
            if (m3 == null)
                return;
            switch(po)
            {
                case 0: m3.sw_all = onoff; break;
                case 1: m3.sw_1 = onoff; break;
                case 2: m3.sw_2 = onoff; break;
                case 3: m3.sw_3 = onoff; break;
                case 4: m3.sw_4 = onoff; break;
            }
            Tam.EMServerTableAdapter.Update(Ds1.EMServer);
        }

        #endregion

        #region // EMBS 비상방송 관리 부분 
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
                m2.EMNAME = t1.EMNAME;
                Ds1.EMBs.Rows.Add(m2);
                Tam.EMBsTableAdapter.Update(Ds1.EMBs);
            }
        }

        #endregion

        #region // Eventvm 이벤트처리 관리 부분 

        public void Eventbs(string event_text, string base_text, string state)
        {
            try
            {
                EventbsRow em = Ds1.Eventbs.NewEventbsRow();
                em.write_time = DateTime.Now;
                em.event_text = event_text;
                em.path = base_text;
                em.state = state;
                em.alarm = 0;
                Ds1.Eventbs.Rows.Add(em);
                Tam.EventbsTableAdapter.Update(Ds1.Eventbs);
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
        }

        public void Eventsyslog(string event_text, string base_text, string state)
        {
            try
            {
                EventsyslogRow em = Ds1.Eventsyslog.NewEventsyslogRow();
                em.write_time = DateTime.Now;
                em.event_text = event_text;
                em.path = base_text;
                em.state = state;
                em.alarm = 0;
                Ds1.Eventsyslog.Rows.Add(em);
                Tam.EventsyslogTableAdapter.Update(Ds1.Eventsyslog);
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
        }

        public void Eventpreset(string event_text, string base_text, string state)
        {
            try
            {
                EventpresetRow em = Ds1.Eventpreset.NewEventpresetRow();
                em.write_time = DateTime.Now;
                em.event_text = event_text;
                em.path = base_text;
                em.state = state;
                em.alarm = 0;
                Ds1.Eventpreset.Rows.Add(em);
                Tam.EventpresetTableAdapter.Update(Ds1.Eventpreset);
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
        }
        public void Eventvm(string event_text, string base_text, string state)
        {
            try
            {
                EventvmRow em = Ds1.Eventvm.NewEventvmRow();
                em.write_time = DateTime.Now;
                em.event_text = event_text;
                em.path = base_text;
                em.state = state;
                em.alarm = 0;
                Ds1.Eventvm.Rows.Add(em);
                Tam.EventvmTableAdapter.Update(Ds1.Eventvm);
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
        }
        public void Eventdevice(AssetsRow t3)
        {
            try
            {
                EventdeviceRow em = Ds1.Eventdevice.NewEventdeviceRow();
                em.write_time = DateTime.Now;
                em.ip = t3.ip;
                em.path = t3.path;
                em.DeviceName = t3.DeviceName;
                em.state = t3.state;
                em.alarm = 2;
                Ds1.Eventdevice.Rows.Add(em);
                Tam.EventdeviceTableAdapter.Update(Ds1.Eventdevice);
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
        }

        #endregion

        #region // 음원 처리

        internal bool MusicFileSave(string path, string filename)
        {

            string path1 = Path.Combine(path, filename);
            var mu1 = TagLib.File.Create(path1);
            Thread.Sleep(50);
            MusicsRow m2 = Ds1.Musics.NewMusicsRow();
            string str1 = "00:00:00";
            var r1 = mu1.Properties.Duration;
            m2.FileName = filename;
            m2.FileContent = "";
            m2.deletable = "N";
            Thread.Sleep(50);
            str1 = r1.ToString(@"hh\:mm\:ss");
            if (str1 == "00:00:00")
                str1 = "00:00:01";
            m2.duration = str1;
            Ds1.Musics.Rows.Add(m2);
            Tam.MusicsTableAdapter.Update(Ds1.Musics);
            return true;
        }

        // 음원 폴더에서 가져와 디비 생성 
        // 듀레이션은 시간이 걸리므로 타이머 쓰레드 처리 
        public void MusicSave()
        {
            if (Ds1.Musics.Count > 1)
                return;
            string strFileUploadPath = @"C:\SimplePA2" + "\\Music\\";

            if (!Directory.Exists(strFileUploadPath))
            {
                Directory.CreateDirectory(strFileUploadPath);
            }

            var directoryInfo = new DirectoryInfo(strFileUploadPath);
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles("*.mp3");

                foreach (var fileInfo in files)
                {
                    var mu1 = TagLib.File.Create(fileInfo.FullName);
                    var m3 = Ds1.Musics.FirstOrDefault(p => p.FileName == fileInfo.Name);
                    if (m3 != null)
                    {
                        if (m3.duration == "" || m3.duration == "00:00:00")
                        {
                            Thread.Sleep(50);
                            string str2 = "00:00:00";
                            var r1 = mu1.Properties.Duration;
                            str2 = r1.ToString(@"hh\:mm\:ss");
                            if (str2 == "00:00:00")
                                str2 = "00:00:01";
                            m3.duration = str2;
                            Tam.MusicsTableAdapter.Update(Ds1.Musics);
                        }
                    }
                    else
                    {
                        MusicsRow m2 = Ds1.Musics.NewMusicsRow();
                        string str1 = "00:00:00";
                        var r1 = mu1.Properties.Duration;
                        m2.FileName = fileInfo.Name;
                        m2.FileContent = "";
                        m2.deletable = "N";
                        Thread.Sleep(50);
                        str1 = r1.ToString(@"hh\:mm\:ss");
                        if (str1 == "00:00:00")
                            str1 = "00:00:01";
                        m2.duration = str1;
                        Ds1.Musics.Rows.Add(m2);
                        Tam.MusicsTableAdapter.Update(Ds1.Musics);
                    }
                }
            }
        }

        #endregion

        #region // Simplepa 환경설정 관리 부분 

        public void Init()
        {
            SimplepaRow s = Ds1.Simplepa.NewSimplepaRow();

            s.UserName = "엘에스전선";
            s.SimplePAId = 1;
            s.EmMusic = "재난위험경보(3분).mp3";
            s.sms_server = "https://sms.nicesms.co.kr/cpsms_utf8/cpsms.html";
            s.sms_id = "lscnssms";
            s.sms_pw = "3ef5afb7e743196d9e0726dba16b02d9";
            s.sms_rcvno = "";
            //s.Jigsangbalhwa = 1;
            //s.Pport = 0;
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


        #endregion

        #region // 사용자 관리 

        public UserTreesRow UsertreeGet(string t2)
        {
            Tam.UserTreesTableAdapter.Fill(Ds1.UserTrees);
            var m1 = Ds1.UserTrees.FirstOrDefault(p => p.login_id == t2);
            return m1;
        }

        #endregion

        #region // not use // Device 장치관리 부분 

        /*
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
                        r1.chname = "IN" + num.ToString();
                        r1.DeviceId = t1.DeviceId;
                        r1.dsp_out_ch1 = "";
                        r1.dsp_out_ch2 = "";
                        r1.io = 0;
                        r1.devicein = "";
                        r1.deviceinch = 0;
                        if (num > 16 && num < 25)
                        {
                            r1.deviceinch = num - 16;
                        }
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

        */


        /*
        var t1 = dbContext.AssetBases.Where(a1 => msg.assetsRows.Contains(a1.AssetBaseId));
        bSTree.AssetBases = t1.ToList(); // .ToList();
        var t2 = dbContext.Musics.Where(a1 => msg.musicsRows.Contains(a1.MusicId));
        bSTree.Musics = t2.ToList();
        */
        #endregion

    }
}
