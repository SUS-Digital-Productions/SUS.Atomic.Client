using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Schemas.AllSchemas
{
    public class AllSchemasResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<Data> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data : AtomicSchema
    {
        [JsonProperty("assets")]
        public string Assets { get; set; }
    }
}
