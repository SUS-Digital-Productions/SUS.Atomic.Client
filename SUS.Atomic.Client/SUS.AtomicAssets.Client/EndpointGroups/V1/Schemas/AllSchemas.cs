using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Schemas.AllSchemas;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Schemas
{
    public class AllSchemas
        :
        BaseEndpoint,
        ICollectionFilterable<AllSchemas>,
        IAuthorizedAccountFilterable<AllSchemas>,
        ISchemaFilterable<AllSchemas>,
        IMatchable<AllSchemas>,
        ICollectionsBlocklistable<AllSchemas>,
        ICollectionsAllowlistable<AllSchemas>,
        IIdsFilterable<AllSchemas>,
        ILowerBoundable<AllSchemas>,
        IUpperBoundable<AllSchemas>,
        IBeforeFilterable<AllSchemas>,
        IAfterFilterable<AllSchemas>,
        IPageable<AllSchemas>,
        ILimitable<AllSchemas>,
        IOrderable<AllSchemas>,
        ISortable<AllSchemas, AllSchemasSortType>,
        IExecutable<AllSchemasResponse>
    {
        internal AllSchemas(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
