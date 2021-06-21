using System;

namespace DDD_Dotnet.Domain.Entities
{
    public class Ciente: EntityBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public bool Ativo{ get; set; }
    }
}
