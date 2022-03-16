using Microsoft.AspNet.SignalR;
using System;

namespace SignalRChatSystem.Hubs
{
    public class MessagesHub : Hub
    {
        public void Send(string alias, string message)
        {
            Clients.All.sendMessageToClients($"[{DateTime.Now}] <b>{alias} says:</b> {message}");
        }
    }
}