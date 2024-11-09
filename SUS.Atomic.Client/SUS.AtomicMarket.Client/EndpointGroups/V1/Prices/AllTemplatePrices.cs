using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Prices.AllTemplatePrices;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Prices
{
    public class AllTemplatePrices
        :
        BaseEndpoint,
        ICollectionFilterable<AllTemplatePrices>,
        ISchemaFilterable<AllTemplatePrices>,
        ITemplateFilterable<AllTemplatePrices>,
        IBurnedAssetsFilterable<AllTemplatePrices>,
        ITokenSymbolFilterable<AllTemplatePrices>,
        IPageable<AllTemplatePrices>,
        ILimitable<AllTemplatePrices>,
        IOrderable<AllTemplatePrices>,
        IExecutable<AllTemplatePricesResponse>
    {
        internal AllTemplatePrices(string endpoint)
        {
            _endpoint = $"{endpoint}/templates";
        }
    }
}
