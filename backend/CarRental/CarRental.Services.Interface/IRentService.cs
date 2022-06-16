using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using CarRental.Domain.Dtos;
using CarRental.Domain.Entity;

namespace CarRental.Services.Interface
{
    public interface IRentService
    {
        Task<Rent> Create(Rent rent);

        Task<Rent> Update(Rent rent);

        Task<List<Rent>> GetAll();

        Task<Rent> GetDetailed(Guid id);

        Task<List<Rent>> GetFilter(RentParams rentParams);

        Task<List<Rent>> GetRentsByVehicle(Guid vehicleId);

        Task<List<Rent>> GetRentsByUser(string userId);
    }
}
