using ITSIContaDesktopClient.Entities.User;
using ITSIContaDesktopClient.PersistenceConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ITSIContaDesktopClient.Services
{
    class UserService
    {
        private readonly LocalContext Db;
        private readonly APIService<User> API;
        public UserService()
        {
            Db = Global.Db;
            API = new APIService<User>();
        }

        public bool AreThereAnyUserOnLocalDb()
        {
            return Db.Users.Count() > 0;
        }

        public async Task<List<User>> GetAllUsersFromAPI()
        {
            return await API.GetList("/users");
        }
    }
}
