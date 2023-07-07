using Tierra.Domain.Exceptions;

namespace Tierra.Domain.ValueObjects;

public class Temperature
{
    public double Value { get; }

    public Temperature(double value)
    {
        if (value is -100 or > 1000)
        {
            throw new InvalidTemperatureException( value);
        }
 
        Value = value;
    }

    public static implicit operator Temperature(double temperature) => new(temperature);
    public static implicit operator double(Temperature temperature) => temperature.Value;
}