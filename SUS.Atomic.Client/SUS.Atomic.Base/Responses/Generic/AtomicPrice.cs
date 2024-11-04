using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicPrice
    {
        [JsonProperty("average")]
        public string Average { get; set; }

        [JsonProperty("market_contract")]
        public string MarketContract { get; set; }

        [JsonProperty("max")]
        public string Max { get; set; }

        [JsonProperty("min")]
        public string Min { get; set; }

        [JsonProperty("sales")]
        public string Sales { get; set; }

        [JsonProperty("suggested_average")]
        public string SuggestedAverage { get; set; }

        [JsonProperty("suggested_median")]
        public string SuggestedMedian { get; set; }

        [JsonProperty("token")]
        public AtomicToken Token { get; set; }
    }
}
