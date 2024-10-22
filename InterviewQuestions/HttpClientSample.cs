
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class HttpClientSample
    {
        private readonly HttpClient _httpClient;

        //It’s a good practice to make the HttpClient injectable for better testability. 
        //Here’s a refactored version of your FetchDataAsync method:
        public HttpClientSample(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AsyncAwaitTest()
        {
            string url = "https://jsonplaceholder.typicode.com/posts/1";
            
            try
            {
                string result = await FetchDataAsync(url);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public async Task<string> FetchDataAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
