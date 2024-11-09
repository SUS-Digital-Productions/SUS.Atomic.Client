using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Assets.SingleAssetStats;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Assets
{
    public class SingleAssetStats
        :
        BaseEndpoint,
        IExecutable<SingleAssetStatsResponse>
    {
        internal SingleAssetStats(string endpoint, long assetId)
        {
            _endpoint = $"{endpoint}/{assetId}/stats";
        }
    }
}
