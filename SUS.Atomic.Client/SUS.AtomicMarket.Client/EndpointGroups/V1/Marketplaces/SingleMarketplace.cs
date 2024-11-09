using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Marketplaces.SingleMarketplace;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Marketplaces
{
    public class SingleMarketplace
        :
        BaseEndpoint,
        IExecutable<SingleMarketplaceResponse>
    {
        internal SingleMarketplace(string endpoint, string name)
        {
            _endpoint = $"{endpoint}/{name}";
        }
    }
}
