using Eventify_Tutorial_Series.Application.Abstractions.Services;
using Eventify_Tutorial_Series.Persistence.DbContexts;
using Microsoft.Extensions.DependencyInjection;

namespace Eventify_Tutorial_Series.Persistence.Services;

public static class ServiceRegistration
{
    public static void AddPersistanceServices(this IServiceCollection services)
    {
        services.AddScoped<IEventService, EventService>();
        services.AddScoped<EventifyDbContext>();
    }
}