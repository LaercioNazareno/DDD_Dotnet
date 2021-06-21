using System;
using Microsoft.EntityFrameworkCore;

namespace DDD_Dotnet.Domain.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime dateRegister { get; set; }
        public DateTime dateUpdate { get; set; }
        
    }
}
