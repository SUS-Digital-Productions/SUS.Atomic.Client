using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Config.AllConfigs
{
    public class ConfigResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data
    {
        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("collection_format")]
        public List<CollectionFormat> CollectionFormats { get; set; }

        [JsonProperty("supported_tokens")]
        public List<AtomicToken> Tokens { get; set; }
    }

    public class CollectionFormat
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}
