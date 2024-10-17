using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Schemas.CollectionSchema;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Schemas
{
    public class CollectionSchema
        :
        BaseEndpointGroup,
        IExecutable<CollectionSchemaResponse>
    {
        internal CollectionSchema(string endpoint, string collection, string schema)
        {
            _endpoint = $"{endpoint}/{collection}/{schema}";
        }
    }
}
