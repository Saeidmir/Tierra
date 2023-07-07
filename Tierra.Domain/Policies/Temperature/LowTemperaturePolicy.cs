using Tierra.Domain.ValueObjects;

namespace Tierra.Domain.Policies.Temperature;

internal sealed class LowTemperaturePolicy: IPackingItemPolicies
{
    public bool IsApplicable(PolicyData data)
        => data.Temperature < 10D;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        => new List<PackingItem>
        {
            new("Winter hat", 1),
            new("Scarf", 1),
            new("Gloves", 1),
            new("Hoodie", 1),
            new("Warm jacket", 1),
        };
}