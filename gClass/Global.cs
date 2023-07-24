using DataClass;
using OpenQA.Selenium.Chrome;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace gClass
{
    public static class gl
    {
        // 버젼, 실행 위치  
        static public string version { get; set; } = "Simple PA v2.0";
        static public string appPathServer { get; set; } = @"C:\SimplePA2\";
        static public string appPathServer_speaker { get; set; } = @"C:\SimplePA2\Speaker\";
        static public string appPathServer_log { get; set; } = @"C:\SimplePA2\Log\";
        static public string appPathServer_music { get; set; } = @"C:\SimplePA2\Music\";
        static public string appPathServer_image { get; set; } = @"C:\SimplePA2\Image";
        // dante 
        static public DanteDevice danteDevice { get; set; } = new DanteDevice();

        // 앰프 메트릭스 명령후 실행 안됨 메트릭스 찾기 
        static public object QueueLock { get; set; } = new object();

        public static List<DSPMatrix> SvsR { get; set; } = new List<DSPMatrix>();

        static public List<NetworkCard> networkCardList { get; set; } = new List<NetworkCard>();
        static public string NetworkCardName { get; set; } = "이더넷";
        static public int NetworkCardNo { get; set; } = 0;
        static public int NetworkCardmDNS { get; set; } = 0;

        public static void NetWorkCardFind()
        {
            if (System.IO.File.Exists("NetworkCardName.ini") == false)
            {
                System.IO.File.WriteAllText("NetworkCardName.ini", "0:0:이더넷");
            }
            string n2 = System.IO.File.ReadAllText("NetworkCardName.ini");

            string[] ar = n2.Split(':');
            gl.NetworkCardNo = int.Parse(ar[0]);
            gl.NetworkCardmDNS = int.Parse(ar[1]);
            gl.NetworkCardName = ar[2];
            gl.BestInterfaceIndex();

            string t2 = "";
            foreach (var nc in gl.networkCardList)
            {
                int no = 0;
                foreach (var t1 in CaptureDeviceList.Instance)
                {
                    string s1 = ((LibPcapLiveDevice)t1).Interface.FriendlyName;
                    if (nc.NetworkCardName == s1 && nc.ipv4.Contains("169"))
                    {
                        nc.NetworkCardNo = no;
                        gl.NetworkCardNo = no;
                        gl.NetworkCardmDNS = nc.NetworkCardmDNS;
                        gl.NetworkCardName = nc.NetworkCardName;
                        t2 = gl.NetworkCardNo + ":" + gl.NetworkCardmDNS + ":" + gl.NetworkCardName;
                        Console.WriteLine(t2);
                        System.IO.File.WriteAllText("NetworkCardName.ini", t2);
                    }
                    no++;
                }
            }
        }

        static public int BestInterfaceIndex()
        {
            networkCardList.Clear();
            NetworkInterface[]  nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface nic in nics)
            {
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet) continue;
                if (nic.Supports(NetworkInterfaceComponent.IPv4) == false) continue;
                IPInterfaceProperties properties = nic.GetIPProperties();
                IPv4InterfaceProperties v4_props = properties.GetIPv4Properties();
                //g.Log("Interface No : " + v4_props.Index + " : " + nic.Name);

                foreach (var t1 in properties.UnicastAddresses)
                {
                    if (t1.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        string t2 = "Interface No : " + v4_props.Index + " : " + nic.Name + " : " + t1.Address.ToString();
                        Console.WriteLine(t2);
                        //g.Log(t1.Address.ToString());
                        networkCardList.Add(new NetworkCard(v4_props.Index, nic.Name, t1.Address.ToString()));

                    }
                }
                //return v4_props.Index;
            }
            return 0;
        }

        #region // XML 처리 ,   XMLSimplePA, XMLSimpleSpeaker, XMLSchedule, XMLBS1Tree, XMLFloor, XMLLocation, XMLInfoTree, XMLGroupTree, ReadScheduleTestData

        static public void InitSimplePA()
        {
            if (System.IO.File.Exists(gl.appPathServer + @"gclass.ini") == false)
            {
                System.IO.File.WriteAllText(gl.appPathServer + @"gclass.ini", gl.appPathServer);
            }
            gl.appPathServer = System.IO.File.ReadAllText(gl.appPathServer + @"gclass.ini");

            appPathServer_speaker = gl.appPathServer + @"Speaker\";
            appPathServer_log = gl.appPathServer + @"Log\";
            appPathServer_music = gl.appPathServer + @"Music\";
            appPathServer_image = gl.appPathServer + @"Image\";

            var directoryInfo = new DirectoryInfo(appPathServer_speaker);
            directoryInfo.Create();
            directoryInfo = new DirectoryInfo(appPathServer_log);
            directoryInfo.Create();
            directoryInfo = new DirectoryInfo(appPathServer_music);
            directoryInfo.Create();
            directoryInfo = new DirectoryInfo(appPathServer_image);
            directoryInfo.Create();

            MakeBackup();
        }

        // 월단위 백업 실행 
        private static void MakeBackup()
        {
            DateTime dt1 = DateTime.Now;
            string backup = gl.appPathServer + @"Backup\" + dt1.ToString("yyyMM") +@"\";
            var directoryInfo = new DirectoryInfo(backup);
            if (directoryInfo.Exists) return;
            
            directoryInfo.Create();
            System.IO.File.Copy(gl.appPathServer + "SimplePA.xml", backup + "SimplePA.xml");
            System.IO.File.Copy(gl.appPathServer + "DanteDevice.xml", backup + "DanteDevice.xml");
        }

        // DanteDevice 
        public static void XMLDanteDevice(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = @appPathServer + "DanteDevice.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    danteDevice = ser.Deserialize<DanteDevice>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<DanteDevice>(danteDevice);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log("XMLDanteDevice" + e.Message);
            }
        }

        #endregion

        #region // 로그 및 유틸 
        public static void Log(string str1)
        {
            try
            {
                string fn = "svr_" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString();
                StreamWriter writer = new StreamWriter(File.Open(appPathServer + "Log\\" + fn + ".txt", FileMode.Append));
                TextWriterTraceListener listener = new TextWriterTraceListener(writer);
                //Debug.Listeners.Add(listener);
                //Debug.WriteLine(string.Format("{0} : {1}", DateTime.Now, str1));
                //Debug.Flush();
                string st1 = string.Format("{0} : {1}", DateTime.Now, str1);
                writer.WriteLine(st1);
                writer.Close();
                Console.WriteLine(st1);
            }
            catch (ObjectDisposedException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        public static string long2IPstring(long s2)
        {
            string ipstr;
            var t1 = BitConverter.GetBytes(s2);
            byte[] t2 = { t1[0], t1[1], t1[2], t1[3] };
            ipstr = new IPAddress(t2.Reverse().ToArray()).ToString();
            return ipstr;
        }

        public static string bytetostring(byte[] t)
        {
            string ret = string.Empty;

            ret = string.Concat(Array.ConvertAll(t, byt => byt.ToString("X2")));
            return ret;
        }

        public static string RePlaceAt(this string str, int index, int length, string replace)
        {
            return str.Remove(index, Math.Min(length, str.Length - index)).Insert(index, replace);
        }

        public static byte[] hexatobyte(string str1)
        {
            if (str1 == null)
                return null;
            byte[] cvt = new byte[str1.Length / 2];
            int len = cvt.Length;

            for (int i = 0; i < len; i++)
            {
                string s1 = str1.Substring(i * 2, 2);
                cvt[i] = Convert.ToByte(s1, 16);
            }
            return cvt;
        }

        // 오브젝트 딥 카피 처리용 
        public static class ObjectCopier
        {
            /// <span class="code-SummaryComment"><summary></span>
            /// Perform a deep Copy of the object.
            /// <span class="code-SummaryComment"></summary></span>
            /// <span class="code-SummaryComment"><typeparam name="T">The type of object being copied.</typeparam></span>
            /// <span class="code-SummaryComment"><param name="source">The object instance to copy.</param></span>
            /// <span class="code-SummaryComment"><returns>The copied object.</returns></span>
            public static T Clone<T>(T source)
            {
                if (!typeof(T).IsSerializable)
                {
                    throw new ArgumentException("The type must be serializable.", "source");
                }

                // Don't serialize a null object, simply return the default for that object
                if (Object.ReferenceEquals(source, null))
                {
                    return default(T);
                }

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new MemoryStream();
                using (stream)
                {
                    formatter.Serialize(stream, source);
                    stream.Seek(0, SeekOrigin.Begin);
                    return (T)formatter.Deserialize(stream);
                }
            }
        }
        #endregion


    }

}
