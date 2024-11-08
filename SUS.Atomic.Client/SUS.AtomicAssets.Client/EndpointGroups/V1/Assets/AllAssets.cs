using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Assets.AllAssets;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Assets
{
    public class AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
          :
        BaseEndpointGroup,
        ICollectionFilterable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISchemaFilterable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITemplateFilterable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOwnersFilterable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMatchable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISearchable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IImmutableNameMatchable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMutableNameMatchable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsTransferable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsBurnable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOnlyDuplicateTemplatesFilterable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IHasBackedTokens<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IHasTemplateBuyoffer<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAuthorizedAccountFilterable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITemplatesAllowlistable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITemplatesBlocklistable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IHideTemplatesByAccounts<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAssetOfferFilterable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsAllowlistable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsBlocklistable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAssetsFilterable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIdsFilterable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILowerBoundable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IUpperBoundable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBeforeFilterable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAfterFilterable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IPageable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILimitable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOrderable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISortable<AllAssets<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllAssetsSortType>,
        IExecutable<AllAssetsResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal AllAssets(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
