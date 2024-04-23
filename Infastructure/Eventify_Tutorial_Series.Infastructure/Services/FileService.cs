using Eventify_Tutorial_Series.Application.Abstractions.Services;

namespace Eventify_Tutorial_Series.Infastructure.Services;

public class FileService:IFileService
{
    public async Task SaveTextAsync(string text, string path)
    {
        try
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException(nameof(text));
         
            await File.WriteAllTextAsync(path,text);
        }catch (Exception e)
        {
            Console.WriteLine($"An Error Ocured while saving text to file : {e.Message}");
            throw;
        }
    }
}