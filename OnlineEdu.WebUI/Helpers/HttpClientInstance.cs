using OnlineEdu.WebUI.Services.TokenServices;

namespace OnlineEdu.WebUI.Helpers
{
    public static class HttpClientInstance
    {
        

        public static HttpClient CreateClient() {
            
            HttpClient client = new HttpClient();
            
            client.BaseAddress = new Uri("https://localhost:7114/api/");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer");

            return client;

                
                
        }
    }
}
