using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.TemplateBuyoffers.SingleTemplateBuyofferLogs;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.TemplateBuyoffers
{
    public class SingleTemplateBuyofferLogs
        :
        BaseEndpointGroup,
        IPageable<SingleTemplateBuyofferLogs>,
        ILimitable<SingleTemplateBuyofferLogs>,
        IActionAllowlistable<SingleTemplateBuyofferLogs>,
        IActionBlocklistable<SingleTemplateBuyofferLogs>,
        IOrderable<SingleTemplateBuyofferLogs>,
        IExecutable<SingleTemplateBuyofferLogsResponse>
    {
        internal SingleTemplateBuyofferLogs(string endpoint, long buyofferId)
        {
            _endpoint = $"{endpoint}/{buyofferId}/logs";
        }
    }
}
