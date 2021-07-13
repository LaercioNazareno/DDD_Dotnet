using DDD_Dotnet.Domain.Entities;
using DDD_Dotnet.Domain.Interfaces.Services;
using DDD_Dotnet.Domain.Interfaces.Repositories;

namespace DDD_Dotnet.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _ClienteRepository;

        public ClienteService(IClienteRepository ClienteRepository)
            : base(ClienteRepository)
        {
            _ClienteRepository = ClienteRepository;
        }
    }
}

