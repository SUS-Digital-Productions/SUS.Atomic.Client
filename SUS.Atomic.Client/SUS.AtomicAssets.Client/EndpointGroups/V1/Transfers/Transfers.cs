using SUS.Atomic.Base;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Transfers
{
    public class Transfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup
    {
        internal Transfers(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/transfers";
        }

        public AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get()
        {
            return new AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
        }
    }
}
