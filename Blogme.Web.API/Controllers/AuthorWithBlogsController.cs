using AutoMapper;
using Blogden.Core.DTOs;
using Blogden.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blogme.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorWithBlogsController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IAuthorService authorService;

        public AuthorWithBlogsController(IMapper mapper, IAuthorService authorService)
        {
            this.mapper = mapper;
            this.authorService = authorService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorWithBlogsById(int id)
        {
            var authorWithBlogs = await authorService.GetAuthorWithBlogsAsync(id);

            var authorWithBlogsDto = mapper.Map<AuthorWithBlogsDTO>(authorWithBlogs);

            return Ok(authorWithBlogsDto);
        }
    }
}
