using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Assets.SingleAsset;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Assets
{
    public class SingleAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup,
        IExecutable<SingleAssetResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal SingleAsset(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}