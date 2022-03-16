using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;

[assembly: OwinStartup(typeof(sig_svr_wpf.Startup))]

namespace sig_svr_wpf
{

    [HubName("signalr")]
    public class signalr : Hub
    {
        public signalr()
        {
            App._hub = this;
        }

        public void AddMessage(string name, string message)
        {
            Console.WriteLine("Hub AddMessage {0} {1}\n", name, message);
            Clients.All.addMessage(name, message);
        }

        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
            sendMessageToClients("ssssssssssssssssss");
        }
        public void sendMessageToClients(string message)
        {
            Clients.All.sendMessageToClients(message);
        }
        /*
                public void MessageS2C(msg message)
                {
                    Clients.All.MessageS2C(message);
                    g.Log(message.em_status);
                }

                public void MessageC2S(msg message)
                {
                    Clients.All.MessageC2S(message);
                    g.Log(message.em_status);
                }
        */
    }

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

    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        static Thread t2;
        public static signalr _hub = null;
        public App()
        {
            // 가장 먼저 시작되는 곳...
            StartApp();
        }

        public void StartApp()
        {
            // 기본(대표) 리소스 화일명을 등록
        }


        protected override void OnStartup(StartupEventArgs e)
        {
                    base.OnStartup(e);
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            // 로긴 후에 데이터 준비 기간 동안 프로그래스 바를 보여준다.
            var mainWindow = new MainWindow();
            //Re-enable normal shutdown mode.
            Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            Current.MainWindow = mainWindow;
            mainWindow.Show();

            t2 = new Thread(new ThreadStart(DoSignalRThread));
            t2.Start();


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
