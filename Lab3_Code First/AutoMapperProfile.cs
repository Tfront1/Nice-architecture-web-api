using AutoMapper;
using DataAccess.Models.ClientSpace;
using DataAccess.Models.HotelSpace;
using Lab3_Code_First.Models.Client;
using Lab3_Code_First.Models.Hotel;

namespace Lab3_Code_First
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ClientDto, Client>();
            CreateMap<Client, ClientDto>();

            CreateMap<HotelDto, Hotel>();
            CreateMap<Hotel, HotelDto>();
        }
    }
}
