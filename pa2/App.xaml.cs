using System;
using System.IO;
using System.Threading;
using System.Windows;
using gClass;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;

namespace pa
{
    public partial class App : Application
    {
        public App()
        {
            // 가장 먼저 시작되는 곳...
            StartApp();
        }

        public void StartApp()
        {
            // 기본(대표) 리소스 화일명을 등록
        }

        Mutex _mutex = null;

        protected override void OnStartup(StartupEventArgs e)
        {
            string mutex_name = "SimplePA_EM";
            bool isCreateNew = false;

            try
            {
                _mutex = new Mutex(true, mutex_name, out isCreateNew);
                if (isCreateNew)
                {
                    base.OnStartup(e);
                }
                else
                {
                    Application.Current.Shutdown();
                }
            }
            catch (Exception ex)
            {
                Application.Current.Shutdown();
            }
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            g.XMLEMClient(true);
            string str1 = g._EMClient.apppath;

            var directoryInfo = new DirectoryInfo(str1 + "\\" + "Log");
            if (directoryInfo.Exists == false)
                directoryInfo.Create();

            g.XMLRead();

            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            // 로긴 후에 데이터 준비 기간 동안 프로그래스 바를 보여준다.
            var mainWindow = new MainWindow();
            //Re-enable normal shutdown mode.
            Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            Current.MainWindow = mainWindow;
            mainWindow.Show();

        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
        }
    }
}
