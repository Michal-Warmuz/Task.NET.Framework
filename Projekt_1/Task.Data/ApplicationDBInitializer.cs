using System;
using System.Collections.Generic;
using System.Data.Entity;
using Task.Core.Domain;

namespace Task.Data
{
    class ApplicationDBInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            IList<Guest> guests = new List<Guest>();

            guests.Add(new Guest("Piotr", "Nowak", "jan@wp.pl", new DateTime(1997, 10, 10), "12-123", "123456789", "Mila 11", "Wrocław"));
            guests.Add(new Guest("Piotr", "Stach", "satch@wp.pl", new DateTime(1996, 3, 1), "12-123", "123456789", "Mila 11", "Wrocław"));
            guests.Add(new Guest("Jan", "Bogdan", "janek@wp.pl", new DateTime(2000, 6, 4), "12-123", "123456789", "Mila 11", null));
            guests.Add(new Guest("Andzej", "Nowak", "janusz@wp.pl", new DateTime(1995, 1, 15), "12-123", "123456789", "Mila 11", "Wrocław"));

            IList<Reservation> reservations = new List<Reservation>();

            reservations.Add(new Reservation("AAAS", new DateTime(2019, 10, 10), 345, "PLN", new DateTime(2019, 10, 10), new DateTime(2019, 10, 17), 30, null));
            reservations.Add(new Reservation("AABB", new DateTime(2019, 1, 10), 405, "PLN", new DateTime(2019, 1, 10), new DateTime(2019, 1, 17), 100, null));
            reservations.Add(new Reservation("AACS", new DateTime(2019, 4, 10), 345, "PLN", new DateTime(2019, 4, 10), new DateTime(2019, 4, 17), 50, null));
            reservations.Add(new Reservation("ASDS", new DateTime(2019, 5, 10), 445, "PLN", new DateTime(2019, 5, 10), new DateTime(2019, 5, 17), 35, null));

            context.Guests.AddRange(guests);
            context.Reservations.AddRange(reservations);
            base.Seed(context);
        }
    }
}
