using SUS.Atomic.Base;

namespace SUS.AtomicMarket.Client.EndpointGroups.V2.Sales
{
    public class SalesV2<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup
    {
        internal SalesV2(string endpoint)
        {
            _endpoint = $"{endpoint}/v2/sales";
        }

        public AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get()
        {
            return new AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
        }
    }
}
