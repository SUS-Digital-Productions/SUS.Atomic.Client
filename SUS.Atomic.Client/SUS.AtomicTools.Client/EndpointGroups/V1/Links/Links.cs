namespace SUS.AtomicTools.Client.EndpointGroups.V1.Links
{
    public class Links<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        private readonly string _endpoint;

        internal Links(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/links";
        }

        public AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get()
        {
            return new AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
        }

        public SingleLink<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get(long linkId)
        {
            return new SingleLink<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint, linkId);
        }

        public SingleLinkLogs GetLogs(long linkId)
        {
            return new SingleLinkLogs(_endpoint, linkId);
        }
    }
}
