using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Templates.SingleTemplateLogs;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Templates
{
    public class SingleTemplateLogs
        :
        BaseEndpoint,
        IPageable<SingleTemplateLogs>,
        ILimitable<SingleTemplateLogs>,
        IOrderable<SingleTemplateLogs>,
        IActionAllowlistable<SingleTemplateLogs>,
        IActionBlocklistable<SingleTemplateLogs>,
        IExecutable<SingleTemplateLogsResponse>
    {
        internal SingleTemplateLogs(string endpoint, string collectionName, long templateId)
        {
            _endpoint = $"{endpoint}/{collectionName}/{templateId}/logs";
        }
    }
}
