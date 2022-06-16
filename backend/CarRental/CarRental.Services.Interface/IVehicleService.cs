using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using CarRental.Domain.Dtos;
using CarRental.Domain.Entity;

namespace CarRental.Services.Interface
{
    public interface IVehicleService
    {
        /// <summary>
        /// Creates new vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        Task<Vehicle> Create(Vehicle vehicle);

        /// <summary>
        /// Updates existing vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        Task<Vehicle> Update(VehicleForUpdateDto vehicle);

        /// <summary>
        /// Get all vehicles
        /// </summary>
        /// <returns></returns>
        Task<List<Vehicle>> GetAll();

        /// <summary>
        /// Get exact vehicle by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Vehicle> GetDetailed(Guid id);
    }
}
