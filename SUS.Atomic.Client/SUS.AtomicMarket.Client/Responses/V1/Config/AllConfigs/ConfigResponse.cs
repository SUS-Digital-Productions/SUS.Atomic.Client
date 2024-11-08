using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Config.AllConfigs
{
    public class ConfigResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; } 
    }

    public class Data
    {
        [JsonProperty("atomicassets_contract")]
        public string AtomicAssetsContract { get; set; }

        [JsonProperty("atomicmarket_contract")]
        public string AtomicMarketContract { get; set; }

        [JsonProperty("delphioracle_contract")]
        public string DelphiOracleContract { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("maker_market_fee")]
        public int MakerMarketFee { get; set; }

        [JsonProperty("taker_market_fee")]
        public int TakerMarketFee { get; set; }

        [JsonProperty("minimum_auction_duration")]
        public long MinimumAuctionDuration { get; set; }

        [JsonProperty("maximum_auction_duration")]
        public long MaximumAuctionDuration { get; set; }

        [JsonProperty("minimum_bid_increase")]
        public long MinimumBidIncrease { get; set; }

        [JsonProperty("auction_reset_duration")]
        public long AuctionResetDuration { get; set; }

        [JsonProperty("supported_tokens")]
        public List<AtomicToken> Tokens { get; set; }

        [JsonProperty("supported_pairs")]
        public List<AtomicPair> Pairs { get; set; }
    }
}
