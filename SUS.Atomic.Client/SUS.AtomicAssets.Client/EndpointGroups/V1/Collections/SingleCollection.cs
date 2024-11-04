using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Collections.SingleCollection;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Collections
{
    public class SingleCollection<CollectionData>
        :
        BaseEndpointGroup,
        IExecutable<SingleCollectionResponse<CollectionData>>
    {
        internal SingleCollection(string endpoint, string collectionName)
        {
            _endpoint = $"{endpoint}/{collectionName}";
        }
    }
}
