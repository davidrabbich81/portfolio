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
                Assert.That(item.Id, Is.Not.Null.And.Not.Empty, "The ID was empty");
                Assert.That(item.JobTitle, Is.Not.Null.And.Not.Empty, "The Job title was empty");
                Assert.That(item.Company, Is.Not.Null.And.Not.Empty, "The Company was empty");
                Assert.That(item.TimeFrame, Is.Not.Null.And.Not.Empty, "The Timeframe was empty");

                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"Title: {item.JobTitle}");
                Console.WriteLine($"Company: {item.Company}");
                Console.WriteLine($"Time: {item.TimeFrame}");
            }

        }

        #endregion
    }
}
