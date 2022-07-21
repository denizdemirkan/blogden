using Blogden.Core.Entities;
using Blogden.Core.Repositories;
using Blogden.Core.Services;
using Blogden.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Service.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IGenericRepository<TEntity> repository;
        protected readonly IUnitOfWork unitOfWork;

        public GenericService(IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public void Delete(TEntity entity)
        {
            repository.Delete(entity);
            unitOfWork.Commit();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await repository.GetAsync(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public async Task SaveAsync(TEntity entity)
        {
            await repository.SaveAsync(entity);
            await unitOfWork.CommitAsync();
        }

        public void Update(TEntity entity)
        {
            repository.Update(entity);
            unitOfWork.Commit();
        }
    }
}
