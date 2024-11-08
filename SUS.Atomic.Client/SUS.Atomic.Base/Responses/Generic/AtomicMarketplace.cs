using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicMarketplace
    {
        [JsonProperty("marketplace_name")]
        public string MarketplaceName { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("created_at_block")]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time")]
        public string CreatedAtTime { get; set; }
    }
}
