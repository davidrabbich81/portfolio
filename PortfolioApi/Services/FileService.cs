using PortfolioApi.Services.Interface;
using System.Reflection;

namespace PortfolioApi.Services
{
    public class FileService : IFileService
    {

        /// <summary>
        /// Reads all files in a directory and turns it into a dictionary of file name and contents
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public async Task<Dictionary<string, string>> ReadAllFilesIntoMemory(string path)
        {
            var results = new Dictionary<string, string>();

            foreach (var file in System.IO.Directory.GetFiles(path))
                results.Add(Path.GetFileNameWithoutExtension(file),
                    await System.IO.File.ReadAllTextAsync(file));

            return results;
        }


        /// <summary>
        /// Gets the fully qualified path from a relative path
        /// </summary>
        /// <param name="relativePath"></param>
        /// <returns></returns>
        public string GetFullPathFromRelativePath(string relativePath)
            => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + relativePath;

    }
}
