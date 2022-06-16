using System;
using CarRental.Database;

namespace CarRental.Services
{
    public class BaseService
    {
        protected readonly CarRentalContext _context;

        public BaseService(CarRentalContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }
    }
}
