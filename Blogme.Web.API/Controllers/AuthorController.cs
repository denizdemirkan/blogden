using AutoMapper;
using Blogden.Core.DTOs;
using Blogden.Core.Entities;
using Blogden.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blogme.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IAuthorService authorService;

        public AuthorController(IMapper mapper, IAuthorService authorService)
        {
            this.mapper = mapper;
            this.authorService = authorService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var author = await authorService.GetAsync(id);

            var authorDto = mapper.Map<AuthorDTO>(author);

            return Ok(authorDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AuthorDTO authorDTO)
        {
            var author = mapper.Map<Author>(authorDTO);

            await authorService.SaveAsync(author);

            return NoContent();

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var authors = authorService.GetAll();

            var authorsDTO = mapper.Map<List<AuthorDTO>>(authors.ToList());

            return Ok(authorsDTO);
        }

    }
}

