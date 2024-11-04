using SUS.AtomicMarket.Client.EndpointGroups.V1.Assets;
using SUS.AtomicMarket.Client.EndpointGroups.V1.Transfers;

namespace SUS.AtomicMarket.Client
{
    public class AtomicMarketClient<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        private readonly string _endpoint;

        public Assets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Assets { get; }

        public Transfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Transfers { get; }

        public AtomicMarketClient(string endpoint)
        {
            _endpoint = $"{endpoint}/atomicmarket";
            Transfers = new Transfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
            Assets = new Assets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
        }
    }
}
