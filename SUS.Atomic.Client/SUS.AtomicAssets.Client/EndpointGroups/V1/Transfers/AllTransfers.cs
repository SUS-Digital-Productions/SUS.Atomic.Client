using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Transfers.AllTransfers;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Transfers
{
    public class AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpoint,
        IAccountFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISendersFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IRecipientsFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMemoFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMemoMatchable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAssetsFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITemplatesFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISchemasFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IHideContracts<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITransfersFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIdsFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILowerBoundable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IUpperBoundable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBeforeFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IAfterFilterable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsBlocklistable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsAllowlistable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IPageable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILimitable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOrderable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISortable<AllTransfers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, AllTransfersSortType>,
        IExecutable<AllTransfersResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal AllTransfers(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
