using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ITSIContaDesktopClient.Services
{
    class APIService
    {
        private HttpClient HttpClient;

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
    }
}
