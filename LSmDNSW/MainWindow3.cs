using DataClass;
using gClass;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using Wisej.CodeProject;
using static Wisej.CodeProject.DataSet1;

namespace LSmDNSW
{
    public partial class MainWindow : Window
    {
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
        private void SpeakerAssignDSP()
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

                var t3 = _DanteDeviceDSPChnnels.Where(p => p.DeviceId == dsp1[dspno].DeviceId).ToList();
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

            string str1 = "a55a100000000000011200010000000000000000000000000000000000000000";
            byte[] b1 = gl.hexatobyte(str1);

            AThreadData aThreadData = new AThreadData();
            aThreadData.ip = "239.16.0.8";
            aThreadData.b1 = b1;
            aThreadData.LocalIP = Resolver.localIP;
            aThreadData.intfindx = Resolver.intfindx;
            bThread.AddData(aThreadData);
            Thread.Sleep(5000);

            LScap.g.CloseCap();
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
                        }
                    }
                }
            }
            findDSP = false;
        }

    }
}
