using ITSIContaDesktopClient.Entities.User;
using ITSIContaDesktopClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSIContaDesktopClient.Controllers
{
    class ConnectionController
    {
        private APIService<Object> API;
        private const string LOGIN_URL = "/login";
        public ConnectionController()
        {
            API = new APIService<Object>();
        }

        public async Task<bool> IsServerUp()
        {
            return await API.IsServerUp();
        }

        public async Task<bool> LoginOnServer(User credentials)
        {
            try
            {
                Global.APIToken = await API.Post(LOGIN_URL, credentials);
                Global.APIToken = Global.APIToken.Split(' ')[1];
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
