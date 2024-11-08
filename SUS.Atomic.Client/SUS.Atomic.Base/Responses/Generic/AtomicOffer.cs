using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicOffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("offer_id")]
        public string OfferId { get; set; }

        [JsonProperty("sender_name")]
        public string SenderName { get; set; }

        [JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("is_sender_contract")]
        public bool IsSenderContract { get; set; }

        [JsonProperty("is_recipient_contract")]
        public bool IsRecipientContract { get; set; }

        [JsonProperty("sender_assets")]
        public List<AtomicAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>> SenderAssets { get; set; }

        [JsonProperty("recipient_assets")]
        public List<AtomicAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>> RecipientAssets { get; set; }

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
