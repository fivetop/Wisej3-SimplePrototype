using PacketDotNet;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LScap
{
    static public class g
    {
        public static List<string> capData = new List<string>();
        public static List<string> capData1 = new List<string>();
        public static List<string> capData2 = new List<string>();

        public static Thread backgroundThread;
        public static ICaptureDevice device = null;
        private static bool BackgroundThreadStop = false;
        private static object QueueLock = new object();
        private static List<RawCapture> PacketQueue = new List<RawCapture>();
        private static DateTime LastStatisticsOutput = DateTime.Now;
        private static TimeSpan LastStatisticsInterval = new TimeSpan(0, 0, 2);

        public static string NetworkCardName = "이더넷";
        public static int NetworkCardNo = 0;

        public static bool OpenCap()
        {
            if (device != null) return false;
            return LSpcapStart();
        }
        public static bool CloseCap()
        {
            if (device == null)
                return false;
            LSpcapStop();
            device = null;
            return true;
        }

        // 인터페이스에 아이피가 있으면 처리 하기 
        public static void getCardNo()
        {
            int no = 0;
            foreach (var t1 in CaptureDeviceList.Instance)
            {
                string str1 = t1.ToString();
                Console.WriteLine("Card No : " + no.ToString() + " : " + str1);

                var t2 = ((LibPcapLiveDevice)t1).Interface.FriendlyName;

                if (t2 == NetworkCardName)
                {
                    NetworkCardNo = no;
                    System.IO.File.WriteAllText("inifileCap.ini", NetworkCardNo.ToString());
                    return;
                }
                no++;
            }
        }

        // 인터페이스에 아이피가 있으면 처리 하기 
        public static void getCardNo2(List<string> cl)
        {
            int no = 0;
            foreach (var t1 in CaptureDeviceList.Instance)
            {
                string str1 = t1.ToString();
                Console.WriteLine("Card No : " + no.ToString() + " : " + str1);

                var t2 = no.ToString() + " : " + ((LibPcapLiveDevice)t1).Interface.FriendlyName;
                cl.Add(t2);
                no++;
            }
        }

        public static bool LSpcapStart()
        {
            string ini = System.IO.File.ReadAllText("inifileCap.ini");
            NetworkCardNo = int.Parse(ini);

            device = CaptureDeviceList.Instance[NetworkCardNo];
            if (device == null)
                return false;
            device.OnPacketArrival += new PacketArrivalEventHandler(device_OnPacketArrival);

            // start the background thread
            BackgroundThreadStop = false;
            backgroundThread = new System.Threading.Thread(BackgroundThread);
            backgroundThread.Start();

            device.Open();
            device.StartCapture();
            return true;
        }

        public static bool LSpcapStop()
        {
            if (device == null)
                return false;
            BackgroundThreadStop = true;
            backgroundThread.Join();
            device.Close();
            device = null;
            return true;
        }

        public static bool Refresh()
        {
            device.StopCapture();
            device.StartCapture();
            return true;
        }

        /// <summary>
        /// received packet
        /// </summary>
        private static void device_OnPacketArrival(object sender, CaptureEventArgs e)
        {
            var Now = DateTime.Now; // cache 'DateTime.Now' for minor reduction in cpu overhead
            var interval = Now - LastStatisticsOutput;
            if (interval > LastStatisticsInterval)
            {
                LastStatisticsOutput = Now;
            }
            lock (QueueLock)
            {
                PacketQueue.Add(e.Packet);
            }
        }
        /// <summary>
        /// Checks for queued packets. 
        /// </summary>
        private static void BackgroundThread()
        {
            while (!BackgroundThreadStop)
            {
                bool shouldSleep = true;

                lock (QueueLock)
                {
                    if (PacketQueue.Count != 0)
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
                    List<RawCapture> ourQueue;
                    lock (QueueLock)
                    {
                        // swap queues, giving the capture callback a new one
                        ourQueue = PacketQueue;
                        PacketQueue = new List<RawCapture>();
                    }

                    foreach (var packet in ourQueue)
                    {
                        var time = packet.Timeval.Date;
                        var len = packet.Data.Length;
                        if (len > 50)
                            Packet_Ana(packet);
                    }
                }
            }
        }



        // romee 팻킷 분석후 디비 저장 
        [Obsolete]
        private static void Packet_Ana(RawCapture Packet)
        {
            try
            {
                var packet = PacketDotNet.Packet.ParsePacket(Packet.LinkLayerType, Packet.Data);
                if (packet is PacketDotNet.EthernetPacket)
                {
                    //Manipulate ethernet parameters
                    var ip = PacketDotNet.IpPacket.GetEncapsulated(packet);
                    if (ip != null)
                    {
                        if (ip.DestinationAddress.ToString() == "239.16.0.9") // DSP catch 239.16.0.8 send 후  239.16.0.9 리스판스 사용 
                        {
                            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                            string label = encoder.GetString(Packet.Data, 0x3e, 20);
                            var v1 = label.IndexOf('\0');
                            var t3 = label.Remove(v1);
                            var t4 = ip.SourceAddress.ToString();

                            if (!capData2.Contains(t3))
                            {
                                capData1.Add(t4);
                                capData2.Add(t3);
                                //Console.WriteLine(t3);
                            }
                        }
                        if (ip.DestinationAddress.ToString() != "224.0.0.251") // MDNS 
                            return;
                        var t1 = ip.SourceAddress.ToString();
                        if (!capData.Contains(t1))
                        {
                            capData.Add(t1);
                            //Console.WriteLine(t1);
                        }
                    } 
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
    }
}
