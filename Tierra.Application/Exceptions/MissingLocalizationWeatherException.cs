using Tierra.Domain.ValueObjects;
using Tierra.Shared.Abstractions.Exceptions;

namespace Tierra.Application.Exceptions;

public class MissingLocalizationWeatherException : TierraExceptions
{
    public MissingLocalizationWeatherException(Localization localization)
        : base($"Couldn't fetch weather data for localization '{localization.Country}/{localization.City}'.")
    {
        Localization = localization;
    }

    public Localization Localization { get; }
}