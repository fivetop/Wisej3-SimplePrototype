using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;

namespace gClass
{
    public class TimeManager
    {

        public DateTime OverHttp()
        {
            Dictionary<string, string> HeaderList = new Dictionary<string, string>();
            WebRequest WebRequestObject = HttpWebRequest.Create("https://www.google.com");


            DateTime httpTime = new DateTime();
            try
            {
                WebResponse ResponseObject = WebRequestObject.GetResponse();
                foreach (string HeaderKey in ResponseObject.Headers)
                {
                    if (HeaderKey == "Date")
                    {
                        if (DateTime.TryParse(ResponseObject.Headers[HeaderKey], out httpTime))
                        {
                            httpTime = TimeZone.CurrentTimeZone.ToLocalTime(httpTime);
                        }
                    }
                }
                ResponseObject.Close();

                return httpTime;
            }
            catch (Exception)
            {
                return httpTime;
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetSystemTime(ref time newTime);

        struct time
        {
            public short Year;
            public short Month;
            public short DayOfWeek;
            public short Day;
            public short Hour;
            public short Minute;
            public short Second;
        }

        public void SystemTime(DateTime newTime)
        {
            newTime = newTime.ToUniversalTime();
            time setTime = new time();
            setTime.Year = (short)newTime.Year;
            setTime.Month = (short)newTime.Month;
            setTime.DayOfWeek = (short)newTime.DayOfWeek;
            setTime.Day = (short)newTime.Day;
            setTime.Hour = (short)newTime.Hour;
            setTime.Minute = (short)newTime.Minute;
            setTime.Second = (short)newTime.Second;

            SetSystemTime(ref setTime);
        }
    }
}