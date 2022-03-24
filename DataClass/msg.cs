using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClass
{
    public class msg
    {
        public string header { get; set; } // F, V, L, LO
        public string em_status { get; set; } // 
        public string type { get; set; } // P 1, R 2
        public string floor { get; set; } // 0 ~ 5 //  일반볼륨 1, 비상볼륨 2
        public string pkt { get; set; } // 0 ~ 5
        public int len { get; set; }
        public string src { get; set; } // 0 ~ 5

        public msg()
        {
            header = "";
            em_status = "";
            type = "";
            floor = "";
            len = 0;
        }

        public msg(string h, string e, string t, string f, string s)
        {
            header = h;
            em_status = e;
            type = t;
            floor = f;
            src = s;
            pkt = h + ":" + e + ":" + t + ":" + f + ":" + s;
        }

        public msg(string m)
        {
            string[] ar = m.Split(':');
            pkt = m;
            len = ar.Count();
            if (ar.Count() < 1)
                return;

            try
            {
                header = ar[0];
                em_status = ar[1];
                type = ar[2];
                floor = ar[3];
                src = ar[4];
            }
            catch (Exception e1)
            { 

            }
        }

    }
}
