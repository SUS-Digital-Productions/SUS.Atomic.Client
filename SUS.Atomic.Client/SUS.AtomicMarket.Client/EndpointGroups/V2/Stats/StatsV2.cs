using SUS.Atomic.Base;

namespace SUS.AtomicMarket.Client.EndpointGroups.V2.Stats
{
    public class StatsV2
        :
        BaseEndpointGroup
    {
        internal StatsV2(string endpoint)
        {
            _endpoint = $"{endpoint}/v2/stats";
        }

        public StatsSchemaCollection GetSchemaCollectionStats(string collection, string symbol)
        {
            return new StatsSchemaCollection(_endpoint, collection, symbol);
        }
    }
}
