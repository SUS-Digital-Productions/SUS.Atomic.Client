using SUS.AtomicTools.Client.EndpointGroups.V1.Links;

namespace SUS.AtomicTools.Client
{
    public class AtomicToolsClient
    {
        private string _endpoint;

        public Links Links { get; }

        public AtomicToolsClient(string endpoint)
        {
            _endpoint = $"{endpoint}/atomictools";
            Links = new Links(_endpoint);
        }
    }
}
