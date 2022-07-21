using Blogden.Core.DTOs;
using Blogden.Core.Entities;

namespace Blogden.Core.Services
{
    public interface IAuthorService : IGenericService<Author>
    {
        public Task<AuthorWithBlogsDTO> GetAuthorWithBlogsAsync(int id);
    }
}
