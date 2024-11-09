using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Offers.AllOffers;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Offers
{
    public class AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpoint,
        IAccountFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISendersFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IRecipientsFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMemoFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMemoMatchable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IStateFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllOffersStateType>,
        IIsRecipientContractFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAssetsFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITemplateFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISchemaFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAccountAllowlistable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAccountBlocklistable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISenderAssetAllowlistable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISenderAssetBlocklistable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IRecipientAssetAllowlistable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IRecipientAssetBlocklistable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IHideContracts<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IHideEmptyOffers<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIdsFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILowerBoundable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IUpperBoundable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBeforeFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAfterFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOffersFilterable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsBlocklistable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsAllowlistable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IPageable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILimitable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOrderable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISortable<AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllOffersSortType>,
        IExecutable<AllOffersResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal AllOffers(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
