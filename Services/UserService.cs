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
        private readonly APIService API;
        public UserService()
        {
            Db = Global.Db;
            API = new APIService();
        }

        public bool AreThereAnyUserOnLocalDb()
        {
            return Db.Users.Count() > 0;
        }


    }
}
