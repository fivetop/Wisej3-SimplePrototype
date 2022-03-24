using System;
using System.Collections.Generic;

namespace DataClass
{

    [Serializable]
    public class AssetBase
    {
        public int AssetBaseId { get; set; }
        public Guid id { get; set; }
        public Guid logicid { get; set; }
        public string ip { get; set; }
        public string GroupName { get; set; }
        public string ZoneName { get; set; }
        public string SpeakerName { get; set; }
        public long ch { get; set; }
        public string path { get; set; }
        public string floor { get; set; }
        public string DeviceName { get; set; }
        public string state { get; set; } // On-Line , Off-Line
        public string state_old { get; set; } // On-Line , Off-Line
        public bool chk { get; set; }
        public int seq { get; set; }
        public Device Device { get; set; }

        public AssetBase()
        {
            //id = Guid.NewGuid();
            ip = "";
            DeviceName = "";
            floor = "";
            state = "";
            state_old = "";
            seq = 0;
        }

    }

}
