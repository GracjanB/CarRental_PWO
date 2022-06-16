using CarRental.Domain.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Database
{
    public class CarRentalContext : IdentityDbContext<AppUser>
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Rent> Rents { get; set; }

        public CarRentalContext(DbContextOptions<CarRentalContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Rent>()
                .HasOne(x => x.Vehicle)
                .WithMany(x => x.Rents)
                .HasForeignKey(x => x.VehicleId);

            builder.Entity<Rent>()
                .HasOne(x => x.User)
                .WithMany(x => x.Rents)
                .HasForeignKey(x => x.UserId);
        }
    }
}
