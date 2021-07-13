using System;

namespace DDD_Dotnet.Domain.Entities
{
    public class Cliente: EntityBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
    }
}
