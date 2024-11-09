using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Prices.AllTemplatePrices
{
    public class AllTemplatePricesResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<Data> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data : AtomicToken
    {
        [JsonProperty("collection_name")]
        public string CollectionName { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("average")]
        public string Average { get; set; }

        [JsonProperty("median")]
        public string Median { get; set; }

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
