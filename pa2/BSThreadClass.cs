using DataClass;
using gClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;

namespace pa
{
    // v2 update ok
    public static class BSThreadClass
    {
        public static Thread backgroundThread { get; set; }
        private static bool BackgroundThreadStop { get; set; } = false;
        private static object QueueLock { get; set; } = new object();
        private static List<BSAsset> DataQueue { get; set; } = new List<BSAsset>();

        private static bool EMClear { get; set; } = false;
        private static BS_STATE Cur_bS_STATE { get; set; } = BS_STATE.STOP;

        private static int[] MetrixChIn = { 0, 16, 17, 18, 19, 20, 21, 22, 23 }; // 입력채널 번호 

        public static void Start()
        {
            BackgroundThreadStop = false;
            backgroundThread = new System.Threading.Thread(BackgroundThread);
            backgroundThread.Start();
        }

        public static bool Stop()
        {
            if (backgroundThread == null)
                return false;
            BackgroundThreadStop = true;
            backgroundThread.Join();
            return true;
        }

        public static void EmClear()
        {
            lock (QueueLock)
            {
                EMClear = true;
            }
        }

        public static void AddData(BSAsset data)
        {
            lock (QueueLock)
            {
                if (data.bS_DSP_STATE == BS_DSP_STATE.PRESET_ALL && DataQueue.Count > 1)
                {
                    // 전체처리가 중복되면 최종 데이터만 처리 
                    var t2 = DataQueue.Where(p => p.bS_DSP_STATE == BS_DSP_STATE.PRESET_ALL);
                    if (t2.Count() > 0)
                    { 
                        var t1 = DataQueue.Last(p => p.bS_DSP_STATE == BS_DSP_STATE.PRESET_ALL);
                        if (t1 == null)
                        {
                            DataQueue.Add(data);
                        }
                        else
                        {
                            // 전체 인 경우 
                            // 기존에 중복된게 있으면 수정 처리 
                            Console.WriteLine("--" + "Replace : " + data.onoff.ToString());
                            t1.onoff = data.onoff;
                        }
                    }
                    else
                    {
                        DataQueue.Add(data);
                    }
                }
                else
                { 
                    DataQueue.Add(data);
                }
            }
        }

        private static void BackgroundThread()
        {
            while (!BackgroundThreadStop)
            {
                bool shouldSleep = true;

                lock (QueueLock)
                {
                    if (DataQueue.Count != 0)
                    {
                        shouldSleep = false;
                    }
                }

                if (shouldSleep)
                {
                    System.Threading.Thread.Sleep(250);
                }
                else // should process the queue
                {
                    List<BSAsset> ourQueue;
                    lock (QueueLock)
                    {
                        // swap queues, giving the capture callback a new one
                        ourQueue = DataQueue;
                        DataQueue = new List<BSAsset>();

                        if (EMClear)
                        {
                            Console.WriteLine("--EM Clear Count : " + ourQueue.Count.ToString());
                            ourQueue.Clear();
                            EMClear = false;
                        }
                        if (ourQueue.Count > 5)
                        {
                            Console.WriteLine("--Queue Count : " + ourQueue.Count.ToString() );
                        }
                    }

                    foreach (var data in ourQueue)
                    {
                        DataAnalyzer(data);
                    }
                }
            }
        }

