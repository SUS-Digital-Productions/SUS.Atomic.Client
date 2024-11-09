using SUS.Atomic.Base;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Config
{
    public class Configs
        :
        BaseEndpointGroup
    {
        internal Configs(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/config";
        }

        public Config Get()
        {
            return new Config(_endpoint);
        }
    }
}
