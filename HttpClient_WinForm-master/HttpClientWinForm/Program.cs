using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace HttpClientWinForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool singleInstance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using(Mutex mutex = new Mutex(true,Application.ProductName,out singleInstance))
            {
                if (singleInstance)
                {
                    Application.Run(new frmDefault());
                }
                else
                {
                    DialogResult dr = MessageBox.Show("温馨提示：已有一个以上的客户端实例正在运行！请注意，运行过多的实例访问同一目标可能会导致网络堵塞。是否继续启动？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        Application.Run(new frmDefault());
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Environment.Exit(1);
                    }
                }
            }
        }
    }
}
