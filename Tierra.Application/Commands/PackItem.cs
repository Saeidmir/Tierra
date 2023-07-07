using Tierra.Shared.Abstractions.Commands;

namespace Tierra.Application.Commands;

public record PackItem(Guid PackingListId, string Name) : ICommand;