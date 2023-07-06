using Tierra.Domain.Consts;
using Tierra.Domain.Entities;
using Tierra.Domain.ValueObjects;

namespace Tierra.Domain.Factories;

class PackingListFactory : IPackingListFactory
{
    public PackingList Create(PackingListId id, PackingListName name, Localization localization)
    {
        throw new NotImplementedException();
    }

    public PackingList CreatewithDefaultItem(PackingListId id, PackingListName name, TravelDays days, Gender gender,
        Localization localization)
    {
        throw new NotImplementedException();
    }
}