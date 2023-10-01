namespace PortfolioApi.Services
{
    public interface IMarkdownConverterService
    {
        /// <summary>
        /// Converts a string of Markdown text to its HTML equivelant
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        Task<Dictionary<string, string>> ConvertMarkdownFilesToHtml(string path);
        
        /// <summary>
        /// Converts a dictionary of markdown content to a dictionary of HTML content
        /// </summary>
        /// <param name="contentDictionary"></param>
        /// <returns></returns>
        Dictionary<string, string> ConvertMarkdownToHtml(Dictionary<string, string> contentDictionary);
        
        /// <summary>
        /// Converts an individual piece of markdown content to HTML
        /// </summary>
        /// <param name="markdownContent"></param>
        /// <returns></returns>
        string ConvertMarkdownToHtml(string markdownContent);
    }
}