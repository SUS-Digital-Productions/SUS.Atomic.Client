using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Offers.SingleOfferLogs;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Offers
{
    public class SingleOfferLogs :
        BaseEndpointGroup,
        IPageable<SingleOfferLogs>,
        ILimitable<SingleOfferLogs>,
        IOrderable<SingleOfferLogs>,
        IActionAllowlistable<SingleOfferLogs>,
        IActionBlocklistable<SingleOfferLogs>,
        IExecutable<SingleOfferLogsResponse>
    {
        internal SingleOfferLogs(string endpoint, long offerId)
        {
            _endpoint = $"{endpoint}/{offerId}/logs";
        }
    }
}
