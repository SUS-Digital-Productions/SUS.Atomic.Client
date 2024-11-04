using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Assets.SingleAssetStats;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Assets
{
    public class SingleAssetStats
        :
        BaseEndpointGroup,
        IExecutable<SingleAssetStatsResponse>
    {
        internal SingleAssetStats(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
