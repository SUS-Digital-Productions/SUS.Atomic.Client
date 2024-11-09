using SUS.Atomic.Base;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Assets
{
    public class Assets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup
    {
        internal Assets(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/assets";
        }

        public AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get()
        {
            return new AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
        }

        public SingleAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get(long assetId)
        {
            return new SingleAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint, assetId);
        }

        public SingleAssetStats GetStats(long assetId)
        {
            return new SingleAssetStats(_endpoint, assetId);
        }

        public SingleAssetLogs GetLogs(long assetId)
        {
            return new SingleAssetLogs(_endpoint, assetId);
        }

    }
}
