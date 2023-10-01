using PortfolioApi.Services.Interface;
using PortfolioApi.Tests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApi.Tests.Tests.Services
{
    internal class ExperienceServiceTests
    {
        #region Setup

        #endregion

        #region Tests

        [Test]
        public async Task When_GetExperiencesIsCalled_Then_ExperienceListIsReturned()
        {
            var service = IoCService.Controller.GetService<IExperienceService>();

            var experiences = await service.GetExperiencesAsync();

            Assert.That(experiences.Any(), Is.True, "There were no experiences found");

            foreach (var item in experiences)
            {
                Console.WriteLine(item.Id);
            }

        }

        #endregion
    }
}
