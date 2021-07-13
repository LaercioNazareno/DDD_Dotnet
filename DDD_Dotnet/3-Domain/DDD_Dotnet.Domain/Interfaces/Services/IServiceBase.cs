using System.Collections.Generic;

namespace DDD_Dotnet.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity: class
    {
         void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAlll();
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Dispose();
    }
}
