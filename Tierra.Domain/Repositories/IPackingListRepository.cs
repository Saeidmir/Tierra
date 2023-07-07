﻿using Tierra.Domain.Entities;
using Tierra.Domain.ValueObjects;

namespace Tierra.Domain.Repositories;

public interface IPackingListRepository
{
    Task<bool> ExistsAsync(PackingListName name);
    Task<PackingList> GetAsync(PackingListId id);
    Task AddAsync(PackingList packingList);
    Task UpdateAsync(PackingList packingList);
    Task DeleteAsync(PackingList packingList);
}