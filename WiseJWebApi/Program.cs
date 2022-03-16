using Wisej.Web;
using System.Web.Http;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Threading;
using System.Web.Routing;
using System.Diagnostics;
using System;
using Nancy.Json;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WebPage1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //Capture original request and response
            //Enabling Attribute Routing, e.g domain.com/api/product/1
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Application.MainPage = new Page1();
        }
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
    }

    public class MessageHandler : DelegatingHandler
    {
   
        private bool IsApi(HttpRequestMessage request)
        {
            return request.RequestUri.PathAndQuery.StartsWith("/api");
        }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // CATCH THE REQUEST BEFORE SENDING TO THE ROUTING HANDLER

            if (IsApi(request))
            {

                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                if (request.Method == HttpMethod.Post)
                {
                   // var headers = request.ToString();
                   // var body = request.Content.ReadAsStringAsync().Result;
                   // var fullRequest = headers + "\n" + body;

                    Debug.WriteLine("Processing Post");
                    
                    if(request.Content.Headers.ContentType.MediaType == @"application/json")
                    {
                        string data = request.Content.ReadAsStringAsync().Result;
                        JavaScriptSerializer jc = new JavaScriptSerializer();
                        Dictionary<string, string> keyValue = jc.Deserialize<Dictionary<string, string>>(data);

                        bool success = false;
                        try
                        {
                            output.name = keyValue["User"];
                            output.surname = keyValue["Password"];
                            success = true;
                        }
                        catch
                        {
                            //Error in finding fields
                        }
                        if(success)
                        {

                            //SqlConnection myConnection = new SqlConnection("user id=usr;" +
                            //                               "password=pass;server=192.168.1.100;" +
                            //                               "Trusted_Connection=yes;" +
                            //                               "database=Test; " +
                            //                               "connection timeout=30");

                            //try
                            //{
                            //    myConnection.Open();
                            //}
                            //catch (Exception e)
                            //{
                            //    Console.WriteLine(e.ToString());
                            //}

                            //SqlCommand myCommand = new SqlCommand("INSERT INTO table (Column1, Column2) " +
                            //         "Values ('string', 1)", myConnection);
                            //myCommand.ExecuteNonQuery();

                            //try
                            //{
                            //    myConnection.Close();
                            //}
                            //catch (Exception e)
                            //{
                            //    Console.WriteLine(e.ToString());
                            //}
                        }

                    }

                 
                    response = new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent("Post Processed!"),
                    };
                }
                else if (request.Method == HttpMethod.Get)
                {
                    Debug.WriteLine("Processing Get");
                    string json = new JavaScriptSerializer().Serialize(
                                                                        new
                                                                        {
                                                                            user = output.name,
                                                                            password = output.surname
                                                                        });

                    // Create the response.
                    response = new HttpResponseMessage(HttpStatusCode.OK)
                    {

                    Content = new StringContent(json)
                    };
                }
                else
                {
                    response = request.CreateResponse(HttpStatusCode.Unauthorized, "You are not authorized");
                }
                // Note: TaskCompletionSource creates a task that does not contain a delegate.
                var tsc = new TaskCompletionSource<HttpResponseMessage>();
                tsc.SetResult(response);   // Also sets the task state to "RanToCompletion"
                return tsc.Task;
            }
            else
            {
                //Pass onto next handler
                return base.SendAsync(request, cancellationToken);
            }
        }
    }


    public class output
    {
        public output()
        {
            result = "Welcome " + name + " " + surname;
        }

        public string result;

        [NonSerialized]
        public static string name;
        [NonSerialized]
        public static string surname;

    }
}