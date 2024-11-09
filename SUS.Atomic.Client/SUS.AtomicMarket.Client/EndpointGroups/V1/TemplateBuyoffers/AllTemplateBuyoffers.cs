using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.TemplateBuyoffers.AllTemplateBuyoffers;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.TemplateBuyoffers
{
    public class AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> :
        BaseEndpointGroup,
        IStateFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllTemplateBuyoffersStateType>,
        IMaxAssetsFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinAssetsFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IShowSellerContracts<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IContractAllowlistable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISellersBlocklistable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBuyersBlocklistable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAssetFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMarketplacesFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMakerMarketplacesFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITakerMarketplacesFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITokenSymbolFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAccountFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISellersFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBuyersFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinPriceFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMaxPriceFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinTemplateMintFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMaxTemplateMintFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISchemaFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITemplateFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBurnedAssetsFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOwnerFillterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMatchable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISearchable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IImmutableNameMatchable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMutableNameMatchable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsTransferable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsBurnable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinterFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBurnerFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IInitialReceiverFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsBlocklistable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsAllowlistable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBuyofferFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIdsFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILowerBoundable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IUpperBoundable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBeforeFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAfterFilterable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IPageable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILimitable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOrderable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISortable<AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllTemplateBuyoffersSortType>,
        IExecutable<AllTemplateBuyoffersResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal AllTemplateBuyoffers(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
