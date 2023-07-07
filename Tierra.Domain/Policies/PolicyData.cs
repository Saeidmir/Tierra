using Tierra.Domain.Consts;
using Tierra.Domain.ValueObjects;

namespace Tierra.Domain.Policies;

public record PolicyData(TravelDays Days, Consts.Gender Gender, ValueObjects.Temperature Temperature, Localization Localization);