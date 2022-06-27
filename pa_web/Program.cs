using System;
using System.Web.Http;
using Wisej.Web;
using System.Diagnostics;
using System.Collections.Generic;

namespace pa_web
{
    internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			//Capture original request and response
			//Enabling Attribute Routing, e.g domain.com/api/product/1
			GlobalConfiguration.Configure(WebApiConfig.Register);

			/*
			LoginPage loginPage = new LoginPage();
			loginPage.Show();
			// */

			Application.Desktop = new MyDesktop();
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}

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