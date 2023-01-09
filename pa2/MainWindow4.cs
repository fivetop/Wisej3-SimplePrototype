using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows;

namespace pa
{
    using DataClass;
    using gClass;
    using static simplepa2.DataSet1;

    // v2 update ok
    public partial class MainWindow : Window
    {
        // EM 전용처리 - 층별 처리 포함 
        // 오디오 처리 
        #region // play 처리 NAUDIO 
        List<DeviceRow> cur_embs_device { get; set; } = new List<DeviceRow>();
        List<DeviceRow> em_play { get; set; } = new List<DeviceRow>();

        public void EMBSOn()
        {
            // 기존 방송 쓰레드에 걸린내용이 있으면 클리어... 
            //BSThreadClass.EmClear();
            // 비상방송 연동정지시 방송 처리 안함. 
            if (eM_MODE == EM_MODE.연동정지)
                return;

            if (_DanteDevice != null)
            {
                EMMetrixChOn();
                InitVolume(true);
            }
            else
            {
                // 서버가 없으면 강제 방송 처리 
                var splist1 = gl.danteDevice._DanteDevice.Where(p => p.device == 2).ToList();

                foreach (Device sp1 in splist1)
                {
                    try
                    {
                        if (sp1 == null) continue;
                        if (sp1.ip == "" || sp1.ip_dspctrl == "") continue;
                        Console.WriteLine("--" + "DSP Metrix Out ==> In :" + sp1.ip_dspctrl);

                        for (int i = 17; i < 33; i++)
                        { 
                            g.dsp.Matrix(16, i, 1, sp1.ip_dspctrl);
                            Thread.Sleep(10);
                        }
                        //g.dsp.makeVolumn(17, 10, sp1.ip_dspctrl);
                    }
                    catch (Exception e1)
                    {
                    }
                }

            }

            // 연속적인 알람은 
            if (Alarm == 1 || TestAlarm)
            {
                PlayChildProcess(1, 999999);
            }
        }

        // 메트릭스 입력 채널에 아웃 채널을 연결 
        private void EMMetrixChOn()
        {
            cur_embs_device.Clear();
            List<DeviceRow> d1 = null;

            var sst1 = _DanteDevice.Where(p => p.device == 2).ToList();

            // 직상층 발화 조건이 있으면 
            if (g._EMClient.Jigsangbalhwa == 1 && run_pktr != null)
            {
                var emd = run_pktr.em_Data;
                emd.getemData();
                d1 = _DanteDevice.Where(p => p.device == 0).ToList();

                switch (emd.cc)
                {
                    case 0: // 지하인경우 지하층 모두, 1층
                        d1 = d1.Where(p => p.floor_em == 0 || p.floor_em == 1).ToList();
                        break;
                    case 1: // 1층인 경우 지하층 모두, 1층, 2층 
                        d1 = d1.Where(p => p.floor_em == 0 || p.floor_em == 1 || p.floor_em == 2).ToList();
                        break;
                    default: // 2층 이상인 경우 직상층 만 
                        int cc1 = emd.cc + 1;
                        d1 = d1.Where(p => p.floor_em == emd.cc || p.floor_em == cc1).ToList();
                        break;
                }
            }

            //Console.WriteLine("DSP Metrix Out ==> In :" + t1.ip_dspctrl);
            List<DeviceRow> sp2 = null;
            sp2 = _DanteDevice.Where(p => p.device == 0).ToList();

            foreach (var t1 in sst1)
            {
                if (t1.ip == "" || t1.ip_dspctrl == "")
                    continue;

                if (sp2 == null)
                    continue;

                for (int j = 1; j < 33; j++)
                {
                    if (d1 == null)
                    {
                        // 스피커가 있는거만 온 시키기 
                        foreach (var d3 in sp2)
                        {
                            if (d3.ip_dspctrl == t1.ip_dspctrl && j == d3.dsp_chno)
                            {
                                em_play.Add(d3);
                                // 직상층 없이 전체 조건 
                            }
                        }
                    }
                    else
                    {
                        // 직상층이 있으면 
                        foreach (var d2 in d1)
                        {
                            if (j == d2.dsp_chno && t1.ip_dspctrl == d2.ip_dspctrl)
                            {
                                em_play.Add(d2);
                                cur_embs_device.Add(d2);
                            }
                        }
                    }
                }
            }
            g.DSP_EMMakeGroupSpeaker(em_play, 1, BS_DSP_STATE.EM_BS_ON, 0);
        }

        private void EMMetrixChOff()
        {
            if (_DanteDevice == null)
            {
                // 서버가 없으면 강제 방송 처리 
                var splist1 = gl.danteDevice._DanteDevice.Where(p => p.device == 2).ToList();

                foreach (Device sp1 in splist1)
                {
                    try
                    {
                        if (sp1 == null) continue;
                        if (sp1.ip == "" || sp1.ip_dspctrl == "") continue;
                        Console.WriteLine("--" + "DSP Metrix Out ==> In :" + sp1.ip_dspctrl);

                        for (int i = 17; i < 33; i++)
                        {
                            g.dsp.Matrix(16, i, 0, sp1.ip_dspctrl);
                            Thread.Sleep(10);
                        }
                        //g.dsp.makeVolumn(17, 6, sp1.ip_dspctrl);
                    }
                    catch (Exception e1)
                    {
                    }
                }
                return;
            }
            if (em_play.Count() == 0)
                return;
            g.DSP_EMMakeGroupSpeaker(em_play, 0, BS_DSP_STATE.EM_BS_OFF, 0);
            em_play = new List<DeviceRow>();
        }

        public void InitVolume(bool emflag = false)
        {
            if (_DanteDevice == null) return;
            var splist1 = _DanteDevice.Where(p => p.device == 0).ToList();

            foreach (var sp1 in splist1)
            {
                try
                {
                    if (sp1 == null) continue;
                    if (sp1.ip == "" || sp1.ip_dspctrl == "") continue;
                    if (emflag)
                    {
                        //for (int i = 16; i < 32; i++)
                        { 
                            g.dsp.makeVolumn(sp1.dsp_chno, sp1.dsp_vol_em, sp1.ip_dspctrl);
                        }
                    }
                    else
                    { 
                        g.dsp.makeVolumn(sp1.dsp_chno, sp1.dsp_vol, sp1.ip_dspctrl);
                    }
                }
                catch (Exception e1)
                {
                }
            }
        }

        // 현재 방송 중지 처리 
        internal void EMBSOff()
        {
            //_T3.txt_Music.Text = "";
            //_T3.txt_Duration.Text = "";

            PlayChildProcess(1, 1);
            em_status = 4;
            CommState(em_status.ToString());
            alarmtest = false;
            Alarm = Alarm - 1;
            if (Alarm < 0) Alarm = 0;
            //write_ini(true);
            //CloseFlyControlEM();
            EMMetrixChOff();
        }

        #endregion

    }
}
