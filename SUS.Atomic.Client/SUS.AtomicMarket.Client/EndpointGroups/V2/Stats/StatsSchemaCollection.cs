using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V2.Stats.StatsSchemaCollection;

namespace SUS.AtomicMarket.Client.EndpointGroups.V2.Stats
{
    public class StatsSchemaCollection
        :
        BaseEndpoint,
        IBeforeFilterable<StatsSchemaCollection>,
        IAfterFilterable<StatsSchemaCollection>,
        IPageable<StatsSchemaCollection>,
        ILimitable<StatsSchemaCollection>,
        IOrderable<StatsSchemaCollection>,
        ISortable<StatsSchemaCollection, StatsSchemaCollectionSortType>,
        IExecutable<StatsSchemaCollectionResponse>
    {
        internal StatsSchemaCollection(string endpoint, string collection, string symbol)
        {
            _endpoint = $"{endpoint}/schemas/{collection}";
            AddQuery("symbol", symbol);
        }
    }
}
