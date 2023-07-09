using Microsoft.EntityFrameworkCore;
using Tierra.Application.DTO;
using Tierra.Application.Queries;
using Tierra.Infrastructure.EF.Contexts;
using Tierra.Infrastructure.EF.Models;
using Tierra.Shared.Abstractions.Queries;

namespace Tierra.Infrastructure.EF.Queries.Handlers;

internal sealed class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
{
    private readonly DbSet<PackingListReadModel> _packingLists;

    public SearchPackingListsHandler(ReadDbContext context)
    {
        _packingLists = context.PackingLists;
    }

    public async Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
    {
        var dbQuery = _packingLists
            .Include(pl => pl.Items)
            .AsQueryable();

        if (query.SearchPhrase is not null)
        {
            // dbQuery = dbQuery.Where(pl =>
            //     Microsoft.EntityFrameworkCore.EF.Functions.ILike(pl.Name, $"%{query.SearchPhrase}%"));
        }

        return await dbQuery
            .Select(pl => Extensions.AsDto(pl))
            .AsNoTracking()
            .ToListAsync();
    }
}