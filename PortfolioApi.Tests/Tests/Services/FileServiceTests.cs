using PortfolioApi.Services.Interface;
using PortfolioApi.Tests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApi.Tests.Tests.Services
{
    internal class FileServiceTests
    {
        #region Setup

        #endregion

        #region Tests

        [Test]
        public async Task When_ReadAllFilesIntoMemoryIsCalled_Then_DictionaryOfFilesIsReturned()
        {
            var service = IoCService.Controller.GetService<IFileService>();

            var results = await service.ReadAllFilesIntoMemory(
                service.GetFullPathFromRelativePath("/Data/Experience/"));

            Assert.That(results.Any(), Is.True, "There were no files read");

            foreach (var item in results)
            {
                Console.WriteLine(item.Key);
            }

        }

        [Test]
        public async Task When_ReadAllFilesIntoMemoryIsCalled_WithADirectFilePath_Then_ResultsAreOneFile()
        {
            var service = IoCService.Controller.GetService<IFileService>();

            var results = await service.ReadAllFilesIntoMemory(
                service.GetFullPathFromRelativePath("/Data/Experience/2020-2023-CTO-Fuuse.md"));

            Assert.That(results.Any(), Is.True, "There were no files read");
            Assert.That(results.Count(), Is.EqualTo(1), "There was more than one file.");

            foreach (var item in results)
            {
                Console.WriteLine(item.Key);
            }

        }

        #endregion
    }
}
