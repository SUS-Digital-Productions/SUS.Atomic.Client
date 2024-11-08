using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Marketplaces.SingleMarketplace
{
    public class SingleMarketplaceResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public AtomicMarketplace Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }
}
