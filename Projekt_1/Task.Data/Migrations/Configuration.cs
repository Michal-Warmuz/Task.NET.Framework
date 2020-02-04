namespace Task.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Task.Core.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<Task.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Task.Data.ApplicationDbContext context)
        {
            context.Guests.AddOrUpdate(x=>x.Id,
                    new Guest("Piotr", "Nowak", "jan@wp.pl", new DateTime(1997, 10, 10), "12-123", "123456789", "Mila 11", "Wrocław"),
                    new Guest("Piotr", "Stach", "satch@wp.pl", new DateTime(1996, 3, 1), "12-123", "123456789", "Mila 11", "Wrocław"),
                    new Guest("Jan", "Bogdan", "janek@wp.pl", new DateTime(2000, 6, 4), "12-123", "123456789", "Mila 11", null),
                    new Guest("Andzej", "Nowak", "janusz@wp.pl", new DateTime(1995, 1, 15), "12-123", "123456789", "Mila 11", "Wrocław"));

            context.Reservations.AddOrUpdate(x => x.Id,
                new Reservation("AAAS", new DateTime(2019, 10, 10), 345, "PLN", new DateTime(2019, 10, 10), new DateTime(2019, 10, 17), 30, null),
                new Reservation("AABB", new DateTime(2019, 1, 10), 405, "PLN", new DateTime(2019, 1, 10), new DateTime(2019, 1, 17), 100, null),
                new Reservation("AACS", new DateTime(2019, 4, 10), 345, "PLN", new DateTime(2019, 4, 10), new DateTime(2019, 4, 17), 50, null),
                new Reservation("ASDS", new DateTime(2019, 5, 10), 445, "PLN", new DateTime(2019, 5, 10), new DateTime(2019, 5, 17), 35, null));
        }
    }
}
