using DataClass;
using gClass;
using Microsoft.Win32;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Wisej.CodeProject;
using static Wisej.CodeProject.DataSet1;

namespace LSmDNSW
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        static udpClient udpc1 = null;
        static bool running = false;
        static System.Timers.Timer timer = new System.Timers.Timer(10000);
        static int case1 = 0;

        public List<int> dsp_vol { get; set; } = new List<int>() { };
        public List<string> dsp_name { get; set; } = new List<string>() { };

        public List<string> purpose { get; set; } = new List<string>() { "예약가능", "중앙방송", "다원방송", "개별방송", "비상방송", "PRESET", "1번연동" };
        public List<string> division { get; set; } = new List<string>() { "일반","Dante"};// 구분 일반/단테

        public DeviceDataTable _DanteDevice { get; set; }
        public DeviceChannelDataTable _DanteDeviceDSPChnnels { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            // NativeMethods.AllocConsole();
            g.MainWindow = this;
            Title = "System Master " + gl.version;
            gl.XMLDanteDevice(true);

            g.dBSqlite.DBInit();
            _DanteDevice = g.dBSqlite.ds1.Device;
            _DanteDeviceDSPChnnels = g.dBSqlite.ds1.DeviceChannel;

            DBCopy();

            init();
            initLeft();
        }


        public void DBCopy()
        {
            try
            {
                foreach (var t1 in gl.danteDevice._DanteDevice)
                {
                    var s1 = g.dBSqlite.ds1.Device.FirstOrDefault(p => p.DeviceId == t1.DeviceId);
                    if (s1 != null)
                    {
                        t1.DeviceId = s1.DeviceId;
                        /*
                        if (t1.ch.Count < 2)
                            continue;

                        for (int i=0; i < t1.ch.Count; i++)
                        { 
                            DeviceChannelRow r1 = g.dBSqlite.ds1.DeviceChannel.NewDeviceChannelRow();
                            r1.chno = t1.ch[i].chno;
                            r1.chname = t1.ch[i].chname[0];
                            r1.DeviceId = t1.DeviceId;
                            r1.dsp_out_ch1 = t1.dsp_out_ch1[i];
                            r1.dsp_out_ch2 = t1.dsp_out_ch2[i];
                            g.dBSqlite.ds1.DeviceChannel.Rows.Add(r1);
                        }
                        g.dBSqlite.Tam.DeviceChannelTableAdapter.Update(g.dBSqlite.ds1.DeviceChannel);
                        //*/
                        continue;
                    }
                    DeviceRow m1 = g.dBSqlite.ds1.Device.NewDeviceRow();
                    if(t1.chspk == null || t1.chspk == 0)
                        m1.chspk = 1;
                    else
                        m1.chspk = t1.chspk;
                    m1.DanteModelName = t1.DanteModelName;
                    m1.DeviceName = t1.DeviceName;
                    m1.device = t1.device;
                    m1.dsp_chno = t1.dsp_chno;
                    m1.dsp_name = t1.dsp_name;
                    m1.dsp_vol = t1.dsp_vol;
                    m1.dsp_vol_em = t1.dsp_vol_em;
                    m1.emData = t1.emData;
                    m1.floor_em = t1.floor_em;
                    m1.ip = t1.ip;
                    m1.ip_dspctrl = t1.ip_dspctrl;
                    m1.name = t1.name;
                    m1.path = t1.path;
                    g.dBSqlite.ds1.Device.Rows.Add(m1);
                }
                g.dBSqlite.Tam.DeviceTableAdapter.Update(g.dBSqlite.ds1.Device);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }


        private void init()
        {
            for (int i = 1; i < 33; i++)
            {
                dsp_vol.Add(i);
            }
            ComboBoxColumn.ItemsSource = null;
            ComboBoxColumn.ItemsSource = dsp_vol;

            foreach (var t1 in _DanteDevice)
            {
                if (t1.device != 2)
                    continue;

                dsp_name.Add(t1.DeviceName);

                /*
                //t1.DSPChnnels.Clear();
                if (t1.DSPChnnels.Count() == 0)
                {
                    t1.DSPChnnels = new List<DSPChnnel>();
                    for (int i = 1; i < 33; i++)
                    {
                        DSPChnnel t2 = new DSPChnnel();
                        t2.chno = i;
                        t2.chname = "IN" + i.ToString();
                        if (t1.ch.Count == 16 && i < 17)
                            t2.division = "일반";
                        else
                            t2.division = "Dante";

                        t2.purpose = "예약가능";
                        switch (i)
                        {
                            case 1: t2.purpose = "PRESET"; break;
                            case 17: t2.purpose = "비상방송"; break;
                            case 18: t2.purpose = "중앙방송"; break;
                            case 19:
                            case 20:
                            case 21:
                            case 22:
                            case 23:
                            case 24: t2.purpose = "다원방송"; break;
                        }
                        t1.DSPChnnels.Add(t2);
                    }
                    for (int i = 1; i < 33; i++)
                    {
                        DSPChnnel t2 = new DSPChnnel();
                        t2.chno = i + 32;
                        t2.chname = "OUT" + i.ToString();
                        if (t1.ch.Count == 16 && i < 17)
                            t2.division = "일반";
                        else
                            t2.division = "Dante";

                        t2.purpose = "예약가능";
                        switch (i)
                        {
                            case 32: t2.purpose = "1번연동"; break;
                        }

                        t1.DSPChnnels.Add(t2);
                    }
                }
                */
            }
            cboType3.ItemsSource = null;
            cboType3.ItemsSource = dsp_name;

            ComboBoxColumn1.ItemsSource = null;
            ComboBoxColumn1.ItemsSource = dsp_name;

            ComboBoxColumn11.ItemsSource = null;
            ComboBoxColumn11.ItemsSource = purpose;

            ComboBoxColumn12.ItemsSource = null;
            ComboBoxColumn12.ItemsSource = division;

        }

        public void Log(string log)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                string str1 = log + "\r\n";
                _out.Inlines.Add(str1);
            }));

        }

        int cardno = 0;
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            gl.NetWorkCardFind();

            List<string> cl = new List<string>();

            foreach (var t1 in gl.networkCardList)
            {
                cl.Add(t1.NetworkCardNo.ToString() + ":" + t1.NetworkCardmDNS.ToString() + ":" + t1.NetworkCardName );
            }
            _combo.ItemsSource = cl.ToList();

            var t2 = gl.networkCardList.Find(p => p.NetworkCardName == gl.NetworkCardName); // cl.f .Find(p=>p.in);
            if (t2 == null)
            {
                // 캡처 카드 인덱스 찾기 
                _combo.SelectedIndex = 0;
                return;
            }
            else
            {
                // 캡처 카드 인덱스 찾기 
                _combo.SelectedItem = t2.NetworkCardNo.ToString() + ":" + t2.NetworkCardmDNS.ToString() + ":" + t2.NetworkCardName;
            }

            try
            { 
                Resolver.intfindx = t2.NetworkCardmDNS;
                Resolver.localIP = t2.ipv4;

                g.Log("Local IP :" + t2.ipv4);

                g.resolver = new Resolver();
                g.resolver.OnReceiveMessage += Resolver_OnReceiveMessage;
                g.resolver.OnEventNewDevice += Resolver_OnEventNewDevice; 

                IPEndPoint ReceiveEndPoint1 = new IPEndPoint(System.Net.IPAddress.Parse(t2.ipv4), 6001);

                udpc1 = new udpClient();
                udpc1.udp.Client.Bind(ReceiveEndPoint1);
                udpc1.option(IPAddress.Parse("239.16.0.8"), LSmDNSW.Resolver.intfindx);
                udpc1.OnReceiveMessage += Udpc1_OnReceiveMessage;
                udpc1.buf2.Clear();
                udpc1.rcv();
            }
            catch (Exception e1)
            {
            }
