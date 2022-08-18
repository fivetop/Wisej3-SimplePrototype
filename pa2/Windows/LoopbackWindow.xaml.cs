using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace pa.Windows
{
    using DataClass;
    using gClass;
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoopbackWindow : Window
    {
        SerialPort spP = new SerialPort(); // P형 화재 수신기 통신용 
        string comPort = "COM3";
        CMDList CMDList = new CMDList();
        CMDList CMDList10 = new CMDList();
        // R 0x52 전체복구  F 0x46 복구  N 발생 E 비상방송 연동정지 e 비상방송 연동정상 

        public LoopbackWindow()
        {
            InitializeComponent();
            comPort = "COM3";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboType.ItemsSource = CMDList.child;
            cboType.SelectedIndex = 0;
            CMDList10.CMD10Byte();
            cboType2.ItemsSource = CMDList10.child;
            cboType2.SelectedIndex = 0;
            cboType21.ItemsSource = CMDList10.child2;
            cboType21.SelectedIndex = 0;
            OpenP();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            spP.Close();
        }

        // P, R 형 수신기 로직 처리 추가 
        public void OpenP()
        {
            if (spP.IsOpen == true)
            {
                spP.Close();
                //return;
            }
            spP.PortName = comPort;
            spP.BaudRate = 9600;
            spP.DataBits = 8;
            spP.Parity = Parity.None;
            spP.StopBits = StopBits.One;

            spP.DataReceived += new SerialDataReceivedEventHandler(SpP_DataReceived);
            try
            {
                spP.Open();
                //sp.Write("gpio iodir ffffffff");
                //spP.WriteLine("gpio iodir ffffffff");
                g.Log("Comm Port Open : " + spP.PortName);
            }
            catch (IOException e1)
            {
                g.Log("Comm Port Error...." + e1.Message);
            }
        }


        private void SpP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                //this.ReceiveProcess();
                g.mainWindow.ReceiveProcessTypeR(this.spP);
            }));
        }

        List<pktr> pktList = new List<pktr>();
        byte[] rx_data = new byte[1024];
        byte cnt = 0;
        private void ReceiveProcess()
        {
            int rx = spP.BytesToRead;
            byte[] trx = new byte[rx];

            int rx1 = spP.Read(trx, 0, rx);

            for (int i=0; i < rx1; i++)
            { 
                switch (trx[i])
                {
                    case 2:
                        cnt = 0;
                        rx_data[cnt] = 2;
                        break;
                    case 3:
                        rx_data[cnt] = 3;
                        pktr pktr1 = new pktr(rx_data, cnt);
                        pktList.Add(pktr1);
                        break;
                    default:
                        if (trx[i] < 0x30) 
                            break;
                        rx_data[cnt] = trx[i];
                        break;
                }
                cnt++;
            }
        }

        string old_string = "";
        public void Log(string str1)
        {
            if (str1 == old_string)
                return;
            old_string = str1;

            try
            {
                string fn = DateTime.Now.ToShortDateString();
                StreamWriter writer = new StreamWriter(File.Open("C:\\SimplePA\\Log_Server\\" + fn + "_232.txt", FileMode.Append));
                TextWriterTraceListener listener = new TextWriterTraceListener(writer);
                //Debug.Listeners.Add(listener);
                //Debug.WriteLine(string.Format("{0} : {1}", DateTime.Now, str1));
                //Debug.Flush();
                string st1 = string.Format("{0} : {1}", DateTime.Now, str1);
                writer.WriteLine(st1);
                writer.Close();
                Console.WriteLine(st1);
            }
            catch (ObjectDisposedException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        Thread th1;
        private void _send_Click(object sender, RoutedEventArgs e)
        {
            th1 = new Thread(sendpkt12);
            th1.Start();
        }

        private void sendpkt12()
        {
            //for (int i = 1; i < 10; i++)
            {
                Dispatcher.Invoke(DispatcherPriority.Normal, ((ThreadStart)delegate
                {
                    pktr pkt1 = makePkt12();
                    spP.Write(pkt1.pkt, 0, 12);
                }));
                Thread.Sleep(100);
            }
        }

        public pktr makePkt12()
        {
            string s1 = txt0.Text;
            string s2 = txt1.Text;
            string s3 = txt2.Text;

            byte[] b1 = Encoding.UTF8.GetBytes(s1);
            byte[] b2 = Encoding.UTF8.GetBytes(s2);
            byte[] b3 = Encoding.UTF8.GetBytes(s3);

            s1 = BitConverter.ToString(b1).Replace("-", string.Empty);
            s2 = BitConverter.ToString(b2).Replace("-", string.Empty);
            s3 = BitConverter.ToString(b3).Replace("-", string.Empty);

            var t1 = (string)cboType.SelectedValue;
            pktr pkt1 = new pktr(s1, s2, s3, t1);
            txt3.Text = pkt1.pkt2str;

            pkt1.tot = BitConverter.ToString(pkt1.pkt).Replace("-", string.Empty);
            txt4.Text = pkt1.tot;
            return pkt1;
        }
        private void cboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t1= cboType.SelectedValue;

            pktr pkt1 = makePkt12();

        }

        public void tst_spR()
        {
            byte[] b1 = { 0x02, 0x30, 0x31, 0x2d, 0x30, 0x31, 0x2d, 0x30, 0x31, 0x4e, 0x30, 0x03 };

            string t2 = Encoding.ASCII.GetString(b1);

            string st2 = bytetostring(b1);

            Console.WriteLine(t2);
            Console.WriteLine(st2);

        }


        public static string bytetostring(byte[] t)
        {
            string ret = string.Empty;

            ret = string.Concat(Array.ConvertAll(t, byt => byt.ToString("x2")));
            return ret;
        }

        private void _dump_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                Dispatcher.Invoke(DispatcherPriority.Normal, ((ThreadStart)delegate
                {
                    string str = i.ToString("D2");
                    txt0.Text = str;
                    pktr pkt1 = makePkt12();
                    spP.Write(pkt1.pkt, 0, 12);
                }));
                Thread.Sleep(100);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pktr pkt1 = makePkt10();
            spP.Write(pkt1.pkt, 0, pkt1.pkt.Length);
        }

        public pktr makePkt10()
        {
            if (cboType2.Items.Count < 1) return null;
            if (cboType21.Items.Count < 1) return null;
            string s1 = txt0.Text;
            string s2 = txt1.Text.Substring(1,1);
            string s3 = txt2.Text;

            byte[] b1 = Encoding.UTF8.GetBytes(s1);
            byte[] b2 = Encoding.UTF8.GetBytes(s2);
            byte[] b3 = Encoding.UTF8.GetBytes(s3);

            s1 = BitConverter.ToString(b1).Replace("-", string.Empty);
            s2 = BitConverter.ToString(b2).Replace("-", string.Empty);
            s3 = BitConverter.ToString(b3).Replace("-", string.Empty);

            var t1 = (string)cboType2.SelectedValue;
            var t2 = (string)cboType21.SelectedValue;
            pktr pkt1 = new pktr();
            pkt1.pktr10(s1, s2, s3, t1, t2);
            txt3.Text = pkt1.pkt2str;

            pkt1.tot = BitConverter.ToString(pkt1.pkt).Replace("-", string.Empty);
            txt4.Text = pkt1.tot;
            return pkt1;
        }

        private void cboType2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t1 = cboType2.SelectedValue;
            pktr pkt1 = makePkt10();
        }

        private void cboType21_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t1 = cboType21.SelectedValue;
            pktr pkt1 = makePkt10();
        }
    }
}
