using Microsoft.EntityFrameworkCore;
using Tierra.Application.Services;
using Tierra.Infrastructure.EF.Contexts;
using Tierra.Infrastructure.EF.Models;

namespace Tierra.Infrastructure.EF.Services
{
    internal sealed class PostgresPackingListReadService : IPackingListReadService
    {
        private readonly DbSet<PackingListReadModel> _packingList;

        public PostgresPackingListReadService(ReadDbContext context)
            => _packingList = context.PackingLists;

        public Task<bool> ExistsByNameAsync(string name)
            => _packingList.AnyAsync(pl => pl.Name == name);
    }
}