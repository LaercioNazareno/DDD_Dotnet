using Microsoft.Extensions.DependencyInjection;
using DDD_Dotnet.Application.Services;
using DDD_Dotnet.Application.Interfaces;
using DDD_Dotnet.Domain.Interfaces.Repositories;
using DDD_Dotnet.Domain.Interfaces.Services;
using DDD_Dotnet.Domain.Services;
using DDD_Dotnet.Infra.Data.Repositories;

namespace DDD_Dotnet.Infra.CrossCutting.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection serviceCollection)
        {
            
            //Aplicação
            serviceCollection.AddScoped(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            serviceCollection.AddScoped<IClienteAppService, ClienteAppService>();

            //Domínio
            serviceCollection.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            serviceCollection.AddScoped<IClienteService, ClienteService>();

            //Repositorio
            serviceCollection.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            serviceCollection.AddScoped<IClienteRepository, ClienteRepository>();
        }
    }
}