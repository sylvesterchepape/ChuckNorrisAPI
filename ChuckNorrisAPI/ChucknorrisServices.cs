using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChuckNorrisAPI
{
    public interface IChucknorrisServices
    {
        Task<string> Get();
    }
    public class ChucknorrisServices : IChucknorrisServices
    {
        private HttpClient _httpClient;

        public ChucknorrisServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> Get()
        {
            string APIURL = $"?";
            var response = await _httpClient.GetAsync(APIURL);
            
            return await response.Content.ReadAsStringAsync();

        }
    }
}
