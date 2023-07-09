using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tierra.Application.Services;
using Tierra.Domain.Repositories;
using Tierra.Infrastructure.EF.Contexts;
using Tierra.Infrastructure.EF.Options;
using Tierra.Infrastructure.EF.Repositories;
using Tierra.Infrastructure.EF.Services;
using Tierra.Shared.Options;

namespace PackIT.Infrastructure.EF;

internal static class Extensions
{
    public static IServiceCollection AddSqlServer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IPackingListRepository, SqlServerPackingListRepository>();
        services.AddScoped<IPackingListReadService, PostgresPackingListReadService>();

        var options = configuration.GetOptions<SqlServerOptions>("Postgres");
        services.AddDbContext<ReadDbContext>(ctx =>
            ctx.UseSqlServer(options.ConnectionString));
        services.AddDbContext<WriteDbContext>(ctx =>
            ctx.UseSqlServer(options.ConnectionString));

        return services;
    }
}