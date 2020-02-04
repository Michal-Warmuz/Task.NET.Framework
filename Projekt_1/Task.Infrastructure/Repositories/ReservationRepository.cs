using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Core.Domain;
using Task.Core.Repositories;
using Task.Data;

namespace Task.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ReservationRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public  IEnumerable<Reservation> GetAll()
        {
            return dbContext.Reservations.AsEnumerable();
        }

        public void SaveReservationWithGuests(Reservation reservation, List<Guest> guests)
        {
            
            foreach (var item in guests)
            {
                reservation.Guests.Add(item);
            }


            dbContext.Reservations.Add(reservation);



            dbContext.Guests.AddRange(guests);
            dbContext.SaveChanges();
        }
    }
}
