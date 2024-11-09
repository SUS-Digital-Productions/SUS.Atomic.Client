using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Buyoffers.AllBuyoffers;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Buyoffers
{
    public class AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpoint,
        IStateFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllBuyoffersStateType>,
        IMaxAssetsFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinAssetsFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IShowSellerContracts<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IContractAllowlistable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISellersBlocklistable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBuyersBlocklistable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAssetFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMarketplacesFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMakerMarketplacesFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITakerMarketplacesFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITokenSymbolFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAccountFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISellersFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBuyersFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinPriceFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMaxPriceFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinTemplateMintFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMaxTemplateMintFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISchemaFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITemplateFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBurnedAssetsFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOwnerFillterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMatchable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISearchable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IImmutableNameMatchable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMutableNameMatchable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsTransferable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsBurnable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinterFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBurnerFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IInitialReceiverFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsBlocklistable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsAllowlistable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBuyofferFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIdsFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILowerBoundable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IUpperBoundable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBeforeFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAfterFilterable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IPageable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILimitable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOrderable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISortable<AllBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllBuyoffersSortType>,
        IExecutable<AllBuyofferResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal AllBuyoffers(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
