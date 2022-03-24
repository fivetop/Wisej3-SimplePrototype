using DataClass;
using gClass;
using Microsoft.AspNet.SignalR;
using System;
using System.Threading.Tasks;
using Wisej.CodeProject;

namespace SignalRChatSelfHost
{
    //[HubName("signalr")]
    
    public class signalr : Hub
    {
        public signalr()
        {
            g._hub = this;
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

        public void MessageS2C2(SignalRMsg message)
        {
            Clients.All.MessageS2C2(message);
            //g.Log(message.message);
        }

        public void MessageC2S2(SignalRMsg message)
        {
            Clients.All.MessageC2S2(message);
            Console.WriteLine(message.message);
            //g.Log(message.message);
        }
    }



    //*/

    /*

    public class chat : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            string msg = string.Format(
                "A new user {0} has just joined. (ID: {1})",
                request.QueryString["name"], connectionId);
            return Connection.Broadcast(msg);
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {

            string msg = string.Format(
                "{0}: {1}", request.QueryString["name"], data);
            return Connection.Broadcast(msg);
        }
    }

    public static class UserHandler
    {
        public static HashSet<string> ConnectedIds = new HashSet<string>();
    }


    [HubName("JakeHub")]
    public class JakeHub : Hub
    {
        static List<string> userinfo = new List<string>();
        public static JakeHub _hub = null;

        public JakeHub()
        {
            _hub = this;
        }

        public override Task OnConnected()
        {
            Clients.Caller.send("Connected..............");

            UserHandler.ConnectedIds.Add(Context.ConnectionId);
            var u1 = Context.Headers["user_id"];
            string c1 = "user";
            if (u1 == null)
            {
                c1 = "user";
                u1 = c1.ToString();
            }
            else
                c1 = u1.ToString();

            var c2 = userinfo.Find(p => p == c1);
            //if (c2 != null)
            if (userinfo.Count > 0)
            {
                Clients.Caller.send("Already exists.");
            }
            userinfo.Add(c1);
            // GS_DEL 일정시간 이후 카운트 클리어용 삭제 필요 
            TestStartTimer();
            //
            string str = string.Format("{0}:{1}", UserHandler.ConnectedIds.Count.ToString(), u1.ToString());
            var version = Context.QueryString["contosochatversion"];
            if (version != "1.0")
            {
                Clients.Caller.notifyWrongVersion();
            }
            Send("broadcastMessage", "Connected..............");

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool b1)
        {
            Clients.Caller.send("Already exists.");
            UserHandler.ConnectedIds.Remove(Context.ConnectionId);
            var u1 = Context.Headers["user_id"];
            userinfo.Remove(u1.ToString());
            string str = string.Format("{0}", UserHandler.ConnectedIds.Count.ToString());
            return base.OnDisconnected(true);
        }

        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }

        // I2MS 메시지 스타일
        public void Send(String msg)
        {
            Clients.All.broadcastMessage(msg);
        }

        // GS_DEL 사용자 입력 없으면 서버에서 클라이언트 관리 카운트 삭제 처리 
        private System.Timers.Timer myTimer = new System.Timers.Timer();

        // 타이머 로직 처리 
        private void TestStartTimer()
        {
            myTimer.Elapsed += new ElapsedEventHandler(OnTimer);
            myTimer.Interval = 660 * 1000;
            myTimer.Enabled = true;
            myTimer.AutoReset = false;
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            if (!myTimer.Enabled)
            {
                myTimer.Enabled = true;
                myTimer.AutoReset = false;
            }
        }

    }
    */
}