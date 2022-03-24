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

[assembly: OwinStartup(typeof(pa.Startup))]

namespace pa
{

    // Signal R 쓰레드 진입점 
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            var hubConfiguration = new HubConfiguration();
            hubConfiguration.EnableDetailedErrors = true;
            hubConfiguration.EnableJSONP = true;
            hubConfiguration.EnableJavaScriptProxies = true;
            app.MapSignalR("/signalr", hubConfiguration);
        }
    }

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

        Thread t2;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            t2 = new Thread(new ThreadStart(DoSignalRThread));
            t2.Start();

            string str1 = gl.appPathServer;
            //str1 = System.IO.Directory.GetCurrentDirectory();

            var directoryInfo = new DirectoryInfo(str1 + "\\" + "Log");
            if (directoryInfo.Exists == false)
                directoryInfo.Create();

            g.ReadConfig();
            g.XMLRead();
            g.Log("XMLRead");

            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            // 로긴 후에 데이터 준비 기간 동안 프로그래스 바를 보여준다.
            var mainWindow = new MainWindow();
            //Re-enable normal shutdown mode.
            Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            Current.MainWindow = mainWindow;
            mainWindow.Show();

        }

        private static void DoSignalRThread()
        {
            string url = "http://localhost:8080";
            using (WebApp.Start(url))
            {
                while (true)
                    Thread.Sleep(10);
            }
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            t2.Abort();
        }
    }
}
