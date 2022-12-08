using gClass;
using LSNAudio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Media;

namespace pa
{
    public class Music
    {
        public int MusicId { get; set; }
        public string FileName { get; set; }
        public string FileContent { get; set; }
        public string deletable { get; set; }
        public string duration { get; set; }
    }

    public class BSTreeC
    {
        public int BSTreeCId { get; set; }
        public Nullable<int> BSTreeId { get; set; }
        public Nullable<int> AssetId { get; set; }
        public Nullable<int> MusicId { get; set; }
    }

    [Serializable]
    public class EMClient
    {
        public string apppath { get; set; } = @"C:\SimplePA2\";
        public string EM_NAME { get; set; } = "서울";
        public string NetworkCardName { get; set; } = "이더넷";
        public int NetworkCardNo { get; set; } = 0;
        public int NetworkCardmDNS { get; set; } = 0;
        public string WebAPIURL { get; set; } = @"http://localhost:9921/api/";
        public string HubURL { get; set; } = @"http://localhost:8080/signalr";
        public EMClient()
        {
        }
    }

    public static class g1
    {
        static public SoundCardList _SoundCardList { get; set; } = new SoundCardList(); // 

        static public DBAccess dBSqlite { get; set; } = new DBAccess();

        static public EMClient _EMClient { get; set; } = new EMClient(); // 기초 정보

        static public List<Music> _music { get; set; } = new List<Music>();
        static public List<BSTreeC> _bstreec { get; set; } = new List<BSTreeC>();


        static public void init()
        {
            XMLEMClient(true);

        }

        static public void XMLSimpleSoundCard(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = gl.@appPathServer + "SimpleSoundCard.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _SoundCardList = ser.Deserialize<SoundCardList>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<SoundCardList>(_SoundCardList);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                //Log(e.Data.ToString());
            }
        }

        public static void XMLEMClient(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = AppDomain.CurrentDomain.BaseDirectory + "EMClient.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _EMClient = ser.Deserialize<EMClient>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<EMClient>(_EMClient);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                xmlData = ser.Serialize<EMClient>(_EMClient);
                File.WriteAllText(path, xmlData);
            }
        }

        public static void Log(string str1)
        {
            if (str1 == "")
                return;
            try
            {
                string fn = "ls_" + DateTime.Now.ToShortDateString();
                StreamWriter writer = new StreamWriter(File.Open(gl.appPathServer_log + fn + ".txt", FileMode.Append));
                TextWriterTraceListener listener = new TextWriterTraceListener(writer);
                string st1 = string.Format("{0} : {1}", DateTime.Now, str1);
                writer.WriteLine(st1);
                writer.Close();
                Console.WriteLine(st1);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }


    }

}
