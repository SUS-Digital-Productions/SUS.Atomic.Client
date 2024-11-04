namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Templates
{
    public class Templates<TemplateImmutableData>
    {
        private readonly string _endpoint;
        internal Templates(string endpoint)
        {
            _endpoint = endpoint;
        }

        public AllTemplates<TemplateImmutableData> Get()
        {
            return new AllTemplates<TemplateImmutableData>(_endpoint);
        }

        public SingleTemplate<TemplateImmutableData> Get(string collectionName, long templateId)
        {
            return new SingleTemplate<TemplateImmutableData>(_endpoint, collectionName, templateId);
        }
    }
}
