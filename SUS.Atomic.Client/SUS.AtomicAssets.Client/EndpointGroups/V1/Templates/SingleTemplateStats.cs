using SUS.Atomic.Base;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Templates
{
    public class SingleTemplateStats
        :
        BaseEndpointGroup
    {
        internal SingleTemplateStats(string endpoint, long templateId)
        {
            _endpoint = $"{endpoint}/{templateId}";
        }
    }
}
