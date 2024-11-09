using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Schemas.CollectionSchemaStats;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Schemas
{
    public class CollectionSchemaStats
        :
        BaseEndpoint,
        IExecutable<CollectionSchemaStatsResponse>
    {
        internal CollectionSchemaStats(string endpoint, string collection, string schema)
        {
            _endpoint = $"{endpoint}/{collection}/{schema}/stats";
        }
    }
}
