using Markdig;
using Markdig.Syntax;
using PortfolioApi.Models.Markdown;
using PortfolioApi.Services.Interface;

namespace PortfolioApi.Services
{
    public class MarkdownConverterService : IMarkdownConverterService
    {
        private readonly IFileService fileService;

        public MarkdownConverterService(IFileService fileService)
        {
            this.fileService = fileService;
        }

        /// <summary>
        /// Converts a string of Markdown text to its HTML equivelant
        /// </summary>
        /// <param name="markdownContent"></param>
        /// <returns></returns>
        public MDConversion ConvertMarkdownToHtml(string markdownContent)
        {
            var md = new MDConversion(markdownContent);
            markdownContent = md.ParseSynopsis(markdownContent);
            md.Formatted = Markdown.ToHtml(markdownContent);
            return md;
        }

        /// <summary>
        /// Converts a dictionary of markdown content to html
        /// </summary>
        /// <param name="contentDictionary"></param>
        /// <returns></returns>
        public Dictionary<string, MDConversion> ConvertMarkdownToHtml(Dictionary<string, string> contentDictionary)
        {
            return contentDictionary.Select(x => new
            {
                x.Key,
                Value = ConvertMarkdownToHtml(x.Value)
            }).ToDictionary(x => x.Key, x => x.Value);
        }

        /// <summary>
        /// Converts files in a folder to HTML format
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public async Task<Dictionary<string, MDConversion>> ConvertMarkdownFilesToHtml(string path)
        {
            var files = await fileService.ReadAllFilesIntoMemory(path);
            if (!files.Any())
                return new Dictionary<string, MDConversion>();

            return ConvertMarkdownToHtml(files);
        }

    }
}
