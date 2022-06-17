using System;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Dtos
{
    public class RentForUpdateDto
    {
        public Guid Id { get; set; }

        public DateTime StartRent { get; set; }

        public DateTime EndRate { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal Discount { get; set; }

        public RentStatus Status { get; set; }

        public Guid VehicleId { get; set; }
    }
}
