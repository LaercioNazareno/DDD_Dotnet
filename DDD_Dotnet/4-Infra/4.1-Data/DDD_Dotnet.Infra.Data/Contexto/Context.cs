using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace DDD_Dotnet.Infra.Data.Contexto
{
    public class Context: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            foreach (var entityEntry in ChangeTracker.Entries()
                .Where(e => e.Entity.GetType().GetProperty("dateRegister") != null))
            {
                if (entityEntry.State == EntityState.Added)
                    entityEntry.Property("dateRegister").CurrentValue = DateTime.Now;
                if (entityEntry.State == EntityState.Modified)
                    entityEntry.Property("dateUpdate").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}
