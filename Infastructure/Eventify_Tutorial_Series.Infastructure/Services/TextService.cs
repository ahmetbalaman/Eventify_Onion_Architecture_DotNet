using System.Text;
using Eventify_Tutorial_Series.Application.Abstractions.Services;
using Eventify_Tutorial_Series.Application.DTOs;

namespace Eventify_Tutorial_Series.Infastructure.Services;

public class TextService:ITextService
{
    public string FormatTextForEvent(IEnumerable<EventDTO?> eventItems)
    {
        if (eventItems is null)
            throw new ArgumentException(nameof(eventItems));

        StringBuilder stringBuilder=new();

        foreach (var eventItem in eventItems)
        {
            if (eventItem is not null)
                stringBuilder.AppendLine(
                    $"Event: {eventItem.Title} - Location: {eventItem.Location.City} - Date: {eventItem.Date.ToString("hh:mm - dd/MM/yyyy")}");

        }
        return stringBuilder.ToString().TrimEnd();
    }
}