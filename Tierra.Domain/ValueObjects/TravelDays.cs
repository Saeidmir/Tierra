using Tierra.Domain.Exceptions;

namespace Tierra.Domain.ValueObjects;

public class TravelDays
{
    public ushort Value { get; }

    public TravelDays(ushort value)
    {
        if (value is 0 or > 1000)
        {
            throw new InvalidTravelDaysException(value);
        }
 
        Value = value;
    }

    public static implicit operator TravelDays(ushort days) => new(days);
    public static implicit operator ushort(TravelDays days) => days.Value;
}