using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Assets.SingleAssetLogs;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Assets
{
    public class SingleAssetLogs
        :
        BaseEndpoint,
        IPageable<SingleAssetLogs>,
        ILimitable<SingleAssetLogs>,
        IOrderable<SingleAssetLogs>,
        IActionAllowlistable<SingleAssetLogs>,
        IActionBlocklistable<SingleAssetLogs>,
        IExecutable<SingleAssetLogsResponse>
    {
        internal SingleAssetLogs(string endpoint, long assetId)
        {
            _endpoint = $"{endpoint}/{assetId}/logs";
        }
    }
}
