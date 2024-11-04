using Newtonsoft.Json;

namespace SUS.AtomicMarket.Client.Responses.V1.Assets.SingleAssetStats
{
    public class SingleAssetStatsResponse
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
        [JsonProperty("template_mint")]
        public int TemplateMint { get; set; }
    }
}
