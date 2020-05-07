using ITSIContaDesktopClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSIContaDesktopClient.Controllers
{
    class UserController
    {
        private readonly UserService userService;
        public UserController()
        {
            userService = new UserService();
        }

        public bool IsFirstRun()
        {
            return userService.AreThereAnyUserOnLocalDb();
        }
    }
}
