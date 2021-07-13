using System;

namespace DDD_Dotnet.Application.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime dateRegister { get; set; }
        public DateTime dateUpdate { get; set; }
    }
}
