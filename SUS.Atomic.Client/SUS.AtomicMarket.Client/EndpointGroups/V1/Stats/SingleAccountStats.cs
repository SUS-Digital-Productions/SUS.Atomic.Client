using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Stats.SingleAccountStats;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Stats
{
    public class SingleAccountStats
        :
        BaseEndpoint,
        ICollectionsBlocklistable<SingleAccountStats>,
        ICollectionsAllowlistable<SingleAccountStats>,
        IExecutable<SingleAccountStatsResponse>
    {
        internal SingleAccountStats(string endpoint, string account, string symbol)
        {
            _endpoint = $"{endpoint}/accounts/{account}";
            AddQuery("symbol", symbol);
        }
    }
}
