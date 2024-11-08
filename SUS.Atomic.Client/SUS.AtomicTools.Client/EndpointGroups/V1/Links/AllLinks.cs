using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicTools.Client.Responses.V1.Links.AllLinks;

namespace SUS.AtomicTools.Client.EndpointGroups.V1.Links
{
    public class AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup,
        ICreatorFilterable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IClaimerFilterable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IPublicKeyFilterable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IStateFilterable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllLinksStateType>,
        ICollectionsBlocklistable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsAllowlistable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILinksFilterable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIdsFilterable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILowerBoundable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IUpperBoundable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBeforeFilterable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAfterFilterable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IPageable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILimitable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOrderable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISortable<AllLinks<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllLinksSortType>,
        IExecutable<AllLinksResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal AllLinks(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
