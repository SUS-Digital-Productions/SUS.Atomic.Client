using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Accounts.SingleAccount;
namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts
{
    public class SingleAccount :
        BaseEndpoint,
        IAssetOfferFilterable<SingleAccount>,
        ICollectionsBlocklistable<SingleAccount>,
        ICollectionsAllowlistable<SingleAccount>,
        IExecutable<SingleAccountResponse>
    {
        internal SingleAccount(string endpoint, string account)
        {
            _endpoint = $"{endpoint}/{account}";
        }
    }
}