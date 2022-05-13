using DataClass;
using gClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;

namespace gClass
{
    // 4440 포트에 쏘는거 전용 리턴 없음 
    public class BThread
    {
        public Thread backgroundThread { get; set; } = null;
        private bool BackgroundThreadStop { get; set; } = false;
        private static object QueueLock { get; set; } = new object();
        private static List<AThreadData> DataQueue { get; set; } = new List<AThreadData>();
        private static udpClient udpc1 { get; set; } = null;

        public BThread()
        {
        }
        
        public void Start()
        {
            BackgroundThreadStop = false;
            backgroundThread = new System.Threading.Thread(BackgroundThread);
            backgroundThread.Start();
        }

        public bool Stop()
        {
            if (backgroundThread == null)
                return false;
            BackgroundThreadStop = true;
            backgroundThread.Join();
            System.Threading.Thread.Sleep(500);
            return true;
        }

        public void AddData(AThreadData data)
        {
            lock (QueueLock)
            {
                DataQueue.Add(data);
            }
        }
        public event EventHandler OnAliveChk;

        private void BackgroundThread()
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
                    List<AThreadData> ourQueue;
                    lock (QueueLock)
                    {
                        // swap queues, giving the capture callback a new one
                        ourQueue = DataQueue;
                        DataQueue = new List<AThreadData>();
                    }

                    foreach (var data in ourQueue)
                    {
                        DataAnalyzer(data);
                    }
                }
            }
        }

        // 4440 포트에 쏘는거 전용 리턴 없음 
        private void DataAnalyzer(AThreadData data)
        {
            IPEndPoint ReceiveEndPoint1 = new IPEndPoint(System.Net.IPAddress.Parse(data.LocalIP), 6001);

            udpc1 = new udpClient();
            udpc1.udp.Client.Bind(ReceiveEndPoint1);
            udpc1.option(IPAddress.Parse("239.16.0.8"), data.intfindx);
            udpc1.OnReceiveMessage += Udpc1_OnReceiveMessage;
            udpc1.buf2.Clear();
            udpc1.rcv();
            udpc1.send("239.16.0.8", 6001, data.b1);

            Thread.Sleep(500);
            udpc1.Close();
        }

        private void Udpc1_OnReceiveMessage(string message)
        {
            Console.WriteLine("Rcv.." + udpc1.buf2.Count.ToString());
            udpc1.buf2.Clear();
            udpc1.Close();
        }
    }
}
