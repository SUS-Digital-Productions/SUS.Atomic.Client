using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class ExtendedAtomicAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> : AtomicAsset<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        [JsonProperty("sales")]
        public List<AtomicSale> Sales { get; set; }

        [JsonProperty("auctions")]
        public List<AtomicAuction> Auctions { get; set; }

        [JsonProperty("template_buyoffers")]
        public List<AtomicTemplateBuyoffer> TemplateBuyoffers { get; set; }

        [JsonProperty("prices")]
        public List<AtomicPrice> Prices { get; set; }
    }
}
