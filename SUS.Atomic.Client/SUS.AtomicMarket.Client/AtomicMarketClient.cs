using SUS.AtomicMarket.Client.EndpointGroups.V1.Assets;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Auctions;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Buyoffers;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Config;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Offers;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Prices;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Sales;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Stats;
using SUS.AtomicMarket.Client.EndpointGroups.V1.TemplateBuyoffers;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Transfers;
using SUS.AtomicMarket.Client.EndpointGroups.V2.Sales;
using SUS.AtomicMarket.Client.EndpointGroups.V2.Stats;

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

        public Buyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Buyoffers { get; }

        public TemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> TemplateBuyoffers { get; }

        public Sales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Sales { get; }

        public SalesV2<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> SalesV2 { get; }

        public Stats<TemplateImmutableData> Stats { get; }

        public StatsV2 StatsV2 { get; }

        public Prices Prices { get; }

        public AtomicMarketClient(string endpoint)
        {
            _endpoint = $"{endpoint}/atomicmarket";
            Transfers = new Transfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Assets = new Assets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            SalesV2 = new SalesV2<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Sales = new Sales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Config = new Config(_endpoint);
            Offers = new Offers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            TemplateBuyoffers = new TemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Auctions = new Auctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Buyoffers = new Buyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Stats = new Stats<TemplateImmutableData>(_endpoint);
            StatsV2 = new StatsV2(_endpoint);
            Prices = new Prices(_endpoint);
        }
    }
}
