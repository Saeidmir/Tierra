using Tierra.Shared.Abstractions.Commands;

namespace Tierra.Application.Commands;

public record RemovePackingItem(Guid PackingListId, string Name) : ICommand;