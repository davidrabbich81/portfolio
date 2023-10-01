using PortfolioApi.Models.Blog;
using PortfolioApi.Models.Experience;
using PortfolioApi.Services.Interface;

namespace PortfolioApi.Services
{
    public class ExperienceService : IExperienceService
    {
        private readonly IMarkdownConverterService markdownConverterService;
        private readonly IFileService fileService;

        public ExperienceService(IMarkdownConverterService markdownConverterService, IFileService fileService)
        {
            this.markdownConverterService = markdownConverterService;
            this.fileService = fileService;
        }

        public async Task<IEnumerable<ExperienceSummary>> GetExperiencesAsync()
        {
            var results = new List<ExperienceSummary>();

            var markdown = await markdownConverterService.ConvertMarkdownFilesToHtml(
                fileService.GetFullPathFromRelativePath("/Data/Experience/"));

            results = markdown
                .Select(x => new ExperienceSummary().ParseNameForInfo(x.Key))
                .ToList();

            return results;
        }

        public async Task<Experience> GetExperienceAsync(string id)
        {
            var result = new Experience();

            var markdown = await markdownConverterService.ConvertMarkdownFilesToHtml(
                fileService.GetFullPathFromRelativePath($"/Data/Experience/{id}.md"));

            if (markdown.Any())
            {
                result.ParseNameForInfo(markdown.First().Key);
                result.FullDescription = markdown.First().Value;
            }

            return result;
        }
    }
}
