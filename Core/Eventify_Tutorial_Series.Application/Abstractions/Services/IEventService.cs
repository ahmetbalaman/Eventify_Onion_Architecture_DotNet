using Eventify_Tutorial_Series.Application.DTOs;
using Eventify_Tutorial_Series.Application.RequestParameters;

namespace Eventify_Tutorial_Series.Application.Abstractions.Services;

public interface IEventService
{
    Task CreateEventAsync(CreateEventDTO createEventDto);

    Task<IEnumerable<EventDTO>> GetAllEventAsync(Pagination pagination);

}