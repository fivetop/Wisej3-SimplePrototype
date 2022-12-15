using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;

using System;
using System.Diagnostics;
using Wisej.Web;
using System.Collections.Generic;
using System.Web.Http;
using simplepa2.UI.Pages;
using System.Threading;
using simplepa2.SignalR;

[assembly: OwinStartup(typeof(simplepa2.Startup))]

// test

namespace simplepa2
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
			//app.MapSignalR(hubConfiguration);
			// Program Work Git
			// Program Work Git2222
		}
	}

	static class Program
	{
		static Thread t2;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			// Microsoft.AspNet.WebApi.WebHost 참조 필요 
			GlobalConfiguration.Configure(WebApiConfig.Register);

			//Application.MainPage = new PA_Login();
			Application.LoadTheme("LSMaterial-3"); //"Material-3" .

			Application.MainPage = new PA_MainFrame();
			//Application.MainPage = new Simple();

			if (t2 == null)
			{ 
				t2 = new Thread(new ThreadStart(DoSignalRThread));
				t2.Start();
			}
		}

		// SignalR Server
		private static void DoSignalRThread()
		{
			string url = "http://*:8080";
			Console.WriteLine("Server running on {0}", url);
			using (WebApp.Start(url))
			{
				while (true)
					Thread.Sleep(10);
			}
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}


		// 사용자 추가 처리 
		internal static event EventHandler ClientListChanged;
		private static List<string> _clientList = new List<string>();

		internal static void AddClient(string name)
		{
			lock (_clientList)
			{
				if (!_clientList.Contains(name))
				{
					_clientList.Add(name);

					ClientListChanged?.Invoke(null, EventArgs.Empty);
				}
			}
		}

		internal static string[] GetList()
		{
			lock (_clientList)
			{
				return _clientList.ToArray();
			}
		}


		// CPU 상태 보기 처리 - 사용치 않음  

		internal static float CPU
		{
			get
			{
				// returns a random number for this sample.
				// returning the CPU Usage % requires elevated
				// permissions on the server side.
				lock (theCPUCounter)
				{
					return theCPUCounter.Next(50);
					// return theCPUCounter.NextValue();
				}
			}
		}
		private static Random theCPUCounter = new Random();
		// private static PerformanceCounter theCPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
	}

	// webapi 지원용 
	// http://localhost:9921/api/user

	public static class WebApiConfig
	{
		//WebApiConfig.Register(GlobalConfiguration.Configuration);
		//FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
		//RouteConfig.RegisterRoutes(RouteTable.Routes);
		//BundleConfig.RegisterBundles(BundleTable.Bundles);

		//API is basically resources, and methods to manipulate those resources

		public static void Register(HttpConfiguration config)
		{
			try
			{
				// Attribute routing.
				config.MapHttpAttributeRoutes();

				config.Routes.MapHttpRoute(
					name: "Route1",
					routeTemplate: "api/{controller}/{id}",
					defaults: new { id = RouteParameter.Optional }
				);

				// Convention-based routing.
				config.Routes.MapHttpRoute(
					name: "DefaultApi",
					routeTemplate: "api/{controller}/{id}",
					defaults: new { id = RouteParameter.Optional },
					constraints: null,
					handler: new MessageHandler()
				);
			}
			catch (Exception e1)
			{
				Debug.WriteLine(e1.Message);
			}
		}
	}
}