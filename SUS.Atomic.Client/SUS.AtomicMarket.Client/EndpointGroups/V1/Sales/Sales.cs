namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Sales
{
    public class Sales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        private readonly string _endpoint;
        internal Sales(string endpoint)
        {
            _endpoint = endpoint;
        }

        public TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> GetTemplates(string tokenSymbol)
        {
            return new TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint, tokenSymbol);
        }

        public SingleSale<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get(long saleId)
        {
            return new SingleSale<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint, saleId);
        }

        public SingleSaleLogs GetLogs(long saleId)
        {
            return new SingleSaleLogs(_endpoint, saleId);
        }
    }
}
