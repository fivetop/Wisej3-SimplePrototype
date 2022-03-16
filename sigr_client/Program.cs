using gClass;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisej.CodeProject;

namespace sigr_client
{
    class Program
    {
        static void Main(string[] args)
        {
            var hubConnection = new HubConnection("http://localhost:8080/");
            IHubProxy proxy = hubConnection.CreateHubProxy("signalr");
            hubConnection.Start().Wait();

            proxy.On<string, string>("broadcastMessage", (name, message) =>
            {
                Console.WriteLine("{0} : {1}", name, message);
            });

            proxy.On<string>("sendMessageToClients", async (str1) =>
            {
                Console.WriteLine(str1);

            });

            proxy.On<SignalRMsg>("MessageS2C2", async (msg) =>
            {
                Console.WriteLine(msg.message);
            });

            proxy.On<SignalRMsg>("MessageC2S2", async (msg) =>
            {
                Console.WriteLine(msg.message);
            });


            while (true)
            {
                Console.Write(">");
                string MyMessage = Console.ReadLine();
                SignalRMsg t1 = new SignalRMsg();
                t1.message = MyMessage;
                proxy.Invoke("MessageC2S2", t1);
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
