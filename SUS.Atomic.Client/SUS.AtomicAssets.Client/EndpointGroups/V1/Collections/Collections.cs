namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Collections
{
    public class Collections<CollectionData>
    {
        private readonly string _endpoint;
        internal Collections(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/collections";
        }

        public AllCollections<CollectionData> Get()
        {
            return new AllCollections<CollectionData>(_endpoint);
        }

        public SingleCollection<CollectionData> GetSingle(string collectionName)
        {
            return new SingleCollection<CollectionData>(_endpoint, collectionName);
        }

        public SingleCollectionLogs GetLogs(string collectionName)
        {
            return new SingleCollectionLogs(_endpoint, collectionName);
        }

        public SingleCollectionStats GetStats(string collectionName)
        {
            return new SingleCollectionStats(_endpoint, collectionName);
        }
    }
}
