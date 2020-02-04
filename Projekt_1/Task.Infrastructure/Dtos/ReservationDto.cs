using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Infrastructure.Dtos
{
    public class ReservationDto
    {
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal? Provision { get; set; }
        public string Source { get; set; }
    }
}
