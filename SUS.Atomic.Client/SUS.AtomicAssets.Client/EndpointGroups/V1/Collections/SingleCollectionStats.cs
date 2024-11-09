using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Collections.SingleCollectionStats;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Collections
{
    public class SingleCollectionStats
        :
        BaseEndpoint,
        IExecutable<SingleCollectionStatsResponse>
    {
        public SingleCollectionStats(string endpoint, string collectionName) 
        {
            _endpoint = $"{endpoint}/{collectionName}/stats";
        }
    }
}
