using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicFormat
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
