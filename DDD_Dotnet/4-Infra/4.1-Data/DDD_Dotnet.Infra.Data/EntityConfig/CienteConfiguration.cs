using DDD_Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD_Dotnet.Infra.Data.EntityConfig
{
    public class CienteConfiguration: IEntityTypeConfiguration<Ciente>
    {
        public void Configure(EntityTypeBuilder<Ciente> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
