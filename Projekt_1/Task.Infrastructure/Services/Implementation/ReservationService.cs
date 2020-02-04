using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Core.Domain;
using Task.Core.Repositories;
using Task.Infrastructure.Commands;
using Task.Infrastructure.Dtos;
using Task.Infrastructure.Services.Interface;

namespace Task.Infrastructure.Services.Implementation
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository reservationRepository;
        private readonly IMapper mapper;

        public ReservationService(IReservationRepository _reservationRepository, IMapper _mapper)
        {
            reservationRepository = _reservationRepository;
            mapper = _mapper;
        }

        public IEnumerable<ReservationDto> GetAll()
        {
            var payload = reservationRepository.GetAll();

            return mapper.Map<IEnumerable<ReservationDto>>(payload);
        }

        public void SaveReservationWithGuests(ReservationWithGuestsCommand command)
        {
            var reservation = mapper.Map<Reservation>(command.Reservation);

            var guests = mapper.Map<List<Guest>>(command.Guests);

            reservationRepository.SaveReservationWithGuests(reservation, guests);
        }
    }
}
