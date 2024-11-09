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
    }
}
