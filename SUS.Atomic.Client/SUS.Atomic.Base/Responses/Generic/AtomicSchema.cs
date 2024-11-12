using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicSchema
    {
        [JsonProperty("schema_name")]
        public string SchemaName { get; set; }

        [JsonProperty("format")]
        public List<AtomicFormat> Formats { get; set; }

        [JsonProperty("created_at_block")]
        public long CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time")]
        public long CreatedAtTime { get; set; }
    }
}
