using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace HttpClientWinForm
{
    public partial class frmDefault : Form
    {
        public string RequestMethod;

        public frmDefault()
        {
            InitializeComponent();
            ServicePointManager.SecurityProtocol |= (SecurityProtocolType)0x300 | (SecurityProtocolType)0xc00;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            if (RequestMethod.Equals("GET"))
            {
                HttpGet();
            }
            else if (RequestMethod.Equals("POST"))
            {
                HttpPost();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        bool CheckInput()
        {
            if (textBoxAddress.Text.Trim().Equals(""))
            {
                textBoxAddress.Focus();
                return false;
            }
            else if (!radioButtonGet.Checked && !radioButtonPost.Checked)
            {
                return false;
            }
            else
            {
                if (radioButtonGet.Checked)
                {
                    RequestMethod = "GET";
                }
                else if (radioButtonPost.Checked)
                {
                    RequestMethod = "POST";
                }
                else
                {
                    RequestMethod = "GET";
                }
                return true;
            }
        }

        /// <summary>
        /// HttpClient-Post方法
        /// </summary>
        void HttpPost()
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(textBoxAddress.Text.Trim());
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = Encoding.UTF8.GetByteCount(textBoxQueryString.Text.Trim());
                req.KeepAlive = false;
                req.ProtocolVersion = HttpVersion.Version11;
                using(StreamWriter sw = new StreamWriter(req.GetRequestStream()))
                {
                    sw.Write(textBoxQueryString.Text.Trim());
                    sw.Close();
                }
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                string encoding = res.ContentEncoding;
                if(encoding == null || encoding.Length < 1)
                {
                    encoding = "UTF-8";
                }
                StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.GetEncoding(encoding));
                string retString = sr.ReadToEnd();
                sr.Close();
                textBoxOutputArea.Text = retString;
            }
            catch (Exception)
            {
                return;
            }
        }

        /// <summary>
        /// HttpClient-Get方法
        /// </summary>
        void HttpGet()
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(textBoxAddress.Text.Trim());
                req.Method = "GET";
                req.ContentType = "text/plain;charset=utf-8";
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream mrs = res.GetResponseStream();
                StreamReader msr = new StreamReader(mrs, Encoding.UTF8);
                string retString = msr.ReadToEnd();
                msr.Close();
                mrs.Close();
                textBoxOutputArea.Text = retString;
            }
            catch (Exception)
            {
                return;
            }
        }

        /// <summary>
        /// 窗口关闭监控
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDefault_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        /// <summary>
        /// 窗口尺寸修改事件监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDefault_ResizeEnd(object sender, EventArgs e)
        {
            if(this.Width <= 530)
            {
                this.Width = 530;
            }
            if(this.Height <= 427)
            {
                this.Height = 427;
            }
        }

        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            textBoxOutputArea.Text = "";
        }
    }
}
