using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Infrastructure.Commands;
using Task.Infrastructure.Dtos;

namespace Task.Infrastructure.Services.Interface
{
    public interface IReservationService
    {
        IEnumerable<ReservationDto> GetAll();
        void SaveReservationWithGuests(ReservationWithGuestsCommand command);
    }
}
