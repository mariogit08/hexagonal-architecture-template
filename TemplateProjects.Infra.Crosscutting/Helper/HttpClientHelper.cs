using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Helper
    
{
    public class HttpClientHelper
    {
        public static HttpClient CreateHttpClient(Uri baseUri)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = baseUri;
            return client;
        }

        public static HttpClient CreateHttpClientBasicAuth(string login)
        {
            HttpClient client = new HttpClient();

            byte[] credentialsBytes = Encoding.UTF8.GetBytes(login);
            string credentials64 = Convert.ToBase64String(credentialsBytes);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials64);

            return client;
        }
        public static HttpClient CreateHttpClientBasicAuth(Uri baseUri, string login)
        {
            HttpClient client = new HttpClient();

            byte[] credentialsBytes = Encoding.UTF8.GetBytes(login);
            string credentials64 = Convert.ToBase64String(credentialsBytes);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials64);
            client.BaseAddress = baseUri;
            return client;
        }
    }
}
