using Blogden.Core.Entities;
using Blogden.Core.Repositories;
using Blogden.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Blogden.Repository.Repositories
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public BlogRepository(MSSqlDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Blog> GetBlogWithCommentsAsync(int id)
        {
            return await dbContext.Blogs.Where(x => x.Id == id).Include(x => x.Comments).FirstAsync();
        }
    }
}
