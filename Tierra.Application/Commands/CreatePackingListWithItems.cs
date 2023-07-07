using Tierra.Domain.Consts;
using Tierra.Shared.Abstractions.Commands;

namespace Tierra.Application.Commands;

public record CreatePackingListWithItems(Guid Id, string Name, ushort Days, Gender Gender,
    LocalizationWriteModel Localization) : ICommand;

public record LocalizationWriteModel(string City, string Country);