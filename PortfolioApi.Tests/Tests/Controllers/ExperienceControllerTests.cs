using PortfolioApi.Controllers;
using PortfolioApi.Services.Interface;
using PortfolioApi.Tests.Services;
using PortfolioApi.Tests.Tests.Base;

namespace PortfolioApi.Tests.Tests.Controllers
{
    public class ExperienceControllerTests : BaseControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task When_TheExperienceControllerGetExperiencesIsCalled_Then_ACollectionOfExperiencesIsReturned()
        {
            // Arrange 
            var controller = new ExperienceController(
                experienceService: IoCService.Controller.GetService<IExperienceService>()
                );

            var result = await controller.GetExperiencesAsync();

            // Assert

            Assert.That(result.Any(), Is.True, "There were no experiences returned");
        }
    }
}