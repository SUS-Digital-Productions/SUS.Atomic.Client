using SUS.AtomicAssets.Client.Interfaces;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts
{
    public class SingleAccountCollection : BaseEndpointGroup, IExecutable<SingleAccountCollection>
    {
        internal SingleAccountCollection(string endpoint, string account, string collection)
        {
            _endpoint = $"{endpoint}/{account}/{collection}";
        }
    }
}
