using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Templates.SingleTemplate;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Templates
{
    public class SingleTemplate<TemplateImmutableData>
        :
        BaseEndpoint,
        IExecutable<SingleTemplateResponse<TemplateImmutableData>>
    {
        internal SingleTemplate(string endpoint, string collectionName, long templateId)
        {
            _endpoint = $"{endpoint}/{collectionName}/{templateId}";
        }
    }
}
