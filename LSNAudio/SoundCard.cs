using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSNAudio
{
    [Serializable]
    public class SoundCardList
    {
        public List<SoundCard> child { get; set; }

        public SoundCardList()
        {
            child = new List<SoundCard>();
        }
    }

    [Serializable]
    public class SoundCard
    {
        public SoundCard()
        {
        }

        public SoundCard(int v1, string v2)
        {
            this.no = v1;
            this.devicename = v2;
        }

        public int no { get; set; }
        public int deviceid { get; set; }
        public string devicename { get; set; }
        public string dev { get; set; }
    }
}
