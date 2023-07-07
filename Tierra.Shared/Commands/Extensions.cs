using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Tierra.Shared.Abstractions.Commands;

namespace Tierra.Shared.Commands;

public static class Extensions
{
    public static IServiceCollection AddCommands(this IServiceCollection services)
    {
        var assembly = Assembly.GetCallingAssembly();
        services.AddSingleton<ICommandDispatcher, InMemoryCommandDispatcher>();
        services.Scan(s => s.FromAssemblies(assembly)
            .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>))
            ).AsImplementedInterfaces().WithScopedLifetime());
        return services;
    }
}