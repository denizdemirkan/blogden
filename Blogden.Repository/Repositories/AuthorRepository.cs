using Blogden.Core.Entities;
using Blogden.Core.Repositories;
using Blogden.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Blogden.Repository.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(MSSqlDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Author> GetAuthorWithBlogsAsync(int id)
        {
            return await dbContext.Authors.Where(x => x.Id == id).Include(x => x.Blogs).FirstAsync();
        }
    }
}
