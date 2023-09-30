using PortfolioApi.Models.Blog;
using PortfolioApi.Models.Experience;
using PortfolioApi.Services.Interface;

namespace PortfolioApi.Services
{
    public class ExperienceService : IExperienceService
    {
        public ExperienceService() { }

        public async Task<IEnumerable<ExperienceSummary>> GetExperiencesAsync()
        {
            var results = new List<ExperienceSummary>();

            results.Add(new ExperienceSummary()
            {
                JobTitle = "Test",
                Id = "1",
                Synopsis = "Test Synopsis",
                Company = "Test Company"
            });

            return results;
        }

        public async Task<Experience> GetExperienceAsync(string id)
        {
            var results = new Experience();

            return await Task.FromResult(results);
        }
    }
}
