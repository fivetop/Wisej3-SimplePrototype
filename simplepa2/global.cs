using simplepa2.SignalR;
using simplepa2.UI.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using static simplepa2.DataSet1;
using System.Net;
using System.Net.Mail;


namespace simplepa2
{
    public static class gweb
    {
        public static PA_MainFrame mainFrame { get; set; } = null;
        public static signalr _hub { get; set; } = null;

        public static List<PA_MainFrame> mgf { get; set; } = new List<PA_MainFrame>();

        public static int dashBoardRefreshInterval = 5000;

        public static DBController dBSqlite { get; set; } = new DBController(); // DB 처리용 


        #region // 로그 처리 
        static string old_string = "";
        public static void Log(string str1)
        {
            if (str1 == old_string)
                return;
            old_string = str1;

            try
            {
                string fn = "svr_" + DateTime.Now.ToString("yyyy_MM_dd");
                StreamWriter writer = new StreamWriter(File.Open("C:\\SimplePA2\\Log\\" + fn + ".txt", FileMode.Append));
                TextWriterTraceListener listener = new TextWriterTraceListener(writer);
                //Debug.Listeners.Add(listener);
                //Debug.WriteLine(string.Format("{0} : {1}", DateTime.Now, str1));
                //Debug.Flush();
                string st1 = string.Format("{0} : {1}", DateTime.Now, str1);
                writer.WriteLine(st1);
                writer.Close();
                Console.WriteLine(st1);
                if (mainFrame != null)
                {
                    //mainFrame.log(st1);
                }
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
        #endregion


        #region // 기타 공통 유틸

        public static void SendTestEmail(string rcvmail,string sub, string id, string pw)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.naver.com")
                {
                    UseDefaultCredentials = false, Port = 587, EnableSsl = true, Timeout = 1000,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(id, pw),
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("fivetop@naver.com"),
                    Subject = "SimplePA Network Server.",
                    Body = "<h1> your password : " + sub + " </h1>",
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(rcvmail);
                smtpClient.Send(mailMessage);
            }
            catch (Exception e)
            {
                Log("Mail Error :" + e.Message);
            }
        }

        #endregion
    }
}