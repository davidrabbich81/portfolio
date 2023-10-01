using PortfolioApi.Controllers;
using PortfolioApi.Services.Interface;
using PortfolioApi.Tests.Services;
using PortfolioApi.Tests.Tests.Base;

namespace PortfolioApi.Tests.Tests.Controllers
{
    public class BlogControllerTests : BaseControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task When_TheBlogControllerGetBlogPostsIsCalled_Then_ACollectionOfPostsIsReturned()
        {
            // Arrange 
            var controller = new BlogController(
                blogService: IoCService.Controller.GetService<IBlogService>()
                );

            var result = await controller.GetBlogsAsync();

            // Assert

            Assert.That(result.Any(), Is.True, "There were no blog posts returned");
        }
    }
}