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
        static bool running = false;
        static System.Timers.Timer timer = new System.Timers.Timer(10000);
        static int case1 = 0;

        public List<int> dsp_vol { get; set; } = new List<int>() { };

        public List<string> purpose { get; set; } = new List<string>() { "예약가능", "중앙방송", "다원방송", "개별방송", "비상방송", "PRESET", "1번연동" };
        public List<string> division { get; set; } = new List<string>() { "일반","Dante"};// 구분 일반/단테

        public DeviceDataTable _DanteDevice { get; set; }
        public DeviceChannelDataTable _DanteDeviceDSPChnnels { get; set; }

        public AThread aThread = new AThread();

        public BThread bThread = new BThread();

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

            //DBCopy();

            init();
            initLeft();
            aThread.Start();
            bThread.Start();
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            aThread.Stop();
            Thread.Sleep(1000);

            bThread.Stop();
            Thread.Sleep(1000);
        }




        private void init()
        {
            List<string> dsp_name = new List<string>();

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
            }
            ComboBoxColumn1.ItemsSource = null;
            ComboBoxColumn1.ItemsSource = dsp_name;
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
        string LocalIP = "";
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
                LocalIP = t2.ipv4;
                g.Log("Local IP :" + t2.ipv4);

                g.resolver = new Resolver();
                g.resolver.OnReceiveMessage += Resolver_OnReceiveMessage;
                g.resolver.OnEventNewDevice += Resolver_OnEventNewDevice; 
            }
            catch (Exception e1)
            {
            }

            var d1 = _DanteDevice.Where(p => p.device == 2);

            if (d1.Count() < 1)
            {
                Log("DSP 가 없습니다. 1.Network Scan 버튼으로 확인바랍니다.");
            }

        }

        private void Resolver_OnEventNewDevice(object o)
        {
            Device t2 = (Device)o;

            var t1 = gl.danteDevice._DanteDevice.Find(p => p.DeviceName == t2.DeviceName);

            if (t1 == null)
            {
                gl.danteDevice._DanteDevice.Add(t2);
                g.Log("Device : " + t2.ip.ToString() + " : " + t2.DeviceName);
                gl.XMLDanteDevice(false);

            }
        }




        //=======================================================================================
        // 장비검색 부분 
        //
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
                            g.division();
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
            gl.XMLDanteDevice(false);

            var gs1 = gl.danteDevice._DanteDevice.Where(p => p.device == 2);
            var gs2 = gl.danteDevice._DanteDevice.Where(p => p.device == 9);

            if (gs1.Count() < 1 || gs2.Count() < 1)
            {
                g.Log("DSP 혹은 버철사운드를 확인 바랍니다.");
                return;
            }
            saveDBDSP_SC();
            saveDBSP();
        }

        private void saveDBSP()
        {
            var gs1 = gl.danteDevice._DanteDevice.ToList();
            saveDBDSP(gs1);
        }

        public void saveDBDSP_SC()
        {
            var gs1 = gl.danteDevice._DanteDevice.Where(p => p.device == 2);
            var gs2 = gl.danteDevice._DanteDevice.Where(p => p.device == 9);

            saveDBDSP(gs1);
            saveDBDSP(gs2);
            saveDBDSPCH(gs1);
        }

        // dsp , sound card 저장
        private void saveDBDSP(IEnumerable<Device> gs1)
        {
            try
            {
                foreach (var t1 in gs1)
                {
                    var s1 = g.dBSqlite.ds1.Device.FirstOrDefault(p => p.DeviceName == t1.DeviceName);
                    if (s1 != null)
                    {
                        continue;
                    }
                    DeviceRow m1 = g.dBSqlite.ds1.Device.NewDeviceRow();
                    m1.DanteModelName = t1.DanteModelName;
                    m1.DeviceName = t1.DeviceName;
                    m1.device = t1.device;
                    m1.ip = t1.ip;
                    m1.ip_dspctrl = t1.ip_dspctrl;
                    m1.name = t1.name;
                    m1.chCount = t1.ch.Count();
                    m1.chspk = 0;
                    m1.dsp_chno = 0;
                    m1.dsp_name = "";
                    m1.dsp_vol = 0;
                    m1.dsp_vol_em = 0;
                    m1.emData = "";
                    m1.floor_em = 0;
                    m1.path = "";
                    g.dBSqlite.ds1.Device.Rows.Add(m1);
                }
                g.dBSqlite.Tam.DeviceTableAdapter.Update(g.dBSqlite.ds1.Device);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        // dsp 저장후 상세정보 저장 
        // dsp ch info 저장 
        private void saveDBDSPCH(IEnumerable<Device> gs1)
        {
            try
            {
                foreach (var t1 in gs1)
                {
                    var s1 = g.dBSqlite.ds1.Device.FirstOrDefault(p => p.DeviceName == t1.DeviceName);
                    if (s1 == null)
                        continue;
                    t1.DeviceId = s1.DeviceId;
                    if (t1.ch.Count < 2)
                        continue;

                    var s2 = g.dBSqlite.ds1.DeviceChannel.Where(p => p.DeviceId == t1.DeviceId).ToList();
                    if (s2.Count() > 0)
                        continue;

                    for (int i = 0; i < t1.ch.Count; i++)
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
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
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
