namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Marketplaces
{
    public class Marketplaces
    {
        private readonly string _endpoint;

        internal Marketplaces(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/marketplaces";
        }

        public AllMarketplaces Get()
        {
            return new AllMarketplaces(_endpoint);
        }

        public SingleMarketplace Get(string name)
        {
            return new SingleMarketplace(_endpoint, name);
        }
    }
}
