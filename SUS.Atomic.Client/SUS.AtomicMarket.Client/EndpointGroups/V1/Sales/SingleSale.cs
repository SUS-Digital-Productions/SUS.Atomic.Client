using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Sales.SingleSale;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Sales
{
    public class SingleSale<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpoint,
        IExecutable<SingleSaleResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal SingleSale(string endpoint, long saleId)
        {
            _endpoint = $"{endpoint}/{saleId}";
        }
    }
}
