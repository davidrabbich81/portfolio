namespace PortfolioApi.Models.Markdown
{
    /// <summary>
    /// Handles conversion of a markdown file into HTML
    /// </summary>
    public class MDConversion
    {
        public string Preformatted { get; set; }

        public string Formatted { get; set; }

        public string Synopsis { get; set; }

        public MDConversion()
        {

        }

        public MDConversion(string content)
        {
            Preformatted = content;
            Synopsis = content;
            ParseSynopsis(content);
        }

        public string ParseSynopsis(string content)
        {
            if (content.StartsWith("//"))
            {
                Synopsis = content
                    .Substring(0, content.IndexOf(Environment.NewLine))
                    .Replace("//", string.Empty);
                content = content.Replace(content.Substring(0, 
                    content.IndexOf(Environment.NewLine)), string.Empty);
            }
            return content;
        }
    }
}
