using Tierra.Shared.Abstractions.Exceptions;

namespace Tierra.Domain.Exceptions;

public class PackingItemAlreadyExistsException:TierraExceptions
{
    public string ListName { get; }
    public string ItemName { get; }

    public PackingItemAlreadyExistsException(string listName, string itemName) : base($"Packing list: '{listName}' already defined item '{itemName}'!")
    {
        ListName = listName;
        ItemName = itemName;
    }
}