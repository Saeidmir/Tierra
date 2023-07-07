using Tierra.Shared.Abstractions.Exceptions;

namespace Tierra.Domain.Exceptions;

public class InvalidTemperatureException: TierraExceptions
{
    public double Value { get; }

    public InvalidTemperatureException(double value):base($"Value '{value}' is invalid temperature!")
     =>   Value = value;
}