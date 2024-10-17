using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Schemas.CollectionSchema
{
    public class CollectionSchemaResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data : AtomicSchema
    {
        [JsonProperty("assets")]
        public string Assets { get; set; }
    }

}
