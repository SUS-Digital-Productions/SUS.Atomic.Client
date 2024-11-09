using Newtonsoft.Json;

namespace SUS.AtomicMarket.Client.Responses.V1.Prices.SingleAccountInventoryPrices
{
    public class SingleAccountInventoryPricesResponse
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
        [JsonProperty("collections")]
        public string Collections { get; set; }
    }
}
