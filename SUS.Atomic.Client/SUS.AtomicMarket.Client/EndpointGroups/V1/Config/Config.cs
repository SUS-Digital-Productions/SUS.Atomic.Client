using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Config.AllConfigs;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Config
{
    public class Config
        :
        BaseEndpoint,
        IExecutable<ConfigResponse>
    {
        internal Config(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
