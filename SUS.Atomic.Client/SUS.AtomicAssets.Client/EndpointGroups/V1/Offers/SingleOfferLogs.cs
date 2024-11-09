using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Offers.SingleOfferLogs;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Offers
{
    public class SingleOfferLogs
        :
        BaseEndpoint,
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
