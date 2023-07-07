using Tierra.Domain.ValueObjects;

namespace Tierra.Domain.Policies;

public interface IPackingItemPolicies
{
    bool IsApplicable(PolicyData data);
    IEnumerable<PackingItem> GenerateItems(PolicyData data);
}