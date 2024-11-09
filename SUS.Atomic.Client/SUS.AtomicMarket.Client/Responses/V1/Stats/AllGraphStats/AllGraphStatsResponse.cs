using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Stats.AllGraphStats
{
    public class AllGraphStatsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public AtomicGraph Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }
}
