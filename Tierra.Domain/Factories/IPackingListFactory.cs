using Tierra.Domain.Consts;
using Tierra.Domain.Entities;
using Tierra.Domain.ValueObjects;

namespace Tierra.Domain.Factories;

public interface IPackingListFactory
{
    PackingList Create(PackingListId id, PackingListName name, Localization localization);
    PackingList CreateWithDefaultItem(PackingListId id, PackingListName name, TravelDays days,Gender gender,Temperature temperature, Localization localization);
}
