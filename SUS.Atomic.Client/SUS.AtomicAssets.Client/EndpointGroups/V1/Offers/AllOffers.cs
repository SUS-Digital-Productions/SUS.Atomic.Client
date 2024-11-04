using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Offers
{
    public class AllOffers
        :
        BaseEndpointGroup,
        IAccountFilterable<AllOffers>,
        ISendersFilterable<AllOffers>,
        IRecipientsFilterable<AllOffers>,
        IMemoFilterable<AllOffers>,
        IMemoMatchable<AllOffers>,
        IStateFilterable<AllOffers, AllOffersStateType>,
        IIsRecipientContractFilterable<AllOffers>,
        IAssetsFilterable<AllOffers>,
        ITemplateFilterable<AllOffers>,
        ISchemaFilterable<AllOffers>,
        ICollectionFilterable<AllOffers>
    {
        public AllOffers(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
