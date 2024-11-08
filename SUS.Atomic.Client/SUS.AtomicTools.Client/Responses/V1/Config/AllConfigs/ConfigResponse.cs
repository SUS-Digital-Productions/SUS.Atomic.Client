using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.AtomicTools.Client.Responses.V1.Config.AllConfigs
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
        [JsonProperty("atomictools_contract")]
        public string AtomicToolsContract { get; set; }

        [JsonProperty("atomicassets_contract")]
        public string AtomicAssetsContract { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
