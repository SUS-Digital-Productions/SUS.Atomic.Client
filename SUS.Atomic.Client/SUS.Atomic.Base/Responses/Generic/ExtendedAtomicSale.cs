using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class ExtendedAtomicSale<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> : AtomicSale
    {
        [JsonProperty("assets_contract")]
        public string AssetsContract { get; set; }

        [JsonProperty("seller")]
        public string Seller { get; set; }

        [JsonProperty("buyer")]
        public string Buyer { get; set; }

        [JsonProperty("offer_id")]
        public string OfferId { get; set; }

        [JsonProperty("price")]
        public ExtendedAtomicToken Price { get; set; }

        [JsonProperty("listing_price")]
        public int ListingPrice { get; set; }

        [JsonProperty("listing_symbol")]
        public string ListingSymbol { get; set; }

        [JsonProperty("assets")]
        public List<AtomicAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>> Assets { get; set; }

        [JsonProperty("maker_marketplace")]
        public string MakerMarketplace { get; set; }

        [JsonProperty("taker_marketplace")]
        public string TakerMarketplace { get; set; }

        [JsonProperty("collection")]
        public AtomicCollection Collection { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("updated_at_block")]
        public string UpdatedAtBlock { get; set; }

        [JsonProperty("updated_at_time")]
        public string UpdatedAtTime { get; set; }

        [JsonProperty("created_at_time")]
        public string CreatedAtTime { get; set; }

        [JsonProperty("created_at_block")]
        public string CreatedAtBlock { get; set; }
    }

}
