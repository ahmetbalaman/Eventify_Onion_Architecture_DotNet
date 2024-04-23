using Eventify_Tutorial_Series.Application.Abstractions.Services;
using Eventify_Tutorial_Series.Application.Abstractions.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Eventify_Tutorial_Series.Application;

public static class ServiceRegistration
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ExportService>();
    }
}