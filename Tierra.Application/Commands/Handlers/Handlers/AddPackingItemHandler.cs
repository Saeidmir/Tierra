using Tierra.Application.Exceptions;
using Tierra.Domain.Repositories;
using Tierra.Domain.ValueObjects;
using Tierra.Shared.Abstractions.Commands;

namespace Tierra.Application.Commands.Handlers.Handlers;

internal sealed class AddPackingItemHandler : ICommandHandler<AddPackingItem>
{
    private readonly IPackingListRepository _repository;

    public AddPackingItemHandler(IPackingListRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(AddPackingItem command)
    {
        var packingList = await _repository.GetAsync(command.PackingListId);

        if (packingList is null) throw new PackingListNotFoundException(command.PackingListId);

        var packingItem = new PackingItem(command.Name, command.Quantity);
        packingList.AddItem(packingItem);

        await _repository.UpdateAsync(packingList);
    }
}