using Eventify_Tutorial_Series.Application.DTOs;

namespace Eventify_Tutorial_Series.Application.Abstractions.Services;

public interface ITextService
{
    string FormatTextForEvent(IEnumerable<EventDTO?> eventItems);
    
}