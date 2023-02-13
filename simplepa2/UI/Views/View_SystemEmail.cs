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

        private string str_error_message = "필수 데이터입니다.";
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
            email_DataSet = getData();

            if (email_DataSet != null)
            {
                setData(email_DataSet);
            }
        }

        private Email_DataList getData()
        {
            // Debug , DB GET 구현 
            MessageBox.Show("Demo 로 ExampleData로 동작합니다., Release 시 삭제");

            Email_DataList data = make_DumpData();     // DB Get 구현 필요 

            return data;

        }

        private void setData(Email_DataList emailDataSet)
        {
            this.tb_ServerName.Text = emailDataSet.emailName;
            this.tb_PortNumber.Text = Convert.ToString(emailDataSet.portName);
            this.tb_Timeout.Text = Convert.ToString(emailDataSet.timeout);
            this.tb_SenderEmail.Text = emailDataSet.senderEmail;
            this.tb_ReceiverEmail.Text = emailDataSet.receiverEmail;

            this.tb_CertifyName.Text = emailDataSet.certificationName;
            this.tb_CertifyPasswd.Text = emailDataSet.certificationPasswd;

            if (emailDataSet.noSecurity == true)
            {
                this.rb_None.Checked = true;
            }
            else if (emailDataSet.sslUsage == true)
            {
                this.rb_SSL.Checked = true;
            }
            else if (emailDataSet.tlsUsage == true)
            {
                this.rb_TLS.Checked = true;
            }
        }

        private Email_DataList packData()
        {
            Email_DataList data = new Email_DataList();
            data.emailName = this.tb_ServerName.Text;
            data.portName = Convert.ToInt32(this.tb_PortNumber.Text);
            data.timeout = Convert.ToInt32(this.tb_Timeout.Text);
            data.senderEmail = this.tb_SenderEmail.Text;
            data.receiverEmail = this.tb_ReceiverEmail.Text;
            data.certificationName = this.tb_CertifyName.Text;
            data.certificationPasswd = this.tb_CertifyPasswd.Text;

            data.noSecurity = this.rb_None.Checked;
            data.sslUsage = this.rb_SSL.Checked;
            data.tlsUsage = this.rb_TLS.Checked;

            return data;
        }

        private void bt_MailTest_Click(object sender, EventArgs e)
        {
            // Debug
            AlertBox.Show("Email Test Function for Test");

            this.email_DataSet = packData();
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
                    Subject = "SimplePA Network Server register your email account as management purpose.",
                    Body = "<h1>Hello, SimplePA Network Server register your email  </h1>",
                    IsBodyHtml = true,
                };
                email_data.receiverEmail = this.tb_ReceiverEmail.Text;
                mailMessage.To.Add(email_data.receiverEmail);
                smtpClient.Send(mailMessage);
            } catch(Exception e)
            {
                returnFlag = false;
                MessageBox.Show(e.ToString());                
            }

            return returnFlag;
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

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            setData(email_DataSet);   // 저장이 되지 않은 데이터를 되돌림
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {

            if(formValidation())
            {
                // 
                email_DataSet = packData();
                
                // DB update logic   : dbUpdate(email_dataSet)
                MessageBox.Show("구현 필요 : DB 업데이트 기능");
            }
            else
            {
                AlertBox.Show("에러메시지의 데이터를 입력하시오");
            }

        }

        private bool formValidation()
        {
            bool bValidation = true;
                        
            if(this.tb_ServerName.Text.Trim().Equals(""))
            {
                bValidation = false;
                this.errorProvider1.SetError(this.tb_ServerName, str_error_message);
            }

            if (this.tb_PortNumber.Text.Trim().Equals(""))
            {
                bValidation = false;
                this.errorProvider1.SetError(this.tb_PortNumber, str_error_message);
            }

            if (this.tb_ReceiverEmail.Text.Trim().Equals(""))
            {
                bValidation = false;
                this.errorProvider1.SetError(this.tb_ReceiverEmail, str_error_message);
            }

            return bValidation;
        }


        // Example 데이터 만들기용 =================================================================
        private Email_DataList make_DumpData()
        {
            Email_DataList edl = new Email_DataList();
            edl.emailName = "smtp.naver.com";
            edl.portName = 587;
            edl.timeout = 1000;
            edl.spareEmailName = "";

            edl.senderEmail = "lscnstest@naver.com";
            edl.receiverEmail = "conculer@lscns.com";
            edl.certificationName = "lscnstest";
            edl.certificationPasswd = "123edsw@@#";

            edl.noSecurity = false;
            edl.tlsUsage = false;
            edl.sslUsage = true;

            return edl;
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
