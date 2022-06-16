using CarRental.Domain.Entity.Enum;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CarRental.Domain.Entity
{
    public class AppUser : IdentityUser
    {
        public UserRole Role { get; set; }

        public IEnumerable<Rent> Rents { get; set; }
    }
}
