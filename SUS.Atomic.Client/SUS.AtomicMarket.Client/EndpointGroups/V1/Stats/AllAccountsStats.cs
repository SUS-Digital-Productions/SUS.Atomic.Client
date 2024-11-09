using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Stats.AllAccountsStats;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Stats
{
    public class AllAccountsStats
        :
        BaseEndpoint,
        ICollectionFilterable<AllAccountsStats>,
        IBeforeFilterable<AllAccountsStats>,
        IAfterFilterable<AllAccountsStats>,
        ICollectionsBlocklistable<AllAccountsStats>,
        ICollectionsAllowlistable<AllAccountsStats>,
        IPageable<AllAccountsStats>,
        ILimitable<AllAccountsStats>,
        IOrderable<AllAccountsStats>,
        ISortable<AllAccountsStats, AllAccountsStatsSortType>,
        IExecutable<AllAccountsStatsResponse>
    {
        internal AllAccountsStats(string endpoint, string symbol)
        {
            _endpoint = $"{endpoint}/accounts";
            AddQuery("symbol", symbol);
        }
    }
}
