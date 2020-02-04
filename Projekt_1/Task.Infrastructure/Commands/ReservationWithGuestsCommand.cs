using System.Collections.Generic;
using Task.Infrastructure.Dtos;

namespace Task.Infrastructure.Commands
{
    public class ReservationWithGuestsCommand
    {
        public ReservationDto Reservation { get; set; }
        public List<GuestDto> Guests { get; set; }
    }
}
