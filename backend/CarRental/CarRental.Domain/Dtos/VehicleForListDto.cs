using System;

namespace CarRental.Domain.Dtos
{
    public class VehicleForListDto
    {
        public Guid Id { get; set; }

        public string Mark { get; set; }

        public string Model { get; set; }

        public decimal PricePerHour { get; set; }
    }
}
