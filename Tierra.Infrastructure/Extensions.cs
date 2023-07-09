using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PackIT.Infrastructure.EF;
using Tierra.Application.Services;
using Tierra.Infrastructure.Logging;
using Tierra.Infrastructure.Services;
using Tierra.Shared.Abstractions.Commands;
using Tierra.Shared.Queries;

namespace Tierra.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSqlServer(configuration);
        services.AddQueries();
        services.AddSingleton<IWeatherService, DumbWeatherService>();
        services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));

        var assembly = Assembly.GetCallingAssembly();

        return services;
    }
}