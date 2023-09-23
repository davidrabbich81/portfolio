namespace PortfolioApi.Models.Blog
{
    /// <summary>
    /// Represents an individual post within the blog
    /// </summary>
    public class BlogSummary
    {
        /// <summary>
        /// The unique Id of the blog post
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// The title of the blog post used for listings
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// The date the blog post was created
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// A short snippet of the blog post
        /// </summary>
        public string? Summary { get; set; }
    }
}
