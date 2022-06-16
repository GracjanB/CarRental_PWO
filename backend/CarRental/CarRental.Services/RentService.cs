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
    public class RentService : BaseService, IRentService
    {
        public RentService(CarRentalContext carRentalContext) : base(carRentalContext) { }

        public async Task<Rent> Create(Rent rent)
        {
            _context.Rents.Add(rent);
            await _context.SaveChangesAsync();

            return rent;
        }

        public async Task<List<Rent>> GetAll()
        {
            return await _context.Rents.Include(x => x.Vehicle).ToListAsync();
        }

        public async Task<Rent> GetDetailed(Guid id)
        {
            return await _context.Rents
                                 .Include(x => x.User)
                                 .Include(x => x.Vehicle)
                                 .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Rent>> GetFilter(RentParams rentParams)
        {
            var query = _context.Rents.Include(x => x.User)
                                      .Include(x => x.Vehicle)
                                      .AsSingleQuery();

            if (rentParams.FromDateRent != null)
                query = query.Where(x => x.StartRent >= rentParams.FromDateRent);

            if (rentParams.ToDateRent != null)
                query = query.Where(x => x.EndRent <= rentParams.ToDateRent);

            if (rentParams.MinTotalPrice != null)
                query = query.Where(x => x.TotalPrice >= rentParams.MinTotalPrice);

            if (rentParams.MaxTotalPrice != null)
                query = query.Where(x => x.TotalPrice <= rentParams.MaxTotalPrice);

            if (rentParams.Status != null)
                query = query.Where(x => x.Status == (Domain.Entity.Enum.RentStatus)rentParams.Status);

            return await query.ToListAsync();
        }

        public async Task<List<Rent>> GetRentsByUser(string userId)
        {
            return await _context.Rents.Include(x => x.User)
                                       .Include(x => x.Vehicle)
                                       .Where(x => x.UserId == userId)
                                       .ToListAsync();
        }

        public async Task<List<Rent>> GetRentsByVehicle(Guid vehicleId)
        {
            return await _context.Rents.Include(x => x.User)
                                       .Include(x => x.Vehicle)
                                       .Where(x => x.VehicleId == vehicleId)
                                       .ToListAsync();
        }

        public async Task<Rent> Update(Rent rent)
        {
            var rentFromDb = _context.Rents.SingleOrDefault(x => x.Id == rent.Id);

            if (rentFromDb != null)
            {
                rentFromDb.StartRent = rent.StartRent;
                rentFromDb.EndRent = rent.EndRent;
                rentFromDb.Discount = rent.Discount;
                rentFromDb.Status = rent.Status;

                await _context.SaveChangesAsync();

                return rent;
            }
            else throw new RentNotFoundException();
        }
    }
}
