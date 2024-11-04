using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Collections.SingleCollectionLogs;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Collections
{
    public class SingleCollectionLogs
        :
        BaseEndpointGroup,
        IPageable<SingleCollectionLogs>,
        ILimitable<SingleCollectionLogs>,
        IOrderable<SingleCollectionLogs>,
        IActionAllowlistable<SingleCollectionLogs>,
        IActionBlocklistable<SingleCollectionLogs>,
        IExecutable<SingleCollectionLogsResponse>
    {
        internal SingleCollectionLogs(string endpoint, string collectionName)
        {
            _endpoint = $"{endpoint}/{collectionName}/logs";
        }
    }
}
