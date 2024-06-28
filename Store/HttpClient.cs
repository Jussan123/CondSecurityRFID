using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CondSecurityRFID.Store
{
    public class HttpOptions
    {
        private static readonly string host = "https://apicondsecurity.azurewebsites.net/api";
        private static readonly int timeOutSeconds = 5;
        public static HttpClient configuredHttpClient = new HttpClient();

        public static HttpClient GetHttpClientNoBearer()
        {
            configuredHttpClient = new HttpClient();
            configuredHttpClient.BaseAddress = new Uri(host);
            configuredHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header

            configuredHttpClient.DefaultRequestHeaders.Add("accept", "text/plain");
            configuredHttpClient.Timeout = TimeSpan.FromSeconds(timeOutSeconds);

            return configuredHttpClient;
        }

        public static HttpClient GetHttpClientBearer(String BearerToken)
        {
            configuredHttpClient = new HttpClient();
            configuredHttpClient.BaseAddress = new Uri(host);
            configuredHttpClient.DefaultRequestHeaders.Add("Accept", "*/*");

            configuredHttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken);
            configuredHttpClient.Timeout = TimeSpan.FromSeconds(timeOutSeconds);
            return configuredHttpClient;
        }
    }
}
