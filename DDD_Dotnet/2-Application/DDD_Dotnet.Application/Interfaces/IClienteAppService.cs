using DDD_Dotnet.Application.DTO;

namespace DDD_Dotnet.Application.Interfaces
{
    public interface IClienteAppService
    {
        void ClienteAdd(ClienteDTO clienteDTO);
    }
}
