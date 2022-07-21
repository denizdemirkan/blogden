using Blogden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Core.Repositories
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
        public Task<Blog> GetBlogWithCommentsAsync(int id);
    }
}
