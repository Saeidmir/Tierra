using Tierra.Shared.Abstractions.Exceptions;

namespace Tierra.Domain.Exceptions;

public class EmptyPackingListIdException: TierraExceptions
{
    public EmptyPackingListIdException() : base("Packing List Id cannot be empty!")
    {
    }
}