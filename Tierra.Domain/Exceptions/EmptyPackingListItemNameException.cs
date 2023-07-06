using Tierra.Shared.Abstractions.Exceptions;

namespace Tierra.Domain.Exceptions;

public class EmptyPackingListItemNameException: TierraExceptions
{
    public EmptyPackingListItemNameException() : base("Packing item name cannot be empty!")
    {
    }
}