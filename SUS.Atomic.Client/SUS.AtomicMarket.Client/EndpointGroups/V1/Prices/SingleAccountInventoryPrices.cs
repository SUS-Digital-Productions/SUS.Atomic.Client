using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Prices.SingleAccountInventoryPrices;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Prices
{
    public class SingleAccountInventoryPrices
        :
        BaseEndpoint,
        ICollectionFilterable<SingleAccountInventoryPrices>,
        ISchemaFilterable<SingleAccountInventoryPrices>,
        ITemplateFilterable<SingleAccountInventoryPrices>,
        IBurnedAssetsFilterable<SingleAccountInventoryPrices>,
        IMatchable<SingleAccountInventoryPrices>,
        ISearchable<SingleAccountInventoryPrices>,
        IImmutableNameMatchable<SingleAccountInventoryPrices>,
        IMutableNameMatchable<SingleAccountInventoryPrices>,
        IIsTransferable<SingleAccountInventoryPrices>,
        IIsBurnable<SingleAccountInventoryPrices>,
        ICollectionsBlocklistable<SingleAccountInventoryPrices>,
        ICollectionsAllowlistable<SingleAccountInventoryPrices>,
        IAuthorizedAccountFilterable<SingleAccountInventoryPrices>,
        IAssetOfferFilterable<SingleAccountInventoryPrices>,
        IAssetsFilterable<SingleAccountInventoryPrices>,
        IIdsFilterable<SingleAccountInventoryPrices>,
        ILowerBoundable<SingleAccountInventoryPrices>,
        IUpperBoundable<SingleAccountInventoryPrices>,
        IExecutable<SingleAccountInventoryPricesResponse>
    {
        internal SingleAccountInventoryPrices(string endpoint, string account)
        {
            _endpoint = $"{endpoint}/inventory/{account}";
        }
    }
}
