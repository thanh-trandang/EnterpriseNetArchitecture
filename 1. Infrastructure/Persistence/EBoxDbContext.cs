using LogiGear.Infrastructure.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiGear.Infrastructure.Persistence
{
    public class EBoxDbContext : DbContext
    {
        public EBoxDbContext()
            : base("EBoxDbContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EBoxDbContext, Migrations.Configuration>("EBoxDbContext"));
        }

        public DbSet<User> Users { get; set; }
    }
}
