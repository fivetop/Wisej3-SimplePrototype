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
    public static class g1
    {
        static public SoundCardList _SoundCardList { get; set; } = new SoundCardList(); // 

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
