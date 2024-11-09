using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Stats.AllGraphStats;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Stats
{
    public class AllGraphStats
        :
        BaseEndpoint,
        ICollectionsBlocklistable<AllGraphStats>,
        ICollectionsAllowlistable<AllGraphStats>,
        IExecutable<AllGraphStatsResponse>
    {
        internal AllGraphStats(string endpoint, string symbol)
        {
            _endpoint = $"{endpoint}/graph";
            AddQuery("symbol", symbol);
        }
    }
}
