using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ProductMVC
{
    public static class GlobalVariable
    {
        public static HttpClient webApiClient = new HttpClient();
        static GlobalVariable()
        {
            webApiClient.BaseAddress = new Uri("https://localhost:44353/api/");
            webApiClient.DefaultRequestHeaders.Clear();
            webApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}