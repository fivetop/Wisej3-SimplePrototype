using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace gClass
{
    /*
    [Serializable]
    public class EMEventLIST
    {
        public List<EventVm> child { get; set; }
        public EMEventLIST()
        {
            child = new List<EventVm>();
        }

        public void Add(EventVm em)
        {
            child.Add(em);
        }
    }

    public class EventVm
    {
        public string write_time { get; set; } = "";  // 발생시각 
        public string event_text { get; set; } = "";  // 발생위치
        public string base_text { get; set; } = "";  // 발생내용 
        public string state { get; set; } = "";  // 상태 

        public EventVm()
        {
        }
    }
    */
    public class EMLIST
    {
        public List<EM_Data> child { get; set; }
        public EMLIST()
        {
            child = new List<EM_Data>();
        }
    }

    public class EM_Data
    {
        public string CMD { get; set; } = "F";
        public string AA { get; set; } = "01";  // 01동~99동
        public string BB { get; set; } = "00";  // 01계단 ~ 99계단
        public string CC { get; set; } = "01";  // 00 층 ~~ 99 층 
        public string emData { get; set; } = "";  // 00 층 ~~ 99 층 

        public int aa { get; set; } = 0;
        public int bb { get; set; } = 0;
        public int cc { get; set; } = 0;
        public EM_Data()
        {
            CMD = "";
            AA = "";
            BB = "";
            CC = "";
        }

        public string getemData()
        {
            aa = int.Parse(AA);
            bb = int.Parse(BB);
            cc = int.Parse(CC);
            emData = AA+"동/"+BB+"계단/"+CC+"층";
            return emData;
        }
    }


    public class pktr
    {
        string STX { get; set; } = "02";
        string ETX { get; set; } = "03";
        string D { get; set; } = "2d";

        // R 0x52 전체복구  F 0x46 복구  N 발생 E 비상방송 연동정지 e 비상방송 연동정상 
        string SUM { get; set; } = "00";

        public string GB { get; set; } = "42";  // 층구분 B, P, K, " " 
        public string tot { get; set; } = "";  // 00 층 ~~ 99 층 

        public byte[] pkt { get; set; }
        public string pkt2str { get; set; }
        public byte size { get; set; }
        public CMDList cmdList { get; set; } = new CMDList();
        public EM_Data em_Data { get; set; } = new EM_Data();
        public string log { get; set; } = "";  // log 

        public pktr()
        {

        }

        public pktr(string aa, string bb, string cc, string cmd)
        {
            tot = STX + aa + D + bb + D + cc + cmd + SUM + ETX;

            byte[] pkt1 = hexatobyte(tot);
            int sum1 = 0;
            int sum2 = 0;
            for (int i=0; i < 12; i++ )
            {
                sum1 = sum1 + pkt1[i];
            }
            sum2 = (sum1 % 16) + 0x30;
            pkt1[10] = (byte)sum2;
            pkt = pkt1;
            pkt2str = Encoding.Default.GetString(pkt);
        }

        public pktr(byte[] rx_data, byte size1)
        {
            size1++;
            byte[] b1 = new byte[size1];
            Buffer.BlockCopy(rx_data, 0, b1, 0, size1);
            this.pkt = b1;
            this.size = size1;

            switch (this.size)
            {
                case 10:
                    pkt2str = Encoding.Default.GetString(pkt);
                    tot = pkt2str.Substring(1, 7);
                    em_Data.CMD = pkt2str.Substring(1, 1);
                    em_Data.AA = pkt2str.Substring(2, 2);
                    em_Data.BB = pkt2str.Substring(4, 1);
                    GB = pkt2str.Substring(5, 1);
                    em_Data.CC = pkt2str.Substring(6, 2);
                    break;
                case 12:
                    pkt2str = Encoding.Default.GetString(pkt);
                    tot = pkt2str.Substring(1, 10);
                    em_Data.AA = pkt2str.Substring(1, 2);
                    em_Data.BB = pkt2str.Substring(4, 2);
                    em_Data.CC = pkt2str.Substring(7, 2);
                    em_Data.CMD = pkt2str.Substring(9, 1);
                    break;
            }
            log = em_Data.AA + "동" + "/" + em_Data.BB + "계단" + "/" + em_Data.CC + "층";
            Console.WriteLine("RCV:" + log);
        }

        public pktr(string rx_data)
        {
            int rxl = rx_data.Length;
            pkt2str = rx_data;

            switch(rxl)
            {
                case 7:
                    tot = pkt2str.Substring(0, 7);
                    em_Data.CMD = pkt2str.Substring(0, 1);
                    em_Data.AA = pkt2str.Substring(1, 2);
                    em_Data.BB = pkt2str.Substring(3, 1);
                    GB = pkt2str.Substring(4, 1);
                    em_Data.CC = pkt2str.Substring(5, 2);
                    break;
                case 10:
                    tot = pkt2str.Substring(0, 10);
                    em_Data.AA = pkt2str.Substring(0, 2);
                    em_Data.BB = pkt2str.Substring(3, 2);
                    em_Data.CC = pkt2str.Substring(6, 2);
                    em_Data.CMD = pkt2str.Substring(8, 1);
                    break;
                default:
                    em_Data.AA = "";
                    em_Data.BB = "";
                    em_Data.CC = "";
                    em_Data.CMD = "";
                    break;
            }
            log = em_Data.AA + "동" + "/" + em_Data.BB + "계단" + "/" + em_Data.CC + "층";
        }


        public byte[] hexatobyte(string str1)
        {
            if (str1 == null)
                return null;
            byte[] cvt = new byte[str1.Length / 2];
            int len = cvt.Length;

            for (int i = 0; i < len; i++)
            {
                string s1 = str1.Substring(i * 2, 2);
                cvt[i] = Convert.ToByte(s1, 16);
            }
            return cvt;
        }


        public void pktr10(string aa, string bb, string cc, string cmd, string gb)
        {
            tot = STX + cmd + aa + bb + GB + cc + ETX;

            byte[] pkt1 = hexatobyte(tot);

            byte chk = (byte)(pkt1[1] ^ pkt1[2] ^ pkt1[3] ^ pkt1[4] ^ pkt1[5] ^ pkt1[6] ^ pkt1[7]);
            Array.Resize(ref pkt1, 10);
            pkt1[9] = chk;
            pkt = pkt1;
            pkt2str = Encoding.Default.GetString(pkt);
        }

        // 수신데이터 점검 
        public bool checkSUM()
        {
            byte[] pkt1 = new byte[pkt.Length];
            pkt1 = pkt;

            switch (size)
            {
                case 10:
                    byte chk = (byte)(pkt1[1] ^ pkt1[2] ^ pkt1[3] ^ pkt1[4] ^ pkt1[5] ^ pkt1[6] ^ pkt1[7]);
                    if (chk != pkt[9])
                        return false;
                    break;
                case 12:
                    int sum1 = 0;
                    int sum2 = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        if (i == 10) continue;
                        sum1 = sum1 + pkt1[i];
                    }
                    sum2 = (sum1 % 16) + 0x30;

                    if (sum2 != pkt[10])
                        return false;
                    break;
            }

            return true;
        }
    }
}
