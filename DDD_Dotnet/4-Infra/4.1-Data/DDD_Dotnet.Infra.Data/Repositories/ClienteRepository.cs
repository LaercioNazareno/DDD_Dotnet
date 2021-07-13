using DDD_Dotnet.Infra.Data.Contexto;
using DDD_Dotnet.Domain.Entities;
using DDD_Dotnet.Domain.Interfaces.Repositories;

namespace DDD_Dotnet.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(Context context) : base(context)
        {
        }
    }
}
