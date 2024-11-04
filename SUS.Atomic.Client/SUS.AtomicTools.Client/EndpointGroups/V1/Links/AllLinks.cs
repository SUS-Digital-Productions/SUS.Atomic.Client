using SUS.Atomic.Base;

namespace SUS.AtomicTools.Client.EndpointGroups.V1.Links
{
    public class AllLinks
        :
        BaseEndpointGroup
    {
        internal AllLinks(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
