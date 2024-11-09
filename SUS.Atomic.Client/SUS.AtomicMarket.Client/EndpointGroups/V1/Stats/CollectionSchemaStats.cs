using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Stats.CollectionSchemaStats;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Stats
{
    public class CollectionSchemaStats
        :
        BaseEndpoint,
        IBeforeFilterable<CollectionSchemaStats>,
        IAfterFilterable<CollectionSchemaStats>,
        IPageable<CollectionSchemaStats>,
        ILimitable<CollectionSchemaStats>,
        IOrderable<CollectionSchemaStats>,
        ISortable<CollectionSchemaStats, CollectionSchemaStatsSortType>,
        IExecutable<CollectionSchemaStatsResponse>
    {
        internal CollectionSchemaStats(string endpoint, string collection, string symbol)
        {
            _endpoint = $"{endpoint}/schemas/{collection}";
            AddQuery("symbol", symbol);
        }
    }
}
