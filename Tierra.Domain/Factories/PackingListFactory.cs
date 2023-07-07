using Tierra.Domain.Consts;
using Tierra.Domain.Entities;
using Tierra.Domain.Policies;
using Tierra.Domain.ValueObjects;

namespace Tierra.Domain.Factories;

// The Factory responsible for creating our packing list
public sealed class PackingListFactory : IPackingListFactory
{
    private readonly IEnumerable<IPackingItemPolicies> _policies;

    public PackingListFactory(IEnumerable<IPackingItemPolicies> policies)
    {
        _policies = policies;
    }

    public PackingList Create(PackingListId id, PackingListName name, Localization localization)
    {
        return new PackingList(id, name, localization);
    }

    public PackingList CreateWithDefaultItem(PackingListId id, PackingListName name, TravelDays days, Gender gender,
        Temperature temperature
        , Localization localization)
    {
        var data = new PolicyData(days, gender, temperature, localization);
        var applicablePolicies = _policies.Where(p => p.IsApplicable(data));
        var items = applicablePolicies.SelectMany(p => p.GenerateItems(data));
        var packingList = Create(id, name, localization);
        packingList.AddItems(items);
        return packingList;
    }
}