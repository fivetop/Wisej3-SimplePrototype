using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClass
{
    [Serializable]
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
        public string  emData { get; set; }

        public string file { get; set; }
        public string[] array { get; set; } = new string[8];
        public string DeviceName { get; set; }
        public string ch { get; set; }

        public int floor { get; set; }

        public string getfile()
        {
            file = array[0] + " " + array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " " + array[5];
            DeviceName = array[4];
            ch = array[5];
            emData = array[6].Trim(' ') + "동/" + array[7].Trim(' ') + "계단/" + array[8].Trim(' ') + "층";
            floor = int.Parse(array[6]) * 100 + int.Parse(array[7]) * 10 + int.Parse(array[8]);
            return file;
        }
    }
}
