using ITSIContaDesktopClient.PersistenceConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSIContaDesktopClient.Services
{
    class UserService
    {
        private readonly LocalContext LocalStorage;
        public UserService()
        {
            LocalStorage = new LocalContext();
        }


    }
}
