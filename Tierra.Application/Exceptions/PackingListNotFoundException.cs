using Tierra.Shared.Abstractions.Exceptions;

namespace Tierra.Application.Exceptions;

public class PackingListNotFoundException : TierraExceptions
{
    public PackingListNotFoundException(Guid id) : base($"Packing list with ID '{id}' was not found.")
    {
        Id = id;
    }

    public Guid Id { get; }
}