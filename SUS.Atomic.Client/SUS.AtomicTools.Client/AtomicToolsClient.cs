using SUS.AtomicTools.Client.EndpointGroups.V1.Config;
using SUS.AtomicTools.Client.EndpointGroups.V1.Links;

namespace SUS.AtomicTools.Client
{
    public class AtomicToolsClient<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        private string _endpoint;

        public Links<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Links { get; }

        public Config Config { get; }

        public AtomicToolsClient(string endpoint)
        {
            _endpoint = $"{endpoint}/atomictools";
            Links = new Links<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Config = new Config(_endpoint);
        }
    }
}
