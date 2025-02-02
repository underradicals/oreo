using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace D2Data.Service.Injestion;

public static class GlobalSetting
{
    public static IServiceCollection AddSettings<TSetting>(this IServiceCollection services, IConfiguration configuration, string name) where TSetting : class, new()
    {
        services.Configure<TSetting>(configuration.GetSection(name));
        services.AddSingleton(service => service.GetRequiredService<IOptions<TSetting>>().Value);
        return services;
    }
}