using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSmDNSW
{
    public class NetworkCard
    {
        public NetworkCard(int index, string name, string ipv4)
        {
            this.Index = index;
            this.nicname = name;
            this.ipv4 = ipv4;
        }

        public int Index { get; set; }
        public string nicname { get; set; }
        public string ipv4 { get; set; }
    }
}
