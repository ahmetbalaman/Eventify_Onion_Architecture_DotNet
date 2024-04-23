using Eventify_Tutorial_Series.Application.Abstractions.Services;
using Eventify_Tutorial_Series.Application.DTOs;
using Eventify_Tutorial_Series.Application.RequestParameters;
using Eventify_Tutorial_Series.Domain.Entities;
using Eventify_Tutorial_Series.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Eventify_Tutorial_Series.Persistence.Services;

public class EventService : IEventService
{
    private readonly EventifyDbContext _context;

    public EventService(EventifyDbContext context)
    {
        _context = context;
    }

    public async Task CreateEventAsync(CreateEventDTO createEventDto)
    {
        if (createEventDto is null)
        {
            throw new NullReferenceException();
        }
        
        
        var newEvent = new Event()
        {
            //Id = Guid.NewGuid(),
            Title = createEventDto.Title,
            Date = createEventDto.Date,
            Location = createEventDto.Location,
            //CreatedDate = DateTimeOffset.Now

        };

        await _context.AddAsync(newEvent);
        await _context.SaveChangesAsync();
        
        
    }

    public async Task<IEnumerable<EventDTO>> GetAllEventAsync(Pagination pagination)
    {
        return await _context.Events.AsNoTracking().Select(x => new EventDTO()
        {
            Title = x.Title,
            Date = x.Date,
            Location = x.Location
            
        }).Skip(pagination.ItemCount * pagination.PageCount)
            .Take(pagination.ItemCount)
            .ToListAsync();

    }
}