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

        [TestCase("20230923-Test_Blog_Post")]
        public async Task When_GetBlogIsCalled_Then_ASingleBlogPostIsReturned(string file)
        {
            var service = IoCService.Controller.GetService<IBlogService>();

            var item = await service.GetBlogPostAsync(file);

            Assert.That(item.Id, Is.Not.Null.And.Not.Empty, "The ID was empty");
            Assert.That(item.Title, Is.Not.Null.And.Not.Empty, "The post title was empty");
            Assert.That(item.DateCreated, Is.Not.EqualTo(new DateTime()), "The date was empty");
            
            Console.WriteLine($"Id: {item.Id}");
            Console.WriteLine($"Title: {item.Title}");
            Console.WriteLine($"Date: {item.DateCreated}");
            Console.WriteLine($"Content: {item.Content}");
        }

        #endregion
    }
}
