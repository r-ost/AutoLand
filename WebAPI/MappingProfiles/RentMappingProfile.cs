using AutoMapper;
using WebAPI.Entities;
using WebAPI.Dtos;

namespace WebAPI.MappingProfiles
{
    public class RentMappingProfile : Profile
    {
        public RentMappingProfile()
        {
            CreateMap<Rent, RentResponseDto>();//ponizej automatyczne
                //.ForMember(m => m.QuoteId, c => c.MapFrom(s => s.QuoteId))
                //.ForMember(m => m.RentId, c => c.MapFrom(s => s.RentId))
                //.ForMember(m => m.RentAt, c => c.MapFrom(s => s.RentAt))
                //.ForMember(m => m.StartDate, c => c.MapFrom(s => s.StartDate))
                //.ForMember(m => m.EndDate, c => c.MapFrom(s => s.EndDate)); 
            CreateMap<Vehicle, VehicleDto>();
        }
    }
}
