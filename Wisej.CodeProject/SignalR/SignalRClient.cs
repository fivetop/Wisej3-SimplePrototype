using DataClass;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Wisej.Web;

namespace Wisej.CodeProject.SignalR
{
    public class SignalRClient
    {
		public IHubProxy proxy;
        public MyDesktop owner { get; set; } = null;

		private HubConnection hubConnection;

        public SignalRClient()
		{
		}


        public async Task ConnectToSignalR()
		{
            hubConnection = new HubConnection("http://localhost:8080/signalr");

			proxy = hubConnection.CreateHubProxy("signalr");
			await hubConnection.Start();


            hubConnection.Received += Connection_Received;
            hubConnection.Reconnected += Connection_Reconnected;
            hubConnection.Reconnecting += Connection_Reconnecting;
            hubConnection.StateChanged += Connection_StateChanged;
            hubConnection.Error += connection_Error;
            hubConnection.ConnectionSlow += connectionhubConnectionSlow;
            hubConnection.Closed += Connection_Closed;

            proxy.On<string>("sendMessageToClients", async (str1) =>
			{
				Console.WriteLine(str1);

			});

            proxy.On<SignalRMsg>("MessageS2C2", async (msg) =>
            {
                Application.Update(owner, () =>
                {
                    owner.RcvSigR(msg);
                });
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
                    // GS_DEL 단일 유저 접속 처리 
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
            // romee 2015/05/07 서버가 끈어지면 타이머를 돌려 1분마다 재시도 처리 필요 // 부산 주택금융공사 
            // 여기서 처리 요망 

        }

        // 타이머 처리 


        // 커넥션이 다시 되는 경우 
        void Connection_Reconnecting()
        {
            // Console.WriteLine(string.Format("connection_Reconnecting New State:" + hubConnection.State + " " + hubConnection.ConnectionId));
        }

        void Connection_Reconnected()
        {
            // Console.WriteLine(string.Format("connection_Reconnected New State:" + hubConnection.State + " " + hubConnection.ConnectionId));
        }

        // 커넥션이 종료된 경우 -> 디버깅시 발생 
        private void Connection_Closed()
        {
            Console.WriteLine("SignalR Client Disconnected.");
        }

        // 서버와 연결/해제 되면 해당 색상이 바뀜
        private void set_connect_color(Color color)
        {
            Application.Update(owner, () =>
            {
                AlertBox.Show("test");
                //g.main_window._colorConnect.DarkColor = color;
                //g.main_window._colorConnect.LightColor = color;
            });
        }

        public void send(SignalRMsg msg)
        {
            try
            {
                proxy.Invoke("Send", new object[] { msg });
            }
            catch (Exception e)
            {
                Console.WriteLine("Error={0}, Message={1}", e.HResult, e.Message);
            }
        }
        // 수신 메시지 처리 
        private async Task<bool> process_msg(SignalRMsg msg)
        {
            eSignalRMsgType type = msg.Msgtype;
            switch (type)
            {
                case eSignalRMsgType.eEM:
                    break;
            }
            return true;
        }
        // 자산 변경시 서버로 시그날 전송 
        public void send_asset_to_signalr()
        {
            SignalRMsg msg = new SignalRMsg()
            {
                Msgtype = eSignalRMsgType.eEM,
                message = string.Format("Hello Server")
            };
            if (proxy == null)
                return;
            send(msg);
        }

    }
}