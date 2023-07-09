using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tierra.Domain.Repositories;

namespace Tierra.Infrastructure;

public class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IPackingListRepository>()
        var assembly = Assembly.GetCallingAssembly();

        return services;
    }
}