using gClass;
using System;
using System.IO;

/*
<sms_server>http://sms.nicesms.co.kr/cpsms_utf8/cpsms.aspx</sms_server>
<sms_id>lstest</sms_id>
<sms_pw>FFo0DXm9fvE9LBlkZIsO+IIhNQINR+1SM2KV2uCr3BY=</sms_pw>

*/

namespace WatchDog
{
    [Serializable]
    public class EMClient
    {
        public string apppath { get; set; } = @"C:\SimplePA2\";
        public string EM_NAME { get; set; } = "서울";
        public string NetworkCardName { get; set; } = "이더넷";
        public int NetworkCardNo { get; set; } = 0;
        public int NetworkCardmDNS { get; set; } = 0;
        public string WebAPIURL { get; set; } = @"http://localhost:9921/api/";
        public string HubURL { get; set; } = @"http://localhost:8080/signalr";
        public string processname { get; set; } = @"pa_em";
        public string processfile { get; set; } = @"pa_em.exe";


        public EMClient()
        {
        }
    }


    public static class g
    {
        #region // 글로벌 변수 선언 
        static public EMClient _EMClient { get; set; } = new EMClient(); // 기초 정보

        // DanteDevice 
        public static void XMLEMClient(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = AppDomain.CurrentDomain.BaseDirectory + "EMClient.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _EMClient = ser.Deserialize<EMClient>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<EMClient>(_EMClient);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                xmlData = ser.Serialize<EMClient>(_EMClient);
                File.WriteAllText(path, xmlData);
            }
        }


        #endregion

    }

}
