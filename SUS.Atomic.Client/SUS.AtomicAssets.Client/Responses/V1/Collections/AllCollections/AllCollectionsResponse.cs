using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Collections.AllCollections
{
    public class AllCollectionsResponse<CollectionData>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<GenericSingleCollection<CollectionData>> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

}
