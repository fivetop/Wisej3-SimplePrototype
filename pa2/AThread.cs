﻿using DataClass;
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
    public class AThreadClass
    {
        public Thread backgroundThread { get; set; } = null;
        private bool BackgroundThreadStop { get; set; } = false;

        public int DeviceChktime { get; set; } = 40;

        public AThreadClass()
        {
        }
        
        public void Start()
        {
            if (backgroundThread != null)
                return;
            BackgroundThreadStop = false;
            backgroundThread = new System.Threading.Thread(BackgroundThread);
            backgroundThread.Start();
        }

        public bool Stop()
        {
            if (backgroundThread == null)
                return false;
            try
            {
                BackgroundThreadStop = true;
                //backgroundThread.Join();
                backgroundThread.Abort();
                System.Threading.Thread.Sleep(500);
                backgroundThread = null;
            }
            catch (ThreadStateException e1)
            {
                Console.WriteLine(e1.Message);
            }
            return true;
        }

        public event EventHandler OnAliveChk;
        public event EventHandler OnSpeakerCheck;

        private int T1chktimer_cnt = 0;

        private void BackgroundThread()
        {
            while (!BackgroundThreadStop)
            {
                System.Threading.Thread.Sleep(500);
                T1chktimer_cnt++;

                if (T1chktimer_cnt == 4)
                {
                    this.OnSpeakerCheck?.Invoke(null, null);
                }
                if (T1chktimer_cnt > 40) // 장비가 많아지면 시간 늘리기 
                {
                    T1chktimer_cnt = 0;
                    this.OnAliveChk?.Invoke(null, null);
                }
            }
        }

    }
}
