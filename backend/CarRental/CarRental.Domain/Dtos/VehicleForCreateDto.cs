namespace CarRental.Domain.Dtos
{
    public class VehicleForCreateDto
    {
        public string Name { get; set; }

        public string Mark { get; set; }

        public string Model { get; set; }

        public decimal Range { get; set; }

        public decimal Speed { get; set; }

        public bool IsAvailable { get; set; }

        public decimal PricePerHour { get; set; }

        public double Longtitude { get; set; }

        public double Latitude { get; set; }
    }
}
