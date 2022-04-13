using AutoMapper;
using CarInspections.Api.DTOs;
using CarInspections.Api.Entities;

namespace CarInspections.Api.AutoMapperProfiles
{
    public class CarInspectionsProfile : Profile
    {
        public CarInspectionsProfile()
        {
            CreateMap<Car, CarInspectionsDto>();
        }
    }
}
