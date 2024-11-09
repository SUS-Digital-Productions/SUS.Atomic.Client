using SUS.Atomic.Base;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Schemas
{
    public class Schemas
        :
        BaseEndpointGroup
    {

        internal Schemas(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/schemas";
        }

        public AllSchemas Get()
        {
            return new AllSchemas(_endpoint);
        }

        public CollectionSchema Get(string collection, string schema)
        {
            return new CollectionSchema(_endpoint, collection, schema);
        }

        public CollectionSchemaStats GetStats(string collection, string schema)
        {
            return new CollectionSchemaStats(_endpoint, collection, schema);
        }

        public CollectionSchemaLogs GetLogs(string collection, string schema)
        {
            return new CollectionSchemaLogs(_endpoint, collection, schema);
        }
    }
}
