using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Task.Core.Domain;
using Task.Core.Repositories;
using Task.Data;

namespace Task.Infrastructure.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly ApplicationDbContext dbContext;

        public GuestRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IEnumerable<Guest> GetPeters()
        {
            return dbContext.Guests.Where(x => x.FirstName == "Piotr" && (x.City == "Wrocław" || x.City == null)).AsEnumerable();
        }
    }
}
