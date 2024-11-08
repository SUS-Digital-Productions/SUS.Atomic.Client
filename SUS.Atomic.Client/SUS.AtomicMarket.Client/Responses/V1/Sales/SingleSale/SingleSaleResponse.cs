using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Sales.SingleSale
{
    public class SingleSaleResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ExtendedAtomicSale<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime;
    }
}
