using Tierra.Application.DTO;
using Tierra.Infrastructure.EF.Models;

namespace Tierra.Infrastructure.EF.Queries;

internal static class Extensions
{
    public static PackingListDto AsDto(this PackingListReadModel readModel)
    {
        return new PackingListDto
        {
            Id = readModel.Id,
            Name = readModel.Name,
            Localization = new LocalizationDto
            {
                City = readModel.Localization?.City,
                Country = readModel.Localization?.Country
            },
            Items = readModel.Items?.Select(pi => new PackingItemDto
            {
                Name = pi.Name,
                Quantity = pi.Quantity,
                IsPacked = pi.IsPacked
            })
        };
    }
}