using System;
using System.Collections.Generic;
using Task.Core.Domain.Base;

namespace Task.Core.Domain
{
    public class Guest : Entity
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
        public DateTime? DateOfBirth { get; protected set; }
        public string ZIP { get; protected set; }
        public string Phone { get; protected set; }
        public string Address { get; protected set; }
        public string City { get; protected set; }

        public virtual ICollection<Reservation> Reservations { get; protected set; }

        protected Guest()
        {

        }

        public Guest(string firstName, string lastName, string email, DateTime? dateOfBirth, string zip, string phone, string address, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            ZIP = zip;
            Phone = phone;
            Address = address;
            City = city;
            Reservations = new List<Reservation>();
        }
    }
}
