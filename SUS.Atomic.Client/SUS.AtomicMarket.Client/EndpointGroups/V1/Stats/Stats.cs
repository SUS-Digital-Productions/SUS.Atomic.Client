using SUS.Atomic.Base;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Stats
{
    public class Stats<TemplateImmutableData>
        :
        BaseEndpointGroup
    {
        internal Stats(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/stats";
        }

        public AllTemplateStats<TemplateImmutableData> GetTemplateStats(string symbol, string search)
        {
            return new AllTemplateStats<TemplateImmutableData>(_endpoint, symbol, search);
        }

        public AllSalesStats GetSalesStast(string symbol)
        {
            return new AllSalesStats(_endpoint, symbol);
        }

        public AllGraphStats GetGraphStats(string symbol)
        {
            return new AllGraphStats(_endpoint, symbol);
        }

        public AllAccountsStats GetAccountsStats(string symbol)
        {
            return new AllAccountsStats(_endpoint, symbol);
        }

        public SingleAccountStats GetAccountStats(string account, string symbol)
        {
            return new SingleAccountStats(_endpoint, account, symbol);
        }

        public AllCollectionsStats GetCollectionsStats(string symbol, string search)
        {
            return new AllCollectionsStats(_endpoint, symbol, search);
        }

        public SingleCollectionStats GetCollectionStats(string collection, string symbol)
        {
            return new SingleCollectionStats(_endpoint, collection, symbol);
        }

        public CollectionSchemaStats GetCollectionSchemaStats(string collection, string symbol)
        {
            return new CollectionSchemaStats(_endpoint, collection, symbol);
        }
    }
}
