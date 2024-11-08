namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Config
{
    public class Configs
    {
        private readonly string _endpoint;
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
