using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Templates
{
    public class GenericSingleTemplate<TemplateImmutableData> : AtomicTemplate<TemplateImmutableData>
    {
        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("scheme")]
        public AtomicSchema Schema { get; set;}

        [JsonProperty("collection")]
        public AtomicCollection Collection { get; set; }
    }
}
