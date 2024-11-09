using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Stats.SingleCollectionStatsResponse;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Stats
{
    public class SingleCollectionStats
        :
        BaseEndpoint,
        IExecutable<SingleCollectionStatsResponse>
    {
        internal SingleCollectionStats(string endpoint, string collection, string symbol)
        {
            _endpoint = $"{endpoint}/collections/{collection}";
            AddQuery("symbol", symbol);
        }
    }
}
