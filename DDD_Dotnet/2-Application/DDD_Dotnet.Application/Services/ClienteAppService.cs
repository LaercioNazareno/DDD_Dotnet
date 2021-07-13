using DDD_Dotnet.Application.Interfaces;
using DDD_Dotnet.Application.Services;
using DDD_Dotnet.Domain.Entities;
using DDD_Dotnet.Domain.Interfaces.Services;
using DDD_Dotnet.Application.DTO;
using DDD_Dotnet.Application.AutoMapper;

namespace DDD_Dotnet.Application.Services
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;
        public ClienteAppService(IClienteService clienteService)
           : base(clienteService)
        {
            _clienteService = clienteService;
        }
        public void ClienteAdd(ClienteDTO clienteDTO)
        {
            var cliente = ObjectMapper.Mapper.Map<Cliente>(clienteDTO);
            _clienteService.Add(cliente);
        }
    }
}
