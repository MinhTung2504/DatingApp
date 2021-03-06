using AutoMapper;
using DatingApp.API.Database.Entities;
using DatingApp.API.DTOs;
using DatingApp.API.Extensions;

namespace Namespace
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<User, MemberDto>()
                .ForMember(
                    dest => dest.Age,
                    opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge())
                );

        }
    }
}