using SUS.Atomic.Base;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Templates
{
    public class SingleTemplateLogs
        :
        BaseEndpointGroup
    {
        internal SingleTemplateLogs(string endpoint, string templateId)
        {
            _endpoint = $"{endpoint}/{templateId}/logs";
        }
    }
}
