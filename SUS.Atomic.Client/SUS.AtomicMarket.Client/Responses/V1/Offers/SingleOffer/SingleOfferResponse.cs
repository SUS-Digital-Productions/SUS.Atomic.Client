using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Offers.SingleOffer
{
    public class SingleOfferResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ExtendedAtomicOffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }
}
