using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Controllers.Base;
using PortfolioApi.Models.Blog;
using PortfolioApi.Models.Experience;
using PortfolioApi.Services;
using PortfolioApi.Services.Interface;

namespace PortfolioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : BaseController
    {
        private readonly IExperienceService experienceService;

        public ExperienceController(IExperienceService experienceService) 
        {
            this.experienceService = experienceService;
        }

        [HttpGet]
        public async Task<IEnumerable<ExperienceSummary>> GetExperiencesAsync()
        {
            return await experienceService.GetExperiencesAsync();
        }

        [HttpGet("{id}")]
        public async Task<Experience> GetExperienceAsync(string id)
        {
            return await experienceService.GetExperienceAsync(id);
        }

    }
}
