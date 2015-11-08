using System.Data.Entity.Migrations;
using Uranus.Data.Infrastucture;

namespace Uranus.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DatabaseContext context)
        {
             
        }
    }
}