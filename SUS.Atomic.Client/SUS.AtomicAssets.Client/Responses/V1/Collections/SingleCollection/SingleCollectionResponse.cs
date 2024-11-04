using Newtonsoft.Json;

namespace SUS.AtomicAssets.Client.Responses.V1.Collections.SingleCollection
{
    public class SingleCollectionResponse<CollectionData>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        public GenericSingleCollection<CollectionData> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
        
    }
}
