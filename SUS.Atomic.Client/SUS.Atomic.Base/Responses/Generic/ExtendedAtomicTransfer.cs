using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class ExtendedAtomicTransfer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("transfer_id")]
        public string TransferId { get; set; }

        [JsonProperty("sender_name")]
        public string Sender { get; set; }

        [JsonProperty("recipient_name")]
        public string Recipient { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("assets")]
        public List<AtomicAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>> Assets { get; set; }

        [JsonProperty("created_at_block")]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time")]
        public string CreatedAtTime { get; set; }
    }
}
