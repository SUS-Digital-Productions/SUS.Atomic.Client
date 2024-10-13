using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Burns.AllBurns
{
    public class AllBurnsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("data")]
        public List<Data> Data { get; set; }
        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("assets")]
        public string Assets { get; set; }
    }
}
