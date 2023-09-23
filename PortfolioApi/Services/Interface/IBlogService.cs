using PortfolioApi.Models.Blog;

namespace PortfolioApi.Services.Interface
{
    public interface IBlogService
    {
        Task<Blog> GetBlogPostAsync(string id);
        Task<IEnumerable<BlogSummary>> GetBlogPostsAsync();
    }
}