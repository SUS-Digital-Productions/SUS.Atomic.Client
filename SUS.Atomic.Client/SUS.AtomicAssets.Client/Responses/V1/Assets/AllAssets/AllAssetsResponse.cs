using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Assets.AllAssets
{
    public class AllAssetsResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<GenericSingleAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }
}
