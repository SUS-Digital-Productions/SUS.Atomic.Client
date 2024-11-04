using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Assets
{
    public class GenericSingleAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("asset_id")]
        public string AssetId { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_transferable")]
        public bool IsTransferable { get; set; }

        [JsonProperty("is_burnable")]
        public bool IsBurnable { get; set; }

        [JsonProperty("template_mint")]
        public string TemplateMint { get; set; }

        [JsonProperty("collection")]
        public AtomicCollection Collection { get; set; }

        [JsonProperty("schema")]
        public AtomicSchema Schema { get; set; }

        [JsonProperty("template")]
        public AtomicTemplate<TemplateImmutableData> Template { get; set; }

        [JsonProperty("backed_tokens")]
        public List<AtomicBackedToken> BackedTokens { get; set; }

        [JsonProperty("immutable_data")]
        public AssetImmutableData ImmutableData { get; set; }

        [JsonProperty("mutable_data")]
        public AssetMutableData MutableData { get; set; }

        [JsonProperty("data")]
        public CombinedData AssetData { get; set; }

        [JsonProperty("burned_by_account")]
        public string BurnedByAccount { get; set; }

        [JsonProperty("burned_at_block")]
        public string BurnedAtBlock { get; set; }

        [JsonProperty("burned_at_time")]
        public string BurnedAtTime { get; set; }

        [JsonProperty("updated_at_block")]
        public string UpdatedAtBlock { get; set; }

        [JsonProperty("updated_at_time")]
        public string UpdatedAtTime { get; set; }

        [JsonProperty("transferred_at_block")]
        public string TransferredAtBlock { get; set; }

        [JsonProperty("transferred_at_time")]
        public string TransferredAtTime { get; set; }

        [JsonProperty("minted_at_block")]
        public string MintedAtBlock { get; set; }

        [JsonProperty("minted_at_time")]
        public string MintedAtTime { get; set; }
    }
}
