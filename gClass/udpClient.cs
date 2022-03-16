using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace gClass
{
    public class udpClient
    {
        public UdpClient udp = null;
        IAsyncResult ar_ = null;
        IPEndPoint ips = null;
        IPEndPoint ipr = null;

        public List<byte[]> buf2 = new List<byte[]>();
        public int id;
        public int ch;
        public byte[] on = { };
        public byte[] off = { };
        public string dstip;

        public udpClient()
        {
            udp = new UdpClient();
            id = 0;
            ch = 0;
            dstip = "";
            buf2.Clear();
        }

        public void option(IPAddress pAddress, int intfindex)
        {
            var options = new MulticastOption(pAddress, intfindex);
            udp.Client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, options);
        }

        public void Close()
        {
            try
            { 
                if (udp != null)
                {
                    udp.Close();
                    //udp = null;
                }
            }
            catch (Exception e1)
            { 
            }
        }

        public void send(string strip, int port, byte[] bytes)
        {
            if (bytes == null)
                return;
            try
            {
                ips = new IPEndPoint(IPAddress.Parse(strip), port);
                udp.Send(bytes, bytes.Length, ips);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        public void rcv()
        {
            try
            {
                udp.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udp.ExclusiveAddressUse = false;
                ipr = new IPEndPoint(IPAddress.Any, 0);
                udp.Client.Bind(ipr);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
            StartListening();
        }

        private void StartListening()
        {
            ar_ = udp.BeginReceive(Receive, new object());
        }

        private void Receive(IAsyncResult ar)
        {
            try
            {
                if (udp != null)
                {
                    IPEndPoint ip = new IPEndPoint(IPAddress.Any, 0);
                    //IPEndPoint ip = new IPEndPoint(IPAddress.Any, port);
                    byte[] buffer = udp?.EndReceive(ar, ref ip);
                    if (buffer == null)
                        return;

                    if (buffer.Length < 12)
                        return;

                    try
                    {
                        makeData(buffer);
                    }
                    catch (Exception e1)
                    {
                        Console.WriteLine(e1.Message);
                    }


                    StartListening();

                    if (ips == null)
                        return;

                    if (OnReceiveMessage != null)
                    {
                        OnReceiveMessage(gl.bytetostring(buffer));
                        //OnReceiveMessage(ips.Address.ToString());
                        //Console.WriteLine(gl.bytetostring(buffer));
                    }

                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }

        }

        private void makeData(byte[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] == 0xb3)
                {
                    byte[] buf3 = new byte[12];
                    Buffer.BlockCopy(buffer, i, buf3, 0, 12);
                    buf2.Add(buf3);
                    i = i + 12;
                    //Console.WriteLine(gl.bytetostring(buf3));
                }
                if (i + 12 > buffer.Length)
                {
                    break;
                }
            }
        }

        public delegate void ReceiveMessageHandler(string message);
        public event ReceiveMessageHandler OnReceiveMessage;
/*
        public void sendON(int v)
        {
            ips = new IPEndPoint(IPAddress.Parse(dstip), v);
            udp.Send(on, on.Length, ips);
        }

        public void sendOFF(int v)
        {
            ips = new IPEndPoint(IPAddress.Parse(dstip), v);
            udp.Send(off, off.Length, ips);
        }
*/
    }
}
