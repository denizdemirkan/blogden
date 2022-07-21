using AutoMapper;
using Blogden.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blogme.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogWithCommentsController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IBlogService blogService;

        public BlogWithCommentsController(IMapper mapper, IBlogService blogService)
        {
            this.mapper = mapper;
            this.blogService = blogService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogWithCommentsByIdAsync(int id)
        {
            // This method returns DTO directly, so don't need to MAPPING!
            var blogDto = await blogService.GetBlogWithCommentsAsync(id);

            return Ok(blogDto);
        }
    }
}
