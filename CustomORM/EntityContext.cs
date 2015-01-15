using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomORM
{
    public class EntityContext : DbContext
    {
        public DbSet<Lot> Lots { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
