using Tierra.Shared.Abstractions.Exceptions;

namespace Tierra.Domain.Exceptions;

public class EmptyPackingListNameException : TierraExceptions
{
    public EmptyPackingListNameException() : base("packing list cannot be empty")
    {
    }
}