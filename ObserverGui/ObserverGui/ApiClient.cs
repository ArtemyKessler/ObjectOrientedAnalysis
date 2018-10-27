using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Timers;

using System.Threading.Tasks;

namespace ObserverGui
{
    public class ApiClient
    {
        static string URL = "https://api.weather.yandex.ru/v1/forecast?lat=55.75396&lon=37.620393&extra=true";
        public WebRequest request = WebRequest.Create(URL);
        
        public ApiClient()
        {
            request.Headers.Add("X-Yandex-API-Key", "065b9283-43c1-4641-8bc0-441d2d8d3559");
            request.Method = "GET";
        }

    }
}
