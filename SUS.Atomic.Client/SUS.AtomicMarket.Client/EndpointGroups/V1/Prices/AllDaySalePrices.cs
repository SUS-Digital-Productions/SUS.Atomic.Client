using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Prices.AllDaySalePrices;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Prices
{
    public class AllDaySalePrices
        :
        BaseEndpoint,
        ICollectionFilterable<AllDaySalePrices>,
        ISchemaFilterable<AllDaySalePrices>,
        ITemplateFilterable<AllDaySalePrices>,
        IBurnedAssetsFilterable<AllDaySalePrices>,
        ITokenSymbolFilterable<AllDaySalePrices>,
        IExecutable<AllDaySalePricesResponse>
    {
        internal AllDaySalePrices(string endpoint)
        {
            _endpoint = $"{endpoint}/sales/days";
        }
    }
}
