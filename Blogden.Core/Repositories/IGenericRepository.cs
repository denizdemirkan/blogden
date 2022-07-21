using Blogden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Core.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        Task<TEntity> GetAsync(int id);
        Task SaveAsync(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        IQueryable<TEntity> GetAll();

    }
}
