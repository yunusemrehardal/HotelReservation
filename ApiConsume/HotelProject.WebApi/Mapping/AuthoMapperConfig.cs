using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AuthoMapperConfig: Profile
    {
        public AuthoMapperConfig()
        {
            CreateMap<Room, RoomAddDto>().ReverseMap();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
