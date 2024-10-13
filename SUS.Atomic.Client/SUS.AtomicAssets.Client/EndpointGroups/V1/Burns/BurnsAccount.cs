using SUS.AtomicAssets.Client.Interfaces;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Burns
{
    public class BurnsAccount
        :
        BaseEndpointGroup,
        IAssetOfferFilterable<BurnsAccount>,
        ICollectionBlocklistable<BurnsAccount>,
        ICollectionAllowlistable<BurnsAccount>,
        IExecutable<BurnsAccount>
    {
        internal BurnsAccount(string endpoint, string account)
        {
            _endpoint = $"{endpoint}/{account}";
        }
    }
}
