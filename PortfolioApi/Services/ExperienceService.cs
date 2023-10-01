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
                .Select(x => new ExperienceSummary()
                    .ParseNameForInfo(x.Key)
                    .GetSynopsis(x.Value)
                    .GetFullContent(x.Value)
                )
                .ToList();

            return results.OrderByDescending(x => x.TimeFrame);
        }

        public async Task<Experience> GetExperienceAsync(string id)
        {
            var result = new Experience();

            var markdown = await markdownConverterService.ConvertMarkdownFilesToHtml(
                fileService.GetFullPathFromRelativePath($"/Data/Experience/{id}.md"));

            if (markdown.Any())
            {
                var item = markdown.First();
                result.ParseNameForInfo(item.Key);
                result.FullDescription = item.Value.Formatted;
                result.Synopsis = item.Value.Synopsis;
            }

            return result;
        }
    }
}
