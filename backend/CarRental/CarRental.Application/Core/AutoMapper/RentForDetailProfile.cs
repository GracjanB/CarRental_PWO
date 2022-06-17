using AutoMapper;
using CarRental.Domain.Dtos;

namespace CarRental.Application.Core.AutoMapper
{
    public class RentForDetailProfile : Profile
    {
        public RentForDetailProfile()
        {
            CreateMap<Domain.Entity.Rent, RentDetailsDto>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id))
                .ForMember(dest => dest.StartRent, options => options.MapFrom(src => src.StartRent))
                .ForMember(dest => dest.EndRent, options => options.MapFrom(src => src.EndRent))
                .ForMember(dest => dest.TotalPrice, options => options.MapFrom(src => src.TotalPrice))
                .ForMember(dest => dest.Discount, options => options.MapFrom(src => src.Discount))
                .ForMember(dest => dest.Status, options => options.MapFrom(src => src.Status))
                .ForMember(dest => dest.User, options => options.MapFrom(src => src.User))
                .ForMember(dest => dest.Vehicle, options => options.MapFrom(src => src.Vehicle));
        }
    }
}
