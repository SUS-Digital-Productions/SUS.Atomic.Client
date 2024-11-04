using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicAuction
    {
        [JsonProperty("market_contract")]
        public string MarketContract { get; set; }

        [JsonProperty("auction_id")]
        public string AuctionId { get; set; }
    }
}
