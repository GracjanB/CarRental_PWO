using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using CarRental.Database;
using CarRental.Domain.Dtos;
using CarRental.Domain.Entity;
using CarRental.Domain.Exceptions;
using CarRental.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Services
{
    public class VehicleService : BaseService, IVehicleService
    {
        public VehicleService(CarRentalContext context) : base(context)
        {
        }

        public async Task<Vehicle> Create(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();

            return vehicle;
        }

        public async Task<List<Vehicle>> GetAll()
        {
            return await _context.Vehicles.ToListAsync();
        }

        public async Task<Vehicle> GetDetailed(Guid id)
        {
            return await _context.Vehicles.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Vehicle> Update(VehicleForUpdateDto vehicle)
        {
            var vehicleFromDb = _context.Vehicles.SingleOrDefault(x => x.Id == vehicle.Id);

            if (vehicleFromDb != null)
            {
                if (vehicle.IsAvailable != null)
                    vehicleFromDb.IsAvailable = (bool)vehicle.IsAvailable;

                if (vehicle.Mark != null)
                    vehicleFromDb.Mark = vehicle.Mark;

                if (vehicle.Model != null)
                    vehicleFromDb.Model = vehicle.Model;

                if (vehicle.PricePerHour != null)
                    vehicleFromDb.PricePerHour = (decimal)vehicle.PricePerHour;

                if (vehicle.Range != null)
                    vehicleFromDb.Range = (decimal)vehicle.Range;

                if (vehicle.Speed != null)
                    vehicleFromDb.Speed = (decimal)vehicle.Speed;

                if (vehicle.Longtitude != null)
                    vehicleFromDb.Longtitude = (double)vehicle.Longtitude;

                if (vehicle.Latitude != null)
                    vehicleFromDb.Latitude = (double)vehicle.Latitude;

                if (vehicle.IsAvailable != null)
                    vehicleFromDb.IsAvailable = (bool)vehicle.IsAvailable;

                if (vehicle.IsDeleted != null)
                    vehicleFromDb.IsDeleted = (bool)vehicle.IsDeleted;


                await _context.SaveChangesAsync();

                return vehicleFromDb;
            }
            else throw new VehicleNotFoundException();
        }
    }
}
