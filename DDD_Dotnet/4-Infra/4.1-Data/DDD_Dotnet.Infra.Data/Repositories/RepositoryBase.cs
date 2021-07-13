using System.Linq.Expressions;
using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using DDD_Dotnet.Infra.Data.Contexto;
using DDD_Dotnet.Domain.Interfaces.Repositories;

namespace DDD_Dotnet.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private Context context;
        private bool disposed = false;

        public RepositoryBase(Context context)
        {
            this.context = context;
        }
        public TEntity Add(TEntity obj)
        {
            context.Set<TEntity>().Add(obj);
            return obj;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetBy(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = context.Set<TEntity>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public TEntity GetById(int Id)
        {
            return context.Set<TEntity>().Find(Id);
        }
        public TEntity Remove(TEntity obj)
        {
            context.Remove(obj);
            return obj;
        }
        public TEntity Update(TEntity obj)
        {
            context.Update(obj);
            return obj;
        }

        public void Save()
        {
            context.SaveChanges();
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
