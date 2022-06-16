using CarRental.Domain.Entity.Enum;
using System;

namespace CarRental.Domain.Entity
{
    public class Rent
    {
        public Guid Id { get; set; }

        public DateTime StartRent { get; set; }

        public DateTime EndRent { get; set; }

        public decimal TotalPrice { get; set; }

        public int Discount { get; set; }

        public RentStatus Status { get; set; }


        public Guid VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }


        public string UserId { get; set; }

        public AppUser User { get; set; }
    }
}
