using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Sales.SingleSaleLogs;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Sales
{
    public class SingleSaleLogs
        :
        BaseEndpointGroup,
        IPageable<SingleSaleLogs>,
        ILimitable<SingleSaleLogs>,
        IOrderable<SingleSaleLogs>,
        IActionAllowlistable<SingleSaleLogs>,
        IActionBlocklistable<SingleSaleLogs>,
        IExecutable<SingleSaleLogsResponse>
    {
        internal SingleSaleLogs(string endpoint, long saleId)
        {
            _endpoint = $"{endpoint}/{saleId}/logs";
        }
    }
}
