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
            : base("EFDbContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            //TODO check this calling
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<EBoxDbContext, Migrations.Configuration>("EFDbContext"));
        }
    }
}
