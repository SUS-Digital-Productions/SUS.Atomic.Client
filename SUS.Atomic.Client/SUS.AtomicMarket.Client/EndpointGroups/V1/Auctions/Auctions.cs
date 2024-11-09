using SUS.Atomic.Base;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Auctions
{
    public class Auctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup
    {
        internal Auctions(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/auctions";
        }

        public AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get()
        {
            return new AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
        }

        public SingleAuction<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get(long auctionId)
        {
            return new SingleAuction<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint, auctionId);
        }

        public SingleAuctionLogs GetLogs(long auctionId)
        {
            return new SingleAuctionLogs(_endpoint, auctionId);
        }
    }
}
