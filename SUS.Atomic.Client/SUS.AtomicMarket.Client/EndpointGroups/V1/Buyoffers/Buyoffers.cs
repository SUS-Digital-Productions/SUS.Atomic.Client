using SUS.Atomic.Base;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Buyoffers
{
    public class Buyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup
    {
        internal Buyoffers(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/buyoffers";
        }

        public AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get()
        {
            return new AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
        }

        public SingleBuyoffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get(long offerId)
        {
            return new SingleBuyoffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint, offerId);
        }

        public SingleBuyofferLogs GetLogs(long offerId)
        {
            return new SingleBuyofferLogs(_endpoint, offerId);
        }
    }
}
