using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace _4.data
{
    class FourSquareContextMigrationConfiguration : DbMigrationsConfiguration<FourSquareContext>
    {
        public FourSquareContextMigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;

        }
    }
}