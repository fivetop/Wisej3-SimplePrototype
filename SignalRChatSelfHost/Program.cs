using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Threading;

[assembly: OwinStartup(typeof(SignalRChatSelfHost.Startup))]

namespace SignalRChatSelfHost
{
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

    class Program
    {
        static Thread t2;
        public static signalr _hub = null;


        static void Main(string[] args)
        {
            // This will *ONLY* bind to localhost, if you want to bind to all addresses
            // use http://*:8080 to bind to all addresses. 
            // See http://msdn.microsoft.com/library/system.net.httplistener.aspx 
            // for more information.
            string url = "http://localhost:8080";
            //using (WebApp.Start(url))
            {
                //Console.ReadLine();
            }

            t2 = new Thread(new ThreadStart(DoSignalRThread));
            t2.Start();
        }

        private static void DoSignalRThread()
        {
            string url = "http://localhost:8080";
            Console.WriteLine("Server running on {0}", url);
            using (WebApp.Start(url))
            {
                while (true)
                    Thread.Sleep(10);
            }
        }
    }
}
