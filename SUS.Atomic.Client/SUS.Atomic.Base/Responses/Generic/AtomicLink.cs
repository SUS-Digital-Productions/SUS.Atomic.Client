using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicLink<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        [JsonProperty("tools_contract")]
        public string ToolsContract { get; set; }

        [JsonProperty("assets_contract")]
        public string AssetsContract { get; set; }

        [JsonProperty("link_id")]
        public string LinkId { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("claimer")]
        public string Claimer { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("txid")]
        public string TxId { get; set; }

        [JsonProperty("assets")]
        public List<AtomicAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>> Assets { get; set; }

        [JsonProperty("created_at_block")]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time")]
        public string CreatedAtTime { get; set; }
    }
}
