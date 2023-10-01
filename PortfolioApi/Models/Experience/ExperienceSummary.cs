using PortfolioApi.Models.Markdown;
using System.Text.RegularExpressions;

namespace PortfolioApi.Models.Experience
{
    /// <summary>
    /// Represents experience held in a job position
    /// </summary>
    public class ExperienceSummary
    {
        #region Properties
        
        /// <summary>
        /// The unique identifier of the experience post
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The title held during the experience
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// The name of the company where the experience was had
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// A short synopsis of the experience to explain it pre-click
        /// </summary>
        public string Synopsis { get; set; }

        /// <summary>
        /// The length of the experience
        /// </summary>
        public string TimeFrame { get; set; }

        /// <summary>
        /// The main content for the experience
        /// </summary>
        public string Content { get; set; }

        #endregion



    }

    public static class ExperienceExtensionMethods
    {
        internal static Regex _nameRegex = new Regex("^(?<time>\\d+-\\d+)-(?<title>.*?)-(?<company>.*?)$");

        /// <summary>
        /// Gets the critical info from the name of the post
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ExperienceSummary ParseNameForInfo(this ExperienceSummary summary, string name)
        {
            var nameMatch = _nameRegex.Match(name);
            if (nameMatch.Success)
            {
                summary.Id = nameMatch.Value;
                summary.JobTitle = nameMatch.Groups["title"].Value.MakeCodeReplacementsInString();
                summary.TimeFrame = nameMatch.Groups["time"].Value;
                summary.Company = nameMatch.Groups["company"].Value.MakeCodeReplacementsInString();
            }
            return summary;
        }


        public static ExperienceSummary GetSynopsis(this ExperienceSummary summary, MDConversion content)
        {
            summary.Synopsis = content.Synopsis;
            return summary;
        }

        public static ExperienceSummary GetFullContent(this ExperienceSummary summary, MDConversion content)
        {
            summary.Content = content.Formatted;
            return summary;
        }

        private static string MakeCodeReplacementsInString(this string input)
        {
            return input.Replace("_", " ");
        }

    }
}
