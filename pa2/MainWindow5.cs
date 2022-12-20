using DataClass;
using gClass;
using pa.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Threading;
using simplepa2;
using static simplepa2.DataSet1;

namespace pa
{
    // v2 update ok

    /// 시리얼 포트 처리 로직 
    /// 1. GPIO, 프리셋 처리 
    /// 2. P 형 수신 알람처리 테스트 모듈
    /// 3. R 형 수신 알람처리 테스트 모듈
    /// 4. USB 탈부착 감지 처리 
    /// 
    public partial class MainWindow : Window
    {
        // GPIO 프리셋 스위치 및 테스트 버튼 처리 
        // P형 처리, R형 처리 

        // em_status : 1 ~ 6  수신기 화재 1, 수신기 복구 2, 시험용 3, 시험용 복구 4, 가스 5, 가스 복구 6
        // v2 : T, 1, 2, 3 , T 시험용, 1 P형, 2 R형 10, 3 R형 12 
        // v3 : p형 층 
        // str1 : P 형 low data 
        // t1 : packet 

        #region // 알람처리 
        private void Fire_Alarm(int em_status, string v2, string v3, string prowdata, pktr t1)
        {
            string event_text = "";
            string log = "";
            em_status = em_status;
            CommState("");
            msg pkt = new msg("F", em_status.ToString(), v2, v3, prowdata);
            //s1.Send(pkt.pkt);
            run_pktr = t1;

            try
            {
                if (prowdata == "")
                {
                    if (run_pktr != null)
                        prowdata = run_pktr.cmdList.log;
                    else
                        prowdata = "";
                }
            }
            catch (Exception e1)
            {
                prowdata = "";
            }

            string str1;

            switch (em_status)
            {
                case 1:
                    TestAlarm = false;
                    Alarm = Alarm + 1;
                    write_ini(true);

                    if (v2 == "1")
                    {
                        event_text = v3 + "층";
                        log = "발생:";
                    }
                    else
                    {
                        pktr pktr1 = new pktr(pkt.src);
                        event_text = pktr1.log; // dv1.array[2];
                    }
                    //FireEventDisplay();
                    str1 = "화재발생 신호를 수신하였습니다." + pkt.src;
                    g.Log(str1);

                    SendSigR(str1, eSignalRMsgType.eEM_FIRE, 1, int.Parse(v3));
                    EMBSOn();
                    break;
                case 2:
                    TestAlarm = false;

                    if (Alarm > 0)
                    {
                        Alarm = 0;
                        write_ini(true);
                        EMBSOff();
                        // 볼륨 초기화 처리  
                        InitVolume();

                        str1 = "화재복구 신호를 수신하였습니다." + pkt.src;
                        g.Log(str1);
                        SendSigR(str1, eSignalRMsgType.eEM_FIRE, 2, 0);
                    }

                    if (run_pktr == null)
                    {
                        log = "복구:";
                    }
                    else
                    {
                        switch (run_pktr.em_Data.CMD)
                        {
                            case "R":
                                event_text = "전체복구";
                                break;
                            case "F":
                                event_text = t1.log;
                                break;
                            case "N":
                                event_text = t1.log;
                                break;
                            case "E":
                                event_text = "연동정지";
                                break;
                            case "e":
                                event_text = "연동정상";
                                break;
                        }
                    }
                    break;
                case 3:
                    //if (g.Alarm) return;
                    TestAlarm = true;
                    write_ini(true);
                    str1 = "시험용 화재발생 신호를 수신하였습니다." + pkt.pkt;
                    g.Log(str1);
                    event_text = "0층 시험용";
                    UpdateStatusbar("0층", "시험용", "정상");
                    log = "발생:";
                    EMBSOn();
                    SendSigR(str1, eSignalRMsgType.eEM_FIRE, 3, 0);
                    //FireEventDisplay();
                    break;
                case 4:
                    if (TestAlarm)
                    {
                        TestAlarm = false;
                        // 테스트 버튼 복구시 비상방송도 복구 ??
                        Alarm = 0;
                        write_ini(true);
                        EMBSOff();
                        // 볼륨 초기화 처리  
                        InitVolume();
                        str1 = "시험용 화재복구 신호를 수신하였습니다." + pkt.pkt;
                        g.Log(str1);
                        SendSigR(str1, eSignalRMsgType.eEM_FIRE, 4, 0);
                    }
                    log = "복구:";
                    event_text = "0층 시험용";
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }

            string type1 = "";
            switch (v2)
            {
                case "T": type1 = "시험용"; break;
                case "1": type1 = "P형 "; break;
                case "2": type1 = "R형10"; break;
                case "3": type1 = "R형12"; break;
            }

            _write_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _event_text.Text = event_text;
            if (t1 != null)
                _event_content.Text = t1.cmdList.log;
            else
                _event_content.Text = "화재 신호 수신";

            try
            {
                string str2 = event_text + "~" + type1 + "~" + log + type1 + prowdata;
                //g.Log(str2);
                dBAccess.Eventvms(event_text, type1, log + type1 + prowdata);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }


        #endregion

        #region // 시리얼 P 형 수신기 처리 
        // P, R 형 수신기 로직 처리 추가 
        public void OpenP()
        {
            if (spP.IsOpen == true)
            {
                spP.Close();
                //return;
            }
            spP.PortName = g._BaseData.GPIOPort; // .sim "COM3";
            spP.BaudRate = 115200;
            spP.DataBits = 8;
            spP.Parity = Parity.None;
            spP.StopBits = StopBits.One;

            spP.DataReceived += new SerialDataReceivedEventHandler(SpP_DataReceived);

            EMServerRow.com_gpio = g._BaseData.GPIOPort;
            try
            {
                spP.Open();
                //sp.Write("gpio iodir ffffffff");
                //spP.WriteLine("gpio iodir ffffffff");
                g.Log("Comm Port EM Open : " + spP.PortName);
                //sendErr(0xC1);
                //sendErr(0x31);
                EMServerRow.com_gpio_state = 1;
            }
            catch (IOException e1)
            {
                EMServerRow.com_gpio_state = 0; 
                g.Log("Comm Port EM Error...." + e1.Message);
            }
        }

        private void sendErr(byte v1)
        {
            byte[] pkt = new byte[17];
            pkt[0] = v1;

            for (int i = 1; i < 17; i++)
            {
                pkt[i] = 0xFF;
            }
            pkt[8] = 0x20;
            try
            {
                if (spP.IsOpen)
                    spP.Write(pkt, 0, 17);
            }
            catch (Exception e1)
            {
                g.Log("Comm Port Error...." + e1.Message);
            }
            string str1 = BitConverter.ToString(pkt).Replace("-", string.Empty);
            str1 = str1.Replace("20", " ");
            //Console.WriteLine("Send>" + str1);
            //g.Log("Send>" + str1);
        }

        List<byte[]> rcvBuf = new List<byte[]>();

        private void SpP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int rcvsize = spP.BytesToRead;
            string str1 = string.Empty;

            if (rcvsize < 17)
            {
                //Console.WriteLine("RX Size : " + rcvsize.ToString());
                return;
            }

            byte[] buf = new byte[rcvsize];
            spP.Read(buf, 0, rcvsize);

            try
            {
                if (buf.Length > 17)
                {
                    makeData(buf);
                }
                else
                {
                    rcvBuf.Add(buf);
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }

            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                for (int i = 0; i < rcvBuf.Count; i++)
                {
                    this.ReceiveProcessTypeP(i);
                }
                rcvBuf.Clear();

            }));
        }

        private void makeData(byte[] buf2)
        {
            for (int i = 0; i < buf2.Length; i++)
            {
                if (buf2[i] == 0x20)
                {
                    if (i > 7)
                    {
                        byte[] buf3 = new byte[17];
                        Buffer.BlockCopy(buf2, i - 8, buf3, 0, 17);
                        rcvBuf.Add(buf3);
                        i = i + 8;
                        Console.WriteLine(bytetostring(buf3));
                    }
                }
                if (i + 8 > buf2.Length)
                {
                    break;
                }
            }
            /*
                        byte[] buf3 = new byte[17];
                        Buffer.BlockCopy(buf2, i, buf3, 0, 17);
                        i = i + 16;
                        if (buf2.Length < 17)
                        {
                            Console.WriteLine("RX Buf Size : " + buf2.Length.ToString());
                            return;
                        }
                        rcvBuf.Add(buf2);

                        Console.WriteLine("RX Size : " + rcvsize.ToString());
                        Console.WriteLine(bytetostring(buf));
                        //return;
            */
        }

        public string bytetostring(byte[] t)
        {
            string ret = string.Empty;

            ret = string.Concat(Array.ConvertAll(t, byt => byt.ToString("x2")));
            return ret;
        }

        string Myoldbstr = "1111111111111111111111111111111111000000000000000000000000000000";

        // GPIO 에서 들어오는 프리셋 스위치/테스트 버튼  처리 포함 
        private void ReceiveProcessTypeP(int po)
        {
            string str1 = string.Empty;
            string newbstr = string.Empty;
            string oldbstr = string.Empty;

            byte[] buf = rcvBuf[po];

            if (buf[8] != 0x20)
            {
                g.Log("Data Err.." + bytetostring(buf));
                return;
            }
            byte[] newb = new byte[8];
            byte[] oldb = new byte[8];

            Buffer.BlockCopy(buf, 0, newb, 0, 8);
            Buffer.BlockCopy(buf, 9, oldb, 0, 8);

            //if(rcvBuf.Count > 0)
            //    rcvBuf.RemoveAt(0);

            foreach (byte b in newb)
            {
                string s = Convert.ToString(b, 2);
                newbstr += s.PadLeft(8, '0');
            }

            foreach (byte b in oldb)
            {
                string s = Convert.ToString(b, 2);
                oldbstr += s.PadLeft(8, '0');
            }
            str1 = BitConverter.ToString(buf).Replace("-", string.Empty);
            str1 = str1.Replace("20", " ");
            //Console.WriteLine("spP=>" + str1);
            // 스페이스 체크, 없으면 에러처리 
            if (str1[16] != ' ')
                return;
            if (str1[5] != 'F' || str1[6] != 'F' || str1[7] != 'F')
            {
                g.Log("Data Err!" + str1);
                return;
            }
            if (str1.Length != 33)
                return;
            //g.Log("spP=>" + str1);
            //Console.WriteLine("spP=>" + str1);
            byte b1 = 0;

            List<int> chkl = stringCompare(newbstr, oldbstr);
            //Console.WriteLine("Change " + chk.ToString());

            // 물리적인 에러로 이전 상태가 시스템과 다르면 저장된 이전 상태하고 비교하여 처리 하기 
            if (Myoldbstr != oldbstr)
            {
                chkl = stringCompare(newbstr, Myoldbstr);
            }
            if (newbstr[7] == '0' && newbstr[8] == '0')
            {
                g.Log("Data Err!" + str1);
                return;
            }
            if (str1[3] == 'F' || str1[4] == 'F')
            {
                g.Log("Data Err!" + str1);
                return;
            }
            Myoldbstr = newbstr;
            //_comm_led.IsChecked = true;
            CommState("");
            g.Log("spP=>" + str1);

            try
            {
                foreach (int chk in chkl)
                {
                    // 0 ~ 8 // Error LED, Fire LED // 프리셋 all, 1, 2, 3, 4 // test 7, 8
                    if (chk < 9)
                    {
                        checkPreset(newbstr, chk, str1);
                    }

                    // 12 ~ 19 P형 수신기 포트수 12~15 10자리, 16~19 단자리  
                    if (g._BaseData.Pport == 0 && g._BaseData.Rport == "")
                    {
                        switch (chk)
                        {
                            case int n when (n > 11 && n < 20):
                                string st1 = str1[3].ToString();
                                int i1 = int.Parse(st1) * 10;
                                string st2 = str1[4].ToString();
                                int i2 = int.Parse(st2);
                                g._BaseData.Pport = i1 + i2;
                                break;
                        }
                    }
                    else
                    {
                        switch (chk)
                        {
                            // 34 ~ 63 P 형 포트  
                            // case 34 - 63:
                            case int n when (n > 33 && n < 64):
                                int cnt = chk - 33;
                                if (GetBit(newbstr, chk) == 0)
                                {
                                    g.Log(cnt.ToString() + "P형 : On");
                                    Fire_Alarm(1, "1", cnt.ToString(), str1, null);
                                }
                                break;
                        }
                    }

                }
            }
            catch (Exception e1)
            {
                g.Log(e1.Message);
            }
            GC.SuppressFinalize(this);
            return;
        }

        private void checkPreset(string newbstr, int chk, string str1)
        {
            switch (chk)
            {
                // Error LED, Fire LED
                case 0:
                case 1:
                    break;
                // 프리셋 all, 1, 2, 3, 4
                case 2:
                    if (GetBit(newbstr, chk) == 1)
                    {
                        g.Log("All 프리셋 버튼 : Off");
                        //_a1.IsChecked = false;
                        g.DSP_MakeGroupSpeaker(null, 0, BS_DSP_STATE.PRESET_ALL);
                        Preset_chk();
                        SendSigR("All 프리셋 버튼 : Off", eSignalRMsgType.eEM_PRESET_SW, 0, 0);
                        dBAccess.Eventvms("eEM_PRESET_SW", "All 프리셋 버튼 : Off", "OFF");
                    }
                    else
                    {
                        g.Log("All 프리셋 버튼 : On");
                        //_a1.IsChecked = true;
                        g.DSP_MakeGroupSpeaker(null, 1, BS_DSP_STATE.PRESET_ALL);
                        SendSigR("All 프리셋 버튼 : On", eSignalRMsgType.eEM_PRESET_SW, 0, 1);
                        dBAccess.Eventvms("eEM_PRESET_SW", "All 프리셋 버튼 : On", "ON");
                    }
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    string sh = "PRESET";
                    int cnt = chk - 2;
                    if (GetBit(newbstr, chk) == 1)
                    {
                        g.Log(cnt.ToString() + "번 프리셋 버튼 : Off");
                        sh = sh + cnt.ToString();
                        //Tam.AssetGroupsTableAdapter.Fill(Ds1.AssetGroups);
                        var t1 = dBAccess.AssetGroups.FirstOrDefault(p => p.Name == sh);
                        if (t1 == null)
                        {
                            g.Log("Check : 프리셋 그룹");
                            return;
                        }
                        switch (cnt)
                        {
                            //case 1: _a2.IsChecked = false; break;
                            //case 2: _a3.IsChecked = false; break;
                            //case 3: _a4.IsChecked = false; break;
                            //case 4: _a5.IsChecked = false; break;
                        }
                        // make asset array to assetbase 
                        //g.DSP_MakeGroupSpeaker(t1.child.ToList(), 0, BS_DSP_STATE.PRESET);
                        Preset_chk();
                        SendSigR("프리셋 버튼 : Off", eSignalRMsgType.eEM_PRESET_SW, cnt, 0);
                        dBAccess.Eventvms("eEM_PRESET_SW", cnt.ToString() + "번 프리셋 버튼 : Off", "OFF");
                    }
                    else
                    {
                        g.Log(cnt.ToString() + "번 프리셋 버튼 : On");
                        sh = sh + cnt.ToString();
                        //Tam.AssetGroupsTableAdapter.Fill(Ds1.AssetGroups);
                        var t1 = dBAccess.AssetGroups.FirstOrDefault(p => p.Name == sh);
                        if (t1 == null)
                        {
                            g.Log("Check : 프리셋 그룹");
                            return;
                        }
                        switch (cnt)
                        {
                            //case 1: _a2.IsChecked = true; break;
                            //case 2: _a3.IsChecked = true; break;
                            //case 3: _a4.IsChecked = true; break;
                            //case 4: _a5.IsChecked = true; break;
                        }
                        // make asset array to assetbase 
                        //g.DSP_MakeGroupSpeaker(t1.child.ToList(), 1, BS_DSP_STATE.PRESET);
                        SendSigR("프리셋 버튼 : On", eSignalRMsgType.eEM_PRESET_SW, cnt, 1);
                        dBAccess.Eventvms("eEM_PRESET_SW", cnt.ToString() + "번 프리셋 버튼 : On", "ON");
                    }
                    break;
                // EM Test
                case 7:
                    if (GetBit(newbstr, chk) == 1)
                        break;
                    if (TestAlarm) // 실행중이면 리턴 
                        return;
                    Fire_Alarm(3, "T", "0", str1, null);
                    break;
                // EM Test Recovery 화재 LED Off
                case 8:
                    if (TestAlarm == false) // 종료 상태면 리턴 
                        return;
                    Fire_Alarm(4, "T", "0", str1, null);
                    g.Log(chk.ToString() + " 복구");
                    break;
                    // 9 ~ 11 사용하지 않음 
                    // 12 ~ 19 P형 수신기 포트수 12~15 10자리, 16~19 단자리  
                    // 9 ~ 33 사용하지 않음 
            }
        }


        // Preset SW 4번을 EM mic 로 사용함 - 최
        private void MicChannel(bool v)
        {
            // 종료인 경우 
            if (v == false)
            {
                foreach (var t1 in cur_embs_device)
                {
                    if (t1.device != 2)
                        continue;
                    for (int j = 1; j < 32; j++)
                    {
                        g.dsp.Matrix(0, j, 0, t1.ip_dspctrl);
                    }
                }
                return;
            }

            // 직상 발화가 아닌경우 
            if (g._BaseData.Jigsangbalhwa != 2)
            {
                foreach (var t1 in cur_embs_device)
                {
                    if (t1.device != 2)
                        continue;
                    for (int j = 1; j < 32; j++)
                    {
                        g.dsp.Matrix(0, j, 1, t1.ip_dspctrl);
                    }
                }
                return;
            }
            else
            {
                // 직상 발화인 경우 
                foreach (var t1 in cur_embs_device)
                {
                    g.dsp.Matrix(0, t1.dsp_chno, 1, t1.ip_dspctrl);
                }
            }
        }

        // 다른 스위치 오프시 다른거 열린거만 다시  온 
        private void Preset_chk()
        {
            /*
            if (_a2.IsChecked == true)
            {
                var t1 = gl._AssetGroupList.child.Find(p => p.Name == "PRESET1");
                if (t1 == null)
                    return;
                g.DSP_MakeGroupSpeaker(t1.child, 1, BS_DSP_STATE.PRESET);
            }

            if (_a3.IsChecked == true)
            {
                var t1 = gl._AssetGroupList.child.Find(p => p.Name == "PRESET2");
                if (t1 == null)
                    return;
                g.DSP_MakeGroupSpeaker(t1.child, 1, BS_DSP_STATE.PRESET);
            }

            if (_a4.IsChecked == true)
            {
                var t1 = gl._AssetGroupList.child.Find(p => p.Name == "PRESET3");
                if (t1 == null)
                    return;
                g.DSP_MakeGroupSpeaker(t1.child, 1, BS_DSP_STATE.PRESET);
            }

            if (_a5.IsChecked == true)
            {
                var t1 = gl._AssetGroupList.child.Find(p => p.Name == "PRESET4");
                if (t1 == null)
                    return;
                g.DSP_MakeGroupSpeaker(t1.child, 1, BS_DSP_STATE.PRESET);
            }
            */

        }
        #endregion

        #region // 시리얼 R 형 수신기 처리 

        public void OpenR()
        {
            if (g._BaseData.Rport == "")
            {
                g.Log("R형 없음..");
                return;
            }
            if (spR.IsOpen == true)
            {
                spR.Close();
                //return;
            }
            spR.PortName = g._BaseData.Rport;  // .sim "COM3";
            spR.BaudRate = 9600;                // R형 수신기 9600
            spR.DataBits = 8;
            spR.Parity = Parity.None;
            spR.StopBits = StopBits.One;

            spR.DataReceived += new SerialDataReceivedEventHandler(SpR_DataReceived);

            EMServerRow.com_Rtype = g._BaseData.Rport;

            try
            {
                spR.Open();
                g.Log("Comm Port R형 Open : " + spR.PortName);
                EMServerRow.com_Rtype_state = 1;
            }
            catch (Exception e1)
            {
                g.Log("Comm Port R형 Error...." + e1.Message);
                EMServerRow.com_Rtype_state = 0;
            }
        }

        private void SpR_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                this.ReceiveProcessTypeR(this.spR);
            }));
        }

        List<pktr> pktList = new List<pktr>();
        List<pktr> pktListSave = new List<pktr>();
        byte[] rx_data = new byte[1024];
        byte cnt = 0;
        public void ReceiveProcessTypeR(SerialPort sp)
        {
            Thread.Sleep(50);
            int rx = sp.BytesToRead;
            byte[] trx = new byte[rx];

            int rx1 = sp.Read(trx, 0, rx);

            //Console.WriteLine(bytetostring(trx));

            for (int i = 0; i < rx1; i++)
            {
                switch (trx[i])
                {
                    case (byte)COMM_ASC.STX:
                        cnt = 0;
                        rx_data[cnt] = (byte)COMM_ASC.STX;
                        break;
                    case (byte)COMM_ASC.ETX:
                        rx_data[cnt] = (byte)COMM_ASC.ETX;

                        if (cnt == 8 && trx.Length == 10)
                        {
                            cnt++;
                            rx_data[cnt] = trx[i + 1];
                        }
                        pktr pktr1 = new pktr(rx_data, cnt);

                        if (pktr1.checkSUM() == false)
                        {
                            SendNACK(sp);
                            return;
                        }

                        pktList.Add(pktr1);
                        Rtype_Analyzer();
                        SendACK(sp);
                        break;
                    case (byte)COMM_ASC.ACK:
                        Console.WriteLine("Rx Ack");
                        CommState("Rx Ack");
                        break;
                    case (byte)COMM_ASC.NACK:
                        Console.WriteLine("Rx NAck");
                        CommState("Rx NAck");
                        break;
                    default:
                        if (trx[i] < 0x20) // " " 스페이스 0x20  이 외의 제어 코드는 무시 처리 
                            break;
                        rx_data[cnt] = trx[i];
                        break;
                }
                cnt++;
            }
        }

        public void ReceiveProcessTypeRLoopback(byte[] pkt)
        {
            int rx = 12;
            byte[] trx = pkt;

            int rx1 = 12;

            //Console.WriteLine(bytetostring(trx));

            for (int i = 0; i < rx1; i++)
            {
                switch (trx[i])
                {
                    case (byte)COMM_ASC.STX:
                        cnt = 0;
                        rx_data[cnt] = (byte)COMM_ASC.STX;
                        break;
                    case (byte)COMM_ASC.ETX:
                        rx_data[cnt] = (byte)COMM_ASC.ETX;

                        if (cnt == 8 && trx.Length == 10)
                        {
                            cnt++;
                            rx_data[cnt] = trx[i + 1];
                        }
                        pktr pktr1 = new pktr(rx_data, cnt);

                        pktList.Add(pktr1);
                        Rtype_Analyzer();
                        break;
                    case (byte)COMM_ASC.ACK:
                        Console.WriteLine("Rx Ack");
                        break;
                    case (byte)COMM_ASC.NACK:
                        Console.WriteLine("Rx NAck");
                        break;
                    default:
                        if (trx[i] < 0x20) // " " 스페이스 0x20  이 외의 제어 코드는 무시 처리 
                            break;
                        rx_data[cnt] = trx[i];
                        break;
                }
                cnt++;
            }
        }

        private void Rtype_Analyzer()
        {
            if (pktList.Count < 1)
                return;

            run_pktr = pktList.ElementAt(0);
            string str1 = "";

            switch (run_pktr.size)
            {
                case 10:
                    run_pktr.cmdList.CMD10Byte();
                    run_pktr.cmdList.Log(run_pktr.size, run_pktr.em_Data.CMD, run_pktr.GB);
                    switch (run_pktr.em_Data.CMD)
                    {
                        case "A": Fire_Alarm(2, "2", "0", run_pktr.tot, run_pktr); break;
                        case "C": Fire_Alarm(2, "2", "0", run_pktr.tot, run_pktr); break;
                        case "F": Fire_Alarm(1, "2", "0", run_pktr.tot, run_pktr); break;
                        case "B":
                            eM_MODE = EM_MODE.연동정지;
                            Fire_Alarm(2, "2", "0", run_pktr.tot, run_pktr);
                            break;
                        case "D":
                            eM_MODE = EM_MODE.연동정상;
                            Fire_Alarm(2, "2", "0", run_pktr.tot, run_pktr);
                            break;
                    }
                    break;
                case 12:
                    run_pktr.cmdList.Log(run_pktr.size, run_pktr.em_Data.CMD, " ");
                    switch (run_pktr.em_Data.CMD)
                    {
                        case "R": // 전체복구
                            if (eM_MODE == EM_MODE.연동정지)
                            {
                                // 연동 정지중 전체 복구가 들어오면 수신된 방송 삭제 처리  
                                pktListSave.Clear();
                            }
                            Fire_Alarm(2, "3", "0", run_pktr.tot, run_pktr);
                            // 메트릭스와 볼류 초기 처리 
                            // g.DSP_metrix_initial(0);
                            break;
                        case "F": Fire_Alarm(2, "3", "0", run_pktr.tot, run_pktr); break;
                        case "N":
                            Fire_Alarm(1, "3", "0", run_pktr.tot, run_pktr);
                            if (eM_MODE == EM_MODE.연동정지)
                            {
                                // 연동 정지중 수신된 방송은 연동 정상 후 방송 처리 
                                pktListSave.Add(run_pktr);
                            }
                            break;
                        case "E":
                            eM_MODE = EM_MODE.연동정지;
                            Fire_Alarm(2, "3", "0", run_pktr.tot, run_pktr);
                            break;
                        case "e":
                            eM_MODE = EM_MODE.연동정상;
                            Alarm = 0;
                            _event_text.Text = "연동정상";
                            _event_content.Text = "연동복구";

                            // 저장된 방송을 시작 한다. 
                            foreach (pktr rr in pktListSave)
                            {
                                Fire_Alarm(1, "3", "0", rr.tot, rr);
                            }

                            if (pktListSave.Count == 0)
                            {
                                Fire_Alarm(2, "3", "0", run_pktr.tot, run_pktr);
                            }
                            break;
                    }
                    break;
            }
            pktList.RemoveAt(0);
        }


        private void SendACK(SerialPort sp)
        {
            if (sp == null)
                return;
            byte[] b1 = new byte[2];
            b1[0] = (byte)COMM_ASC.ACK;
            //sp.WriteLine(st1);
            sp.Write(b1, 0, 1);
            Console.WriteLine("Send Ack.");
        }

        private void SendNACK(SerialPort sp)
        {
            byte[] b1 = new byte[2];
            b1[0] = (byte)COMM_ASC.NACK;
            //sp.WriteLine(st1);
            sp.Write(b1, 0, 1);
        }

        #endregion

        #region // P형 수신기 테스트  


        private void Testimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                CommState("", true);

                switch (test)
                {
                    case 0: sendErr(0xFF); break; // off
                    case 1: sendErr(0xBF); break; // err
                    case 2: sendErr(0xFF); break; // off
                    case 3: sendErr(0x7F); break; // fire
                    case 4: sendErr(0xFF); break; // off
                    case 5: sendErr(0x3F); break; // err, fire
                }

                //Console.WriteLine(test.ToString());
                test++;
                if (test > 5)
                    test = 0;
            }));
        }

        private void GPIOtimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                //CommState("", true);
                sendErr(0xFF);
            }));
        }


        #endregion

        #region // R형 수신기 테스트  

        private void StatusBarItem_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendACK(this.spR);
        }




        #endregion

        // 시스템에서 호출됨
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            HwndSource source = PresentationSource.FromVisual(this) as HwndSource;
            source.AddHook(WndProc);
        }

        // USB Serial 감지 
        // 강제적으로 통신 두절시 OFF
        // 연결시 ON
        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg != 537)
                return IntPtr.Zero;
            long l4 = wParam.ToInt64();
            Console.WriteLine(msg.ToString() + " : " + l4.ToString());
            switch (l4)
            {
                case 0x8000:
                    g.Log("Device Detect USB..");
                    OpenP();
                    break;
                case 0x8004:
                    g.Log("Device Disconnected..");
                    break;
            }
            return IntPtr.Zero;
        }


        #region // 비상방송 및 서버 메시지 처리  
        // 상태바 출력하기 
        // GPIO 타이머 5초 마다 상태 점검 처리 
        public int GPIOResponse { get; set; }

        private void CommState(string s1, bool off = false)
        {
            GPIOResponse++;
            if (GPIOResponse > 9)
                GPIOResponse = 0;

            _comm_state.Text = "정상:" + s1 + GPIOResponse.ToString();

            if (eM_MODE == EM_MODE.연동정지)
                _comm_state.Text = "연동정지:정상:" + s1;

            if (off)
                _comm_state.Text = "";
        }

        private void UpdateStatusbar(string log, string v, string v1)
        {
            DateTime t1 = DateTime.Now;
            _write_time.Text = t1.ToString("yyyy-MM-dd (ddd) HH:mm:ss");
            _event_text.Text = log;
            _event_content.Text = v;

            _comm_state.Text = v1;

            if (eM_MODE == EM_MODE.연동정지)
                _comm_state.Text = "연동정지:정상:" + v1;
        }

        void write_ini(bool rw)
        {
            return;
        }
        #endregion

    }
}
