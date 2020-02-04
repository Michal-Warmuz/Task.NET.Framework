using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Infrastructure.Dtos;

namespace Task.Infrastructure.Services.Interface
{
    public interface IGuestService
    {
        IEnumerable<GuestDto> GetPeters();
    }
}
