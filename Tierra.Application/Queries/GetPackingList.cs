using Tierra.Application.DTO;
using Tierra.Shared.Abstractions.Queries;

namespace Tierra.Application.Queries
{
    public class GetPackingList : IQuery<PackingListDto>
    {
        public Guid Id { get; set; }
    }
}