using Eventify_Tutorial_Series.Domain.ValueObjects;

namespace Eventify_Tutorial_Series.Application.DTOs;

public class CreateEventDTO
{
    public string Title { get; set; }
    public DateTimeOffset Date { get; set; }
    public Location Location { get; set; }
}