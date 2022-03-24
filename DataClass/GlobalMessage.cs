using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DataClass
{

    public static class GlobalMessage
    {
        public const uint HWND_BROADCAST = 0xffff;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern uint RegisterWindowMessage(string lpString);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool PostMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        static private uint message;

        public static uint Register(string msg)
        { 
            message = RegisterWindowMessage(msg);
            return message;
        }

        public static void Send(uint msg, int v1, long v2)
        {
            IntPtr i1 = new IntPtr(v1);
            IntPtr i2 = new IntPtr(v2);
            PostMessage((IntPtr)HWND_BROADCAST, msg, i1, i2);
        }
    }
}
