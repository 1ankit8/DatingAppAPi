using System.Linq;
using AutoMapper;
using DatingApp.API.dto;
using DatingApp.API.Models;

namespace DatingApp.API.helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForDetailedDTO>()
            .ForMember(
                destinationMember => destinationMember.PhotoUrl,
                options =>
                {
                    options.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).URL);
                })
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.GetAge()));
            CreateMap<User, UserForListDTO>()
            .ForMember(
                destinationMember => destinationMember.PhotoUrl,
                options =>
                {
                    options.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).URL);
                })
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.GetAge()));

            CreateMap<Photo, PhotoForDetailedDTO>();
        }
    }
}