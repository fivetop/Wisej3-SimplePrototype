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
using DataClass;

namespace simplepa2
{
    public static class gweb
    {
        public static PA_MainFrame mainFrame { get; set; } = null;
        public static signalr _hub { get; set; } = null;

        public static List<PA_MainFrame> mgf { get; set; } = new List<PA_MainFrame>();

        public static int dashBoardRefreshInterval = 5000;

        public static DBController dBSqlite { get; set; } = new DBController(); // DB 처리용 

        public static void RcvSigR(SignalRMsg msg1)
        {
            string addinfo = msg1.EMNAME;
            bool disp = true;

            switch (msg1.Msgtype)
            {
                case eSignalRMsgType.eEM:
                    if (msg1.state == 1)
                        addinfo = "ONLINE";
                    else
                        addinfo = "OFFLINE";
                    gweb.dBSqlite.Eventsyslog(addinfo, msg1.EMNAME, addinfo);
                    gweb.dBSqlite.EMServerupdate(msg1.EMNAME, addinfo);
                    //view_DashBoard2.reDraw();
                    break;
                case eSignalRMsgType.eEM_FIRE:
                    switch (msg1.seqno)
                    {
                        case 1:
                            gweb.dBSqlite.Eventvm("화재발생수신", msg1.state + "층", msg1.message);
                            break;
                        case 2:
                            gweb.dBSqlite.Eventvm("화재복구수신", msg1.state + "층", msg1.message);
                            break;
                        case 3:
                            gweb.dBSqlite.Eventvm("시험화재발생", "0층 시험", msg1.message);
                            break;
                        case 4:
                            gweb.dBSqlite.Eventvm("시험화재복구", "0층 시험", msg1.message);
                            break;
                    }
                    //view_DashBoard2.reDraw();
                    break;
                case eSignalRMsgType.eEM_PRESET_SW:
                    string m0 = "PRESET_SW";
                    string m1 = msg1.EMNAME + ":" + msg1.seqno.ToString() + "번 프리셋 버튼";
                    string m2 = "OFF";

                    if (msg1.state == 1) m2 = "ON";
                    if (msg1.seqno == 0)
                        m1 = msg1.EMNAME + ":" + "All 프리셋 버튼";

                    switch (msg1.seqno)
                    {
                        case 0:
                            gweb.dBSqlite.Eventpreset(m0, m1, m2);
                            break;
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            gweb.dBSqlite.Eventpreset(m0, m1, m2);
                            break;
                    }
                    gweb.dBSqlite.EMServerupdatePreset(msg1.EMNAME, msg1.seqno, msg1.state);
                    //view_DashBoard2.reDraw2();
                    //if (view_BBSEMManage2 != null) view_BBSEMManage2.reDraw();
                    break;
                case eSignalRMsgType.ePlay:
                    //view_DashBoard2.reDraw2();
                    //view_BBCEMManager2.reDraw();
                    break;
                case eSignalRMsgType.ePlayCheck:
                    disp = false;
                    break;
                case eSignalRMsgType.ePlayEnd:
                    disp = false;
                    //view_DashBoard2.reDraw2();
                    //view_BBSAnchor2.refresh();
                    //view_BBCEMManager2.reDraw();
                    break;
                case eSignalRMsgType.ePlaying:
                    disp = false;
                    //view_DashBoard2.reDraw2();
                    //view_BBCEMManager2.reDraw();
                    break;
                case eSignalRMsgType.eStop:
                    //view_BBCEMManager2.reDraw();
                    break;
                case eSignalRMsgType.eLoginUser:
                    break;
                case eSignalRMsgType.eLogoutUser:
                    disp = false;
                    break;
                case eSignalRMsgType.eScanEM:
                    //view_BBSEMManage2.reDraw();
                    break;
                case eSignalRMsgType.eFindDSP:
                    if (msg1.state == 1)
                    {
                        gweb.dBSqlite.LinkAssetDevice();
                        //reDraw();
                    }
                    //else
                    //    AlertBox.Show("DSP 혹은 버철사운드를 확인 바랍니다..", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
                    break;
            }
        }


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