using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicTools.Client.Responses.V1.Links.SingleLinkLogs;

namespace SUS.AtomicTools.Client.EndpointGroups.V1.Links
{
    public class SingleLinkLogs
        :
        BaseEndpointGroup,
        IPageable<SingleLinkLogs>,
        ILimitable<SingleLinkLogs>,
        IOrderable<SingleLinkLogs>,
        IActionAllowlistable<SingleLinkLogs>,
        IActionBlocklistable<SingleLinkLogs>,
        IExecutable<SingleLinkLogsResponse>
    {
        internal SingleLinkLogs(string endpoint, long linkId)
        {
            _endpoint = $"{endpoint}/{linkId}/logs";
        }
    }
}
