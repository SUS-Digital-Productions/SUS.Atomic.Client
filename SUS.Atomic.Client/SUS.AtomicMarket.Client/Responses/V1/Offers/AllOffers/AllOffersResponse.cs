using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Offers.AllOffers
{
    public class AllOffersResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<ExtendedAtomicOffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }
}
