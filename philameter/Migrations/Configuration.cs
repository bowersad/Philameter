namespace philameter.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DAL.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<philameter.DAL.Entities.PhilaModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(philameter.DAL.Entities.PhilaModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var statBirth = new Stats {Id = 1,Name = "Births", Details = "Number of people born in Philadelphia, PA",Source = "IDK", Stat  = 63.25};
            var statPretzel = new Stats { Id = 2, Name = "Pretzel", Details = "Number of pretzel's eaten in Philadelphia, PA", Source = "IDK", Stat = 63.25 };


            context.Stats.AddOrUpdate(statBirth);
            context.Stats.AddOrUpdate(statPretzel);
            context.Stats.AddOrUpdate(statPretzel);

        }
    }
}
