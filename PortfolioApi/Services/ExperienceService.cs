﻿using PortfolioApi.Models.Blog;
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
                .Select(x => new ExperienceSummary() { 
                    Id = x.Key, 
                    Synopsis = x.Value, 
                    JobTitle = "Test title", 
                    Company = "Test company" 
                }).ToList();

            return results;
        }

        public async Task<Experience> GetExperienceAsync(string id)
        {
            var results = new Experience();

            return await Task.FromResult(results);
        }
    }
}
