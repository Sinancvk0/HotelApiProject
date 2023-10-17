using AutoMapper;
using Entity;
using HotelProject.Dtos.ServiceDto;

namespace HotelProject.Mapping
{
    public class AurtoMapperConfig:Profile
    {
        public AurtoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto,Service>().ReverseMap();
            CreateMap<CreateServiceDto,Service>().ReverseMap(); 
        }
    }
}
