using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Schemas.CollectionSchemaLogs;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Schemas
{
    public class CollectionSchemaLogs
        :
        BaseEndpointGroup,
        IPageable<CollectionSchemaLogs>,
        ILimitable<CollectionSchemaLogs>,
        IOrderable<CollectionSchemaLogs>,
        IActionAllowlistable<CollectionSchemaLogs>,
        IActionBlocklistable<CollectionSchemaLogs>,
        IExecutable<CollectionSchemaLogsResponse>
    {
        internal CollectionSchemaLogs(string endpoint, string collection, string schema)
        {
            _endpoint = $"{endpoint}/{collection}/{schema}/logs";
        }
    }
}
