using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicGraph
    {
        [JsonProperty("symbol")]
        public AtomicToken Symbol { get; set; }

        [JsonProperty("results")]
        public List<GraphResult> Results { get; set; }
    }

    public class GraphResult
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("sales")]
        public string Sales { get; set; }

        [JsonProperty("max")]
        public string Max { get; set; }
    }

}
