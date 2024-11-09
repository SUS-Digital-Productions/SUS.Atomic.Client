using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Prices.AllDaySalePrices
{
    public class AllDaySalePricesResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data : AtomicToken
    {
        [JsonProperty("average")]
        public string Average { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("median")]
        public string Median { get; set; }
    }
}
