using SUS.Atomic.Base;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Templates
{
    public class Templates<TemplateImmutableData>
        :
        BaseEndpointGroup
    {
        internal Templates(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/templates";
        }

        public AllTemplates<TemplateImmutableData> Get()
        {
            return new AllTemplates<TemplateImmutableData>(_endpoint);
        }

        public SingleTemplate<TemplateImmutableData> Get(string collectionName, long templateId)
        {
            return new SingleTemplate<TemplateImmutableData>(_endpoint, collectionName, templateId);
        }

        public SingleTemplateLogs GetLogs(string collectionName, long templateId)
        {
            return new SingleTemplateLogs(_endpoint, collectionName, templateId);
        }

        public SingleTemplateStats GetStats(string collectionName, long templateId)
        {
            return new SingleTemplateStats(_endpoint, collectionName, templateId);
        }
    }
}
