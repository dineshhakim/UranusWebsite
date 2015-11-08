using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uranus.Domain.Entities;

namespace Uranus.Data.Infrastucture
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
           // : base("DefaultConnection")
        {
            // ROLA - This is a hack to ensure that Entity Framework SQL Provider is copied across to the output folder.
            // As it is installed in the GAC, Copy Local does not work. It is required for probing.
            // Fixed "Provider not loaded" error
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Company> Company { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Products> Products { get; set; }

        public DbSet<OrderDemo> OrderDemo { get; set; }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

    }

}
