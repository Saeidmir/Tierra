using Tierra.Application.DTO.External;
using Tierra.Domain.ValueObjects;

namespace Tierra.Application.Services;

public interface IWeatherService
{
    Task<WeatherDto> GetWeatherAsync(Localization localization);
}