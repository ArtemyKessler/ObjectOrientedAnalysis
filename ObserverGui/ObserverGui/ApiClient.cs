using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Timers;
using Newtonsoft.Json;

using System.Threading.Tasks;

namespace ObserverGui
{
    public class ApiClient
    {
        static string URL = "https://api.weather.yandex.ru/v1/forecast?lat=55.75396&lon=37.620393&extra=true";
        
        public ApiClient()
        {
            
        }

        public void GetDataViaApi()
        {
            Thread.Sleep(1500);
         
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Headers.Add("X-Yandex-API-Key", "065b9283-43c1-4641-8bc0-441d2d8d3559");
            request.Method = "GET";

            HttpWebResponse webResponse = (HttpWebResponse) request.GetResponse();
            string textResponse;
            using (StreamReader reader = new StreamReader(webResponse.GetResponseStream() ?? throw new Exception("Response = 0")))
            {
                textResponse = reader.ReadToEnd();
            }
            text
            GetDataViaApi();
        }

    }
}
