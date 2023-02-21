using DataClass;
using Newtonsoft.Json;
using simplepa2;
using simplepa2.Controller;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static simplepa2.DataSet1;

namespace pa
{
    public class DBAccess
    {
        HttpClient httpClient = new HttpClient();

        public AssetPresetGroupsDataTable AssetPresetGroups { get; set; } = new AssetPresetGroupsDataTable();
        public AssetGroupsDataTable AssetGroups { get; set; } = new AssetGroupsDataTable();
        public AssetsDataTable Assets { get; set; } = new AssetsDataTable();
        public BSTreeDataTable BStree { get; set; } = new BSTreeDataTable();
        public BSTreeCDataTable BStreeC { get; set; } = new BSTreeCDataTable();
        public DeviceDataTable Device { get; set; } = new DeviceDataTable();
        public DeviceChannelDataTable DeviceChannel { get; set; } = new DeviceChannelDataTable();
        public EMBsDataTable EMBs { get; set; } = new EMBsDataTable();
        public EMServerDataTable EMServer { get; set; } = new EMServerDataTable();
        public EventvmDataTable Eventvm { get; set; } = new EventvmDataTable();
        public EventbsDataTable Eventbs { get; set; } = new EventbsDataTable();
        public EventdeviceDataTable Eventdevice { get; set; } = new EventdeviceDataTable();
        public HolidaysDataTable Holidays { get; set; } = new HolidaysDataTable();
        public MusicsDataTable Musics { get; set; } = new MusicsDataTable();
        public SimplepaDataTable Simplepa { get; set; } = new SimplepaDataTable();
        public UserTreesDataTable UserTrees { get; set; } = new UserTreesDataTable();
        public DataSet1.SchduleDataTable schdules { get; set; } = new DataSet1.SchduleDataTable();
        public DataSet1.SchduleCDataTable schduleCs { get; set; } = new DataSet1.SchduleCDataTable();

        #region // Database 초기화 처리
        public void DBInit()
        {
            AssetPresetGroups = Dbread<AssetPresetGroupsDataTable>("AssetPresetGroups");
            AssetGroups = Dbread<AssetGroupsDataTable>("AssetGroups");
            Assets = Dbread<AssetsDataTable>("Assets");
            BStree = Dbread<BSTreeDataTable>("BStrees");
            BStreeC = Dbread<BSTreeCDataTable>("BStreeCs");
            Device = Dbread<DeviceDataTable>("Devices");
            DeviceChannel = Dbread<DeviceChannelDataTable>("DeviceChannels");
            EMBs = Dbread<EMBsDataTable>("EMBs");
            EMServer = Dbread<EMServerDataTable>("EMServers");
            Eventvm = Dbread<EventvmDataTable>("Eventvms");
            Eventbs = Dbread<EventbsDataTable>("Eventbs");
            Holidays = Dbread<HolidaysDataTable>("Holidays");
            Musics = Dbread<MusicsDataTable>("Musics");
            Simplepa = Dbread<SimplepaDataTable>("Simplepas");
            UserTrees = Dbread<UserTreesDataTable>("UserTrees");
            schdules = Dbread<DataSet1.SchduleDataTable>("schdules");
            schduleCs = Dbread<DataSet1.SchduleCDataTable>("schdulecs");
        }

        public void DBSchdule()
        {
            schdules = Dbread<DataSet1.SchduleDataTable>("schdules");
            schduleCs = Dbread<DataSet1.SchduleCDataTable>("schdulecs");
        }


