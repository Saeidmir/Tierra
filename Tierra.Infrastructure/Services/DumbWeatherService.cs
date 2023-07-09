using Tierra.Application.DTO.External;
using Tierra.Application.Services;
using Tierra.Domain.ValueObjects;

namespace Tierra.Infrastructure.Services 
{
    internal sealed class DumbWeatherService : IWeatherService
    {
        public Task<WeatherDto> GetWeatherAsync(Localization localization)
            => Task.FromResult(new WeatherDto(new Random().Next(5, 30)));
    }
}