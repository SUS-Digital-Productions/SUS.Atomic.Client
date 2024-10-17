using SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts;
using SUS.AtomicAssets.Client.EndpointGroups.V1.Burns;
using SUS.AtomicAssets.Client.EndpointGroups.V1.Schemas;

namespace SUS.AtomicAssets.Client
{
    public class AtomicAssetsClient
    {
        private string _endpoint;
        public Accounts Accounts { get; }
        public Schemas Schemas { get; }
        public Burns Burns { get; }

        public AtomicAssetsClient(string endpoint)
        {
            _endpoint = endpoint + "/atomicassets";
            Accounts = new Accounts(_endpoint);
            Schemas = new Schemas(_endpoint);
            Burns = new Burns(_endpoint);
        }
    }
}
