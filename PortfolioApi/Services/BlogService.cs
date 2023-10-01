using PortfolioApi.Models.Blog;
using PortfolioApi.Services.Interface;
using System.Reflection;

namespace PortfolioApi.Services
{
    public class BlogService : IBlogService
    {
        private readonly IMarkdownConverterService markdownConverterService;
        private readonly IFileService fileService;

        public BlogService(IMarkdownConverterService markdownConverterService, IFileService fileService)
        {
            this.markdownConverterService = markdownConverterService;
            this.fileService = fileService;
        }

        public async Task<IEnumerable<BlogSummary>> GetBlogPostsAsync()
        {
            var results = new List<BlogSummary>();

            var markdown = await markdownConverterService.ConvertMarkdownFilesToHtml(
                fileService.GetFullPathFromRelativePath("/Data/Blog/"));


            results = markdown
                .Select(x => new BlogSummary()
                    .ParseNameForInfo(x.Key)
                    .GetSynopsis(x.Value)
                )
                .ToList();

            return results;
        }


        public async Task<Blog> GetBlogPostAsync(string id)
        {
            var result = new Blog();

            var markdown = await markdownConverterService.ConvertMarkdownFilesToHtml(
                fileService.GetFullPathFromRelativePath($"/Data/Blog/{id}.md"));

            if (markdown.Any())
            {
                var item = markdown.First();
                result.ParseNameForInfo(item.Key);
                result.Content = item.Value.Formatted;
                result.Summary = item.Value.Synopsis;
            }

            return result;
        }
    }
}
