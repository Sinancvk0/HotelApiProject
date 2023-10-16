using AutoMapper;
using DTO.Dtos.RoomDto;
using Entity;

namespace HotelApiProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //Reverse Map ile Tersine eşleme yapılıyor.
            CreateMap<RoomAddDto, Room>().ReverseMap();
            CreateMap<RoomUpdateDto, Room>().ReverseMap();
        }
    }
}
