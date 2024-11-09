using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicTemplateResult<TemplateImmutableData> : AtomicTemplate<TemplateImmutableData>
    {
        [JsonProperty("scheme")]
        public AtomicSchema Schema { get; set; }

        [JsonProperty("collection")]
        public AtomicCollection Collection { get; set; }
    }
}
