using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Accounts.SingleAccountCollection;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts
{
    public class SingleAccountCollection
        :
        BaseEndpointGroup,
        IExecutable<SingleAccountCollectionResponse>
    {
        internal SingleAccountCollection(string endpoint, string account, string collection)
        {
            _endpoint = $"{endpoint}/{account}/{collection}";
        }
    }
}
