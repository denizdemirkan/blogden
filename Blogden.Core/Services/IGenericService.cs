using Blogden.Core.Entities;

namespace Blogden.Core.Services
{
    public interface IGenericService<TEntity> where TEntity : class, IEntity, new()
    {
        Task<TEntity> GetAsync(int id);
        Task SaveAsync(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        IQueryable<TEntity> GetAll();
    }
}
