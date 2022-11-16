using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClass
{
    [Serializable]
    // 파일 읽은후 임시 저장용 ==> 화면 확인 용 
    public class EmSpeakerPositionList
    {
        public List<EmSpeakerPosition> child { get; set; }
        public EmSpeakerPositionList()
        {
            child = new List<EmSpeakerPosition>();
        }
    }

    [Serializable]
    public class EmSpeakerPosition
    {
        public string emData { get; set; }
        public string emServer { get; set; }

        public string file { get; set; }
        public string[] array { get; set; } = new string[13];
        public string DeviceName { get; set; }
        public string ch { get; set; }
        public int floor { get; set; }
        public string zpc { get; set; }
        public int zpci { get; set; }
        public int zpco { get; set; }

        public string getfile()
        {
            if (array.Length < 12)
                return null;
            file = array[0] + " " + array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " " + array[5] + " " + array[6];
            emServer = array[1];
            DeviceName = array[5];
            ch = array[7];
            zpc = array[8];
            zpci = int.Parse(array[9] == "" ? "0" : array[9]);
            zpco = int.Parse(array[10] == "" ? "0" : array[10]);
            emData = array[11].Trim(' ') + "동/" + array[12].Trim(' ') + "계단/" + array[13].Trim(' ') + "층";
            floor = int.Parse(array[11]) * 100 + int.Parse(array[12]) * 10 + int.Parse(array[13]);
            return file;
        }
    }
}
