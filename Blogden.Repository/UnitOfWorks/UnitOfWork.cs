using Blogden.Core.UnitOfWork;
using Blogden.Repository.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MSSqlDbContext dbContext;

        public UnitOfWork(MSSqlDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
