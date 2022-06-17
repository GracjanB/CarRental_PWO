using System;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Dtos
{
    public class RentDetailsDto
    {
        public Guid Id { get; set; }

        public DateTime StartRent { get; set; }

        public DateTime EndRent { get; set; }

        public decimal TotalPrice { get; set; }

        public int Discount { get; set; }

        public RentStatus Status { get; set; }

        public VehicleDetailsDto Vehicle { get; set; }

        public UserDto User { get; set; }
    }
}
