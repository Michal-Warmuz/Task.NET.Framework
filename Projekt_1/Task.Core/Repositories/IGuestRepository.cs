using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Task.Core.Domain;

namespace Task.Core.Repositories
{
    public interface IGuestRepository
    {
        IEnumerable<Guest> GetPeters();
    }
}
