using System;

namespace CarRental.Domain.Dtos
{
    public class RentForListDto
    {
        public Guid Id { get; set; }

        public DateTime StartRent { get; set; }

        public DateTime EndRent { get; set; }

        public decimal TotalPrice { get; set; }

        public VehicleForListDto Vehicle { get; set; }
    }
}
