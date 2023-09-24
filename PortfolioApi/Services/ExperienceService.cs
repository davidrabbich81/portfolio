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

            return results;
        }

        public async Task<Experience> GetExperienceAsync(string id)
        {
            var results = new Experience();

            return await Task.FromResult(results);
        }
    }
}
