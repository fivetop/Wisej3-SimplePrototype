using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchDog
{
    class ManageProcess
    {
        public string ProcessName { get; set; }
        public string ProcessFile { get; set; }
        public int notrespondingcount { get; set; }
        public int view { get; set; }
        public ManageProcess(string ProcessName, string ProcessFile, int view)
        {
            this.ProcessName = ProcessName;
            this.ProcessFile = ProcessFile;
            this.view = view;
            this.notrespondingcount = 0;
        }
    }
}
