using AutoMapper;
using DDD_Dotnet.Domain.Entities;

namespace DDD_Dotnet.Application.DTO
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>();
        }
    }
}
