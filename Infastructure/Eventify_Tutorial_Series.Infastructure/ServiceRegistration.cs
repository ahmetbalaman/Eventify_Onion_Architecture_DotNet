using Eventify_Tutorial_Series.Application.Abstractions.Services;
using Eventify_Tutorial_Series.Infastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Eventify_Tutorial_Series.Infastructure;

public static class ServiceRegistration
{
    public static void AddInfastructureServices(this IServiceCollection services)
    {
        services.AddScoped<ITextService,TextService>();
        services.AddScoped<IFileService,FileService>();
    }
}