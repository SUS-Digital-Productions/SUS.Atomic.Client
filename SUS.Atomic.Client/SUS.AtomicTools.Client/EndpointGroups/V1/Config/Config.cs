using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicTools.Client.Responses.V1.Config.AllConfigs;

namespace SUS.AtomicTools.Client.EndpointGroups.V1.Config
{
    public class Config
        :
        BaseEndpointGroup,
        IExecutable<ConfigResponse>
    {
        internal Config(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
