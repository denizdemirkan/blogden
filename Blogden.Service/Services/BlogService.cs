using AutoMapper;
using Blogden.Core.DTOs;
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
    public class BlogService : GenericService<Blog>, IBlogService
    {
        private IMapper mapper;
        private IBlogRepository blogRepository;

        public BlogService(IGenericRepository<Blog> repository, IUnitOfWork unitOfWork, 
            IMapper mapper, IBlogRepository blogRepository) : base(repository, unitOfWork)
        {
            this.mapper = mapper;
            this.blogRepository = blogRepository;
        }

        public async Task<BlogDTO> GetBlogWithCommentsAsync(int id)
        {
            var blogsWithComments = await blogRepository.GetBlogWithCommentsAsync(id);

            var blogWithCommentsDto = mapper.Map<BlogWithCommentsDTO>(blogsWithComments);

            return blogWithCommentsDto;
        }
    }
}
