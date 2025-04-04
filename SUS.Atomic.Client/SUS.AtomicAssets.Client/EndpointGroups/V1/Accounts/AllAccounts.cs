﻿using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Accounts.AllAccounts;
namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts
{
    public class AllAccounts
        :
        BaseEndpoint,
        IOwnerMatchable<AllAccounts>,
        ICollectionFilterable<AllAccounts>,
        ISchemaFilterable<AllAccounts>,
        ITemplateFilterable<AllAccounts>,
        IBurnedAssetsFilterable<AllAccounts>,
        IAssetOfferFilterable<AllAccounts>,
        ICollectionsBlocklistable<AllAccounts>,
        ICollectionsAllowlistable<AllAccounts>,
        IOwnersFilterable<AllAccounts>,
        IIdsFilterable<AllAccounts>,
        ILowerBoundable<AllAccounts>,
        IUpperBoundable<AllAccounts>,
        IPageable<AllAccounts>,
        ILimitable<AllAccounts>,
        IOrderable<AllAccounts>,
        IExecutable<AllAccountsResponse>
    {
        internal AllAccounts(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}