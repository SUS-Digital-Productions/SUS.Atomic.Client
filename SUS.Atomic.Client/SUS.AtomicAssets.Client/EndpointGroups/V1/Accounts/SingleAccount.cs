using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Accounts.SingleAccount;
namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts
{
    public class SingleAccount :
        BaseEndpointGroup,
        IAssetOfferFilterable<SingleAccount>,
        ICollectionBlocklistable<SingleAccount>,
        ICollectionAllowlistable<SingleAccount>,
        IExecutable<SingleAccountResponse>
    {
        internal SingleAccount(string endpoint, string account)
        {
            _endpoint = $"{endpoint}/{account}";
        }
    }
}