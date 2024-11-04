using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class ExtendedAtomicSchema : AtomicSchema
    {
        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("collection")]
        public AtomicCollection Collection { get; set; }
    }
}
