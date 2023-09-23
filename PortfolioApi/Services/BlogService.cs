using PortfolioApi.Models.Blog;
using PortfolioApi.Services.Interface;

namespace PortfolioApi.Services
{
    public class BlogService : IBlogService
    {
        public BlogService() { }

        public async Task<IEnumerable<BlogSummary>> GetBlogPostsAsync()
        {
            var results = new List<BlogSummary>();

            return results;
        }


        public async Task<Blog> GetBlogPostAsync(string id)
        {
            var results = new Blog();

            return results;
        }
    }
}
