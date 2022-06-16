using System;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Dtos
{
    public class RentParams
    {
        public DateTime? FromDateRent { get; set; }

        public DateTime? ToDateRent { get; set; }

        public decimal? MinTotalPrice { get; set; }

        public decimal? MaxTotalPrice { get; set; }

        public RentStatus? Status { get; set; }
    }
}