        private static void DataAnalyzer(BSAsset data)
        {
            try
            {
                switch (data.bS_DSP_STATE)
                {
                    case BS_DSP_STATE.EM_BS_ON:
                    case BS_DSP_STATE.EM_BS_OFF:
                        Console.WriteLine("EM_BS" + " : " + data.onoff.ToString());
                        g.dsp.BufferClear();

                        // 뮤트 시키고
                        //var ld1 = data.device.GroupBy(p => p.ip_dspctrl).ToList();
                        var ld1 = g.mainWindow._DanteDevice.Where(p => p.device == 2).ToList();

                        foreach (var d1 in ld1)
                        {
                            //string str1 = d1.Key;
                            string str1 = d1.ip_dspctrl;
                            if (data.onoff == 1)
                                g.dsp.DSPmuteInON(str1);
                            else
                                g.dsp.DSPmuteInOFF(str1);

                        }

                        // 뮤트온한다음 1,17,32 채널 오프 시킴 모든 DSP 에 대해서 
                        // 버젼 1.0 확인 필요 
                        foreach (var d1 in ld1)
                        {
                            //string str1 = d1.Key;
                            string str1 = d1.ip_dspctrl;
                            if (data.onoff == 1)
                            {
                                g.dsp.DSPmuteInOFF(str1, 1);
                                g.dsp.DSPmuteInOFF(str1, 17);
                                g.dsp.DSPmuteInOFF(str1, 32);
                            }
                            else
                            {
                            }
                        }

                        // 앰프 처리하고 
                        // 특정 Asset List 만 처리
                        foreach (var t1 in data.device)
                        {
                            try
                            {
                                if (t1.ip == "") continue;
                                if (t1.ip == "" || t1.ip_dspctrl == "") continue;
                                Console.WriteLine("EM:" + "DSP Metrix Out ==> In :" + t1.ip_dspctrl + " : " + t1.path + " : " + data.onoff.ToString());
                                g.dsp.Matrix(16, t1.dsp_chno, data.onoff, t1.ip_dspctrl);
                                //g.dsp.makeVolumn(sst1.dsp_chno, sst1.dsp_vol, sst1.ip_dspctrl);
                            }
                            catch (Exception e1)
                            {
                            }
                        }
                        break;

                    case BS_DSP_STATE.PRESET:
                        Console.WriteLine("PRESET" + " : " + data.onoff.ToString());
                        g.dsp.BufferClear();
                        // 특정 Asset List 만 처리
                        foreach (AssetBase t1 in data.child)
                        {
                            try
                            {
                                if (t1.ip == "") continue;
                                var sst1 = g.mainWindow._DanteDevice.First(p => p.DeviceName == t1.DeviceName && p.chspk == t1.ch);
                                if (sst1 == null) continue;
                                if (sst1.ip == "" || sst1.ip_dspctrl == "") continue;
                                Console.WriteLine("--" + "DSP Metrix Out ==> In :" + sst1.ip_dspctrl + " : " + t1.path + " : " + data.onoff.ToString());
                                g.dsp.Matrix(0, sst1.dsp_chno, data.onoff, sst1.ip_dspctrl);
                                //g.dsp.makeVolumn(sst1.dsp_chno, sst1.dsp_vol, sst1.ip_dspctrl);
                            }
                            catch (Exception e1)
                            {
                            }
                        }
                        break;

                    case BS_DSP_STATE.MUL_BS:
                        Console.WriteLine("MUL_BS" + " : " + data.onoff.ToString());
                        g.dsp.BufferClear();

                        if (data.onoff == 0)
                        { 
                            chClear(data);
                            return;
                        }

                        foreach (var t1 in data.child)
                        {
                            try
                            {
                                if (t1.ip == "") continue;
                                var sst1 = g.mainWindow._DanteDevice.First(p => p.DeviceName == t1.DeviceName && p.chspk == t1.ch);
                                if (sst1 == null) continue;
                                if (sst1.ip == "" || sst1.ip_dspctrl == "") continue;
                                Console.WriteLine("--" + "DSP Metrix Out ==> In :" + sst1.ip_dspctrl + " : " + t1.path + " : " + data.onoff.ToString());
                                g.dsp.Matrix(MetrixChIn[data.chno], sst1.dsp_chno, data.onoff, sst1.ip_dspctrl);
                                //g.dsp.makeVolumn(sst1.dsp_chno, sst1.dsp_vol, sst1.ip_dspctrl);
                            }
                            catch (Exception e1)
                            {
                            }
                        }
                        break;
                    case BS_DSP_STATE.GEN_BS:
                        Console.WriteLine("GEN_BS" + " : " + data.onoff.ToString());
                        g.dsp.BufferClear();
                        foreach (var t1 in data.child)
                        {
                            try
                            {
                                if (t1.ip == "") continue;
                                var sst1 = g.mainWindow._DanteDevice.First(p => p.DeviceName == t1.DeviceName && p.chspk == t1.ch);
                                if (sst1 == null) continue;
                                if (sst1.ip == "" || sst1.ip_dspctrl == "") continue;
                                Console.WriteLine("--" + "DSP Metrix Out ==> In :" + sst1.ip_dspctrl + " : " + t1.path + " : " + data.onoff.ToString());
                                g.dsp.Matrix(17, sst1.dsp_chno, data.onoff, sst1.ip_dspctrl); // 16 -> 17 18번채널 
                                //g.dsp.makeVolumn(sst1.dsp_chno, sst1.dsp_vol, sst1.ip_dspctrl);
                            }
                            catch (Exception e1)
                            {
                            }
                        }
                        break;

                    case BS_DSP_STATE.PRESET_ALL:
                        Console.WriteLine("PRESET_ALL" + " : " + data.onoff.ToString());
                        g.dsp.BufferClear();
                        // 전체 컨트롤이므로 Asset List 는 필요 없음 
                        var sstl = g.mainWindow._DanteDevice.Where(p => p.device == 2);

                        foreach (var t1 in sstl)
                        {
                            if (t1.ip == "" || t1.ip_dspctrl == "")
                                continue;
                            Console.WriteLine("--" + "DSP Metrix Out ==> In :" + t1.ip_dspctrl);
                            for (int j = 1; j < 32; j++)
                            {
                                g.dsp.Matrix(0, j, data.onoff, t1.ip_dspctrl);
                            }
                            // 시스템 예약 - 아날로그 지원 용 
                            g.dsp.Matrix(0, 32, 1, t1.ip_dspctrl);
                        }
                        break;

                    case BS_DSP_STATE.INIT :
                        Console.WriteLine("INIT" + " : " + data.onoff.ToString());
                        g.dsp.BufferClear();
                        var sstl2 = g.mainWindow._DanteDevice.Where(p => p.device == 0);

                        foreach (var t1 in sstl2)
                        {
                            if (t1.ip == "" || t1.ip_dspctrl == "")
                                continue;

                            if (data.chno == 0)
                            {
                                g.dsp.Matrix(17, t1.dsp_chno, 0, t1.ip_dspctrl);
                            }
                            else if (data.chno == 2)
                            { 
                                for (int i = 18; i < 24; i++) // in ch 18~24
                                {
                                    //for (int j = 1; j < 33; j++) // out ch 1~32
                                    //{
                                    //    g.dsp.Matrix(i, j, 0, t1.ip_dspctrl);
                                    //}
                                    g.dsp.Matrix(i, t1.dsp_chno, 0, t1.ip_dspctrl);
                                }
                            }
                            for (int j = 1; j < 33; j++) // out ch 1~32
                            {
                                //g.dsp.makeVolumn(j, 0, t1.ip_dspctrl);
                            }
                        }
                        break;

                    case BS_DSP_STATE.MIC_BS:
                        Console.WriteLine("MIC_BS" + " : " + data.onoff.ToString());
                        g.dsp.BufferClear();
                        foreach (AssetBase t1 in data.child)
                        {
                            try
                            {
                                if (t1.ip == "") continue;
                                var sst1 = g.mainWindow._DanteDevice.First(p => p.DeviceName == t1.DeviceName && p.chspk == t1.ch);
                                if (sst1 == null) continue;
                                if (sst1.ip == "" || sst1.ip_dspctrl == "") continue;
                                Console.WriteLine("--" + "DSP Metrix Out ==> In :" + sst1.ip_dspctrl + " : " + t1.path + " : " + data.onoff.ToString());
                                g.dsp.Matrix(31, sst1.dsp_chno, data.onoff, sst1.ip_dspctrl);
                                //g.dsp.makeVolumn(sst1.dsp_chno, sst1.dsp_vol, sst1.ip_dspctrl);
                            }
                            catch (Exception e1)
                            {
                            }
                        }
                        break;
                }

            }
            catch (Exception e1)
            {
                Console.WriteLine("--" + e1.Message);
            }
        }

        private static void chClear(BSAsset data)
        {
            var s2 = g.mainWindow._DanteDevice.Where(p => p.device == 2);
            foreach (var t1 in s2)
            {
                if (t1.ip == "" || t1.ip_dspctrl == "") continue;
                for (int j = 1; j < 32; j++)
                    g.dsp.Matrix(MetrixChIn[data.chno], j, 0, t1.ip_dspctrl);
            }
        }
    }
}
