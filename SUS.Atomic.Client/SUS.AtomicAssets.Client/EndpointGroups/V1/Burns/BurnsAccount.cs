﻿using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Burns.BurnsAccount;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Burns
{
    public class BurnsAccount
        :
        BaseEndpoint,
        IAssetOfferFilterable<BurnsAccount>,
        ICollectionsBlocklistable<BurnsAccount>,
        ICollectionsAllowlistable<BurnsAccount>,
        IExecutable<BurnsAccountResponse>
    {
        internal BurnsAccount(string endpoint, string account)
        {
            _endpoint = $"{endpoint}/{account}";
        }
    }
}
