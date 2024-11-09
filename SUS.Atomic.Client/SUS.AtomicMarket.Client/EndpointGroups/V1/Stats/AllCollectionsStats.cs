using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Stats.AllCollectionsStats;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Stats
{
    public class AllCollectionsStats
        :
        BaseEndpoint,
        ICollectionsFilterable<AllCollectionsStats>,
        IIdsFilterable<AllCollectionsStats>,
        ILowerBoundable<AllCollectionsStats>,
        IUpperBoundable<AllCollectionsStats>,
        IAfterFilterable<AllCollectionsStats>,
        IBeforeFilterable<AllCollectionsStats>,
        IPageable<AllCollectionsStats>,
        ILimitable<AllCollectionsStats>,
        IOrderable<AllCollectionsStats>,
        ICollectionsBlocklistable<AllCollectionsStats>,
        ICollectionsAllowlistable<AllCollectionsStats>,
        ISortable<AllCollectionsStats, AllCollectionsStatsSortType>,
        IExecutable<AllCollectionsStatsResponse>
    {
        internal AllCollectionsStats(string endpoint, string symbol, string search)
        {
            _endpoint = $"{endpoint}/collections";
            AddQuery("symbol", symbol);
            AddQuery("search", search);
        }
    }
}
