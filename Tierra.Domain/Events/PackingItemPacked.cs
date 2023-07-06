using Tierra.Domain.Entities;
using Tierra.Domain.ValueObjects;
using Tierra.Shared.Abstractions.Domain;

namespace Tierra.Domain.Events;

public record PackingItemPacked(PackingList PackingList, PackingItem PackingItem):IDomainEvent;