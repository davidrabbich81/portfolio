namespace PortfolioApi.Models.Experience
{
    /// <summary>
    /// Represents experience held in a job position
    /// </summary>
    public class Experience : ExperienceSummary
    {
        /// <summary>
        /// A full run down of the experience
        /// </summary>
        public string FullDescription { get; set; }

    }
}
