using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClass
{
    public enum BS_STATE : int
    {
        STOP = 0,
        PLAY = 1
    }

    public enum BS_DSP_STATE : int
    {
        NONE = 0,
        PRESET = 1,
        PRESET_ALL = 2,
        INIT = 3,
        GEN_BS = 4,
        MUL_BS = 5,
        EM_BS_ON = 6,
        EM_BS_OFF = 7,
        MIC_BS = 8,
        RESERVED = 9
    }

    public enum COMM_ASC : byte
    {
        STX = 0x02,
        ETX = 0x03,
        ACK = 0x06,
        NACK = 0x15
    }

    public enum EM_MODE : int
    {
        전체복구 = 0,
        복구 = 1,
        발생 = 2,
        연동정지 = 3,
        연동정상 = 4
    }


    class typeRClass
    {
    }

    [Serializable]
    public class CMDList
    {
        public List<CMD> child { get; set; }
        public List<CMD> child2 { get; set; }

        public string log { get; set; }
        public CMDList()
        {
            child = new List<CMD>();
            child2 = new List<CMD>();

            child.Add(new CMD("R 전체복구", "52"));
            child.Add(new CMD("F 복구", "46"));
            child.Add(new CMD("N 발생", "4e"));
            child.Add(new CMD("E 비상방송 연동정지", "45"));
            child.Add(new CMD("e 비상방송 연동정상", "65"));
        }

        public void CMD10Byte()
        {
            child.Clear();
            child.Add(new CMD("A 전체복구", "41"));
            child.Add(new CMD("C 복구", "43"));
            child.Add(new CMD("F 발생", "46"));
            child.Add(new CMD("B 비상방송 연동정지", "42"));
            child.Add(new CMD("D 비상방송 연동정상", "44"));

            child2.Clear();
            child2.Add(new CMD("- 지상층", "20"));
            child2.Add(new CMD("B 지하층", "42"));
            child2.Add(new CMD("P 옥탑층", "50"));
            child2.Add(new CMD("K 주차장", "4b"));
        }
        public void CMD12Byte()
        {
            child.Clear();
            child.Add(new CMD("R 전체복구", "52"));
            child.Add(new CMD("F 복구", "46"));
            child.Add(new CMD("N 발생", "4e"));
            child.Add(new CMD("E 비상방송 연동정지", "45"));
            child.Add(new CMD("e 비상방송 연동정상", "65"));
        }

        public void Log(byte size, string cMD, string gB)
        {
            string str1 = "";
            switch (size)
            {
                case 10:
                    switch (cMD)
                    {
                        case "A": str1 = child[0].cmd; break;
                        case "C": str1 = child[1].cmd; break;
                        case "F": str1 = child[2].cmd; break;
                        case "B": str1 = child[3].cmd; break;
                        case "D": str1 = child[4].cmd; break;
                    }

                    switch (gB)
                    {
                        case " ": str1 = str1 + " : " + child2[0].cmd; break;
                        case "B": str1 = str1 + " : " + child2[1].cmd; break;
                        case "P": str1 = str1 + " : " + child2[2].cmd; break;
                        case "K": str1 = str1 + " : " + child2[3].cmd; break;
                    }
                    break;
                case 12:
                    switch (cMD)
                    {
                        case "R": str1 = child[0].cmd; break; 
                        case "F": str1 = child[1].cmd; break;
                        case "N": str1 = child[2].cmd; break;
                        case "E": str1 = child[3].cmd; break;
                        case "e": str1 = child[4].cmd; break;
                    }
                    break;
            }

            log = str1;
        }
    }

    [Serializable]
    public class CMD
    {
        public string cmd { get; set; }
        public string val { get; set; }
        public CMD(string c, string v)
        {
            cmd = c;
            val = v;
        }
    }

}
