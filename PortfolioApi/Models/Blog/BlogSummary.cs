using PortfolioApi.Models.Experience;
using System.Text.RegularExpressions;

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

    public static class BlogExtensionMethods
    {
        internal static Regex _nameRegex = new Regex(
            "^(?<year>\\d{4})(?<month>\\d{2})(?<date>\\d{2})-(?<title>.*?)$");

        /// <summary>
        /// Gets the critical info from the name of the post
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static BlogSummary ParseNameForInfo(this BlogSummary summary, string name)
        {
            var nameMatch = _nameRegex.Match(name);
            if (nameMatch.Success)
            {
                summary.Id = nameMatch.Value;
                summary.DateCreated = DateTime.Parse(
                    $"{nameMatch.Groups["year"].Value}-{nameMatch.Groups["month"].Value}-{nameMatch.Groups["date"].Value}"
                );
                summary.Title = nameMatch.Groups["title"].Value.MakeCodeReplacementsInString();

            }
            return summary;
        }

        private static string MakeCodeReplacementsInString(this string input)
        {
            return input.Replace("_", " ");
        }

    }
}
