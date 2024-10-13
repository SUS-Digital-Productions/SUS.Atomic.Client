using SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts;

namespace SUS.AtomicAssets.Client
{
    public class AtomicAssetsClient
    {
        private string _endpoint;
        public Accounts Accounts { get; }
        public AtomicAssetsClient(string endpoint)
        {
            _endpoint = endpoint + "/atomicassets";
            Accounts = new Accounts(_endpoint);
        }
    }
}
