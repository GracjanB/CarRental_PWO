using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Dtos
{
    public class VehicleDetailsDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Mark { get; set; }

        public string Model { get; set; }

        public decimal Range { get; set; }

        public decimal Speed { get; set; }

        public bool IsAvailable { get; set; }

        public decimal PricePerHour { get; set; }

        public bool IsDeleted { get; set; }

        public double Longtitude { get; set; }

        public double Latitude { get; set; }
    }
}
