using Microsoft.Extensions.DependencyInjection;
using Tierra.Domain.Factories;
using Tierra.Domain.Policies;
using Tierra.Shared.Commands;

namespace Tierra.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection serivces)
    {
        serivces.AddCommands();
        serivces.AddSingleton<IPackingListFactory, PackingListFactory>();
        serivces.Scan(b => b.FromAssemblies(typeof(IPackingItemPolicies).Assembly)
            .AddClasses(c => c.AssignableTo<IPackingItemPolicies>())
            .AsImplementedInterfaces().WithSingletonLifetime());
        return serivces;
    }
}