using Tierra.Shared.Abstractions.Exceptions;

namespace Tierra.Domain.Exceptions;

public class PackingItemNotFoundException: TierraExceptions
{
    public string ItemName { get; }
    public PackingItemNotFoundException(string itemName) : base($"Packing item 'itemName' was not found! ")
    => ItemName = itemName;
}