using gClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Threading;

namespace pa
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        // 챗서버, 유틸리티

        #region  // 챗 서버 처리 
        private void S1_OnReceiveMessage(string message)
        {
            g.Log("Server RX=>" + message);
        }
        #endregion

        #region // 유틸 처리 

        internal void log(string st1)
        {
            Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
            {
                mlog.Insert(0, st1);

                if (mlog.Count > 100)
                    mlog.Clear();
            }));
        }

        public string Mid(string text, int si, int ei)
        {
            string str1;

            if (si < text.Length || ei < text.Length)
            {
                str1 = text.Substring(si, ei);
                return str1;
            }
            else
                return text;
        }

        private List<int> stringCompare(string newst, string oldst)
        {
            List<int> ret = new List<int>();
            for (int i = 0; i < newst.Length; i++)
            {
                if (newst.Substring(i, 1) != oldst.Substring(i, 1))
                {
                    ret.Add(i);
                }
            }
            return ret;
        }

        private int GetBit(string str1, int v)
        {
            int ret = 1;
            var str5 = Mid(str1, v, 1);
            if (str5 == "0")
                ret = 0;
            return ret;
        }


        // 타이머가 종료 할때 처음곡 시작 
        #endregion




    }
}
