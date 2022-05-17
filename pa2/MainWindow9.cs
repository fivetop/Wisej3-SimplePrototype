using DataClass;
using gClass;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using static Wisej.CodeProject.DataSet1;

namespace pa
{
    //
    // 리시브 시그날알 처리 
    //
    public partial class MainWindow : Window
    {
        static System.Timers.Timer timer { get; set; } = new System.Timers.Timer(10000);

        public AThread aThread { get; set; } = new AThread();
        public BThread bThread { get; set; } = new BThread();


        public void Resolver_OnEventNewDevice(object o)
        {
            Device t2 = (Device)o;

            var t1 = gl.danteDevice._DanteDevice.Find(p => p.DeviceName == t2.DeviceName);

            if (t1 == null)
            {
                gl.danteDevice._DanteDevice.Add(t2);
                g.Log("Device : " + t2.ip.ToString() + " : " + t2.DeviceName);
                gl.XMLDanteDevice(false);
                //g.SendSigR("Find Device", eSignalRMsgType.eFindDSP, 0, 0);
            }
        }

        //=======================================================================================
        // 장비검색 부분 
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
            ScanAll();
        }

        public void ScanAll()
        {
            if (timer.Enabled == true)
                return;
            AThread.Stop();
            g.Log("Network Scan Timer Start..");
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Start();
        }

