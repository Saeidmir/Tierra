using Tierra.Shared.Abstractions.Commands;

namespace Tierra.Application.Commands;

public record RemovePackingList(Guid Id) : ICommand;