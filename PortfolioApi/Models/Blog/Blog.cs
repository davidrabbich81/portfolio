namespace PortfolioApi.Models.Blog
{
    /// <summary>
    /// Represents an individual post within the blog
    /// </summary>
    public class Blog : BlogSummary
    {
        /// <summary>
        /// The HTML content of the blog post
        /// </summary>
        public string? Content { get; set; }

    }
}
