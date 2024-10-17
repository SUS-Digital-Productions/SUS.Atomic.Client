using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Schemas.AllSchemas;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Schemas
{
    public class AllSchemas
        :
        BaseEndpointGroup,
        ICollectionFilterable<AllSchemas>,
        IAuthorizedAccountsFilterable<AllSchemas>,
        ISchemaFilterable<AllSchemas>,
        IMatchable<AllSchemas>,
        ICollectionBlocklistable<AllSchemas>,
        ICollectionAllowlistable<AllSchemas>,
        IIdFilterable<AllSchemas>,
        ILowerBoundable<AllSchemas>,
        IUpperBoundable<AllSchemas>,
        IBeforeFilterable<AllSchemas>,
        IAfterFilterable<AllSchemas>,
        IPageable<AllSchemas>,
        ILimitable<AllSchemas>,
        IOrderable<AllSchemas>,
        ISortable<AllSchemas>,
        IExecutable<AllSchemasResponse>
    {
        internal AllSchemas(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
