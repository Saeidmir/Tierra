using Tierra.Shared.Abstractions.Exceptions;

namespace Tierra.Application.Exceptions;

public class PackingListAlreadyExistsException : TierraExceptions
{
    public PackingListAlreadyExistsException(string name)
        : base($"Packing list with name '{name}' already exists.")
    {
        Name = name;
    }

    public string Name { get; }
}