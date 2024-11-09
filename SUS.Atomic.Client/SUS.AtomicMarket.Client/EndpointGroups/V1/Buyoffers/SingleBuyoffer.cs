using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Buyoffers.SingleBuyoffer;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Buyoffers
{
    public class SingleBuyoffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpoint,
        IExecutable<SingleBuyofferResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal SingleBuyoffer(string endpoint, long buyofferId)
        {
            _endpoint = $"{endpoint}/{buyofferId}";
        }
    }
}
