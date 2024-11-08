using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Offers.SingleOffer;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Offers
{
    public class SingleOffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup,
        IExecutable<SingleOfferResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal SingleOffer(string endpoint, long offerId)
        {
            _endpoint = $"{endpoint}/{offerId}";
        }
    }
}
