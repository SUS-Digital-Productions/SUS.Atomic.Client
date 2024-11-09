using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Assets.SingleAssetLogs;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Assets
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
        internal SingleAssetLogs(string endpoint)
        {
            _endpoint = endpoint;
        }

    }
}
