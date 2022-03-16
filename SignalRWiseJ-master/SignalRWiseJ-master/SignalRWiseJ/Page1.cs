using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Wisej.Web;

namespace SignalRWiseJ {

    public partial class Page1 : Page 
    {
        public HubConnection hub;

        public event Action<string> MessageReceived;

        public Page1() {
            InitializeComponent();
            this.MessageReceived += Page1_MessageReceived;

        }

        private void Page1_MessageReceived(string obj)
        {
            Console.WriteLine(obj.ToString());
        }

        private void Connector_MessageReceived(string obj) {
            textBox1.Text = obj;
            Application.Update(textBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string signalr_uri_string = @"http://localhost:8080/signalr";
            //string signalr_uri_string = @"http://localhost:5100/chat";

            try
            {
                this.hub = new HubConnectionBuilder().WithUrl(signalr_uri_string)
                        .WithAutomaticReconnect()
                        .Build();
                this.hub.On<string>("broadcastMessage", s => MessageReceived?.Invoke(s));
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }

            try
            {
                hub.StartAsync();
                hub.InvokeAsync("Send", "aaa", "bbb");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hub.InvokeAsync("Send", "aaa", "bbb");
            hub.InvokeAsync("AddMessage", "aaa", "bbb");

        }

    }
}
