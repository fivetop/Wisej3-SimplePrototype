using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa
{
    public class DBAccess
    {
        HttpClient httpClient = new HttpClient();

        #region // Database 초기화 처리

        public T Dbread <T>(string url)
        {
            try
            {
                var url2 = g1._EMClient.WebAPIURL + url;
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                var res = httpClient.GetStringAsync(url2).Result;
                var ret = JsonConvert.DeserializeObject<T>(res);
                return (T)ret;
            }
            catch (Exception e1)
            {
                return default(T);
            }
        }
        #endregion

    }
}