        static int case1 { get; set; } = 0;

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
            SaveDB();
        }

        public bool SaveDB()
        {
            g.division();
            gl.XMLDanteDevice(false);

            var gs1 = gl.danteDevice._DanteDevice.Where(p => p.device == 2);
            var gs2 = gl.danteDevice._DanteDevice.Where(p => p.device == 9);

            if (gs1.Count() < 1 || gs2.Count() < 1)
            {
                g.Log("DSP 혹은 버철사운드를 확인 바랍니다.");
                g.SendSigR("Find DSP",eSignalRMsgType.eFindDSP, 0,0);
                return false;
            }
            saveDBDSP_SC();
            saveDBSP();
            g.SendSigR("Find DSP", eSignalRMsgType.eFindDSP, 0, 1);
            AThread.Start();
            timer.Stop();
            g.Log("Svae DB : OK");
            return true;
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
                    var s1 = dBSqlite.Ds1.Device.FirstOrDefault(p => p.DeviceName == t1.DeviceName);
                    if (s1 != null)
                    {
                        continue;
                    }
                    DeviceRow m1 = dBSqlite.Ds1.Device.NewDeviceRow();
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
                    dBSqlite.Ds1.Device.Rows.Add(m1);
                }
                dBSqlite.Tam.DeviceTableAdapter.Update(dBSqlite.Ds1.Device);
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
                    var s1 = dBSqlite.Ds1.Device.FirstOrDefault(p => p.DeviceName == t1.DeviceName);
                    if (s1 == null)
                        continue;
                    t1.DeviceId = s1.DeviceId;
                    if (t1.ch.Count < 2)
                        continue;

                    var s2 = dBSqlite.Ds1.DeviceChannel.Where(p => p.DeviceId == t1.DeviceId).ToList();
                    if (s2.Count() > 0)
                        continue;

                    for (int i = 0; i < t1.ch.Count; i++)
                    {
                        DeviceChannelRow r1 = dBSqlite.Ds1.DeviceChannel.NewDeviceChannelRow();
                        r1.chno = t1.ch[i].chno;
                        r1.chname = t1.ch[i].chname[0];
                        r1.DeviceId = t1.DeviceId;
                        r1.dsp_out_ch1 = t1.dsp_out_ch1[i];
                        r1.dsp_out_ch2 = t1.dsp_out_ch2[i];
                        dBSqlite.Ds1.DeviceChannel.Rows.Add(r1);
                    }
                    dBSqlite.Tam.DeviceChannelTableAdapter.Update(dBSqlite.Ds1.DeviceChannel);
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
            DSPinputChannelAssign();
            g.Log("DSP에 사운드 카드 채널 할당을 종료 하였습니다.");
        }

        // DSP Out 에 스피커를 할당 
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Speaker 장치 댓수에 따라 할당 시간이 변동적 입니다.", "관리자 전용", MessageBoxButton.OK);
            DSPoutputChannelAssign();
            g.Log("DSP 출력 채널에 앰프 할당을 종료 하였습니다.");
        }

        //=======================================================================================
        // 선번장 등록 부분 
        //

        private void _btnMake_Click(object sender, RoutedEventArgs e)
        {
            var di1 = new DirectoryInfo(gl.appPathServer_speaker);
            var di2 = new DirectoryInfo(gl.appPathServer_image);

            if (di1.Exists == false)
                di1.Create();
            if (di2.Exists == false)
                di2.Create();

            foreach (var t1 in g._emspl.child)
            {
                string str2 = di1.FullName + t1.file;
                System.IO.File.Create(str2);
                System.Threading.Thread.Sleep(100);
                string str3 = di2.FullName + t1.array[0] + " " + t1.array[1] + " 층고유이름";
                System.IO.File.Create(str3);

                dBSqlite.SaveAssets(t1);
            }
            _txtBlock.Text = gl.appPathServer_speaker + g._emspl.child.Count.ToString() + "개 파일 생성이 완료 되었습니다.";
        }

        private void _btnFile_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Data Files|*.csv"
            };
            dlg.InitialDirectory = gl.appPathServer;
            if (dlg.ShowDialog() == true)
            {
                txtFileName.Text = dlg.FileName;

                string[] d1 = System.IO.File.ReadAllLines(dlg.FileName, Encoding.GetEncoding(949));

                g._emspl.child.Clear();
                foreach (var d2 in d1)
                {
                    EmSpeakerPosition em1 = new EmSpeakerPosition();
                    em1.array = d2.Split(',');
                    em1.file = em1.getfile();
                    g._emspl.child.Add(em1);
                }
                _lvLeft4.ItemsSource = null;
                _lvLeft4.ItemsSource = g._emspl.child;
                _lvLeft4.Items.Refresh();
            }
        }

        public void StatusContent(string v)
        {
            _Status.Content = v;
        }

        int oldindex = 0;

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t1 = (TabControl)sender;
            if (t1 == null) return;
            if (t1.SelectedIndex == oldindex) return;

            switch (t1.SelectedIndex)
            {
                case 0:
                    StatusContent("Main 화면 입니다.");
                    break;
                case 1:
                    StatusContent("앰프의 위치에 따른 DSP 채널을 지정할 경우 사용합니다.");
                    break;
                case 2:
                    StatusContent("초기 스피커 생성시 필요할 경우 사용합니다.");
                    break;
            }
            oldindex = t1.SelectedIndex;
        }


        //=====================================================================================
        // 채널 조정 
        //

        public string sel(string deviceName, long chspk)
        {
            string ret = "통신실";
            if (deviceName == "")
                return ret;
            var ret1 = dBSqlite.Ds1.Assets.FirstOrDefault(p => p.DeviceName == deviceName && p.ch == chspk);
            if (ret1 == null)
                return ret;
            ret = ret1.path;
            return ret;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var t1 = (sender as Button).DataContext as DeviceRow;
            if (t1 == null)
                return;
            if (_lv2.SelectedItem == null) return;
            ComboBox a1 = (ComboBox)_lv2.Columns[4].GetCellContent(_lv2.SelectedItem);
            ComboBox a2 = (ComboBox)_lv2.Columns[3].GetCellContent(_lv2.SelectedItem);
            if (a1.Text == "")
                return;
            int chno = int.Parse(a1.Text);
            string dspname = a2.Text;
            SpeakerAssignDSP(t1.DeviceName, dspname, chno);
        }

        // DSP 각 채널에 스피커를 할당한다. 
        private void SpeakerAssignDSP(string DeviceName, string dspname, int chno)
        {
            // 스피커와 DSP 를 가져온다. 
            int chno2 = chno;
            var src1 = _DanteDevice.FirstOrDefault(p => p.DeviceName == DeviceName);
            var dsp1 = _DanteDevice.FirstOrDefault(p => p.DeviceName == dspname);

            if (src1 == null)
                return;
            if (dsp1 == null)
                return;
            if (src1.ip == "")
                return;
            var t3 = dBSqlite.Ds1.DeviceChannel.Where(p => p.DeviceId == dsp1.DeviceId).ToList();
            if (t3.Count() < 1)
                return;

            if (dsp1.chCount < chno)
            {
                chno2 = chno - dsp1.chCount;
            }
            byte[] b1 = gl.hexatobyte(t3[chno2 - 1].dsp_out_ch1);
            //byte[] b1 = gl.hexatobyte(dsp1.dsp_out_ch1[chno2 - 1]);

            if (src1.chspk != 1)
            {
                b1[13] = (byte)src1.chspk;
            }

            AThreadData aThreadData = new AThreadData();
            aThreadData.ip = src1.ip;
            aThreadData.b1 = b1;
            aThread.AddData(aThreadData);

            src1.dsp_chno = chno;
            src1.dsp_name = dspname;
            src1.ip_dspctrl = dsp1.ip_dspctrl; //추적후 넣기 romee 2021-06-30
            dBSqlite.Tam.DeviceTableAdapter.Update(dBSqlite.Ds1.Device);
        }

        // 사운드 카드 채널번호를 DSP할당 
        private void DSPinputChannelAssign()
        {
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
                    if (t1.chCount == 16)
                        tt1.ch = String.Format("{0:x2}", j + 1) + "00";
                    else
                        tt1.ch = String.Format("{0:x2}", j + 17) + "00";

                    tt1.n1 = chno[j];
                    tt1.n2 = sst1[0].DanteModelName; //  "DESKTOP-GT0TJBV"; //  "DSP-88D-13719a";
                    tt1.r3 = "0000000000000000000000000000";

                    Console.WriteLine("DSP Input Move : " + t1.ip + "/" + chno[j]);
                    string str2 = tt1.make_DSPin();
                    byte[] b1 = gl.hexatobyte(str2);

                    AThreadData aThreadData = new AThreadData();
                    aThreadData.ip = t1.ip;
                    aThreadData.b1 = b1;
                    aThread.AddData(aThreadData);

                }
            }
        }

        // DSP 각 채널에 스피커를 할당한다. 
        private void DSPoutputChannelAssign()
        {
            List<DeviceRow> dsp1 = new List<DeviceRow>();

            dsp1 = _DanteDevice.Where(p => p.device == 2).ToList();

            if (dsp1.Count < 1)
                return;

            var sst1 = _DanteDevice.Where(p => p.device == 0).ToList();
            Console.WriteLine("Assign Speaker :" + sst1.Count().ToString());
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

                var t3 = dBSqlite.Ds1.DeviceChannel.Where(p => p.DeviceId == dsp1[dspno].DeviceId).ToList();
                //byte[] b1 = gl.hexatobyte(dsp1[dspno].dsp_out_ch1[chno - 1]);
                byte[] b1 = gl.hexatobyte(t3[chno - 1].dsp_out_ch1);
                // 단테 컨트롤러 스피커 무브 
                // 스피커 IP, 포트번호, DSP Ch Out -> 271d~~
                ///*
                AThreadData aThreadData = new AThreadData();
                aThreadData.ip = t1.ip;
                aThreadData.b1 = b1;
                aThread.AddData(aThreadData);
                //*/
            }
        }


        // 자동 처리 로직 
        // 1. dsp 찿기 
        // 2. 스피커 찾기 
        // 3. 사운드 카드 찾기 
        //

        // DSP 찾기
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();

            //g.resolver.ResolveServiceName2(g._netaudio_arc);
            g.Log("Find DSP Running..");
            FindDSP();
            gl.XMLDanteDevice(false);
            g.Log("Find DSP End..");
        }

        static bool findDSP = false;

        // DSP Control IP 는  239.16.0.8 에서 확인 요
        // 처음 설치시 한번 필요 
        public void FindDSP()
        {
            if (findDSP)
                return;

            findDSP = true;
            List<string> t21 = new List<string>();
            List<string> t31 = new List<string>();

            LScap.g.capData1.Clear();
            LScap.g.capData2.Clear();
            LScap.g.OpenCap();

            string str1 = "a55a100000000000011200010000000000000000000000000000000000000000";
            byte[] b1 = gl.hexatobyte(str1);

            AThreadData aThreadData = new AThreadData();
            aThreadData.ip = "239.16.0.8";
            aThreadData.b1 = b1;
            aThreadData.LocalIP = Resolver.localIP;
            aThreadData.intfindx = Resolver.intfindx;
            bThread.AddData(aThreadData);
            Thread.Sleep(5000);

            //LScap.g.CloseCap();
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

            foreach (var t5 in gl.danteDevice._DanteDevice)
            {
                if (t5.device == 9)
                {
                    g.Log("--------------------------------------------------------------------------------");
                    g.Log("Find Sound Card  : " + t5.ip_dspctrl + " " + t5.DeviceName);
                    g.Log("--------------------------------------------------------------------------------");
                }
                for (int i = 0; i < t31.Count; i++)
                {
                    if (t5.name == t31[i])
                    {
                        t5.ip_dspctrl = t21[i];

                        if (t5.ch.Count > 1)
                        {
                            g.Log("--------------------------------------------------------------------------------");
                            g.Log("Find DSP Controller IP : " + t5.ip_dspctrl + " " + t31[i]);
                            g.Log("--------------------------------------------------------------------------------");
                            SaveDB();
                        }
                    }
                }
            }
            findDSP = false;
        }
    }
}
