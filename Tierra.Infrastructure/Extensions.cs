using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Tierra.Shared.Abstractions.Commands;
using Tierra.Shared.Commands;

namespace Tierra.Infrastructure;

public class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        var assembly = Assembly.GetCallingAssembly();

        return services;
    }
}