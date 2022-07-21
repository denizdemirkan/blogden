using Blogden.Core.Entities;
using Blogden.Core.Repositories;
using Blogden.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Blogden.Repository.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly MSSqlDbContext dbContext;
        protected readonly DbSet<TEntity> dbSet;

        public GenericRepository(MSSqlDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            // AsNoTracking, disallow manupilation on entities which returned. Kind of pass-by-value injection.
            return dbSet.AsNoTracking().AsQueryable();
        }

        public async Task SaveAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            dbSet.Update(entity);
        }
    }
}
