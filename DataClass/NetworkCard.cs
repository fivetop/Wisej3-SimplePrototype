using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClass
{
    public class NetworkCard
    {
        public NetworkCard(int index, string name, string ipv4)
        {
            this.NetworkCardmDNS = index;
            this.NetworkCardName = name;
            this.ipv4 = ipv4;
            this.NetworkCardNo = 0;
        }

        public int NetworkCardmDNS { get; set; }
        public string NetworkCardName { get; set; }
        public string ipv4 { get; set; }
        public int NetworkCardNo { get; set; }
    }
}
