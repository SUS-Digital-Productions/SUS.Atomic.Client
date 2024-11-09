using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Prices.AllAssetPrices
{
    public class AllAssetPricesResponse
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
        [JsonProperty("median")]
        public string Median { get; set; }

        [JsonProperty("average")]
        public string Average { get; set; }

        [JsonProperty("suggested_average")]
        public string SuggestedAverage { get; set; }

        [JsonProperty("suggested_median")]
        public string SuggestedMedian { get; set; }

        [JsonProperty("min")]
        public string Min { get; set; }

        [JsonProperty("max")]
        public string Max { get; set; }
    }
}
