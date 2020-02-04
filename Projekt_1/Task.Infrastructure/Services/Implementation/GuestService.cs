using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Core.Repositories;
using Task.Infrastructure.Dtos;
using Task.Infrastructure.Services.Interface;

namespace Task.Infrastructure.Services.Implementation
{
    public class GuestService : IGuestService
    {
        private readonly IGuestRepository guestRepository;
        private readonly IMapper mapper;

        public GuestService(IGuestRepository _guestRepository, IMapper _mapper)
        {
            guestRepository = _guestRepository;
            mapper = _mapper;
        }

        public IEnumerable<GuestDto> GetPeters()
        {
            var payload = guestRepository.GetPeters();

            return mapper.Map<IReadOnlyList<GuestDto>>(payload);
        }
    }
}
