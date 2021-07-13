using AutoMapper;
using DDD_Dotnet.Domain.Entities;
using DDD_Dotnet.Application.DTO;

namespace DDD_Dotnet.Application.AutoMapper
{
    public class CustomDtoMapper : Profile
    {
        public CustomDtoMapper()
        {
            CreateMap<Cliente, ClienteDTO>()
                 .ReverseMap();
        }
    }
}