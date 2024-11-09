using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Buyoffers.SingleBuyofferLogs;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Buyoffers
{
    public class SingleBuyofferLogs
        :
        BaseEndpointGroup,
        IPageable<SingleBuyofferLogs>,
        ILimitable<SingleBuyofferLogs>,
        IOrderable<SingleBuyofferLogs>,
        IActionAllowlistable<SingleBuyofferLogs>,
        IActionBlocklistable<SingleBuyofferLogs>,
        IExecutable<SingleBuyofferLogsResponse>
    {
        internal SingleBuyofferLogs(string endpoint, long buyofferId)
        {
            _endpoint = $"{endpoint}/{buyofferId}/logs";
        }
    }
}
