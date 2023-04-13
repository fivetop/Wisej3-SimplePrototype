using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Wisej.Web;

namespace KakaoTTSTest
{
    public class KTTSManager
    {
        private static readonly HttpClient httpClient = new HttpClient();


        public static async Task DownloadTTSAsync(string ssml, string apiKey, string apiEndpointUrl, string outputPath)
        {
            // Configure HttpClient headers
            httpClient.DefaultRequestHeaders.Add("x-api-key", apiKey);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            httpClient.DefaultRequestHeaders.Add("X-TTS-Engine", "deep");

            // Prepare the request content
            var content = new StringContent(ssml, Encoding.UTF8, "application/xml");

            // Send the POST request
            HttpResponseMessage response = await httpClient.PostAsync(apiEndpointUrl, content);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                // Generate a random file name
                string randomFileName = Path.GetRandomFileName();
                randomFileName = Path.ChangeExtension(randomFileName, ".mp3");
                string fullOutputPath = Path.Combine(outputPath, randomFileName);

                // Save the response content as an MP3 file
                using (var fileStream = new FileStream(fullOutputPath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    await response.Content.CopyToAsync(fileStream);
                }
                AlertBox.Show($"TTS 음성 파일이 {fullOutputPath}로 저장되었습니다.");
            }
            else
            {
                AlertBox.Show("요청이 실패했습니다. 오류 코드: " + response.StatusCode);
            }
        }





        public static string BuildSSML(string content, string voiceName, string rate, string volume)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentException("Content cannot be empty or null");
            }

            if (string.IsNullOrEmpty(voiceName))
            {
                voiceName = "Summer"; // 기본 목소리 설정
            }

            if (string.IsNullOrEmpty(rate))
            {
                rate = "medium"; // 기본 속도 설정
            }

            if (string.IsNullOrEmpty(volume))
            {
                volume = "medium"; // 기본 볼륨 설정
            }

            string ssml = $@"<speak>
                              <voice name=""{voiceName}"">
                                <prosody rate=""{rate}"" volume=""{volume}"">
                                  {content}
                                </prosody>
                              </voice>
                            </speak>";

            return ssml;
        }


    }

}
