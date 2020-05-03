using ITSIContaDesktopClient.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSIContaDesktopClient.PersistenceConfigurations
{
    class LocalContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        private readonly string connectionString = String.Format("Data Source = {0}.db", Global.DB_NAME);
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(connectionString);
    }
}
