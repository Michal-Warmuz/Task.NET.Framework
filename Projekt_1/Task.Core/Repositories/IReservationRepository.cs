using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Core.Domain;

namespace Task.Core.Repositories
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> GetAll();
        void SaveReservationWithGuests(Reservation reservation, List<Guest> guests);
    }
}
