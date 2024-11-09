using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Burns.AllBurns;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Burns
{
    public class AllBurns
        :
        BaseEndpoint,
        IOwnerMatchable<AllBurns>,
        ICollectionFilterable<AllBurns>,
        ISchemaFilterable<AllBurns>,
        ITemplateFilterable<AllBurns>,
        IBurnedAssetsFilterable<AllBurns>,
        ICollectionsBlocklistable<AllBurns>,
        ICollectionsAllowlistable<AllBurns>,
        IBurnedByAccountFilterable<AllBurns>,
        IIdsFilterable<AllBurns>,
        ILowerBoundable<AllBurns>,
        IUpperBoundable<AllBurns>,
        IPageable<AllBurns>,
        ILimitable<AllBurns>,
        IOrderable<AllBurns>,
        IExecutable<AllBurnsResponse>
    {
        internal AllBurns(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
