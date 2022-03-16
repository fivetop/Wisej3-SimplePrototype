using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;

namespace SignalRChatSelfHost
{
    /*
    [HubName("signalr")]
    public class signalr : Hub
    {
        public signalr()
        {
            Program._hub = this;
        }

        public void Send2(string alias, string message)
        {
            Clients.All.sendMessageToClients($"[Self Hosted Server][{DateTime.Now}] <b>{alias} says:</b> {message}");
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
    }
    */
}