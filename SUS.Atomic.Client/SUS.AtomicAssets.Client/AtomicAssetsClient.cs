using SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts;
using SUS.AtomicAssets.Client.EndpointGroups.V1.Assets;
using SUS.AtomicAssets.Client.EndpointGroups.V1.Burns;
using SUS.AtomicAssets.Client.EndpointGroups.V1.Collections;
using SUS.AtomicAssets.Client.EndpointGroups.V1.Config;
using SUS.AtomicAssets.Client.EndpointGroups.V1.Offers;
using SUS.AtomicAssets.Client.EndpointGroups.V1.Schemas;
using SUS.AtomicAssets.Client.EndpointGroups.V1.Templates;
using SUS.AtomicAssets.Client.EndpointGroups.V1.Transfers;

namespace SUS.AtomicAssets.Client
{
    public class AtomicAssetsClient<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData, CollectionData>
    {
        private readonly string _endpoint;
        public Accounts Accounts { get; }
        public Schemas Schemas { get; }
        public Burns Burns { get; }
        public Offers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Offers { get; }
        public Templates<TemplateImmutableData> Templates { get; }
        public Assets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Assets { get; }
        public Collections<CollectionData> Collections { get; }
        public Transfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Transfers { get; }

        public Config Config { get; }

        public AtomicAssetsClient(string endpoint)
        {
            _endpoint = $"{endpoint}/atomicassets";
            Accounts = new Accounts(_endpoint);
            Schemas = new Schemas(_endpoint);
            Burns = new Burns(_endpoint);
            Assets = new Assets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Collections = new Collections<CollectionData>(_endpoint);
            Templates = new Templates<TemplateImmutableData>(_endpoint);
            Transfers = new Transfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Offers = new Offers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Config = new Config(_endpoint);
        }
    }
}
