using System.Collections.Generic;
using System.Linq;
using DDD_Dotnet.Domain.Entities;
using IMPORT_INTERFACE_SERVICE;
using IMPORT_INTERFACE_REPOSITORY;

namespace DDD_Dotnet.Domain.Interfaces.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _ProdutoRepository;

        public ProdutoService(IClienteRepository ProdutoRepository)
            : base(ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
        }
    }
}

