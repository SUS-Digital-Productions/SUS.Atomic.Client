using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class ExtendedAtomicAuction<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> : AtomicAuction
    {
        [JsonProperty("assets_contract")]
        public string AssetsContract { get; set; }

        [JsonProperty("sellers")]
        public string Seller { get; set; }

        [JsonProperty("buyer")]
        public string Buyer { get; set; }

        [JsonProperty("price")]
        public ExtendedAtomicToken Price { get; set; }

        [JsonProperty("assets")]
        public List<AtomicAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>> Assets { get; set; }

        [JsonProperty("bids")]
        public List<AtomicBid> Bids { get; set; }

        [JsonProperty("maker_marketplace")]
        public string MakerMarketplace { get; set; }

        [JsonProperty("taker_marketplace")]
        public string TakerMarketplace { get; set; }

        [JsonProperty("collection")]
        public AtomicCollection Collection { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("updated_at_block")]
        public string UpdatedAtBlock { get; set; }

        [JsonProperty("updated_at_time")]
        public string UpdatedAtTime { get; set; }

        [JsonProperty("created_at_block")]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time")]
        public string CreatedAtTime { get; set; }
    }
}
