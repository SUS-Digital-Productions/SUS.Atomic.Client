using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Assets.SingleAssetSales;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Assets
{
    public class SingleAssetSales
        :
        BaseEndpoint,
        IBuyerFilterable<SingleAssetSales>,
        ISellerFilterable<SingleAssetSales>,
        ITokenSymbolFilterable<SingleAssetSales>,
        IOrderable<SingleAssetSales>,
        IExecutable<SingleAssetSalesResponse>
    {
        internal SingleAssetSales(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
