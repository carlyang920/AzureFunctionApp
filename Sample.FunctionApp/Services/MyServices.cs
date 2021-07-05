using System.Net.Http;

namespace Sample.FunctionApp.Services
{
    public class MyServices
    {
        private readonly HttpClient _httpClient;

        public MyServices(
            IHttpClientFactory httpClientFactory
            )
        {
            _httpClient = httpClientFactory.CreateClient();
        }
    }
}
