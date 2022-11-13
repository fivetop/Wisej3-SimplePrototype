using System;
using System.Diagnostics;
using Wisej.Web;
using System.Collections.Generic;
using System.Web.Http;
using simplepa2.UI.Pages;

namespace simplepa2
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			// Microsoft.AspNet.WebApi.WebHost 참조 필요 
			GlobalConfiguration.Configure(WebApiConfig.Register);

			/*
			LoginPage loginPage = new LoginPage();
			loginPage.Show();
			// */

			Application.MainPage = new PA_MainFrame();
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