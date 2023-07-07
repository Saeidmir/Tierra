using Tierra.Domain.ValueObjects;

namespace Tierra.Domain.Policies.Gender;

public class MaleGenderPolicy : IPackingItemPolicies
{
    public bool IsApplicable(PolicyData data)
        => data.Gender is Consts.Gender.Male;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        => new List<PackingItem>
        {
            new PackingItem("Laptop", 1),
            new PackingItem("Beer", 10),
            new PackingItem("Book", (uint)Math.Ceiling(data.Days/7m))
        };
}