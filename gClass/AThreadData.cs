using DataClass;
using System;
using System.Collections.Generic;

namespace gClass
{

    [Serializable]
    public class AThreadData
    {
        public string ip { get; set; }       // ip
        public byte[] b1 { get; set; }       // data

        public string LocalIP { get; set; }       // localip

        public int intfindx { get; set; }   // internet card index

        public AThreadData()
        {
            ip = "";
            b1 = null;
            LocalIP = "";
            intfindx = 0;
        }
    }
}
