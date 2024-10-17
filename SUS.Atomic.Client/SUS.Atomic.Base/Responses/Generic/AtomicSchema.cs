using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.Atomic.Base.Responses.Generic
{
    public abstract class AtomicSchema
    {
        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("schema_name")]
        public string SchemaName { get; set; }

        [JsonProperty("format")]
        public List<Format> Formats { get; set; }

        [JsonProperty("created_at_block")]
        public long CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time")]
        public long CreatedAtTime { get; set; }

        [JsonProperty("collection")]
        public Collection Collection { get; set; }
    }

    public class Format
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Collection : AtomicCollection
    {

    }
}
