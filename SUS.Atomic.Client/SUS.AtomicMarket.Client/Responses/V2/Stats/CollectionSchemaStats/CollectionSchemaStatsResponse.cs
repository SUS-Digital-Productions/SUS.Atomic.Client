using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicMarket.Client.Responses.V2.Stats.StatsSchemaCollection
{
    public class CollectionSchemaStatsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data
    {
        [JsonProperty("symbol")]
        public AtomicToken Symbol { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }

    public class Result
    {
        [JsonProperty("schema")]
        public ExtendedAtomicSchema Schema { get; set; }

        [JsonProperty("schema_name")]
        public string SchemaName { get; set; }

        [JsonProperty("sales")]
        public string Sales { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("assets")]
        public int Assets { get; set; }
    }

}
