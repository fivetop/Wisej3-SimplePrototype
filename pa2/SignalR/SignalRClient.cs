using DataClass;
using Microsoft.AspNet.SignalR.Client;
using simplepa2.UI.Pages;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace pa
{
    public class SignalRClient
    {
		public IHubProxy proxy;
        //public PA_MainFrame owner { get; set; } = null;
		private HubConnection hubConnection;
        private bool Hub_Disconnect_Flag = false;

        public event EventHandler<SignalRMsg> eRcvSigR;
        public event EventHandler eConnect;
        public event EventHandler eDisConnect;

        public SignalRClient()
		{
		}

        public void HubDisconnect()
        {
            Hub_Disconnect_Flag = true;
            hubConnection.Dispose();
        }

        public async Task ConnectToSignalR()
		{
            hubConnection = new HubConnection("http://localhost:8080/signalr");

			proxy = hubConnection.CreateHubProxy("signalr");

            hubConnection.Received += Connection_Received;
            hubConnection.Reconnected += Connection_Reconnected;
            hubConnection.Reconnecting += Connection_Reconnecting;
            hubConnection.StateChanged += Connection_StateChanged;
            hubConnection.Error += connection_Error;
            hubConnection.ConnectionSlow += connectionhubConnectionSlow;
            hubConnection.Closed += Connection_Closed;
            // 아래 코드는 디버그가 필요한 경우 사용  -- romee/jake
            hubConnection.TraceLevel = TraceLevels.All;
            hubConnection.TraceWriter = Console.Out;
            hubConnection.Headers.Add("user_id", "Client1");

            await hubConnection.Start();

            proxy.On<string>("sendMessageToClients", async (str1) =>
			{
				Console.WriteLine(str1);

			});

            proxy.On<SignalRMsg>("MessageS2C2", async (msg) =>
            {
                try 
                {
                    eRcvSigR?.Invoke(this, msg);
                    //owner.RcvSigR(msg);
                    Console.WriteLine("<" + msg.message);

                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1.Message);
                }
            });

            proxy.On<SignalRMsg>("MessageC2S2", async (msg) =>
            {
                Console.WriteLine(msg.message);
            });
        }



        private void Connection_Received(string obj)
        {
            Console.WriteLine("Connected to SignalR Data. {0}", obj.ToString());

            if (obj.Contains("Already exists."))
            {
                try
                {
                }
                catch (Exception e)
                {
                }
            }
        }

        void connectionhubConnectionSlow()
        {
            Console.WriteLine(string.Format("connectionhubConnectionSlow New State:" + hubConnection.State + " " + hubConnection.ConnectionId));
        }

        void connection_Error(Exception obj)
        {
            Console.WriteLine(string.Format("connection_Error New State:" + hubConnection.State + " " + hubConnection.ConnectionId));
        }

        public event Action<bool> ConnectionEvent;
        public ConnectionState State
        {
            get { return hubConnection.State; }
        }


        // 서버 연결 상태가 변경되면 컬러 상태를 바꾸어 준다. -> WPF 에서 이벤트로 처리 
        public async void Connection_StateChanged(StateChange obj)
        {
            int tid = 0;

            switch (this.State)
            {
                case ConnectionState.Connecting:
                    //r_state = 1;
                    //set_connect_color(_red);
                    // Console.WriteLine("ConnectionState.Connecting");
                    break;
                case ConnectionState.Connected:
                    eConnect?.Invoke(obj, null);
                    //set_connect_color(_green);
                    break;
                case ConnectionState.Reconnecting:
                    ///set_connect_color(_red);
                    break;
                case ConnectionState.Disconnected:
                    try
                    {
                        //set_connect_color(_red);
                    }
                    catch (Exception e1)
                    {
                        Console.WriteLine("{0}", e1.ToString());
                    }
                    break;
            }

            if (this.State == ConnectionState.Connected)
            {
                if (ConnectionEvent != null)
                    ConnectionEvent.Invoke(true);
            }
            else
            {
                if (ConnectionEvent != null)
                    ConnectionEvent.Invoke(false);
            }
            Console.WriteLine(string.Format("connection_StateChanged New State:" + hubConnection.State + " " + hubConnection.ConnectionId));
        }
        // 커넥션이 다시 되는 경우 
        void Connection_Reconnecting()
        {
            // Console.WriteLine(string.Format("connection_Reconnecting New State:" + hubConnection.State + " " + hubConnection.ConnectionId));
        }

        void Connection_Reconnected()
        {
            // Console.WriteLine(string.Format("connection_Reconnected New State:" + hubConnection.State + " " + hubConnection.ConnectionId));
        }

        Thread t1;
        // 커넥션이 종료된 경우 -> 디버깅시 발생 
        private void Connection_Closed()
        {
            eDisConnect?.Invoke("Disconnect", null);
            //owner.LabelON(9, false);
            Console.WriteLine("SignalR Client Disconnected.");
            if (!Hub_Disconnect_Flag)
            {
                t1 = new Thread(new ThreadStart(Run));
                t1.Start();
            }

        }

        void Run()
        {
            Thread.Sleep(10000); // 30000
            ConnectToSignalR();
            t1.Abort();
        }

        // 서버와 연결/해제 되면 해당 색상이 바뀜
        private void set_connect_color(Color color)
        {
             //AlertBox.Show("test");
        }

        public void MessageS2C2(SignalRMsg message)
        {
            if (this.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                this.proxy.Invoke("MessageS2C2", message);
        }

        public void MessageC2S2(SignalRMsg message)
        {
            if (this.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                this.proxy.Invoke("MessageC2S2", message);
        }

    }
}