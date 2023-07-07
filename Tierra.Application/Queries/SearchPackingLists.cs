using Tierra.Application.DTO;
using Tierra.Shared.Abstractions.Queries;

namespace Tierra.Application.Queries
{
    public class SearchPackingLists : IQuery<IEnumerable<PackingListDto>>
    {
        public string SearchPhrase { get; set; }
    }
}