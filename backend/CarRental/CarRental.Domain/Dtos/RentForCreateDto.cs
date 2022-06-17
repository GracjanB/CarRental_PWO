using System;

namespace CarRental.Domain.Dtos
{
    public class RentForCreateDto
    {
        public DateTime StartRent { get; set; }

        public DateTime EndRent { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal Discount { get; set; }

        public string VehicleId { get; set; }

        public string UserId { get; set; }
    }
}
