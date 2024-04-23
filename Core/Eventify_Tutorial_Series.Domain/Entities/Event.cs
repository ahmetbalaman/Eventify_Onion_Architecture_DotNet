using Eventify_Tutorial_Series.Domain.Common;
using Eventify_Tutorial_Series.Domain.ValueObjects;

namespace Eventify_Tutorial_Series.Domain.Entities;

public class Event:EntityBase<Guid>
{
    public string Title { get; set; }
    public DateTimeOffset Date { get; set; }

    public Location Location { get; set; }
    
    
}