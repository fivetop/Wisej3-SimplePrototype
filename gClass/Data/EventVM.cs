using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace gClass
{
    /*
    public class EventVm
    {
        [Key]
        public int EventVMId { get; set; }   // Event (1)   <-- 건수 표시
        public string base_text { get; set; }   // Event (1)   <-- 건수 표시
        public DateTime write_time { get; set; }
        public string event_text { get; set; }

        public string ip { get; set; }
        public string path { get; set; }
        public string DeviceName { get; set; }
        public string state { get; set; }


        public EventVm()
        {
            write_time = DateTime.Now;
        }

        public EventVm(string ip, string path, string devicename, string state)
        {
            write_time = DateTime.Now;
            this.ip = ip;
            this.path = path;
            this.DeviceName = devicename;
            this.state = state;
            if (state == "")
                event_text = path + " " + DeviceName + "(" + ip + ")" + " Off line";
            else
                event_text = path + " " + DeviceName + "(" + ip + ")" + " " + state;

        }
    }
    */
}
