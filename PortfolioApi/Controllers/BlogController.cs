using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Controllers.Base;
using PortfolioApi.Models.Blog;
using PortfolioApi.Services;
using PortfolioApi.Services.Interface;

namespace PortfolioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : BaseController
    {
        private readonly IBlogService blogService;

        public BlogController(IBlogService blogService) 
        {
            this.blogService = blogService;
        }

        [HttpGet]
        public async Task<IEnumerable<BlogSummary>> GetBlogsAsync()
        {
            return await blogService.GetBlogPostsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Blog> GetBlogAsync(string id)
        {
            return await blogService.GetBlogPostAsync(id);
        }
    }
}
