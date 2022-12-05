using System;
using System.Net;
using System.Net.Mail;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_SystemEmail : Wisej.Web.UserControl
    {
        private Email_DataList email_DataSet;
        private bool bt_pw_open = false;
        public View_SystemEmail()
        {
            InitializeComponent();
        }

        public View_SystemEmail(Email_DataList edl)
        {
            this.email_DataSet = edl;
            InitializeComponent();
        }

        private void View_SystemEmail_Load(object sender, EventArgs e)
        {
            // Debug
            MessageBox.Show("Demo 로 ExampleData로 동작합니다., Release 시 삭제");
            email_DataSet = make_DumpData();
            
            if(email_DataSet != null)
            {
                this.tb_ServerName.Text = email_DataSet.emailName;
                this.tb_PortNumber.Text = Convert.ToString(email_DataSet.portName);
                this.tb_Timeout.Text = Convert.ToString(email_DataSet.timeout);
                this.tbSenderEmail.Text = email_DataSet.senderEmail;
                this.tb_ReceiverEmail.Text = email_DataSet.receiverEmail;

                this.tb_CertifyName.Text = email_DataSet.certificationName;
                this.tb_CertifyPasswd.Text = email_DataSet.certificationPasswd;

                if (email_DataSet.noSecurity == true)
                {
                    this.rb_None.Checked = true;
                }
                else if (email_DataSet.sslUsage == true)
                {
                    this.rb_SSL.Checked = true;
                }
                else if (email_DataSet.tlsUsage == true)
                {
                    this.rb_TLS.Checked = true;
                }
            }
            
        }

        private void bt_MailTest_Click(object sender, EventArgs e)
        {
            // Debug
            AlertBox.Show("Email Test Function for Test");
            
            if(SendTestEmail(this.email_DataSet))
            {
                MessageBox.Show("Mail 송신이 성공했습니다");
            }
            else
            {
                MessageBox.Show("Mail 송신이 실패했습니다.");
            }

        }


        private bool SendTestEmail(Email_DataList email_data)
        {
            bool returnFlag = true;
            try
            {
                var smtpClient = new SmtpClient(email_data.emailName)
                {
                    
                    UseDefaultCredentials = false,
                    Port = email_data.portName,
                    EnableSsl = email_data.sslUsage,
                    Timeout = email_data.timeout,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(email_data.certificationName, email_data.certificationPasswd),                    
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(email_data.senderEmail),
                    Subject = "Mail Registration from SimplePA Network Server",
                    Body = "<h1>Hello this is test email from simplepa system, your email configured as management email account. </h1>",
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(email_data.receiverEmail);
                smtpClient.Send(mailMessage);
            } catch(Exception e)
            {
                returnFlag = false;
                MessageBox.Show(e.ToString());                
            }

            return returnFlag;
        }

        // Example 데이터 만들기용 
        private Email_DataList make_DumpData()
        {
            Email_DataList edl = new Email_DataList();
            edl.emailName = "smtp.naver.com";
            edl.portName = 587;
            edl.timeout = 1000;
            edl.senderEmail = "lscnstest@naver.com";
            edl.receiverEmail = "conculer@lscns.com";

            edl.spareEmailName = "";

            edl.certificationName = "lscnstest";
            edl.certificationPasswd = "123edsw@@#";

            edl.noSecurity = false;
            edl.tlsUsage = false;
            edl.sslUsage = true;

            return edl;
        }

        private void bt_toText_Click(object sender, EventArgs e)
        {
            this.bt_pw_open = !bt_pw_open;
            if(this.bt_pw_open)
            {
                bt_toText.Text = "숨기기";                
                this.tb_CertifyPasswd.InputType.Type = Wisej.Web.TextBoxType.Text;

            }
            else
            {
                bt_toText.Text = "문자로보기";
                this.tb_CertifyPasswd.InputType.Type = Wisej.Web.TextBoxType.Password;

            }
        }

        private void rb_None_CheckedChanged(object sender, EventArgs e)
        {
            email_DataSet.noSecurity = rb_None.Checked;
            email_DataSet.sslUsage = rb_SSL.Checked;
            email_DataSet.tlsUsage = rb_TLS.Checked;
        }

        private void rb_TLS_CheckedChanged(object sender, EventArgs e)
        {
            email_DataSet.noSecurity = rb_None.Checked;
            email_DataSet.sslUsage = rb_SSL.Checked;
            email_DataSet.tlsUsage = rb_TLS.Checked;
        }

        private void rb_SSL_CheckedChanged(object sender, EventArgs e)
        {
            email_DataSet.noSecurity = rb_None.Checked;
            email_DataSet.sslUsage = rb_SSL.Checked;
            email_DataSet.tlsUsage = rb_TLS.Checked;
        }
    }


    public class Email_DataList
    {
        public string emailName;
        public int portName;
        public int timeout;
        public string senderEmail;
        public string receiverEmail;

        public string spareEmailName;
        public string spareEmailPort;

        public string certificationName;
        public string certificationPasswd;

        public bool sslUsage;
        public bool tlsUsage;
        public bool noSecurity;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
