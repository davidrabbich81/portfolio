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
        public void When_TheBlogControllerGetBlogPostsIsCalled_Then_ACollectionOfPostsIsReturned()
        {
            Assert.Pass();
        }
    }
}