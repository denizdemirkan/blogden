using AutoMapper;
using Blogden.Core.DTOs;
using Blogden.Core.Entities;
using Blogden.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blogme.Web.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IBlogService blogService;

        public BlogController(IMapper mapper, IBlogService blogService)
        {
            this.mapper = mapper;
            this.blogService = blogService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var blog = await blogService.GetAsync(id);

            var blogDto = mapper.Map<BlogDTO>(blog);

            return Ok(blogDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(BlogDTO blogDto)
        {
            var blog = mapper.Map<Blog>(blogDto);

            await blogService.SaveAsync(blog);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var blogs = blogService.GetAll();

            var blogsDto = mapper.Map<List<BlogDTO>>(blogs.ToList());

            return Ok(blogsDto);
        }
    }
}
