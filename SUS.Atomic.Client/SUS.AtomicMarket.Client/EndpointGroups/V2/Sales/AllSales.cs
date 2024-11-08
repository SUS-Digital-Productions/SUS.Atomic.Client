using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V2.Sales.AllSales;

namespace SUS.AtomicMarket.Client.EndpointGroups.V2.Sales
{
    public class AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup,
        IStateFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllSalesStateType>,
        IHideTemplatesByAccounts<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMaxAssetsFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinAssetsFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IShowSellerContracts<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IContractAllowlistable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISellersBlocklistable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBuyersBlocklistable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAssetsFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMarketplacesFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMakerMarketplacesFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITakerMarketplacesFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITokenSymbolFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAccountFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBuyersFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISellersFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinPriceFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMaxPriceFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinTemplateMintFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMaxTemplateMintFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISchemaFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITemplateFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBurnedAssetsFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOwnerFillterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMatchable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISearchable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IImmutableNameMatchable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMutableNameMatchable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsTransferable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsBurnable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinterFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBurnerFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IInitialReceiverFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsAllowlistable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsBlocklistable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIdsFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILowerBoundable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IUpperBoundable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBeforeFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAfterFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IPageable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILimitable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOrderable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISortable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllSalesSortType>,
        ISalesFilterable<AllSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IExecutable<AllSalesResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal AllSales(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
