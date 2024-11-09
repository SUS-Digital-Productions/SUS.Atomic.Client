using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Prices.AllAssetPrices;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Prices
{
    public class AllAssetPrices
        :
        BaseEndpoint,
        ICollectionFilterable<AllAssetPrices>,
        ISchemaFilterable<AllAssetPrices>,
        ITemplateFilterable<AllAssetPrices>,
        IBurnedAssetsFilterable<AllAssetPrices>,
        IOwnerFillterable<AllAssetPrices>,
        IMatchable<AllAssetPrices>,
        ISearchable<AllAssetPrices>,
        IImmutableNameMatchable<AllAssetPrices>,
        IMutableNameMatchable<AllAssetPrices>,
        IIsTransferable<AllAssetPrices>,
        IIsBurnable<AllAssetPrices>,
        IMinterFilterable<AllAssetPrices>,
        IBurnerFilterable<AllAssetPrices>,
        IInitialReceiverFilterable<AllAssetPrices>,
        ICollectionsBlocklistable<AllAssetPrices>,
        ICollectionsAllowlistable<AllAssetPrices>,
        IAssetFilterable<AllAssetPrices>,
        IIdsFilterable<AllAssetPrices>,
        ILowerBoundable<AllAssetPrices>,
        IUpperBoundable<AllAssetPrices>,
        IExecutable<AllAssetPricesResponse>
    {
        internal AllAssetPrices(string endpoint)
        {
            _endpoint = $"{endpoint}/assets";
        }
    }
}
