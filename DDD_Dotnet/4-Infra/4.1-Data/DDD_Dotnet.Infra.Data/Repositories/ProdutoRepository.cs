using DDD_Dotnet.Infra.Data.Contexto;
using DDD_Dotnet.Domain.Entities;
using DDD_Dotnet.Domain.Interfaces;

namespace DDD_Dotnet.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(Context context) : base(context)
        {
        }
    }
}
