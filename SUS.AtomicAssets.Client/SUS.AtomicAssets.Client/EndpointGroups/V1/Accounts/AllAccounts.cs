using SUS.AtomicAssets.Client.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Accounts;
namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts
{
    public class AllAccounts
        :
        BaseEndpointGroup,
        IOrderable<AllAccounts>,
        ILimitable<AllAccounts>,
        IPageable<AllAccounts>,
        ICollectionable<AllAccounts>,
        ISchemable<AllAccounts>,
        IExecutable<AccountsResponse>
    {
        internal AllAccounts(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}