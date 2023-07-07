using Tierra.Domain.ValueObjects;

namespace Tierra.Domain.Policies.Gender;

internal sealed class FemaleGenderPolicy : IPackingItemPolicies
{
    public bool IsApplicable(PolicyData data)
        => data.Gender is Consts.Gender.Female;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        => new List<PackingItem>
        {
            new("Lipstick", 1),
            new("Powder", 1),
            new("Eyeliner", 1)
        };
}