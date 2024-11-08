using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Auctions.AllAuctions;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Auctions
{
    public class AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup,
        IStateFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllAuctionsStateType>,
        IBidderFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IParticipantFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IHideEmptyAuctions<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMaxAssetsFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinAssetsFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IShowSellerContracts<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IContractAllowlistable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISellersBlocklistable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBuyersBlocklistable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAssetFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMarketplacesFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMakerMarketplacesFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITakerMarketplacesFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITokenSymbolFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAccountFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISellersFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBuyersFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinPriceFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMaxPriceFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinTemplateMintFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMaxTemplateMintFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISchemaFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITemplateFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBurnedAssetsFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOwnerFillterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMatchable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISearchable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IImmutableNameMatchable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMutableNameMatchable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsTransferable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsBurnable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinterFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBurnerFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IInitialReceiverFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsBlocklistable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsAllowlistable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAuctionsFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIdsFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILowerBoundable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IUpperBoundable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBeforeFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAfterFilterable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IPageable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILimitable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOrderable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISortable<AllAuctions<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllAuctionsSortType>,
        IExecutable<AllAuctionsResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal AllAuctions(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
