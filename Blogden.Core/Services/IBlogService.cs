using Blogden.Core.DTOs;
using Blogden.Core.Entities;

namespace Blogden.Core.Services
{
    public interface IBlogService : IGenericService<Blog>
    {
        public Task<BlogDTO> GetBlogWithCommentsAsync(int id);
    }
}
