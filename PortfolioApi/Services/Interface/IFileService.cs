namespace PortfolioApi.Services.Interface
{
    /// <summary>
    /// A service that reads and writes data to files
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Reads all files in a directory and turns it into a dictionary of file name and contents
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        Task<Dictionary<string, string>> ReadAllFilesIntoMemory(string path);

        /// <summary>
        /// Gets the fully qualified path from a relative path
        /// </summary>
        /// <param name="relativePath"></param>
        /// <returns></returns>
        public string GetFullPathFromRelativePath(string relativePath);
    }
}