using SUS.AtomicAssets.Client.Interfaces;
namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts
{
    public class SingleAccount : BaseEndpointGroup, IOrderable<SingleAccount>
    {
        internal SingleAccount(string endpoint, string account)
        {
            _endpoint = $"{endpoint}/{account}";
        }
    }
}