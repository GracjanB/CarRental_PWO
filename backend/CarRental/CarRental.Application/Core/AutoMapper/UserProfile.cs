using AutoMapper;
using CarRental.Domain.Dtos;

namespace CarRental.Application.Core.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Domain.Entity.AppUser, UserDto>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id))
                .ForMember(dest => dest.Username, options => options.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, options => options.MapFrom(src => src.Email));
        }
    }
}
