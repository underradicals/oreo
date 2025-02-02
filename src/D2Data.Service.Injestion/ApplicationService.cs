using System.IO.Compression;
using D2.App.Kernel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace D2Data.Service.Injestion;

public class ApplicationService
{
    private readonly ManifestSerializer _serializer;
    private readonly IHttpClientFactory _httpFactory;
    private readonly ILogger<ApplicationService> _logger;

    public ApplicationService(ManifestSerializer serializer, IHttpClientFactory httpFactory, ILogger<ApplicationService> logger)
    {
        _serializer = serializer;
        _httpFactory = httpFactory;
        _logger = logger;
    }

    public void Run()
    {
        var httpClient = _httpFactory.CreateClient(ProjectConstants.ManifestHttpClientName);
        var manifest = File.ReadAllText(Paths.ManifestPath);
        var result = _serializer.Deserialize(manifest);
        var db_url = result.GetMobileWorldContentPath("En");
        var json_urls = result.GetJsonWorldComponentsContentPath("En");
        var dict = json_urls.ToDictionary();
        
        // Delete All Files
        try
        {
            var dirList = Directory.GetFiles(Directories.DataDirectory, "*.json");
            foreach (var filename in dirList)
            {
                _logger.LogInformation($"Deleting file: {filename}");
                File.Delete(filename);
            }
        }
        catch (IOException ex)
        {   
            _logger.LogError(ex, ex.Message);
        }
        
        // Create New Directory
        try
        {
            _logger.LogInformation($"Creating Directory: {Directories.DataDirectory}");
            Directory.CreateDirectory(Directories.DataDirectory);
        }
        catch (Exception e)
        {
            _logger.LogError(e, e.Message);
        }
        
        // Download all Json Files
        foreach (var item in dict)
        {
            var httpResponseMessage = httpClient.GetAsync(item.Value).GetAwaiter().GetResult();
            _logger.LogInformation($"Download {item.Key}: {httpResponseMessage.StatusCode}");
            File.WriteAllText(Path.Combine(Directories.DataDirectory, $"{item.Key}.json"), 
                httpResponseMessage.Content
                    .ReadAsStringAsync().GetAwaiter().GetResult());
            _logger.LogInformation($"Wrote {item.Key}: to disk");
        }
        
        // Download Database file and write to disk (file is a zip-file)
        var mobileWorldDatabase = httpClient.GetByteArrayAsync(db_url).GetAwaiter().GetResult();
        File.WriteAllBytes(Paths.WorldContentPath, mobileWorldDatabase);
        
        // Extract Contents of Archive
        try
        {
            var zipArchive = ZipFile.OpenRead(Paths.WorldContentPath);
            try
            {
                foreach (var archive in zipArchive.Entries)
                {
                    archive.ExtractToFile(Path.Combine(Directories.CurrentWorkingDirectory, "world_content.db"), true);
                }
            }
            finally
            {
                // Ensure that file is not locked so we can delete it later
                zipArchive.Dispose();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        // Remove zip-file
        try
        {
            File.Delete(Paths.WorldContentPath);
        }
        catch (IOException ex)
        {
            _logger.LogError($"Failed to delete World Content: {ex.Message}");
        }
    }
}