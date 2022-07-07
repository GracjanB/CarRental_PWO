using AutoMapper;
using CarRental.Domain.Dtos;

namespace CarRental.Application.Core.AutoMapper
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Domain.Entity.Vehicle, VehicleForListDto>();
            CreateMap<Domain.Entity.Vehicle, VehicleDetailsDto>();
            CreateMap<VehicleForCreateDto, Domain.Entity.Vehicle>();
            CreateMap<VehicleForUpdateDto, Domain.Entity.Vehicle>();
            CreateMap<Domain.Entity.Rent, RentForListDto>();
            CreateMap<RentForCreateDto, Domain.Entity.Rent>();
            CreateMap<RentForUpdateDto, Domain.Entity.Rent>();
        }
    }
}
