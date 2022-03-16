using gClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace pa
{
    public class SendSMS
    {
        public string tosms { get; set; }
        public string subject { get; set; }

        /*

        public string from { get; set; }
        public string to { get; set; }
        public string body { get; set; }

        public bool Send_email()
        {
            if (g.mail_use != 1)
                return false;
            from = g.mail_id;
            MailMessage mail = new MailMessage(from, to, subject, body);
            System.Net.NetworkCredential auth = new System.Net.NetworkCredential(g.mail_id, g.mail_pw);
            SmtpClient client = new SmtpClient(g.mail_server, g.mail_port);
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.Credentials = auth;

            try
            {
                client.Send(mail);
                Console.WriteLine("Emai sent");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Email was not sent : {0}", ex.Message);
                return false;
            }
            return true;
        }
        */
        public bool Send_sms()
        {
            if (gl._BaseData.sms_rcvno == "")
                return false;
            //if (g.sms_use != 1)
            //    return false;
            //Creating the Web Request.
            HttpWebRequest httpWebRequest = HttpWebRequest.Create(gl._BaseData.sms_server) as HttpWebRequest;
            httpWebRequest.Method = "POST";
            //Data to Post to the Page, itis key value pairs; separated by "&"
            string data1 = string.Format("userid={0}&password={1}", gl._BaseData.sms_id, gl._BaseData.sms_pw);
            string data2 = string.Format("{0}&msgcnt=1&msg1={1}", data1, subject);
            string data3 = string.Format("{0}&receivers={1}&sender=01000000000", data2, gl._BaseData.sms_rcvno);
            //Setting the content type, it is required, otherwise it will not work.
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            //Getting the request stream and writing the post data
            using (StreamWriter sw = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                sw.Write(data3);
            }
            //Getting the Respose and reading the result.
            try
            {
                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
                using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    string s1 = sr.ReadToEnd();
                    Console.WriteLine(s1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SMS Error : {0}", ex.Message);
            }
            return true;
        }
    }
}
