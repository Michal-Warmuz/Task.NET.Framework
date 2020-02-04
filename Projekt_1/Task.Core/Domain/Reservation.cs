using System;
using System.Collections.Generic;
using System.Text;
using Task.Core.Domain.Base;

namespace Task.Core.Domain
{
    public class Reservation : Entity
    {
        public string Code { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public decimal Price { get; protected set; }
        public string Currency { get; protected set; }
        public DateTime CheckInDate { get; protected set; }
        public DateTime CheckOutDate { get; protected set; }
        public decimal? Provision { get; protected set; }
        public string Source { get; protected set; }

        public virtual ICollection<Guest> Guests { get; protected set; }

        protected Reservation()
        {

        }

        public Reservation(string code, DateTime createdAt, decimal price, string currency, DateTime checkInDate, DateTime checkOutDate, decimal? provision, string source)
        {
            Code = code;
            CreatedAt = createdAt;
            Price = price;
            Currency = currency;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Provision = provision;
            Source = source;
            Guests = new List<Guest>();
        }
    }
}
