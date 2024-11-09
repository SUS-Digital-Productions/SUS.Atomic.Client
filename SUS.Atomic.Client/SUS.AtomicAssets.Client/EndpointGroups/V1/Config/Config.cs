using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Config.AllConfigs;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Config
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
