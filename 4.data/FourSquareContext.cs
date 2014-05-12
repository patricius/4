using _4.data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.data
{
    public class FourSquareContext : DbContext
    {
        public FourSquareContext() :
            base("DBConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FourSquareContext, FourSquareContextMigrationConfiguration>());
        }

        public DbSet<BookmarkedPlace> BookmarkedPlaces { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookmarkedPlaceMapper());

            base.OnModelCreating(modelBuilder);
        }
    }
}
