using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Assets.SingleAsset;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Assets
{
    public class SingleAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup,
        IExecutable<SingleAssetResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal SingleAsset(string endpoint, long assetId)
        {
            _endpoint = $"{endpoint}/{assetId}";
        }
    }
}
