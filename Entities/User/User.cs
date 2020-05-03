using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSIContaDesktopClient.Entities.User
{
    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
        public Role Role { get; set; }
    }
}
