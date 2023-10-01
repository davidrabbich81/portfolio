using PortfolioApi.Services.Interface;

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

    }
}
