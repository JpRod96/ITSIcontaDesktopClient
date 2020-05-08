using ITSIContaDesktopClient.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ITSIContaDesktopClient.Services
{
    class APIService<T>
    {
        private readonly HttpClient HttpClient;

        public APIService()
        {
            HttpClient = Global.APIClient;
        }

        public async Task<bool> IsServerUp()
        {
            try
            {
                var checkingResponse = await HttpClient.GetAsync("");
                return checkingResponse.IsSuccessStatusCode;
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
        }

        public async Task<string> Post(string url, User user)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync(
            url, new { username= user.Username, password= user.Password });
            response.EnsureSuccessStatusCode();
            return response.Headers.GetValues("Authorization").ToList()[0];
        }

        public async Task<List<T>> GetList(string url)
        {
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global.APIToken);
            List<T> list = null;
            HttpResponseMessage response = await HttpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                list = await response.Content.ReadAsAsync<List<T>>();
            }
            return list;
        }
    }
}
