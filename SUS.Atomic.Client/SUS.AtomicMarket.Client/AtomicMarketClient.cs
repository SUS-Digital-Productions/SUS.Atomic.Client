using SUS.AtomicMarket.Client.EndpointGroups.V1.Assets;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Auctions;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Config;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Offers;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Sales;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Transfers;
using SUS.AtomicMarket.Client.EndpointGroups.V2.Sales;

namespace SUS.AtomicMarket.Client
{
    public class AtomicMarketClient<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        private readonly string _endpoint;

        public Assets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Assets { get; }

        public Auctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Auctions { get; }

        public Config Config { get; }

        public Transfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Transfers { get; }

        public Offers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Offers { get; }

        public Sales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Sales { get; }

        public SalesV2<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> SalesV2 { get; }

        public AtomicMarketClient(string endpoint)
        {
            _endpoint = $"{endpoint}/atomicmarket";
            Transfers = new Transfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Assets = new Assets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            SalesV2 = new SalesV2<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Sales = new Sales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Config = new Config(_endpoint);
            Offers = new Offers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Auctions = new Auctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
        }
    }
}