// 유지보수에서 사용 
            ReadAssetList();

            //g.Main2();

        }

        private void Resolver_OnEventNewDevice(object o)
        {
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(udpc1 != null)
                udpc1.Close();

        }


        //=======================================================================================
        // 장비검색 부분 
        //

        // 리스트 보기 
        private void _Status1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            g.Log("L:List");
            g.division();
            foreach (var t2 in _DanteDevice)
            {
                g.Log(t2.ip.ToString() + " : " + t2.DeviceName + " : " + t2.name + " : " + t2.device.ToString() + " : " + t2.ip_dspctrl);
            }

        }


        private void Resolver_OnReceiveMessage(string message)
        {
            //if (resolver.rcvAddress() == false)
            //    return;
            if (running == false)
            {
                running = true;
                //resolver.GetDevice();
                //g.Log("Rcv Packet..");
                running = false;
            }
        }

        // 리스트 출력 
        private void _Status1_Click(object sender, RoutedEventArgs e)
        {
            g.Log("L:List");
            g.division();
            foreach (var t2 in _DanteDevice)
            {
                g.Log(t2.ip.ToString() + " : " + t2.DeviceName + " : " + t2.name + " : " + t2.device.ToString() + " : " + t2.ip_dspctrl);
            }
        }


        // 네트웍 탐색 시작 
        private void _Status2_Click(object sender, RoutedEventArgs e)
        {
            if (timer.Enabled == true)
                return;
            g.Log("Network Scan Timer Start..");
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Interval = 1000 * 10;
            try
            {
                switch (case1)
                {
                    case 0:
                        case1 = 1;
                        g.Log("process 1 -- _netaudio_arc");
                        //resolver.ResolveServiceName(g._netaudio_arc);
                        g.resolver.ResolveServiceName2(g._netaudio_arc);
                        break;
                    case 1:
                        case1 = 2;
                        g.Log("process 2 -- _netaudio_chan");
                        g.resolver.ResolveServiceName(g._netaudio_chan);
                        break;
                    case 2:
                        case1 = 3;
                        g.Log("process 3 -- _netaudio_cmc");
                        g.resolver.ResolveServiceName(g._netaudio_cmc);
                        break;
                    case 3:
                        case1 = 0;
                        g.Log("process 4 -- Find DSP");

                        Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                        {
                            FindDSP();
                        }));
                        break;
                }
            }
            catch (Exception e1)
            { 
            }


            //timer.Close();
            //timer.Dispose();
            g.resolver.GetDevice();
            GC.Collect();
        }

        // 저장 처리 
        private void _Status3_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            g.Log("");
            g.Log("S:Save Data...");
            g.division();
            //gl.XMLDanteDevice(true);
            gl.XMLDanteDevice(false);
            //SpeakerAssignDSP();
            //g.XMLDanteDevice(true);
            //gl.XMLDanteDevice(false);

        }

        static bool findDSP = false;

        private void FindDSP()
        {
            if (findDSP)
                return;
            findDSP = true;
            List<string> t21 = new List<string>();
            List<string> t31 = new List<string>();

            LScap.g.capData1.Clear();
            LScap.g.capData2.Clear();
            LScap.g.OpenCap();

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files\Wireshark\tshark.exe");
            startInfo.UseShellExecute = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo = startInfo;
            process.Start();
            Thread.Sleep(1000);

            string str1 = "a55a100000000000011200010000000000000000000000000000000000000000";
            byte[] bytes1 = gl.hexatobyte(str1);
            udpc1.send("239.16.0.8", 6001, bytes1);
            Thread.Sleep(3000);

            if (process.HasExited == false)
                process.Kill();

            var t2 = LScap.g.capData1;
            var t3 = LScap.g.capData2;
            foreach (var t1 in t2)
            {
                t21.Add(t1);
                g.Log(t1);
            }
            foreach (var t1 in t3)
            {
                t31.Add(t1);
                g.Log(t1);
            }
            LScap.g.CloseCap();


            foreach (var t5 in _DanteDevice)
            {
                for (int i = 0; i < t31.Count; i++)
                {
                    if (t5.name == t31[i])
                    {
                        t5.ip_dspctrl = t21[i];
                        g.Log("--------------------------------------------------------------------------------");
                        g.Log("Find DSP Controller IP : " + t5.ip_dspctrl + " " + t31[i]);
                        g.Log("--------------------------------------------------------------------------------");
                    }
                }
            }
            findDSP = false;
        }

        // DSP 각 채널에 스피커를 할당한다. 
        private void SpeakerAssignDSP()
        {
            List<DeviceRow> dsp1 = new List<DeviceRow>();

            dsp1 = _DanteDevice.Where(p=>p.device == 2).ToList();

            if (dsp1.Count < 1)
                return;
            udpc1 = new udpClient();
            udpc1.OnReceiveMessage += Udpc1_OnReceiveMessage;
            udpc1.buf2.Clear();
            udpc1.rcv();


            /*
                        // 스피커 분리 처리
                        for (int i = 0; i < g.danteDevice._DanteDevice.Count; i++)
                        {
                            var t1 = g.danteDevice._DanteDevice[i];
                            if (t1.device != 0)
                                continue;

                            if (t1.ip == "")
                                continue;
                            byte[] b1 = g.etc.hexatobyte(dsp1.dsp_off_ch1);
                            udpc1.send(t1.ip, 4440, b1);
                            Thread.Sleep(50);
                        }
            */

            var sst1 = _DanteDevice.Where(p => p.device == 0).ToList();
            Console.WriteLine ("Assign Speaker :" + sst1.Count().ToString());
            int chno = 0;
            int dspno = 0;
            // 스피커에 DSP 채널 할당하고 이동 처리 
            for (int i = 0; i < sst1.Count; i++)
            {
                var t1 = sst1[i];
                if (t1.device != 0)
                    continue;

                if (t1.ip == "")
                    continue;
                chno++;
                // DSP 채널이 없으면 다음 DSP 로 할당 
                if (dsp1[dspno].chCount < chno)
                {
                    chno = 1;
                    dspno++;
                }
                if (dsp1.Count < (dspno + 1))
                {
                    g.Log("DSP channel check!!");
                    return;
                }
                if (dsp1[dspno].chCount > 16)
                {
                    t1.dsp_chno = chno;
                }
                else
                { 
                    t1.dsp_chno = chno + 16;
                }

                t1.dsp_name = dsp1[dspno].name;
                t1.ip_dspctrl = dsp1[dspno].ip_dspctrl;
                g.Log("Speaker Assign DSP Name Ch :" + t1.dsp_name + " : " + t1.dsp_chno.ToString());

                var t3 = _DanteDeviceDSPChnnels.Where(p=>p.DeviceId == dsp1[dspno].DeviceId).ToList();
                //byte[] b1 = gl.hexatobyte(dsp1[dspno].dsp_out_ch1[chno - 1]);
                byte[] b1 = gl.hexatobyte(t3[chno - 1].dsp_out_ch1);
                // 단테 컨트롤러 스피커 무브 
                // 스피커 IP, 포트번호, DSP Ch Out -> 271d~~
                udpc1.send(t1.ip, 4440, b1);
                Thread.Sleep(2000);
            }

            Thread.Sleep(500);
            udpc1.Close();

        }

        private static void Udpc1_OnReceiveMessage(string message)
        {
            Console.WriteLine("Rcv.." + udpc1.buf2.Count.ToString());
            udpc1.buf2.Clear();
        }

        // 사운드 카드 채널번호를 DSP할당 
        private void DSPinputChannelAssign()
        {
            udpc1 = new udpClient();
            udpc1.OnReceiveMessage += Udpc1_OnReceiveMessage;
            udpc1.buf2.Clear();
            udpc1.rcv();

            try
            {
                var sst2 = _DanteDevice.First(p => p.device == 9);
                if (sst2 == null)
                {
                    g.Log("Check Virtual Sound Card.. (ID:9)");
                    return;
                }
            }
            catch 
            {
                Console.WriteLine("Check Virtual Sound Card..");
                return;
            }
            var sst1 = _DanteDevice.Where(p => p.device == 9).ToList();
            var sst3 = _DanteDevice.Where(p => p.device == 2).ToList();

            string[] chno = { "01", "03", "05", "07", "09", "11", "13", "15" };

            foreach (var t1 in sst3)
            {
                if (t1.ip == "")
                    continue;

                for (int j = 0; j < 8; j++)
                {
                    Dante_DSP_PACKET tt1 = new Dante_DSP_PACKET();
                    tt1.hd = "2729";
                    tt1.seqn = 0x1f + j;
                    tt1.ch = "0100";
                    if(t1.chCount == 16)
                        tt1.ch = String.Format("{0:x2}", j + 1) + "00";
                    else
                        tt1.ch = String.Format("{0:x2}", j + 17) + "00";

                    tt1.n1 = chno[j];
                    tt1.n2 = sst1[0].DanteModelName; //  "DESKTOP-GT0TJBV"; //  "DSP-88D-13719a";
                    tt1.r3 = "0000000000000000000000000000";

                    Console.WriteLine("DSP Input Move : " + t1.ip + "/" + chno[j]);
                    string str2 = tt1.make_DSPin();
                    byte[] b1 = gl.hexatobyte(str2);
                    // DSP IP, port no, 2729
                    udpc1.send(t1.ip, 4440, b1);
                    Thread.Sleep(3000);

                }
            }
        }
        // 콤보 변경 
        private void _combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string t1 = (string)_combo.SelectedValue;

            var t2 = t1.Split(':');
            string t3 = t2[2];
            if (t3 == "이더넷") return;

            System.IO.File.WriteAllText("NetworkCardName.ini", t1);
            g.Log("Change Network : " + t3);
        }

        // DSP 찾기
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //g.resolver.ResolveServiceName2(g._netaudio_arc);
            g.Log("Find DSP Running..");
            FindDSP();
            gl.XMLDanteDevice(false);
            g.Log("Find DSP End..");
        }


        // DSP 에 사운드 카드 채널 할당 
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("DSP 장치 댓수에 따라 할당 시간이 변동적 입니다.", "관리자 전용", MessageBoxButton.OK);
            gl.XMLDanteDevice(true);
            DSPinputChannelAssign();
            g.Log("DSP에 사운드 카드 채널 할당을 종료 하였습니다.");
        }

        // DSP Out 에 스피커를 할당 
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Speaker 장치 댓수에 따라 할당 시간이 변동적 입니다.", "관리자 전용", MessageBoxButton.OK);
            gl.XMLDanteDevice(true);
            SpeakerAssignDSP();
            g.Log("DSP 출력 채널에 앰프 할당을 종료 하였습니다.");
        }

    }
}
