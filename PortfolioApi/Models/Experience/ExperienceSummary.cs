namespace PortfolioApi.Models.Experience
{
    /// <summary>
    /// Represents experience held in a job position
    /// </summary>
    public class ExperienceSummary
    {
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


    }
}
