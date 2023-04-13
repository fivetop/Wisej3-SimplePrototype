using System;
using System.Security.Claims;
using System.Windows.Forms;
using Wisej.Web;

namespace KakaoTTSTest
{
    public partial class Window1 : Wisej.Web.Form
    {

        public string APIKey = "1686354bc9da7dd8bf974dc770761f34";
        public string APIEndpointUrl = "https://4a1429dc-581e-4eb9-9a75-ffbb28dac134.api.kr-central-1.kakaoi.io/ai/text-to-speech/fcdea7e09c804c46996368bb8ecf89b6";
        public Window1()
        {
            InitializeComponent();

            
            comboVoice.SelectedIndex = 0;
            comboProsody.SelectedIndex = 1;
            comboVolume.SelectedIndex = 1;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // comboVoice, comboProsody, tbTTSText 에서 셋팅값을 받아와 string 변 수를 생성해서 SSML를 작성
            string voice = comboVoice.Text;
            string prosody = comboProsody.Text;
            string volume = comboVolume.Text;
            string text = tbTTSText.Text;
            // SSML 작성
            string ssml = KTTSManager.BuildSSML(text, voice, prosody, volume);

            string outputPath = @"C:\Users\YKGOME\Music";
            // SSML을 음성으로 변환, 파일 저장 
            await KTTSManager.DownloadTTSAsync(ssml, APIKey, APIEndpointUrl, outputPath);
        }

    }
}
