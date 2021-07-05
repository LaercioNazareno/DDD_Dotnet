using System.Collections.Generic;

namespace DDD_Dotnet.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity: class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int Id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(TEntity obj);
        TEntity Remove(TEntity obj);
        void Dispose();
    }
}
