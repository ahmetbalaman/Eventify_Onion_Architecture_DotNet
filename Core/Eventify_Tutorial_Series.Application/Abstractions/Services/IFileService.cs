using Eventify_Tutorial_Series.Application.DTOs;

namespace Eventify_Tutorial_Series.Application.Abstractions.Services;

public interface IFileService
{
    Task SaveTextAsync(string text,string path);
    
}