using Tierra.Shared.Abstractions.Exceptions;

namespace Tierra.Domain.Exceptions;

public class InvalidTravelDaysException : TierraExceptions
{
    public ushort Days { get; }

    public InvalidTravelDaysException(ushort days) : base($"Value '{days}' is invalid travel days!")
        => Days = days;
}