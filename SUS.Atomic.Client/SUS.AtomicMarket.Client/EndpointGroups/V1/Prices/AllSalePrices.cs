using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Prices.AllSalePrices;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Prices
{
    public class AllSalePrices
        :
        BaseEndpoint,
        ICollectionFilterable<AllSalePrices>,
        ISchemaFilterable<AllSalePrices>,
        ITemplateFilterable<AllSalePrices>,
        IBurnedAssetsFilterable<AllSalePrices>,
        ITokenSymbolFilterable<AllSalePrices>,
        IExecutable<AllSalePricesResponse>
    {
        internal AllSalePrices(string endpoint)
        {
            _endpoint = $"{endpoint}/sales";
        }
    }
}
