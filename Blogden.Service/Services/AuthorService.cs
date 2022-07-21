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
    public class AuthorService : GenericService<Author>, IAuthorService
    {
        private IAuthorRepository authorRepository;
        private IMapper mapper;

        public AuthorService(IGenericRepository<Author> repository, IUnitOfWork unitOfWork, 
            IAuthorRepository authorRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            this.authorRepository = authorRepository;
            this.mapper = mapper;
        }

        public async Task<AuthorWithBlogsDTO> GetAuthorWithBlogsAsync(int id)
        {
            var authorEntity = await authorRepository.GetAuthorWithBlogsAsync(id);

            var authorWithBlogsDto = mapper.Map<AuthorWithBlogsDTO>(authorEntity);
            
            return authorWithBlogsDto;
        }
    }
}
