using Tierra.Shared.Abstractions.Commands;

namespace Tierra.Application.Commands;

public record AddPackingItem(Guid PackingListId, string Name, uint Quantity) : ICommand;