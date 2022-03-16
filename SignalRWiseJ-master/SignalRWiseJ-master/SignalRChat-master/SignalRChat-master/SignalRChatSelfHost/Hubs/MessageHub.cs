using Microsoft.AspNet.SignalR;
using System;

namespace SignalRChatSelfHost.Hubs
{
    public class signalr : Hub
    {
        public void Send(string alias, string message)
        {
            Clients.All.sendMessageToClients($"[Self Hosted Server][{DateTime.Now}] <b>{alias} says:</b> {message}");
        }
    }
}