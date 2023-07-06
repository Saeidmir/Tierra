﻿using Tierra.Domain.Exceptions;

namespace Tierra.Domain.ValueObjects;

public class PackingListId
{
    public Guid Value { get; }

    public PackingListId(Guid value)
    {
        if (value == Guid.Empty)
            throw new EmptyPackingListIdException();
        Value = value;
    }

    public static implicit operator Guid(PackingListId id) => id.Value;
    public static implicit operator PackingListId(Guid id) => new(id);
}