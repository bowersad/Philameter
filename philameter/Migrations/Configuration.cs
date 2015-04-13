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

            var catPeople = new Category { Id = 1, Name = "People", FontAwesomeIcon = "fa-child" };
            var catfood = new Category { Id = 2, Name = "Food", FontAwesomeIcon = "fa-cutlery" };
            var catTransport = new Category { Id = 3, Name = "Transportation", FontAwesomeIcon="fa-exchange" };

            context.Category.AddOrUpdate(catPeople);
            context.Category.AddOrUpdate(catfood);
            context.Category.AddOrUpdate(catTransport);

            var statBirth = new Stats { Id = 1, Name = "Births", Details = "Number of people born in Philadelphia, PA", Source = "IDK", Stat = 63.25, PanelClass = "bg-success", FontAwesomeIcon = "fa-birthday-cake" ,Category = catPeople};
            var statPretzel = new Stats { Id = 2, Name = "Pretzels", Details = "Number of pretzel's eaten in Philadelphia, PA", Source = "IDK", Stat = 63821, PanelClass = "bg-warning", FontAwesomeIcon = "fa-cutlery", Category = catfood };
            var statSeptaRidership = new Stats { Id = 3, Name = "SEPTA Ridership", Details = "Number of people riding SEPTA each day", Source = "IDK", Stat = 333600, PanelClass = "bg-info", FontAwesomeIcon = "fa-subway", Category = catTransport };



            context.Stats.AddOrUpdate(statBirth);
            context.Stats.AddOrUpdate(statPretzel);
            context.Stats.AddOrUpdate(statSeptaRidership);

        }
    }
}
