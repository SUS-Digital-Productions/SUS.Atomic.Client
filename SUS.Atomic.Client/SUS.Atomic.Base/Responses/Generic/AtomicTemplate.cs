using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicTemplate<TemplateImmutableData>
    {
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("max_supply")]
        public string MaxSupply { get; set; }

        [JsonProperty("issued_supply")]
        public string IssuedSupply { get; set; }

        [JsonProperty("is_transferable")]
        public bool IsTransferable { get; set; }

        [JsonProperty("is_burnable")]
        public bool IsBurnable { get; set; }

        [JsonProperty("immutable_data")]
        public TemplateImmutableData ImmutableData { get; set; }

        [JsonProperty("created_at_time")]
        public string CreatedAtTime { get; set; }

        [JsonProperty("created_at_block")]
        public string CreatedAtBlock { get; set; }
    }
}
