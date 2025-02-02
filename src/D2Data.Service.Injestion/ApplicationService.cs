using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace D2Data.Service.Injestion;

public static class ApplicationService
{

    public static IServiceCollection AddInjestionServices(this IServiceCollection services, IConfiguration configuration)
    {
        
        return services;
    }
}