using PortfolioApi.Services.Interface;
using PortfolioApi.Tests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApi.Tests.Tests.Services
{
    internal class BlogServiceTests
    {
        #region Setup

        #endregion

        #region Tests

        [Test]
        public async Task When_GetBlogPostsIsCalled_Then_BlogListIsReturned()
        {
            var service = IoCService.Controller.GetService<IBlogService>();

            var blogs = await service.GetBlogPostsAsync();

            Assert.That(blogs.Any(), Is.True, "There were no blog posts found");

            foreach (var item in blogs)
            {
                Console.WriteLine(item.Id);
            }

        }

        #endregion
    }
}
