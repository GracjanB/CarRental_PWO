using CarRental.Domain.Entity.Enum;
using System;
using System.Collections.Generic;

namespace CarRental.Domain.Entity
{
    public class Vehicle
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public VehicleType Type { get; set; }

        public string Mark { get; set; }

        public string Model { get; set; }

        public decimal Range { get; set; }

        public decimal Speed { get; set; }

        public bool IsAvailable { get; set; }

        public decimal PricePerHour { get; set; }

        public bool IsDeleted { get; set; }

        public double Longtitude { get; set; }

        public double Latitude { get; set; }


        public IEnumerable<Rent> Rents { get; set; }
    }
}
