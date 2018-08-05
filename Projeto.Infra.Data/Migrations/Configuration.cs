namespace Projeto.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Projeto.Infra.Data.Context.DataContext>
    {
        public Configuration()
        {
            //permiss�o para CREATE, ALTER
            AutomaticMigrationsEnabled = true;
            //permiss�o para DROP
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Projeto.Infra.Data.Context.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