        public void DBRead()
        {
            if (MainWindow.signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return;

            Device = Dbread<DeviceDataTable>("Devices");
            DeviceChannel = Dbread<DeviceChannelDataTable>("DeviceChannels");
        }

        public T Dbread <T>(string url)
        {
            if (MainWindow.signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return default(T);

            try
            {
                var url2 = g._EMClient.WebAPIURL + url;
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                var res = httpClient.GetStringAsync(url2).Result;
                var ret = JsonConvert.DeserializeObject<T>(res);
                return (T)ret;
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
                return default(T);
            }
        }

        public T Dbsave<T>(string url, DataRow t1)
        {
            if (MainWindow.signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return default(T);
            try
            {
                string jsonEmp = JsonConvert.SerializeObject(t1);

                var url2 = g._EMClient.WebAPIURL + url;
                StringContent stringC = new StringContent(jsonEmp, Encoding.UTF8, "application/json"); 
                var res = httpClient.PostAsync(url2, stringC).Result;  

                var ret = JsonConvert.DeserializeObject<T>(res.Content.ReadAsStringAsync().Result); 
                return (T)ret;
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
                return default(T);
            }
        }

        public void Dbupdate<T>(string url, DataRow te1, int id)
        {
            if (MainWindow.signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return;
            try
            {
                /*
                EMServer e1 = new EMServer();
                e1.EMServerId = te1.EMServerId;
                e1.EMNAME = te1.EMNAME;
                e1.state = te1.state;
                e1.state_old = te1.state_old;
                e1.com_gpio = te1.com_gpio;
                e1.com_Rtype = te1.com_Rtype;
                e1.net_local = te1.net_local;
                e1.net_dante = te1.net_dante;
                e1.dsp_ctrl = te1.dsp_ctrl;
                e1.dsp_dante = te1.dsp_dante;
                e1.com_gpio_state = te1.com_gpio_state;
                e1.com_Rtype_state = te1.com_Rtype_state;
                e1.sw_all = te1.sw_all;
                e1.sw_1 = te1.sw_1;
                e1.sw_2 = te1.sw_2;
                e1.sw_3 = te1.sw_3;
                e1.sw_4 = te1.sw_4;
                e1.err = te1.err;
                e1.fire = te1.fire;
                e1.emtest = te1.emtest;
                */

                string jsonEmp = JsonConvert.SerializeObject(te1);
                var url2 = g._EMClient.WebAPIURL + url +"/" + id.ToString(); 
                StringContent stringC = new StringContent(jsonEmp, Encoding.UTF8, "application/json"); 
                var res = httpClient.PutAsync(url2, stringC).Result;
                if (res.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("Success");
                }
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
                return;
            }
        }

        public void UpUser()
        {
            UserTrees a = new UserTrees();
            a.UserTreeId = 5;
            a.user_name = "cccccccc";

            var jsonEmp = JsonConvert.SerializeObject(a);
            var url2 = @"http://localhost:9921/api/UserTrees/5"; 

            //var url2 = g._EMClient.WebAPIURL + "UserTrees" + "/" + a.UserTreeId.ToString();
            StringContent stringC = new StringContent(jsonEmp, Encoding.UTF8, "application/json"); 
            var res = httpClient.PutAsync(url2, stringC).Result;
        }

        public void RemoveEMServer(string url, int id)
        {
            try
            {
                var url2 = g._EMClient.WebAPIURL + url + "/" + id.ToString();
                var res = httpClient.DeleteAsync(url2).Result;  
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
            }

        }

        internal bool EMServerUpdate()
        {
            if (MainWindow.signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return false;

            if (g.mainWindow.EMServerRow.EMServerId == 0)
                return false;

            try
            {
                var t1 = g.mainWindow.EMServerRow;
                t1.state = "On-Line";
                t1.state_old = "On-Line";
                t1.com_gpio = g._EMClient.GPIOPort;
                t1.com_gpio_state = g._EMClient.com_gpio_state;
                t1.com_Rtype = g._EMClient.Rport;
                t1.com_Rtype_state = g._EMClient.com_Rtype_state;
                t1.net_dante = g._EMClient.net_dante;
                t1.net_local = g._EMClient.net_local;
                t1.dsp_ctrl = g._EMClient.dsp_ctrl;
                t1.dsp_dante = g._EMClient.dsp_dante;
                Dbupdate<EMServerRow>("EMServers", t1, t1.EMServerId);
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
            }

            g.XMLEMClient(false);
            return true;
        }


        #endregion

        #region // Device 장치관리 부분 
        // dsp 저장후 상세정보 저장 
        // dsp ch info 저장 
        public void saveDBDSPCH(IEnumerable<DataClass.Device> gs1)
        {
            //Tam.DeviceTableAdapter.Fill(Ds1.Device);
            //Tam.DeviceChannelTableAdapter.Fill(Ds1.DeviceChannel);
            try
            {
                foreach (var t1 in gs1)
                {
                    var s1 = Device.FirstOrDefault(p => p.DeviceName == t1.DeviceName);
                    if (s1 == null)
                        continue;
                    t1.DeviceId = s1.DeviceId;
                    if (t1.ch.Count < 2)
                        continue;

                    var s2 = DeviceChannel.Where(p => p.DeviceId == t1.DeviceId).ToList();
                    if (s2.Count() > 0)
                        continue;

                    for (int i = 0; i < t1.ch.Count; i++)
                    {
                        DeviceChannelRow r1 = DeviceChannel.NewDeviceChannelRow();
                        r1.chno = t1.ch[i].chno;
                        r1.chname = t1.ch[i].chname[0];
                        r1.DeviceId = t1.DeviceId;
                        r1.dsp_out_ch1 = t1.dsp_out_ch1[i];
                        r1.dsp_out_ch2 = t1.dsp_out_ch2[i];
                        r1.io = 1;
                        r1.devicein = "";
                        r1.deviceinch = 0;
                        DeviceChannel.Rows.Add(r1);
                        var t2 = Dbsave<DeviceChannel>("DeviceChannels", (DataRow)r1);

                    }

                    int num = 1;
                    if (t1.ch.Count < 17)
                        num = 17;

                    for (int i = 0; i < t1.ch.Count; i++)
                    {
                        DeviceChannelRow r1 = DeviceChannel.NewDeviceChannelRow();
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
                        DeviceChannel.Rows.Add(r1);
                        var t2 = Dbsave<DeviceChannel>("DeviceChannels", (DataRow)r1);
                    }
                    //Tam.DeviceChannelTableAdapter.Update(Ds1.DeviceChannel);
                }
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
                //Console.WriteLine(e1.Message);
            }
        }

        // Device ADD
        public void NewDeviceRow(DataClass.Device t1, int v)
        {
            try 
            { 
                DeviceRow m1 = Device.NewDeviceRow();
                m1.DanteModelName = t1.DanteModelName;
                m1.DeviceName = t1.DeviceName;
                m1.device = t1.device;
                m1.ip = t1.ip;
                m1.name = t1.name;
                m1.chCount = t1.ch.Count();
                m1.chspk = v;
                m1.dsp_chno = 0;
                m1.ip_dspctrl = t1.ip_dspctrl;
                m1.dsp_name = "";
                m1.dsp_vol = 0;
                m1.dsp_vol_em = 0;
                m1.emData = "";
                m1.floor_em = 0;
                m1.path = "";
                m1.AssetId = 0;
                m1.EMNAME = g._EMClient.EM_NAME;

                if (g.mainWindow.MainDSPIP != "" && g.mainWindow.MainDSPName != "")
                {
                    m1.ip_dspctrl = g.mainWindow.MainDSPIP;
                    m1.dsp_name = g.mainWindow.MainDSPName;
                }

                Device.Rows.Add(m1);
                var t2 = Dbsave<DeviceRow>("Devices", m1);
                //Tam.DeviceTableAdapter.Update(Ds1.Device);
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
            }
        }



        #endregion

        #region // AssetBase 자산관리 기초 부분 
        // 나중에 디비는 모두 몰기 
        public List<AssetBase> db2List(SignalRMsg msg)
        {
            if (MainWindow.signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return null;

            List<AssetBase> play = new List<AssetBase>();
            var ab1 = Assets.Where(a1 => msg.assetsRows.Contains(a1.AssetId));
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

        internal List<AssetBase> db2ListSch(List<simplepa2.Controller.SchduleC> schduleC)
        {
            List<int> assetsRows = new List<int>();
            foreach (var schdule in schduleC)
            {
                int assetId = (int)schdule.AssetId;
                if(assetId > 0)
                    assetsRows.Add(assetId);
            }

            List<AssetBase> play = new List<AssetBase>();
            var ab1 = Assets.Where(a1 => assetsRows.Contains(a1.AssetId));
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

        public void BSTreeCDelete(int idno, int state)
        {
            if (MainWindow.signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return;
            BStree = Dbread<BSTreeDataTable>("BStrees");
            BStreeC = Dbread<BSTreeCDataTable>("BStreeCs");

            try
            {
                var bt = BStree.FirstOrDefault(p => p.chno == idno && p.EMNAME == g._EMClient.EM_NAME);
                if(bt != null)
                {
                    var btc = BStreeC.Where(p => p.BSTreeId == bt.BSTreeId);
                    foreach (BSTreeCRow t2 in btc)
                    {
                        RemoveEMServer("BSTreeCs", t2.BSTreeCId);
                    }
                    bt.playing = "대기";
                }
                Dbupdate<BSTreeRow>("BSTrees", bt, bt.BSTreeId);
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
            }
        }
        #endregion
        
        #region // Simplepa 환경설정 관리 부분 

        public void Init()
        {
            SimplepaRow s = Simplepa.NewSimplepaRow();

            s.UserName = "엘에스전선";
            s.SimplePAId = 1;
            s.EmMusic = "재난위험경보(3분).mp3";
            s.sms_server = "https://sms.nicesms.co.kr/cpsms_utf8/cpsms.html";
            s.sms_id = "lscnssms";
            s.sms_pw = "3ef5afb7e743196d9e0726dba16b02d9";
            s.sms_rcvno = "";

            Simplepa.Rows.Add(s);
            //Tam.SimplepaTableAdapter.Update(Ds1.Simplepa);
            var t2 = Dbsave<Simplepa>("Simplepas", (DataRow)s);
        }

        public void Remove(SimplepaRow s2)
        {
            Simplepa.RemoveSimplepaRow(s2);
            //Tam.SimplepaTableAdapter.Update(Ds1.Simplepa);
        }


        #endregion

        #region // Eventvm 이벤트처리 관리 부분 

        public void Eventbss(string event_text, string base_text, string state)
        {
            if (MainWindow.signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return;

            try
            {
                EventbsRow em = Eventbs.NewEventbsRow();
                em.write_time = DateTime.Now;
                em.event_text = event_text;
                em.path = base_text;
                em.state = state;
                em.alarm = 0;
                em.ip = "";
                em.DeviceName = "";
                var t2 = Dbsave<Eventbs>("Eventbs", (DataRow)em);
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
            }

        }

        public void Eventvms(string event_text, string base_text, string state)
        {
            if (MainWindow.signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return;
            try
            {
                EventvmRow em = Eventvm.NewEventvmRow();
                em.write_time = DateTime.Now;
                em.event_text = event_text;
                em.path = base_text;
                em.state = state;
                em.alarm = 0;
                em.ip = "";
                Save(em);
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
            }

        }

        public void EventvmIP(DataClass.Device t3)
        {
            if (MainWindow.signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return ;

            try
            {
                EventdeviceRow em = Eventdevice.NewEventdeviceRow();
                em.write_time = DateTime.Now;
                em.ip = t3.ip;
                em.path =  Assets.FirstOrDefault(p=>p.ip == t3.ip).path;
                em.DeviceName = t3.DeviceName;
                em.state = t3.state;
                if(t3.state == "")
                    em.state = "Off-Line";
                em.alarm = 0;
                em.event_text = t3.ip +" : " + t3.state;
                //this.Save(em);
                var t2 = Dbsave<Eventdevice>("Eventdevices", (DataRow)em);
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
            }

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
                        var t2 = Dbsave<Eventvm>("Eventvms", (DataRow)o1);
                        //Eventvm.Rows.Add((EventvmRow)o1);
                        //Tam.EventvmTableAdapter.Update(Ds1.Eventvm);
                        break;
                    case "SimplepaRow":
                        //Simplepa.Rows.Add((SimplepaRow)o1);
                        //Tam.SimplepaTableAdapter.Update(Ds1.Simplepa);
                        break;
                }
                //g.Log(t1.Name + " Save OK..");
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
            }
        }
        #endregion

        #region //  emServer 

        public EMServerRow EMServerGet()
        {
            if (MainWindow.signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return null;

            EMServerRow ret;
            ret = EMServer.FirstOrDefault(p=>p.EMNAME == g._EMClient.EM_NAME);

            if (ret == null)
                return null;
            return ret;
        }

        #endregion

    }
}
