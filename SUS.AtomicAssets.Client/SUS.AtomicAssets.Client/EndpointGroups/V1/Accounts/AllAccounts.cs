using SUS.AtomicAssets.Client.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Accounts;
namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts
{
    public class AllAccounts
        :
        BaseEndpointGroup,
        IOwnerMatchable<AllAccounts>,
        ICollectionFilterable<AllAccounts>,
        ISchemaFilterable<AllAccounts>,
        ITemplateFilterable<AllAccounts>,
        IBurnedAssetsFilterable<AllAccounts>,
        IAssetOfferFilterable<AllAccounts>,
        ICollectionBlocklistable<AllAccounts>,
        ICollectionAllowlistable<AllAccounts>,
        IOwnerFilterable<AllAccounts>,
        IIdFilterable<AllAccounts>,
        ILowerBoundable<AllAccounts>,
        IUpperBoundable<AllAccounts>,
        IPageable<AllAccounts>,
        ILimitable<AllAccounts>,
        IOrderable<AllAccounts>,
        IExecutable<AccountsResponse>
    {
        internal AllAccounts(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}