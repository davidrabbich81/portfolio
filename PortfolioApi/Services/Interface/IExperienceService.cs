using PortfolioApi.Models.Experience;

namespace PortfolioApi.Services.Interface
{
    public interface IExperienceService
    {
        Task<Experience> GetExperienceAsync(string id);
        Task<IEnumerable<ExperienceSummary>> GetExperiencesAsync();
    }
}