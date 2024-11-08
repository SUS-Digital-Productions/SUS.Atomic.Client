using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Auctions.SingleAuction;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Auctions
{
    public class SingleAuction<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup,
        IExecutable<SingleAuctionResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal SingleAuction(string endpoint, long auctionId)
        {
            _endpoint = $"{endpoint}/{auctionId}";
        }
    }
}
